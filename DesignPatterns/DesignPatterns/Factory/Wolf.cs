using DesignPatterns.SingletonPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern
{
    public class Wolf : IEnemy
    {
        private int _health;
        private readonly int _level;
        public int Health { get => _health; set => _health = value; }
        public int Level => _level;

        public int OverTimeDamage { get; set; }
        public int Armor { get; set; }
        public bool Paralyzed { get; set; }
        public int ParalyzedFor { get; set; }

        public Wolf(int health, int level)
        {
            _health = health;
            _level = level;
        }

        public void Attack(Player player)
        {
            Console.WriteLine("Wolf attacking " + player.Name);
            player.Health -= 20;
        }

        public void Defend(Player player)
        {
            Console.WriteLine("Wolf defending " + player.Name);
        }
    }
}
