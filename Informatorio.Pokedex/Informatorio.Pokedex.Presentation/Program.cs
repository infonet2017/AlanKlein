using Informatorio.pokedex.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatorio.Pokedex.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokemngr = new PokemonManager();
            Console.WriteLine("Ingress name, altura, alias, peso y tipo");
            pokemngr.RegisterPokemon("pikachu", 123, "amarillito",19,1);
            pokemngr.RegisterPokemon("pikachu", 1234, "pendejo", 18, 2);

            pokemngr.RegisterPokemon("charizard", 2234, "fueguito", 100, 1);
            pokemngr.RegisterPokemon("chicorita", 120, "chico", 50, 1);
            pokemngr.RegisterPokemon("achicoria", 12, "achii", 5, 1);
            pokemngr.RegisterPokemon("blastoid", 3234, "aguazord", 120, 1);


            var textToshow = pokemngr.GetAllPokemons();
            Console.WriteLine(textToshow);
            int count = pokemngr.GetCantPokemons();
            Console.WriteLine(Convert.ToString(count));

            string mostskinni = pokemngr.GetMostSkinni();
            Console.WriteLine(mostskinni);


            Console.ReadKey();

        }
    }
}
