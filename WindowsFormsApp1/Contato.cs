using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Contato
    {
        private string nome;
        private string sobrenome;
        private string telefone;

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }
        public string Sobrenome
        {
            get
            {
                return sobrenome;
            }
            set
            {
                sobrenome = value;
            }
        }
        public string Telefone
        {
            get
            {
                return telefone;
            }
            set
            {
                if (value.Length == 13)
                {
                    telefone = value;
                }
                else
                {
                    telefone = "(00) 00000-0000";
                }
            }
        }

        public Contato()
        {
            Nome = "Cláudia";
            Sobrenome = "Josefa";
            Telefone = "(00) 11111-1111";
        }

        public Contato(string nome, string sobrenome, string telefone)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Telefone = telefone;

        }

        public override string ToString()
        {
            string saída = string.Empty;
            saída +=String.Format("{0} {1}", Nome, Sobrenome);
            saída +=String.Format("({0}) {1}-{2}",
             Telefone.Substring(0,2), 
             Telefone.Substring(3,5),
             Telefone.Substring(7,4));

        }
    }
}
         
