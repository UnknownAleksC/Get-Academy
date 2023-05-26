using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilTesting.Interface
{
    public class CarDealer
    {
        public string Name { get; private set; }
        public string Address { get; private set; }
        public List<Car> CarList { get; private set; }

        public CarDealer(string name, string address)
        {
            Name = name;
            Address = address;
            CarList = new List<Car>();
        }

        public void AddCar(Car car)
        {
            CarList.Add(car);
        }

        public void RemoveCar(Car car)
        {
            int i = CarList.FindIndex(x => x.RegisterNum == car.RegisterNum);
            CarList.RemoveAt(i);
        }

        public List<Car> GetOldCars(int yearX)
        {
            var oldCars = new List<Car>();
            foreach (Car car in CarList)
            {
                if (car.ProductionYear - yearX < 0)
                    oldCars.Add(car);
            }

            return oldCars;
        }

        public List<Car> GetHighMileageCars(int minMileage)
        {
            var highMilageCars = new List<Car>();
            foreach (Car car in CarList)
            {
                if (car.Mileage >= minMileage)
                    highMilageCars.Add(car);
            }
            return highMilageCars;
        }
    }
}
