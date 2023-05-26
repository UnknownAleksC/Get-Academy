using BilTesting.Interface;

namespace BilTesting.Test
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var carDealership = new CarDealer("Bobs Automotor", "Snake Street 3");
            Car car1 = new Car("Volvo", 14124, 1999, 2520);
            Car car2 = new Car("Nissan", 29124, 2015, 10);
            Car car3 = new Car("Toyota", 11114, 1978, 5000);
            Car car4 = new Car("Volvo", 12345, 2011, 792);
            Car car5 = new Car("Toyota", 91145, 2019, 252);
            carDealership.AddCar(car1);
            carDealership.AddCar(car2);
            carDealership.AddCar(car3);
            carDealership.AddCar(car4);
            carDealership.AddCar(car5);
            carDealership.RemoveCar(car5);

            List<Car> oldCars = carDealership.GetOldCars(2011);
            List<Car> highMilageCars = carDealership.GetHighMileageCars(500);

            Assert.AreEqual("Bobs Automotor", carDealership.Name);
            Assert.AreEqual("Snake Street 3", carDealership.Address);
            Assert.That(carDealership.CarList.Count, Is.EqualTo(4));
            Assert.NotZero(oldCars.Count);
            Assert.NotZero(highMilageCars.Count);
        }
    }
}