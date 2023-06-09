using System.Runtime.CompilerServices;

namespace Pokemon_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var wildPokemons = new List<IPokemon>();
            wildPokemons.Add(new Jigglypuff());
            wildPokemons.Add(new Aerodactyl());

            var Magikarp = new Magikarp();

            while (Magikarp.Health > 0)
            {
                var pokemon = GetWildPokemon(wildPokemons);
                pokemon.Attack(Magikarp);
                Console.ReadLine();
                Magikarp.Attack(pokemon);
                Console.ReadLine();
            }
            Console.WriteLine("Oh no! Magikarp has died :(");
            Console.ReadLine();
        }

        public static IPokemon GetWildPokemon(List<IPokemon> wildPokemons)
        {
            int random = new Random().Next(0, wildPokemons.Count);
            return wildPokemons[random];
        }
    }
}