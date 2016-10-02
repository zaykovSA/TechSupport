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
    public partial class StatisticsForm : Form
    {
        private bool _manualyRedirecting = false;
        public StatisticsForm()
        {
            InitializeComponent();
        }

        private void WorkingForm_Load(object sender, EventArgs e)
        {
            //var path = string.Format(@"{0}\client_Info.est", Application.StartupPath);
            //using (var sreader =
            //    new StreamReader(path, Encoding.Default))
            //{
            //    var userInfo = sreader.ReadToEnd();
            //    _clients = !string.IsNullOrEmpty(userInfo)
            //        ? JsonConvert.DeserializeObject<List<Client>>(userInfo)
            //        : new List<Client>();
            //}
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _manualyRedirecting = true;
            Owner.Show();
            Close();
        }

        private void StatisticsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_manualyRedirecting)
                Application.Exit();
        }
    }
}
