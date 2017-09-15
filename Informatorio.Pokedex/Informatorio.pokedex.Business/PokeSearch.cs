using Informatorio.Pokedex.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatorio.pokedex.Business
/*{
    public class PokeSearch /// quiso ser un intento pero casi mori
    {


        public string GetMostTallest(PokemonRepository pokeList)
        {
            var pokemons = pokeList.GetAll();

            int cantmax = pokemons.Max(p => p.Height);
            PokemonData pkm = pokemons.Find(u => u.Height == cantmax);
            var text = "nombre: " + pkm.Name + "alias: " + pkm.Alias + " altura: " + pkm.Height + "peso: " + pkm.Weight;

            return text;
        }

        public string GetMostLowest(PokemonRepository pokeList)
        {
            var pokemons = pokeList.GetAll();

            int cantmin = pokemons.Min(p => p.Height);
            PokemonData pkm = pokemons.Find(u => u.Height == cantmin);
            var text = "nombre: " + pkm.Name + "alias: " + pkm.Alias + " altura: " + pkm.Height + "peso: " + pkm.Weight;

            return text;
        }

        public string GetMostFat(PokemonRepository pokeList)
        {
            var pokemons = pokeList.GetAll();

            int cantmax = pokemons.Max(p => p.Weight);
            PokemonData pkm = pokemons.Find(u => u.Weight == cantmax);
            var text = "nombre: " + pkm.Name + "alias: " + pkm.Alias + " altura: " + pkm.Height + "peso: " + pkm.Weight;

            return text;
        }

        public string GetMostSkinni(PokemonRepository pokeList)
        {
            var pokemons = pokeList.GetAll();

            int cantmin = pokemons.Min(p => p.Weight);
            PokemonData pkm = pokemons.Find(u => u.Weight == cantmin);
            
            var text = "nombre: " + pkm.Name + "alias: " + pkm.Alias + " altura: " + pkm.Height + "peso: " + pkm.Weight;

            return text;

        }
    }
}
