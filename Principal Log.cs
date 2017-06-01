using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeniorNet_Events.Logica;
using SeniorNet_Events.Modelos;

namespace SeniorNet_Events
{
    public partial class Principal_Log : Form
    {
        public Principal_Log()
        {
            InitializeComponent();
        }

        private void buttonNovoEvent_Click(object sender, EventArgs e)
        {
            InserirEventos ev = new InserirEventos();
            ev.ShowDialog();
        }

        private void ButtumAlterar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonlogout_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            ListBox listb = new ListBox();
           
        }

        private void Principal_Log_Load(object sender, EventArgs e)
        {

        }
    }
}
