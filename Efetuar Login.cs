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


          private void FormEfetuarLogin_Load(object sender, EventArgs e)
        {

        }

          private void btcancelar_Click(object sender, EventArgs e)
        {
           this.Close();
            Principal ev = new Principal();
            ev.ShowDialog();
        }

          private void btnLogin_Click(object sender, EventArgs e)
          {

          }
    }
}
