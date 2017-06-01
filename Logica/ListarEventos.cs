using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeniorNet_Events.Dados_;
using SeniorNet_Events.Modelos;

namespace SeniorNet_Events
{



public class ListarEventos 
{
        //public List <Eventos> even (List<Eventos> ev)
        //{
        //    return Dados.Instance.CarregarEvento(ev);
            
        //}

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


