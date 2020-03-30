using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CompositionOverInheritance
{
    public class Person : Animal, IWalkable
    {
        public void Walk()
        {
            Console.WriteLine("I can walk");
        }
    }
}
