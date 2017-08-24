using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4
{
    class Program
    {
        static void Main(string[] args)
        {
            int mayor, menor, a;
            
            Console.WriteLine("Ingrese 10 números");

            int.TryParse(Console.ReadLine(), out a);
            menor = a;
            mayor = a;

            for (int i = 1; i <= 9; i++)
            {
                int.TryParse(Console.ReadLine(), out a);

                if (a > mayor)
                {
                    mayor = a;
                   
                }
                else
                {
                    if (a < menor)
                    {
                        menor = a;
                        
                    }
                }

            }
            Console.Write("El menor numero es: "+menor);
            Console.WriteLine(" y el mayor es: " + mayor);
            Console.ReadLine();
        }
    }
}
