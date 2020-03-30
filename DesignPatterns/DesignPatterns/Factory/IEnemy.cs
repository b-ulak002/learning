using DesignPatterns.SingletonPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern
{
    public interface IEnemy
    {
        int Health { get; set; }
        int Level { get; }

        int OverTimeDamage { get; set; }
        int Armor { get; set; }
        bool Paralyzed { get; set; } //Is enemy paralyzed
        int ParalyzedFor { get; set; } //how many rounds is the enemy paralyzed for
        void Attack(Player player);
        void Defend(Player player);
    }
}
