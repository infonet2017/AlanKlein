using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 40000;
            double total;
            
            Console.WriteLine("Ingresa el nombre del loco");
            string nom = Console.ReadLine();
            Console.WriteLine("Ingresa la antiguedad del loco");
            int.TryParse(Console.ReadLine(), out int ant);

            if (ant >= 10)
            {
                total = a + (a * 0.10);
            }
            else
            {
                if (ant >= 5)
                {
                    total = a + (a * 0.07);
                }
                else
                {
                    if (ant >= 3)
                    {
                        total = a + (a * 0.5);
                    }
                    else
                    {
                        total = a + (a * 0.03);
                    }
                }
            }

            Console.WriteLine("El sueldo sera " + total);
            Console.ReadLine();



        }
    }
}
