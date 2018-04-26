using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploFor
{
    class Exercicio02
    {
        public Exercicio02()
        {
             

            for (int i = 1; i <= 10; i++)
            {
                for (int numero = 1; numero <= 10; numero++)
                {
                    int tabuada = i * numero;
                    Console.WriteLine(i + " x " + numero + " = " + tabuada  );
                    
                }
                Console.WriteLine();
            }
        }
    }
}
