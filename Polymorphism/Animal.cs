using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles.Polymorphism
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public virtual void MakeSound()
        {
            Console.WriteLine("The animal is making a sound.");
        }
        public virtual void Eat()
        {
            Console.WriteLine("The animal is eating.");
        }



    }
}
