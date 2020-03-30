using DesignPatterns.Loose_Coupling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SingletonPattern
{
    public sealed class Player
    {
        private static readonly Player _instance;

        static Player()
        {
            _instance = new Player()
            {
                Name = "Rocket",
                Level = 1,
                Armor = 25,
                Health = 100
            };
        }

        public static Player Instance
        {
            get
            {
                return _instance;
            }
        }
        public string Name { get; set; }
        public int Level { get; set; }

       // public IWeapon Weapon { get; set; }
        public List<IWeapon> WeaponList { get; set; }

        public IWeapon ActiveWeapon { get; set; }
        public int Armor { get; set; }

        public int Health { get; set; }
       
    }
}
