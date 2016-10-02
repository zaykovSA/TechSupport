using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using TechSupport;

namespace StatisticsG
{
    public partial class ClientsForm : Form
    {
        private bool _manualyRedirecting = false;
        private bool _loadUsers;
        private List<UserConfiguration> _users;
        private List<ClientsConfiguration> _clients;
        private List<string> _userLogins;
        private List<string> _clientsLogins;
        public ClientsForm(string user)
        {
            InitializeComponent();
            usersP.Visible = user.ToLower().Contains("admin");
            usersP.Enabled = user.ToLower().Contains("admin");
            _loadUsers = user.ToLower().Contains("admin");
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _manualyRedirecting = true;
            Owner.Show();
            Close();
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            _userLogins = new List<string>();
            if (_loadUsers)
            {
                var path = string.Format(@"{0}\startup_config.est", Application.StartupPath);
                using (var sreader =
                    new StreamReader(path, Encoding.Default))
                {
                    var userInfo = sreader.ReadToEnd();
                    _users = JsonConvert.DeserializeObject<List<UserConfiguration>>(userInfo);
                }
                foreach (var user in _users)
                {
                    UsersLB.Items.Add(user.UserLogin);
                    _userLogins.Add(user.UserLogin.ToLower());
                }
            }
            var clientsPath = string.Format(@"{0}\clInfo.est", Application.StartupPath);
            using (var sreader =
                new StreamReader(clientsPath, Encoding.Default))
            {
                var clientsInfo = sreader.ReadToEnd();
                _clients = string.IsNullOrEmpty(clientsInfo)
                    ? new List<ClientsConfiguration>()
                    : JsonConvert.DeserializeObject<List<ClientsConfiguration>>(clientsInfo);
            }
            _clientsLogins = new List<string>();
            foreach (var client in _clients)
            {
                clientsLB.Items.Add(client.ClientFIO);
                _clientsLogins.Add(client.ClientFIO.ToLower());
            }
        }

        private void UsersLB_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedUserLogin = UsersLB.SelectedItem;
            var selectedUser = new UserConfiguration();
            foreach (var user in _users.Where(user => (string) selectedUserLogin == user.UserLogin))
            {
                selectedUser = user;
                break;
            }

            loginTB.Text = selectedUser.UserLogin;
            PassTB.Text = selectedUser.UserPassword;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            UsersLB.ClearSelected();
            if (filterTB.Text == string.Empty)
            {
                UsersLB.Items.Clear();
                foreach (var user in _users)
                {
                    UsersLB.Items.Add(user.UserLogin);
                }
            }
            else
            {
                UsersLB.Items.Clear();
                foreach (var user in _users.Where(user => user.UserLogin.ToLower().Contains(filterTB.Text.ToLower())))
                {
                    UsersLB.Items.Add(user.UserLogin);
                }
            }
        }

        private void clearB_Click(object sender, EventArgs e)
        {
            UsersLB.ClearSelected();
        }

        private void editB_Click(object sender, EventArgs e)
        {
            if (!(UsersLB.SelectedIndex >= 0))
            {
                MessageBox.Show("Не выбран пользователь для изменения!", "Ошибка изменения", MessageBoxButtons.OK);
                return;
            }
            if ((_userLogins.Contains(loginTB.Text.ToLower()) && loginTB.Text.ToLower() != UsersLB.SelectedItem.ToString().ToLower()) || string.IsNullOrWhiteSpace(loginTB.Text))
            {
                MessageBox.Show("Такой пользователь уже существует!", "Ошибка изменения", MessageBoxButtons.OK);
                return;
            }
            if (string.IsNullOrWhiteSpace(PassTB.Text) || PassTB.TextLength < 6)
            {
                MessageBox.Show("Длина пароля должна быть больше 6!", "Ошибка изменения", MessageBoxButtons.OK);
                return;
            }
            var selectedUserLogin = UsersLB.SelectedItem;
            foreach (var user in _users.Where(user => (string)selectedUserLogin == user.UserLogin))
            {
                user.UserLogin = loginTB.Text;
                user.UserPassword = PassTB.Text;
                break;
            }
            UsersLB.Items.Clear();
            _userLogins.Clear();
            foreach (var user in _users)
            {
                UsersLB.Items.Add(user.UserLogin);
                _userLogins.Add(user.UserLogin.ToLower());
            }
            loginTB.Text = string.Empty;
            PassTB.Text = string.Empty;
            MessageBox.Show("Данные пользователя изменены!", "Успешно", MessageBoxButtons.OK);
            writeUsersDataToFile(_users);
        }

        private void newB_Click(object sender, EventArgs e)
        {
            if (_userLogins.Contains(loginTB.Text.ToLower()))
            {
                MessageBox.Show("Такой пользователь уже существует!", "Ошибка изменения", MessageBoxButtons.OK);
                return;
            }
            if (string.IsNullOrWhiteSpace(loginTB.Text))
            {
                MessageBox.Show("Имя пользователя не может быть пустым!", "Ошибка изменения", MessageBoxButtons.OK);
                return;
            }
            if (string.IsNullOrWhiteSpace(PassTB.Text) || PassTB.TextLength < 6)
            {
                MessageBox.Show("Длина пароля должна быть больше 6!", "Ошибка изменения", MessageBoxButtons.OK);
                return;
            }
            _users.Add(new UserConfiguration {UserLogin = loginTB.Text, UserPassword = PassTB.Text});
            UsersLB.Items.Add(loginTB.Text);
            UsersLB.ClearSelected();
            _userLogins.Add(loginTB.Text.ToLower());
            loginTB.Text = string.Empty;
            PassTB.Text = string.Empty;
            MessageBox.Show("Пользователь добавлен!", "Успешно", MessageBoxButtons.OK);
            writeUsersDataToFile(_users);
        }

        private void writeUsersDataToFile(List<UserConfiguration> config)
        {
            var path = string.Format(@"{0}\startup_config.est", Application.StartupPath);
            using (var swriter = new StreamWriter(path, false))
            {
                var serString = JsonConvert.SerializeObject(config);
                swriter.Write(serString);
            }
        }

        private void deleteB_Click(object sender, EventArgs e)
        {
            var selectedUser = UsersLB.SelectedItem.ToString().ToLower();
            if (selectedUser.Contains("admin"))
            {
                MessageBox.Show("Администратор не может быть удален!", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            var indexToDelete = -1;
            for (var i = 0; i < _users.Count; i++)
            {
                if (!string.Equals(_users[i].UserLogin, selectedUser, StringComparison.CurrentCultureIgnoreCase))
                    continue;
                indexToDelete = i;
                break;
            }
            if (indexToDelete != -1)
            {
                _users.RemoveAt(indexToDelete);
                MessageBox.Show("Пользователь был удален!", "Успешно", MessageBoxButtons.OK);
                UsersLB.Items.Clear();
                foreach (var user in _users)
                    UsersLB.Items.Add(user.UserLogin);
                _userLogins.Remove(selectedUser);
                writeUsersDataToFile(_users);
                return;
            }
            MessageBox.Show("Пользователь не найден, возможно он был удален другим пользователем!", "Ошибка", MessageBoxButtons.OK);
        }

        private void clientsLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedClientFIO = clientsLB.SelectedItem;
            var selectedClient = new ClientsConfiguration();
            foreach (var client in _clients.Where(client => (string)selectedClientFIO == client.ClientFIO))
            {
                selectedClient = client;
                break;
            }

            FIOTB.Text = selectedClient.ClientFIO;
            PhoneTB.Text = selectedClient.ClientPhone;
            switch (selectedClient.ClientGroup)
            {
                case Groups.FirstYearStudent:
                    userGroupCB.SelectedItem = "Первокурсник";
                    break;
                case Groups.EarlyYearStudent:
                    userGroupCB.SelectedItem = "Младшекурсник";
                    break;
                case Groups.HighYearStudent:
                    userGroupCB.SelectedItem = "Старшекурсник";
                    break;
                case Groups.ExStudent:
                    userGroupCB.SelectedItem = "Выпускник";
                    break;
                case Groups.Guest:
                    userGroupCB.SelectedItem = "Гость";
                    break;
                case Groups.Worker:
                    userGroupCB.SelectedItem = "Сотрудник";
                    break;
            }
        }

        private void clientFilterTB_TextChanged(object sender, EventArgs e)
        {
            clientsLB.ClearSelected();
            clientsLB.Items.Clear();
            if (clientFilterTB.Text == string.Empty)
            {
                foreach (var client in _clients)
                {
                    clientsLB.Items.Add(client.ClientFIO);
                }
            }
            else
            {
                foreach (var client in _clients.Where(client => client.ClientFIO.ToLower().Contains(clientFilterTB.Text.ToLower())))
                {
                    clientsLB.Items.Add(client.ClientFIO);
                }
            }
        }

        private void clearClientB_Click(object sender, EventArgs e)
        {
            clientsLB.ClearSelected();
        }

        private void editClientB_Click(object sender, EventArgs e)
        {
            if (!(clientsLB.SelectedIndex >= 0))
            {
                MessageBox.Show("Не выбран клиент для изменения!", "Ошибка изменения", MessageBoxButtons.OK);
                return;
            }
            if ((_clientsLogins.Contains(FIOTB.Text.ToLower()) && FIOTB.Text.ToLower() != clientsLB.SelectedItem.ToString().ToLower()) || string.IsNullOrWhiteSpace(FIOTB.Text))
            {
                MessageBox.Show("Такой клиент уже существует!", "Ошибка изменения", MessageBoxButtons.OK);
                return;
            }
            if (userGroupCB.SelectedIndex < 0)
            {
                MessageBox.Show("Необходимо выбрать группу пользователя!", "Ошибка изменения", MessageBoxButtons.OK);
                return;
            }
            var selectedClientFIO = clientsLB.SelectedItem;
            foreach (var client in _clients.Where(client => (string)selectedClientFIO == client.ClientFIO))
            {
                client.ClientFIO = FIOTB.Text;
                client.ClientPhone = PhoneTB.Text;
                switch (userGroupCB.SelectedItem.ToString())
                {
                    case "Первокурсник":
                        client.ClientGroup = Groups.FirstYearStudent;
                        break;
                    case "Младшекурсник":
                        client.ClientGroup = Groups.EarlyYearStudent;
                        break;
                    case "Старшекурсник":
                        client.ClientGroup = Groups.HighYearStudent;
                        break;
                    case "Выпускник":
                        client.ClientGroup = Groups.ExStudent;
                        break;
                    case "Гость":
                        client.ClientGroup = Groups.Guest;
                        break;
                    case "Сотрудник":
                        client.ClientGroup = Groups.Worker;
                        break;
                }
                break;
            }
            clientsLB.Items.Clear();
            _clientsLogins.Clear();
            foreach (var client in _clients)
            {
                clientsLB.Items.Add(client.ClientFIO);
                _clientsLogins.Add(client.ClientFIO.ToLower());
            }
            FIOTB.Text = string.Empty;
            PhoneTB.Text = string.Empty;
            userGroupCB.SelectedIndex = -1;
            MessageBox.Show("Данные клиента изменены!", "Успешно", MessageBoxButtons.OK);
            writeClientsDataToFile(_clients);
        }

        private void newClientB_Click(object sender, EventArgs e)
        {
            if (_clientsLogins.Contains(FIOTB.Text.ToLower()))
            {
                MessageBox.Show("Такой клиент уже существует!", "Ошибка изменения", MessageBoxButtons.OK);
                return;
            }
            if (string.IsNullOrWhiteSpace(FIOTB.Text))
            {
                MessageBox.Show("Имя клиента не может быть пустым!", "Ошибка изменения", MessageBoxButtons.OK);
                return;
            }
            if (userGroupCB.SelectedIndex < 0)
            {
                MessageBox.Show("Необходимо выбрать группу пользователя!", "Ошибка изменения", MessageBoxButtons.OK);
                return;
            }
            var newClient = new ClientsConfiguration
            {
                ClientFIO = FIOTB.Text,
                ClientPhone = PhoneTB.Text
            };
            switch (userGroupCB.SelectedText)
            {
                case "Первокурсник":
                    newClient.ClientGroup = Groups.FirstYearStudent;
                    break;
                case "Младшекурсник":
                    newClient.ClientGroup = Groups.EarlyYearStudent;
                    break;
                case "Старшекурсник":
                    newClient.ClientGroup = Groups.HighYearStudent;
                    break;
                case "Выпускник":
                    newClient.ClientGroup = Groups.ExStudent;
                    break;
                case "Гость":
                    newClient.ClientGroup = Groups.Guest;
                    break;
                case "Сотрудник":
                    newClient.ClientGroup = Groups.Worker;
                    break;
            }
            _clients.Add(newClient);
            clientsLB.Items.Add(FIOTB.Text);
            clientsLB.ClearSelected();
            _clientsLogins.Add(FIOTB.Text.ToLower());
            FIOTB.Text = string.Empty;
            PhoneTB.Text = string.Empty;
            userGroupCB.SelectedIndex = -1;
            MessageBox.Show("Клиент добавлен!", "Успешно", MessageBoxButtons.OK);
            writeClientsDataToFile(_clients);
        }

        private void writeClientsDataToFile(List<ClientsConfiguration> config)
        {
            var path = string.Format(@"{0}\clInfo.est", Application.StartupPath);
            using (var swriter = new StreamWriter(path, false, Encoding.Unicode))
            {
                var serString = JsonConvert.SerializeObject(config);
                swriter.Write(serString);
            }
        }

        private void deleteClientB_Click(object sender, EventArgs e)
        {
            var selectedClient = clientsLB.SelectedItem.ToString().ToLower();
            var indexToDelete = -1;
            for (var i = 0; i < _clients.Count; i++)
            {
                if (!string.Equals(_clients[i].ClientFIO, selectedClient, StringComparison.CurrentCultureIgnoreCase))
                    continue;
                indexToDelete = i;
                break;
            }
            if (indexToDelete != -1)
            {
                _clients.RemoveAt(indexToDelete);
                MessageBox.Show("Клиент был удален!", "Успешно", MessageBoxButtons.OK);
                clientsLB.Items.Clear();
                foreach (var client in _clients)
                    clientsLB.Items.Add(client.ClientFIO);
                _clientsLogins.Remove(selectedClient);
                writeClientsDataToFile(_clients);
                return;
            }
            MessageBox.Show("Клиент не найден, возможно он был удален другим пользователем!", "Ошибка", MessageBoxButtons.OK);
        }

        private void ClientsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_manualyRedirecting)
                Application.Exit();
        }
    }
}
