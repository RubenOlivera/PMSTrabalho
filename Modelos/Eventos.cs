using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.Modelos
{
    class Eventos
    {
        public string Titulo { get; set; }
        public string localidade { get; set; }
        public string regiao { get; set; }
        public DateTime Data { get; set; }
        public double Preço { get; set; }
        public string Artista { get; set; }
        public DateTime horaInicio { get; set; }
        public DateTime horaFinal { get; set; }
    }
}
