using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp44
{
    internal class Animalcomparer : IComparer<IAnimal>
    {
        public int Compare(IAnimal? x, IAnimal? y)
        {
            return string.Compare(x.Name, y.Name);
        }
    }
}
