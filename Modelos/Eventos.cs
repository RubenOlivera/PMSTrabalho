using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorNet_Events.Modelos
{
    class Eventos
    {
        public string Titulo { get; set; }
        public int ID { get; set; }
        public string Localidade { get; set; }
        public string Regiao { get; set; }
        public DateTime Data { get; set; }
        public double Preco { get; set; }
        public string Artista { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFinal { get; set; }
    }
}
