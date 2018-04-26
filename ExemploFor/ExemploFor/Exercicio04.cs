using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploFor
{
    class Exercicio04
    {
        public Exercicio04()
        {
            Console.Write("Digite um numero para o quadrado: ");
            int tamanhoDoQuadrado = Convert.ToInt32(Console.ReadLine()) ;
            for (int i = 1; i <= tamanhoDoQuadrado; i++)
            {

                if ((i == 1) || (i == tamanhoDoQuadrado))
                {
                    Console.Write("* ");
                    for (int j = 0; j < tamanhoDoQuadrado - 2; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine("*");
                }
                else
                {
                    Console.Write("* ");
                    for (int j = 0; j < tamanhoDoQuadrado - 2; j++)
                    { 
                        Console.Write("  ");
                    } 
                    Console.WriteLine("*");
                }
            }

        }
    }
}
