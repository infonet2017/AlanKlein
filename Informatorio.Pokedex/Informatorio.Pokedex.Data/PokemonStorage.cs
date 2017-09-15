using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatorio.Pokedex.Data
{
    /*public class PokemonRepository
    {
        private List<PokemonData> Pokemons { get; set; }

        public PokemonRepository()
        {
            Pokemons = new List<PokemonData>();
        }

        public void Save(PokemonData pkm)
        {

            //finds any coincidence in the list based on the pkm.Name
            var searchResult = Pokemons.Where(p => p.Name == pkm.Name).ToList();

            //if it didnt find any coincidence, then searchresult is null
            if (searchResult.Count() > 0)
            {
                throw new Exception("pokemon already stored");
            }
            else
            {
                //otherwise it stores the pokemon successfully
                Pokemons.Add(pkm);
            }

        }

        public PokemonData GetForName(string pokemonName)
        {
            //lambda expression
            var result = Pokemons.Find(p => p.Name == pokemonName);
            return result;

        }

        public PokemonData GetForAlias(string pokemonAlias)
        {
            //lambda expression
            var result = Pokemons.Find(p => p.Alias == pokemonAlias);
            return result;

        }

        
        public List<PokemonData> GetAll()
        {
            return Pokemons;
        }

        public void Remove(string pokemonName)
        {
            Pokemons.RemoveAll(p => p.Name == pokemonName);
        }



    } 
            
}
