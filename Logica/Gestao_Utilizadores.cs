using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeniorNet_Events.Dados_;
using SeniorNet_Events.Modelos;

namespace SeniorNet_Events.Logica
{
    class Gestao_Utilizadores
    {
        public Utilizador Registarutil(string nome, string pass,string email)
        {
            if (Dados.Instance.ExistUtil(email) == false)
                return Dados.Instance.Registar(nome, pass, email);
            else
                return null;
        }
        public Utilizador validarlogin(string nome, string pass)
        {
            
            return Dados.Instance.validarlog(nome, pass);

        }



        private static Gestao_Utilizadores instance;

        private Gestao_Utilizadores() { }

        public static Gestao_Utilizadores Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Gestao_Utilizadores();
                }
                return instance;
            }
        }
    }
}
