using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CompositionOverInheritance
{
    public class Duck : Animal, IWalkable, ISwimmable
    {
        public void Swim()
        {
            Console.WriteLine("I can swim");
        }

        public void Walk()
        {
            Console.WriteLine("I can walk");
        }
    }
}
