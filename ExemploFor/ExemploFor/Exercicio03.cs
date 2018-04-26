using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploFor
{
    class Exercicio03
    {
        public Exercicio03()
        {
            int tamanho = 15;
            for (int i = 1; i <= tamanho; i++)
            {
                
                for (int numero = 1; numero <= tamanho; numero++)
                {

                    Console.Write("* ");

                }
                Console.WriteLine();
            }
        }
    }
}
