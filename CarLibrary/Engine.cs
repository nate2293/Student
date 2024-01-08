using System;
namespace CarLibrary
{
    public class Engine
    {
        // Fields
        private int cylinders;
        private double horsepower;

        // Properties, Read and Write 
        public int Cylinders        // Be very careful with the syntax and the capital letters etc.. 
        {
            get { return cylinders; }      
            set { cylinders = value; }

        }

        public double Horsepower
        {
            get { return horsepower; }
            set { horsepower = value; }

        }

        // Default constructor
        public Engine()
        {
            // assign values 
            cylinders = 4;
            horsepower = 159;

        }

        // Custom Constructor 
        public Engine(double horsepower, int cylinders)
        {
            this.cylinders = cylinders;
            this.horsepower = horsepower;

        }

        // Add a method 'Start' that takes no parameters and prints out engine
        public void Start()
        {
            Console.WriteLine("Engine Starting");
        }

        // Stop method return type void
        public void Stop()
        {
            Console.WriteLine("Engine Stopping");
        }
    }
}