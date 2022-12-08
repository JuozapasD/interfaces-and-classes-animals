using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp44
{
    internal class Cat : IAnimal, IMammal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Cat(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public void Eat()
        {
            Console.WriteLine("I just ate something");
        }

        public void GiveBirth()
        {
            Console.WriteLine("I gave birth to nine kittens");
        }
    }
}
