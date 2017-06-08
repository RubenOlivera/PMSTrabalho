using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeniorNet_Events.Dados_;
using SeniorNet_Events.Modelos;

namespace SeniorNet_Events
{



class ListarEventos
    {
     
        public Eventos RegistarEvent(string Titulo , string Localidade, string Regiao, DateTime Data, double Preco, string Artista, DateTime HoraInicio, DateTime HoraFinal)
        {
            return Dados.Instance.listareven(Titulo
        
        , Localidade
        , Regiao
        , Data
        , Preco
        , Artista
        , HoraInicio
        , HoraFinal);
                } 

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


