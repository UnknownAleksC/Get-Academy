using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilTesting.Interface
{
    public class Car
    {
        public string Brand { get; private set; }
        public int RegisterNum { get; private set; }
        public int ProductionYear { get; private set; }
        public int Mileage { get; private set; }

        public Car(string brand, int registerNum, int productionYear, int mileage)
        {
            Brand = brand;
            RegisterNum = registerNum;
            ProductionYear = productionYear;
            Mileage = mileage;
        }
    }
}
