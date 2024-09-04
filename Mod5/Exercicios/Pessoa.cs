using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Pessoa
    {
        public string nome { get; set; }
        public int idade { get; set; }

        private string mensagem = "Defaul Mensage";



        public string Exibir(string nome, int idade)
        {
            return mensagem;
        }
    }
}
