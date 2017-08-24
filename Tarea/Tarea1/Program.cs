using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine("Ingresa un número loco");
            int.TryParse(Console.ReadLine(), out a);
            
            if ((a % 2) == 0)
            {
                Console.WriteLine(value: "El número ingresado es par");
            }
            else
            {
                Console.WriteLine("El número es impar");
            }

            Console.ReadLine();
            
        }
    }
}
