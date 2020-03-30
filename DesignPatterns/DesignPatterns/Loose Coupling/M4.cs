using DesignPatterns.FactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Loose_Coupling
{
    public class M4 : IWeapon
    {
        private int _damage;
        public int Damage { get => _damage; }

        private int _ArmorDamage;
        private int ArmorDamage { get => _ArmorDamage; }
        public M4(int damage, int armorDamage)
        {
            _damage = damage;
            _ArmorDamage = armorDamage;
        }

        public void Use(IEnemy enemy)
        {
            enemy.Health -= Damage;
            enemy.Armor -= ArmorDamage;
        }
    }
}
