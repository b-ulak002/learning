using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CompositionOverInheritance
{
    public class GoldFish : Animal, ISwimmable
    {
        public void Swim()
        {
            Console.WriteLine("I can swim");
        }
    }
}
