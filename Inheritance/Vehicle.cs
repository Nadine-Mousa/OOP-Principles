using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles.Inheritance
{
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        protected  int Speed { get; set; }

        public Vehicle(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
            Speed = 0;
        }

        public void Accelerate(int increment)
        {
            this.Speed += increment;
            Console.WriteLine($"{Make} {Model} is accelerating. Current speed: {Speed} km/h");
        }
        public void Brake(int decrement)
        {
            Speed = Math.Max(0, Speed - decrement);
            Console.WriteLine($"{Make} {Model} is braking. Current speed: {Speed} km/h");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{Year} {Make} {Model}");
        }

    }
}
