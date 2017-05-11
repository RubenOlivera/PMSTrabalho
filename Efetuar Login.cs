using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeniorNet_Events
{
    public partial class FormEfetuarLogin : Form
    {
        private SeniorNet_Events.ListarEventos logicaListarEventos;


        public FormEfetuarLogin()
        {
            logicaListarEventos = SeniorNet_Events.ListarEventos.Instance;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InserirEventos ev = new InserirEventos();
            ev.ShowDialog();
        }

          private void FormEfetuarLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
