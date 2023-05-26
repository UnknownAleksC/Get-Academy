namespace BilTesting.Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarDealer carDealer = new CarDealer("Mr. Santonios Tires", "123, Blimpstreet");
            Car car1 = new Car("Volvo", 14124, 1999, 2520);
            Car car2 = new Car("Nissan", 29124, 2015, 10);
            Car car3 = new Car("Toyota", 11114, 1978, 5000);
            Car car4 = new Car("Volvo", 12345, 2011, 792);
            Car car5 = new Car("Toyota", 91145, 2019, 252);
            carDealer.AddCar(car1);
            carDealer.AddCar(car2);
            carDealer.AddCar(car3);
            carDealer.AddCar(car4);
            carDealer.AddCar(car5);
            carDealer.RemoveCar(car5);

            List<Car> oldCars = carDealer.GetOldCars(2011);
            List<Car> highMilageCars = carDealer.GetHighMileageCars(500);
        }
    }
}