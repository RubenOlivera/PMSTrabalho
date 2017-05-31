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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            
            FormEfetuarLogin ev = new FormEfetuarLogin();
            ev.ShowDialog();
              
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void buttonRegistar_Click(object sender, EventArgs e)
        {
            Registar gh = new Registar();
            gh.Show();
            
        }

        private void buttonTipEvent_Click(object sender, EventArgs e)
        {
            
            _Tipos_de_eventos te = new _Tipos_de_eventos();
            te.Show();
            
        }

        private void buttonLoc_Click(object sender, EventArgs e)
        {
            Regioes rg = new Regioes();
            rg.Show();
            
        }

        private void buttonData_Click(object sender, EventArgs e)
        {
            Por_Data pc = new Por_Data();
            pc.Show();
           

        }

        private void buttonTodos_Click(object sender, EventArgs e)
        {
            Todos t = new Todos();
            t.Show();
        }
    }
}
