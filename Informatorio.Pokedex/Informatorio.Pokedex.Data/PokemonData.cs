using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatorio.Pokedex.Data
{
    public class PokemonData
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public string Alias { get; set; }
        public int Weight { get; set; }
        public int Type { get; set; }

        

        public PokemonData(int height, string name, string alias, int weight, int type)
        {
            this.Name = name;
            this.Height = height;
            this.Weight = weight;
            this.Alias = alias;
            this.Type = type;

        }



    }
}
