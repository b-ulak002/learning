using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern
{
    public static class EnemyFactory
    {
        private static int _areaLevel;
        public static int AreaLevel { get => _areaLevel; }
  

        public static Wolf SpawnWolf(int areaLevel)
        {
            if(areaLevel < 5)
            {
                return new Wolf(100, 12);
            }
            else
            {
                return new Wolf(100, 20);
            }
        }

        public static Zombie SpawnZombie(int areaLevel)
        {
            if (areaLevel < 5)
            {
                return new Zombie(66, 2, 15);
            }
            else
            {
                return new Zombie(70, 20, 15);
            }
        }
    }
}
