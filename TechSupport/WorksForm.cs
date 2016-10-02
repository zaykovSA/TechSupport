using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace StatisticsG
{
    public partial class WorksForm : Form
    {
        private bool _manualyRedirecting = false;
        private List<ClientsConfiguration> _clients;
        private List<WorksConfiguration> _madeWorks;
        private List<string> _clientsLogins;
        private Dictionary<string, string> _workTypeDictionary;
        public WorksForm()
        {
            InitializeComponent();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _manualyRedirecting = true;
            Owner.Show();
            Close();
        }

        private void WorksForm_Load(object sender, EventArgs e)
        {
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
            clientDD.Items.Clear();
            foreach (var client in _clients)
            {
                clientDD.Items.Add(client.ClientFIO);
                _clientsLogins.Add(client.ClientFIO.ToLower());
            }
            _workTypeDictionary = new Dictionary<string, string>
            {
                {"K1", "Консультация по вопросам слуха и его коррекции, новых исследований в области слуха"},
                {"K2", "Консультация по вопросам биноурального слухопротезирования"},
                {"K3", "Консультация по вопросам новых технологий слухопротезирования"},
                {
                    "K4",
                    "Консультация по вопросам гигиены и ношения СА, эксплуатации СА и других вспомогательных устройств (ALD)"
                },
                {
                    "K5",
                    "Консультация по вопросам форомления документов, индивидуальных программ реабилитации, подготовка заключений, запросов"
                },
                {"K6", "Определение проблемы студента и оценка ресурсов для решения"},
                {"K7", "Направление к профильным специалистам (валидация процессов)"},
                {"O1", "Ввод личных данных в NOAH / Электронный деканат"},
                {"O2", "Уточнение/мониторинг данных пороговой аудиометрии"},
                {"O3", "Считывание параметров и данных СА студента"},
                {"H1", "Проверка функционирования СА, КИ, УИВ"},
                {"H2", "Коррекция параметров настройки СА"},
                {"H3", "Верификация текущих параметров настройки СА inSitu / с помощью сенсограммы через СА"},
                {"H4", "Контроль 'Дневника пользователя СА'"},
                {"H5", "'Точная' настройка СА, верификация параметров"},
                {"H6", "Подключение дополнительных режимов и гаджетов СА"},
                {"H7", "Тестирование режимов СА, КИ для совместного использования с FM-системами"},
                {"A11", "Апробация новых моделей СА 1 фирмы, базовая настройка параметров"},
                {"A12", "Апробация новых моделей СА 2 фирмы, базовая настройка параметров"},
                {"A13", "Апробация новых моделей СА 3 фирмы, базовая настройка параметров"},
                {"A2", "Демонстрация преимуществ биноурального слухопротезирования"},
                {"A3", "Апробация СА в естественных условиях университета"},
                {"A4", "Демонстрация и апробация ALD продуктов"},
                {"C1", "Оценка неполадок в работе СА или другого устройства (предварительная диагностика)"},
                {
                    "C2",
                    "Устранение (в случае, если это возможно без специализированных условий), оформление в ремонтную организацию"
                },
                {
                    "C3",
                    "Изготовлене слепков для ИУВ или СА, выбор фирмы и материала ИУВ, заказ изготовления в отопластической лаборатории (изготовление ИУВ платное*)"
                },
                {"C4", "Замена деталей ИУВ (трубочек)"},
                {"C5", "Очистка спец раствором или замена (платная услуга*) фильтров СА"}
            };

            var madeWorksPath = string.Format(@"{0}\wArc.est", Application.StartupPath);
            using (var sreader =
                new StreamReader(madeWorksPath, Encoding.Default))
            {
                var madeWorksInfo = sreader.ReadToEnd();
                _madeWorks = string.IsNullOrEmpty(madeWorksInfo)
                    ? new List<WorksConfiguration>()
                    : JsonConvert.DeserializeObject<List<WorksConfiguration>>(madeWorksInfo);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedWorkL.Text = _workTypeDictionary[workDD.SelectedItem.ToString()];
        }

        private void saveWorkB_Click(object sender, EventArgs e)
        {
            if (clientDD.SelectedIndex < 0)
            {
                MessageBox.Show("Необходимо выбрать клиента, которому оказывается услуга!", "Ошибка",
                    MessageBoxButtons.OK);
                return;
            }
            if (dateOfWork.Value > DateTime.Now)
            {
                MessageBox.Show("Дата оказания услуги неможет быть позже сегодняшнего дня!", "Ошибка",
                    MessageBoxButtons.OK);
                return;
            }
            if (workDD.SelectedIndex < 0)
            {
                MessageBox.Show("Необходимо выбрать тип оказанной услуги!", "Ошибка",
                    MessageBoxButtons.OK);
                return;
            }
            var selectedClient = new ClientsConfiguration();
            foreach (var client in _clients.Where(client => client.ClientFIO == clientDD.SelectedItem.ToString()))
            {
                selectedClient = client;
                break;
            }
            _madeWorks.Add(new WorksConfiguration
            {
                ClientFIO = selectedClient.ClientFIO, 
                ClientGroup = selectedClient.ClientGroup, 
                WorkDate = dateOfWork.Value, 
                WorkType = workDD.SelectedItem.ToString()
            });
            WriteWorksDataToFile(_madeWorks);
            MessageBox.Show("Работа была сохранена!", "Успешно",
                    MessageBoxButtons.OK);
        }

        private static void WriteWorksDataToFile(List<WorksConfiguration> config)
        {
            var path = string.Format(@"{0}\wArc.est", Application.StartupPath);
            using (var swriter = new StreamWriter(path, false, Encoding.Unicode))
            {
                var serString = JsonConvert.SerializeObject(config);
                swriter.Write(serString);
            }
        }

        private void WorksForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!_manualyRedirecting)
                Application.Exit();
        }
    }
}
