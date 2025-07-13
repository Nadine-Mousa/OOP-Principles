using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles.Polymorphism
{
    public class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age) { }
        public override void MakeSound()
        {
            Console.WriteLine("The cat is mewing.");
        }
        public override void Eat()
        {
            Console.WriteLine("The cat is eating.");
        }
    }
}
