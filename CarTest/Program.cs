using CarTest;
using Car;
using CarLibrary;

namespace CarTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create and instance of care engine
            Engine engine = new Engine(cylinders: 4, horsepower: 210);

            // Create and instance of vehicle with 'Engine'
            Vehicle car = new Vehicle(make: "Volvo", model: "XC90", year: 2022); ;
            car.Engine = new Vehicle();

            // Test the methods in previous classes 
            car.Drive();
            car.Stop();

            // Test Engine methods also
            engine.Start();
            engine.Stop();

        }
    }
}