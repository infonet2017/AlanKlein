using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
        
            Console.WriteLine("Ingrese 3 números separados por enter");
            int.TryParse(Console.ReadLine(), out a);
            int.TryParse(Console.ReadLine(), out b);
            int.TryParse(Console.ReadLine(), out c);

            if ((a<=b)&(b<=c))
            {
                Console.WriteLine("En orden creciente lml ");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Desordena3 ");
                Console.ReadLine();
            }

        }
    }
}
