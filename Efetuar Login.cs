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
           
        }

          private void btnLogin_Click(object sender, EventArgs e)
          {
            Utilizador u= Gestao_Utilizadores.Instance.validarlogin(txtbEmail.Text, txtbPassword.Text);
            if (u != null)
            {
                Principal_Log ev = new Principal_Log();
                this.Close();
                ev.ShowDialog();
                label3.Visible = false;
                this.Close();
            }
            else
                label3.Visible = true;
            
          }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
