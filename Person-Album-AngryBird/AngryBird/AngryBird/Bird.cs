using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngryBird
{
    class Bird
    {
        public int hunger { get; set; }
        public int weight { get; set; }


        public void Eat(int n)
        {
            if ((this.hunger - n) >= 0)
            {
                this.hunger = this.hunger - n;
                this.weight = this.weight + n;
            }
            else
            {
                var d = n - this.hunger;
                this.hunger = this.hunger - d;
                this.weight = this.weight + d;
            }
        }

        public string ShowBird()
        {
            var text = "I'm a bird with a weight of " + this.weight + " and a hunger level of " + this.hunger;
            return text;
        }

    }
}
