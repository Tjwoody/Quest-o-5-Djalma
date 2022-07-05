using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_5_Djalma_numeros_de_1_100
{
        internal class Program
        {
            static void Main(string[] args)
            {
                int numeros;
            for (numeros = 1; numeros < 100; numeros++)
                {
                    numeros = numeros+1 ;
                    Console.WriteLine(numeros);
                }
                Console.ReadKey();
            }
        }
    }