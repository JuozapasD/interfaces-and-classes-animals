using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp44
{
    internal class Bass : IAnimal, IFish
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Bass(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public void Eat()
        {
            Console.WriteLine("I just ate something");
        }

        public void Swim()
        {
            Console.WriteLine("I just swam deeper into the lake");
        }
    }
}
