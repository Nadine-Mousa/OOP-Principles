using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles.Inheritance
{
    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
        public string FuelType { get; set; }

        public Car(string make, string model, int year, int numberOfDoors, string fuelType)
            : base(make, model, year)
        {
            this.NumberOfDoors = numberOfDoors;
            this.FuelType = fuelType;
        }

        public new void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Type: Car, Doors: {NumberOfDoors}, Fuel: {FuelType}");
        }

        public void Honk()
        {
            Console.WriteLine("Honk! Honk!");
        }

    }
}
