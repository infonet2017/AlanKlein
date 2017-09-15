using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Informatorio.Pokedex.Data;


namespace Informatorio.pokedex.Business
{
    public class PokemonManager
    {
        private PokemonRepository PokemonRepository { get; set; }


        public PokemonManager()
        {
           PokemonRepository = new PokemonRepository();
        }
        
       

        public void RegisterPokemon(string name, int height, string alias, int weight, int type)
        {
            var newPokemon = new PokemonData(height, name, alias, weight, type);

            try
            {
                PokemonRepository.Save(newPokemon);
            }
            catch (Exception)
            {

                Console.WriteLine("something wrong with your data. Are you sure you are not storing the same pokemon twice?");
            }

        }

        public int GetCantPokemons(PokemonRepository pkm)
        {
            var allPokemons = pkm.GetAll();
            var cant = allPokemons.Count();
            return cant;
        }

        public string GetAllPokemons() /// aca primero tenia que devuelva un string
        {
            var allPokemons = PokemonRepository.GetAll(); /// aca iba
            
            
            var text = "";

            foreach (var pkm in allPokemons)
            {

                text = text + "nombre: " + pkm.Name + "alias: " + pkm.Alias + " altura: " + pkm.Height + "peso: " + pkm.Weight + "\n";
            }
            
            return text;
        }
        
        public string GetMostTallest() // mas alto
        {
            var pokemons = PokemonRepository.GetAll();
        
            int cantmax = pokemons.Max(p => p.Height);
            PokemonData result = pokemons.Find(u => u.Height == cantmax);
            return ShowPokemon(result);
        }

        public string GetMostLowest() //el mas bajo
        {
            var pokemons = PokemonRepository.GetAll();

            int cantmin = pokemons.Min(p => p.Height);
            PokemonData result = pokemons.Find(u => u.Height == cantmin);
            return ShowPokemon(result);
        }

        public string GetMostFat() // devuelve el mas gordo
        {
            var pokemons = PokemonRepository.GetAll();

            int cantmax = pokemons.Max(p => p.Weight);
            PokemonData result = pokemons.Find(u => u.Weight == cantmax);
            return ShowPokemon(result);
        }

        public string GetMostSkinni() //mas flaco
        {
            var pokemons = PokemonRepository.GetAll();

            int cantmin = pokemons.Min(p => p.Weight);
            PokemonData result = pokemons.Find(u => u.Weight == cantmin);
            return ShowPokemon(result);
        }
        

        public string ShowPokemon(PokemonData pkm) //devuelve el txt de un pokmon
        {
            string text = "nombre: " + pkm.Name + "alias: " + pkm.Alias + " altura: " + pkm.Height + "peso: " + pkm.Weight ;

            return text;

        }

        public double GetPromedioAltura() //promedio de altura gral
        {
            var pokemon = PokemonRepository.GetAll();
            int suma = 0;
            foreach (var pkm in pokemon)
            {
                suma = suma + pkm.Height;
            }
            int cant = pokemon.Count;
            double prom = suma / cant;
            return prom;
        }

        public double GetPromedioPeso() //promedio de peso
        {
            var pokemon = PokemonRepository.GetAll();
            int suma = 0;
            foreach (var pkm in pokemon)
            {
                suma = suma + pkm.Weight;
            }
            int cant = pokemon.Count;
            double prom = suma / cant;
            return prom;
        }


        public double PromHeigthTipo(int tipo) // promedio de altura por tipo
        {

            switch (tipo)
            {
                case 1:
                    var pokemon = PokemonRepository.GetAllFire();
                    int suma = 0;
                    foreach (var pkm in pokemon)
                    {
                        suma = suma + pkm.Height;
                    }
                    int cant = pokemon.Count;
                    double prom = suma / cant;
                    return prom;

                case 2:
                    var pokemon2 = PokemonRepository.GetAllWater();
                    int suma2 = 0;
                    foreach (var pkm in pokemon2)
                    {
                        suma2 = suma2 + pkm.Height;
                    }
                    int cant2 = pokemon2.Count;
                    double prom2 = suma2 / cant2;
                    return prom2;
                case 3:
                    var pokemon3 = PokemonRepository.GetAllWater();
                    int suma3 = 0;
                    foreach (var pkm in pokemon3)
                    {
                        suma3 = suma3 + pkm.Height;
                    }
                    int cant3 = pokemon3.Count;
                    double prom3 = suma3 / cant3;
                    return prom3;

                default:
                    return 0;

            }
        }
        public double PromWeightTipo(int tipopoke) // retorna el promedio de pesos segun el tipo de pkm
        {

            switch (tipopoke)
            {
                case 1:
                    var pokemon = PokemonRepository.GetAllFire();
                    int suma = 0;
                    foreach (var pkm in pokemon)
                    {
                        suma = suma + pkm.Weight;
                    }
                    int cant = pokemon.Count;
                    double prom = suma / cant;
                    return prom;

                case 2:
                    var pokemon2 = PokemonRepository.GetAllWater();
                    int suma2 = 0;
                    foreach (var pkm in pokemon2)
                    {
                        suma2 = suma2 + pkm.Weight;
                    }
                    int cant2 = pokemon2.Count;
                    double prom2 = suma2 / cant2;
                    return prom2;
                case 3:
                    var pokemon3 = PokemonRepository.GetAllWater();
                    int suma3 = 0;
                    foreach (var pkm in pokemon3)
                    {
                        suma3 = suma3 + pkm.Weight;
                    }
                    int cant3 = pokemon3.Count;
                    double prom3 = suma3 / cant3;
                    return prom3;

                default:
                    return 0;

            }

        }

        public string GetAllAlias() // imprime los alias en orden alfabetico
        {
            var texto = "";
            var pokemons = PokemonRepository.GetAll();

            pokemons = pokemons.OrderBy(p => p.Alias).ToList();

            foreach (var n in pokemons)
            {
                texto = texto + n.Alias + "\n";
            }
            return texto;
        }

    }
}
