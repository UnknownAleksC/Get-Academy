using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Interface
{
    internal class Magikarp : IPokemon
    {
        public int Health { get; private set; }

        public Magikarp()
        {
            Health = 100;
        }
        public void Attack(IPokemon opponent)
        {
            opponent.LooseHealth(0);
            Console.WriteLine("Magikarp splashed on the enemy, it did nothing");
        }

        public void LooseHealth(int ap)
        {
            Health -= ap;
        }
    }
}
