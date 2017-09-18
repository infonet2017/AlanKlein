using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherStudent
{
    class Student: Person
    {
        public Student(string name, string surname) : base(name, surname)
        {
        }

        public void GoToClasses()
        {
            Console.WriteLine("I'm going to class");
        }

        public void ShowAge()
        {
            string a = Convert.ToString(this.age);
            Console.WriteLine("My age is: " + a + " years old");
        }

    }
}
