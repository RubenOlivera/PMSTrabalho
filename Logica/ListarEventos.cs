using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.Logica
{



public class ListarEventos 
{
    
        private static ListarEventos instance;

        private ListarEventos() { }

        public static ListarEventos Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ListarEventos();
                }
                return instance;
            }
        }
    }
}


