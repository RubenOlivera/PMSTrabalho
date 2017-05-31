using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SeniorNet_Events.Dados_;
using System.Windows.Forms;


namespace SeniorNet_Events
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Dados a = Dados.Instance;
            a.Carregar();
           
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal());
        }
        //StreamReader sr = new StreamReader("C:\\Users\\Ruben\\PMSTrabalho");
    }
}
