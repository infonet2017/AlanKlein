﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatorio.Pokedex.Data
{
    public class FirePokemon: PokemonData
    {
        private List<String> Atacks { get; set; }


        public FirePokemon(int height, string name, string alias, int weight, int type) : base(height, name, alias, weight, type)
        {
            this.Atacks.Add("Placaje");
            this.Atacks.Add("Gruñido");
            this.Atacks.Add("FlameThrower");
            this.Name = name;
            this.Height = height;
            this.Weight = weight;
            this.Alias = alias;
            this.Type = type;

        }

    }
}
