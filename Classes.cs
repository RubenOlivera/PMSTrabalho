using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorNet_Events
{
    class Classes
    {
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
