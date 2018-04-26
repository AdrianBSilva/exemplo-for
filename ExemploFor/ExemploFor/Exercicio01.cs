using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploFor
{
    class Exercicio01
    {
        public Exercicio01()
        {
            Console.Write("Digite um número para fazer a tabuada: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            double tabuada = 0;
            Console.Clear();

            for (int i = -100000; i <= 100000; i++)
            {
                tabuada = numero * i;

                Console.WriteLine(numero + " x " + i + " = " + tabuada);
            }
        }
    
    }
}
