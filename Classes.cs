using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorNet_Events
{
    class Classes
    {
        public class Evento
        {
            private string titulo;
            public string Titulo { get { return titulo; } set { titulo = value; } }

            private string artistaPrincipal;
            public string ArtistaPrincipal { get { return artistaPrincipal; } set { artistaPrincipal = value; } }
        }
        public class User
        {
            private string email;
            public string Email
            {
                get { return email; }
                set { email = value; }
            }
            private int telemovel;
            public int Telemovel
            {
                get { return telemovel; }
                set { telemovel = value; }

            }
          private string password;

          public string Password
            {
                get { return password; }
                set { password = value; }
            }

          private string nome;

          public string Nome
          {
              get { return nome; }
              set { nome = value; }
          }

        }
    }
}
