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
    public partial class InserirEventos : Form
    {
        public InserirEventos()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InserirEventos_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Principal ev = new Principal();
            ev.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Eventos u = ListarEventos.Instance.RegistarEvent(Tit.Text,loc.Text, reg.Text, Convert.ToDateTime(data.Text), Convert.ToSingle(prec.Text), art.Text, Convert.ToDateTime(hi.Text), Convert.ToDateTime(hf.Text));
                   if (u != null)
                   {
                        Principal_Log ev = new Principal_Log();
                       ev.ShowDialog();
                   }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel fazer Registo. Erro{0}", ex.Message);
            }

        }
    }
}
