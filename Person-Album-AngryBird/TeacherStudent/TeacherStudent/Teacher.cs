using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherStudent
{
    class Teacher: Person
    {
        public Teacher(string name, string surname) : base(name, surname)
        {
        }

        private string subjet { get; set; }

        public void Explain()
        {
            Console.WriteLine("Explanation begins");
        }

    }
}
