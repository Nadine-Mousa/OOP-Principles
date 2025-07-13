using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles.Polymorphism
{
    public class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("The dog is barking.");
        }
        public override void Eat()
        {
            Console.WriteLine("The dog is eating.");
        }
    }
}
