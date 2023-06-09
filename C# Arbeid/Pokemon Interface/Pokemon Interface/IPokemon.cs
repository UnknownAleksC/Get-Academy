using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Interface
{
    internal interface IPokemon
    {
        int Health { get; }

        void Attack(IPokemon opponent);
        void LooseHealth(int ap);
    }
}
