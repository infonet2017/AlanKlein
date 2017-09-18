using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherStudent
{
    class Person
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }


        public Person(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
            
        }


        public void SetAge(int n)
        {
            this.age = n;
        }

        public void Hello()
        {
            Console.WriteLine("Hello I am " + this.name + " " + this.surname);
        }

    }
}
