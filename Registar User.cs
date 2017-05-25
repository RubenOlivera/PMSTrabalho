using System;
using System.IO;
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
    public partial class Registar : Form
    {
        public Registar()
        {
            InitializeComponent();
        }

        private void Registar_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistar_Click(object sender, EventArgs e)
        { 
            
            if (txtbPass.Text == txtbConfirmarPass.Text)
            {
                Utilizador u = Gestao_Utilizadores.Instance.Registarutil(txtbNome.Text, txtbPass.Text, txtbEmail.Text);
                if (u != null)
                {
                    Principal_Log ev = new Principal_Log();
                    ev.ShowDialog();
                }
                
                
            }
        }
    }
}
