using System.Collections.Generic;

namespace Oppgave_Uke3_VirtualPet
{
    internal class Program
    {
        public static List<Pet> pets = new()
        {
            new Pet("Sam", 7, "Liver"),
            new Pet("John", 2, "Pudding"),
        };


        static void Main(string[] args)
        {
            Console.WriteLine($"Hello, my name is Liam and I own {pets.Count()} pets");
            for (int i = 0; i < pets.Count; i++)
            {
                Console.WriteLine($"Pet {i + 1} is called {pets[i].Name} and is {pets[i].Age} years old");
            }
            var randNum = new Random().Next(0, pets.Count);
            Console.WriteLine($"Would you like to feed {pets[randNum].Name}? You do? Great, go ahead :)" +
                              $"\r\nTheir favorite is {pets[randNum].FavoriteFood}");
            pets[randNum].EatFood(Console.ReadLine());
            Console.ReadLine();
        }
    }
}