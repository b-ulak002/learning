using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CompositionOverInheritance
{
    public abstract class Animal
    {
        public int Age { get; set; }
        public virtual void Eat()
        {
            Console.WriteLine("I can eat");
        }
        public virtual void Sleep()
        {
            Console.WriteLine("I can sleep");
        }

    }
}
