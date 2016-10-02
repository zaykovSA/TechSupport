using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using StatisticsG;

namespace TechSupport
{
    public partial class EnterF : Form
    {
        private List<UserConfiguration> _users;

        public EnterF()
        {
            InitializeComponent();
        }

        private void EnterF_Load(object sender, EventArgs e)
        {
            var path = string.Format(@"{0}\startup_config.est", Application.StartupPath);
            using (var sreader =
                new StreamReader(path, Encoding.Default))
            {
                var userInfo = sreader.ReadToEnd();
                _users = JsonConvert.DeserializeObject<List<UserConfiguration>>(userInfo);
            }
        }

        private void EnterB_Click(object sender, EventArgs e)
        {
            var enteredLogin = LoginTB.Text;
            var enteredPassword = PassTB.Text;

            foreach (var user in _users)
            {
                if (string.Equals(enteredLogin, user.UserLogin, StringComparison.CurrentCultureIgnoreCase))
                {
                    if (string.Equals(enteredPassword, user.UserPassword, StringComparison.CurrentCultureIgnoreCase))
                    {
                        Hide();
                        if (WorksCB.Checked)
                        {
                            var worksForm = new WorksForm { Owner = this };
                            worksForm.Show(this);
                            LoginTB.Text = string.Empty;
                            PassTB.Text = string.Empty;
                            return;
                        }
                        if (StatisticsCB.Checked)
                        {
                            var statisticsForm = new StatisticsForm { Owner = this};
                            statisticsForm.Show(this);
                            LoginTB.Text = string.Empty;
                            PassTB.Text = string.Empty;
                            return;
                        }
                        if (ClientsCB.Checked)
                        {
                            var clientsForm = new ClientsForm(LoginTB.Text) { Owner = this };
                            clientsForm.Show(this);
                            LoginTB.Text = string.Empty;
                            PassTB.Text = string.Empty;
                            return;
                        }
                    }
                    MessageBox.Show("Введен неверный пароль!", "Ошибка пароля", MessageBoxButtons.OK);
                    LoginTB.Text = string.Empty;
                    PassTB.Text = string.Empty;
                    return;
                }
            }
            MessageBox.Show("Такого пользователя не существует!", "Ошибка логина", MessageBoxButtons.OK);
            LoginTB.Text = string.Empty;
            PassTB.Text = string.Empty;
        }

        private void EnterF_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
