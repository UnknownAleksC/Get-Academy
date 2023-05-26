using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Water_Project
{
    public class Water
    {
        public int Amount { get; private set; }
        public double Temperature { get; private set; }
        public WaterState State { get; private set; }
        public double? ProportionFirstState { get; private set; }

        public Water(int amount, double temperature, double? proportion = null)
        {
            Amount = amount;
            Temperature = temperature;
            if (temperature < 0)
                State = WaterState.Ice;
            else if (temperature > 100)
                State = WaterState.Gas;
            else if (temperature is > 0 and < 100)
                State = WaterState.Fluid;

            if (!proportion.HasValue && temperature is 100 or 0)
                TempErrorMessage();
            else if (proportion.HasValue && temperature == 0)
            {
                ProportionFirstState = proportion;
                State = WaterState.IceAndFluid;
            }
            else if (proportion.HasValue && temperature == 100)
            {
                ProportionFirstState = proportion;
                State = WaterState.FluidAndGas;
            }
        }

        private static void TempErrorMessage()
        {
            throw new ArgumentException("When temperature is 0 or 100, you must provide a value for proportion");
        }

        public void AddEnergy(double energy)
        {
            if (State == WaterState.Ice && Temperature + energy / Amount >= 0)
            {
                double EnergyAmount = energy + Temperature * Amount - Amount * 80;
                if (EnergyAmount >= 0)
                {
                    State = WaterState.Fluid;
                    Temperature = 0 + EnergyAmount / Amount;
                    ProportionFirstState = 0;
                }
                else
                {
                    State = WaterState.IceAndFluid;
                    Temperature = 0;
                    ProportionFirstState = EnergyAmount / (-Amount * 80);
                }
            }
            else if (State == WaterState.Fluid && Temperature + energy / Amount >= 100)
            {
                double EnergyAmount = energy - (100 - Temperature) * Amount - Amount * 600;
                if (EnergyAmount >= 0)
                {
                    State = WaterState.Gas;
                    Temperature = 100 + EnergyAmount / Amount;
                    ProportionFirstState = 0;
                }
                else
                {
                    State = WaterState.FluidAndGas;
                    Temperature = 100;
                    ProportionFirstState = EnergyAmount / (-Amount * 600);
                }
            }
            else
                Temperature += energy / Amount;
        }
    }

    public enum WaterState
    {
        Ice,
        Fluid,
        Gas,
        IceAndFluid,
        FluidAndGas,
    }
}
