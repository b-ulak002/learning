using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.InterfaceSegregationPrinciple
{
    public class Sparrow : IEat, IFly
    {
        public void Eat(string food)
        {
            Console.WriteLine($"Sparrow is eating {food}");
        }

        public void Fly(int altitude, int distance)
        {
            Console.WriteLine($"Sparrow flies {altitude} high and cover {distance} km");
        }
    }
}
