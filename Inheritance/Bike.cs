using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles.Inheritance
{
    public class Bike : Vehicle
    {
        public string BikeType { get; set; }
        public bool HasBasket { get; set; }
        public Bike(string make, string model, int year, string type, bool hasBasket)
            : base(make, model, year)
        {
            this.BikeType = type;
            this.HasBasket = hasBasket;
        }
        
        public new void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Type: Bike, Style: {BikeType}, Basket: {(HasBasket ? "Yes" : "No")}");
        }

        public void RingBell()
        {
            Console.WriteLine("Ring! Ring!");
        }
    }
}
