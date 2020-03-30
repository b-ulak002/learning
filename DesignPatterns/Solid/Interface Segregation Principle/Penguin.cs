using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.InterfaceSegregationPrinciple
{
    public class Penguin : IBird
    {
        public void Eat(string food)
        {
            Console.WriteLine($"Penguin is eating {food}");
        }

        public void Fly(int altitude, int distance)
        {
            Console.WriteLine($"Penguin can't fly");
        }

        public void Walk(int distance)
        {
            Console.WriteLine($"Penguin walks {distance} km");
        }
    }
}
