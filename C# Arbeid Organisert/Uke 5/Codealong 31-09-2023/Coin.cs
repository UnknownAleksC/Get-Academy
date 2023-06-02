using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codealong_31_09_2023
{
    internal class Coin
    {
        private int Value;
        private int Count;

        public Coin(int value, int count)
        {
            Value = value;
            Count = count;
        }

        public int CalculateTotalCoinValue()
        {
            return Value * Count;
        }
    }
}
