using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherStudent
{
    class StudentAndTeacherTest
    {
        static void Main(string[] args)
        {
            Person Persona = new Person("Alan","Klein");

            Persona.Hello();
            Console.ReadLine();

            Student Estudiante = new Student("El Brayan","TITO");
            Estudiante.SetAge(21);
            Estudiante.Hello();
            Estudiante.ShowAge();
            Console.ReadLine();

            Teacher Profe = new Teacher("Profesor", "Jirafales");
            Profe.SetAge(30);
            Profe.Hello();
            Profe.Explain();

            Console.ReadLine();


        }
    }
}
