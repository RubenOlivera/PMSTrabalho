using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeniorNet_Events.Modelos;


namespace SeniorNet_Events.Dados_
{
    class Dados
    {

        List<Utilizador> utilizadores = new List<Utilizador>();
        List<Eventos> evento = new List<Eventos>();
        //Criar um metodo para carregar so utilizadores 
       
        public void Carregar()
        {StreamReader sr = new StreamReader("Utilizadores.txt");
            
            do
            {
                Utilizador util = new Utilizador();// criar um novo utilizador em cada iteração
                string[] campos = sr.ReadLine().Split('\t');
                if (campos.Length == 3)
                {
                    util.nome = campos[0];
                    util.password = campos[1];
                    util.email = campos[2];
                    utilizadores.Add(util);
                }
                
            } while (sr.ReadToEnd() == null);

            sr.Close();
        }
        public Utilizador Registar(string nome, string pass, string email)
        {
            StreamWriter sw = new StreamWriter("Utilizadores.txt",true);
            Utilizador utiliza = new Utilizador();
            utiliza.nome = nome;
            utiliza.password = pass;
            utiliza.email = email;
            sw.WriteLine(utiliza.nome + "\t" +utiliza.password+"\t"+utiliza.email);
            utilizadores.Add(utiliza);
            sw.Close();
            return utiliza;
        }
        public bool ExistUtil(string nome)
        {
            StreamReader sr = new StreamReader("Utilizadores.txt");
            string u;
            do
            {
                foreach (Utilizador t in utilizadores)
                {
                    if ((t.nome.ToUpper()) ==(nome.ToUpper()))
                    {
                        sr.Close();
                        return true;
                    }
                }
            } while ((u = sr.ReadLine()) != null);
            sr.Close();
            return false;
        }
        public Utilizador validarlog(string nome, string pass)
        {
            foreach(Utilizador u in utilizadores)
            {
                if ((u.nome.ToUpper()) == (nome.ToUpper()) && u.password == pass)
                    return u;
               
            }
            return null;
        }
        
        
        private Dados()
        {
            
        }
        private static Dados instance;

        public static Dados Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Dados();
                }
                return instance;
            }
        }
        public void  CarregarEvento()
        {
            StreamReader sr = new StreamReader("Eventos.txt");

            do
            {
                Eventos even = new Eventos();// criar um novo Evento em cada iteração
                string[] campos = sr.ReadLine().Split('\t');
                if (campos.Length == 9)
                {
                    even.ID = Convert.ToInt32(campos[0]);
                    even.Titulo = campos[1];
                    even.Data = Convert.ToDateTime(campos[2]);
                    even.Regiao = campos[3];
                    even.Localidade = campos[4];
                    even.Preco = Convert.ToSingle(campos[5]);
                    even.HoraInicio= Convert.ToDateTime(campos[6]);
                    even.HoraFinal= Convert.ToDateTime(campos[7]);
                    even.Artista = campos[8];
                    evento.Add(even);
                }

            } while (sr.ReadToEnd() == null);
            sr.Close();
            
           
        }
        public Eventos listareven (List<Eventos >evento)
        {


            return null;
        }
    }
}
