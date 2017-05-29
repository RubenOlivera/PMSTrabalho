using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorNet_Events.Modelos
{
    class Eventos
    {
        public string titulo { get; set; }
        public string localidade { get; set; } //vai ser criada uma lista de strings para as localidades
        public string regiao { get; set; } //vai ser criada lista de strings para as regiões
        public DateTime data { get; set; }
        public double preco { get; set; }
        public string artista { get; set; }
        public DateTime horaInicio { get; set; }
        public DateTime horaFinal { get; set; }
    }
}
