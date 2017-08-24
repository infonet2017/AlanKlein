using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero del 1 al 7");

            int a;
            int.TryParse(Console.ReadLine(), out a);

            switch (a)
            {
                case 1:
                    Console.WriteLine("Día Lunes");
                    break;
                case 2:
                    Console.WriteLine("Día Martes");
                    break;
                case 3:
                    Console.WriteLine("Día Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Día Jueves");
                    break;
                case 5:
                    Console.WriteLine("Día Viernes");
                    break;
                case 6:
                    Console.WriteLine("Día Sabado");
                    break;
                case 7:
                    Console.WriteLine("Día Domingo");
                    break;
                default:
                    Console.WriteLine("Tu número no esta entre 1 y 7");
                    break;
            }
            Console.ReadLine();
        }
    }
}
