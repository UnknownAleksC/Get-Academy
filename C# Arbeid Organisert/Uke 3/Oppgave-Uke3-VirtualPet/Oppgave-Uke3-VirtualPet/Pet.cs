using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave_Uke3_VirtualPet
{
    internal class Pet
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string FavoriteFood { get; private set; }

        public Pet(string name, int age, string favoriteFood)
        {
            Name = name;
            Age = age;
            FavoriteFood = favoriteFood;
        }
        internal void EatFood(string food)
        {
            if (food == FavoriteFood) Console.WriteLine($"\"Thank you SO MUCH for bringing me my favorite food!\" {Name} says!");
            else Console.WriteLine($"\"Thanks for the food\" {Name} says");
        }
    }
}
