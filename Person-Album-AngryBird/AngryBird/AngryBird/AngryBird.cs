using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngryBird
{
    class AngryBird:  Bird
    {
        public int anger { get; set; }

        public void Provoke(int angerlvl) // aca no entendi si anger y fury eran lo mismo o no, asi que tome que fury
        {                                   // era como la rapidez con la que se enfurecía
            if (this.hunger > 0)
            {
                this.anger = this.anger + (2 * angerlvl);
                
            }
            else
            {
                if (this.hunger <= 0)
                {
                    this.anger = this.anger + angerlvl;
                }
            }
        }

        public string ShowAngyBird()
        {
            var text = "I'm a Angrybird with a weight of " + this.weight + ", a hunger level of " + this.hunger + ", and an anger level of "+ this.anger;
            return text;
        }
    }
}
