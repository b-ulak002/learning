using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.InterfaceSegregationPrinciple
{
    public class Eagle : IBird
    {
        public void Eat(string food)
        {
            Console.WriteLine($"Eagle is eating {food}");
        }

        public void Fly(int altitude, int distance)
        {
            Console.WriteLine($"Eagle flies {altitude} high and cover {distance} km");
        }

        public void Walk(int distance)
        {
            Console.WriteLine($"Eagle walks {distance} meters");
        }
    }
}
