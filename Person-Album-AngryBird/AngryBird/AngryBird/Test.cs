using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngryBird
{
    class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FatBird");
            var fury = 5;
            Bird miBird = new Bird();
            miBird.hunger = 100;
            miBird.weight = 50;

            Console.WriteLine(miBird.ShowBird());
            
            miBird.Eat(20);
            Console.WriteLine(miBird.ShowBird());

            AngryBird miAngry = new AngryBird();
            miAngry.hunger = 100;
            miAngry.weight = 50;
            miAngry.anger = 50;

            Console.WriteLine(miAngry.ShowAngyBird());

            miAngry.Provoke(fury);
            Console.WriteLine(miAngry.ShowAngyBird());

            miAngry.Eat(200);
            miAngry.Provoke(fury);

            Console.WriteLine(miAngry.ShowAngyBird());
            Console.ReadLine();
        }
    }
}
