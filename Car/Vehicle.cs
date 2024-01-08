using Car;
using System;
namespace Car
{
    public class Vehicle
    {
        // Private Fields
        private string make;
        private string model;
        private int year;
        private Vehicle formulaOneEngine;

        // Add properties for above ^^^
        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public Vehicle Engine
        {
            get { return formulaOneEngine; }
            set { formulaOneEngine = value; }
        }
        public Vehicle()
        {
            // Default values so assign it something 
            make = "Volvo";
            model = "XC90";
            year = 2022;
            formulaOneEngine = new Vehicle(); 
        }

        // Custom Constructor 
        public Vehicle(string make, string model, int year)
        {
            this.make = make;
            this.model = model;
            this.year = year;
        }

        // Method with no return type void 
        public void Drive()
        {
            Console.WriteLine("Driving Started");
        }

        // Method with no return type void
        public void Stop()
        {
            Console.WriteLine("Driving Stopped");
        }
    }
}