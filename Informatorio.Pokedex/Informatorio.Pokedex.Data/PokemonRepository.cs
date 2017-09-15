using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Informatorio.Pokedex.Data
{
    public class PokemonRepository
    {
        //Las siguientes 3 List estan restringidas a una CLASE del tipo declarada
        private List<WaterPokemon> WaterList { get; set; }
        private List<FirePokemon> FireList { get; set; }
        private List<PlantPokemon> PlantList { get; set; }
        private List<PokemonData> Pokemon { get; set; }

        //Esta lista está restringida a cualquier clase que IMPLEMENTE la interfaz IVehicle
        //public List<IVehicle> VehicleList { get; set; }

        public PokemonRepository()
        {
            //Siempre Inicializar List<> antes de operar
            WaterList = new List<WaterPokemon>();
            FireList = new List<FirePokemon>();
            PlantList = new List<PlantPokemon>();
            Pokemon = new List<PokemonData>();
            //VehicleList = new List<IVehicle>();
        }

        //Solo recibe objetos de la clase WaterVehicle
        public void SaveWaterPokemon(WaterPokemon waterPokemon)
        {
            var searchResult = WaterList.Where(p => p.Name == waterPokemon.Name).ToList();

            //if it didnt find any coincidence, then searchresult is null
            if (searchResult.Count() > 0)
            {
                throw new Exception("pokemon already stored");
            }
            else
            {
                //otherwise it stores the pokemon successfully
                WaterList.Add(waterPokemon);
            }
            
        }

        //Solo recibe objetos de la clase AirVehicle
        public void SaveFirePokemon(FirePokemon firePokemon)
        {
            var searchResult = FireList.Where(p => p.Name == firePokemon.Name).ToList();

            //if it didnt find any coincidence, then searchresult is null
            if (searchResult.Count() > 0)
            {
                throw new Exception("pokemon already stored");
            }
            else
            {
                //otherwise it stores the pokemon successfully
                FireList.Add(firePokemon);
            }
            
        }

        //Solo recibe objetos de la clase TerrainVehicle
        public void SavePlantPokemon(PlantPokemon plantPokemon)
        {
            var searchResult = PlantList.Where(p => p.Name == plantPokemon.Name).ToList();

            //if it didnt find any coincidence, then searchresult is null
            if (searchResult.Count() > 0)
            {
                throw new Exception("pokemon already stored");
            }
            else
            {
                //otherwise it stores the pokemon successfully
                PlantList.Add(plantPokemon);
            }
            
        }

        //Recibe cualquier objeto que implemente IVehicle
        /*public void SaveVehicle(IVehicle vehicle)C:\examples\Informatorio.Pokedex\Informatorio.pokedex.Business\PokemonManager.cs
        {
            VehicleList.Add(vehicle);
        }
        */
        public void Save(PokemonData pkm)
        {

            //finds any coincidence in the list based on the pkm.Name
            var searchResult = Pokemon.Where(p => p.Name == pkm.Name).ToList();

            //if it didnt find any coincidence, then searchresult is null
            if (searchResult.Count() > 0)
            {
                throw new Exception("pokemon already stored");
            }
            else
            {
                //otherwise it stores the pokemon successfully
                Pokemon.Add(pkm);
            }

        }

        public PokemonData GetForName(string pokemonName)
        {
            //lambda expression
            var result = Pokemon.Find(p => p.Name == pokemonName);
            return result;

        }

        public PokemonData GetForAlias(string pokemonAlias)
        {
            //lambda expression
            var result = Pokemon.Find(p => p.Alias == pokemonAlias);
            return result;

        }


        public List<PokemonData> GetAll()
        {
            return Pokemon;
        }

        public void Remove(string pokemonName)
        {
            Pokemon.RemoveAll(p => p.Name == pokemonName);
        }

        public List<FirePokemon> GetAllFire()
        {
            return FireList;
        }
        public List<WaterPokemon> GetAllWater()
        {
            return WaterList;
        }
        public List<PlantPokemon> GetAllPlant()
        {
            return PlantList;
        }


    }
}

