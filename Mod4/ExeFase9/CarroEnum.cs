using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeFase9
{
    enum Cores
    {
        Branco = 1,
        Vermelho,
        Preto,
        Cinza, 
        Prata,
        Azul
    }

   public class Carro
    {
        public int Cor;

        public Carro (int cor)
        {
            Cor = cor;
        }

        public void ExibirInfo()
        {
            Console.WriteLine(Cor);
        }
    }
}
