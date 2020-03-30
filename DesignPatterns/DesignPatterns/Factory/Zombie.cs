using DesignPatterns.SingletonPattern;
using System;

namespace DesignPatterns.FactoryPattern
{
    public class Zombie : IEnemy
    {
        private int _health;
        private readonly int _level;
        private int _armor;
        public int Health { get => _health; set => _health = value; }
        public int Level => _level;

        public int OverTimeDamage { get; set; }
        public int Armor { get; set; }
        public bool Paralyzed { get; set; }
        public int ParalyzedFor { get; set; }

        public Zombie(int health, int level, int armor)
        {
            _health = health;
            _level = level;
            _armor = armor;
        }
        public void Attack(Player player)
        {
            Console.WriteLine("Zombie attacking " + player.Name);
        }

        public void Defend(Player player)
        {
            Console.WriteLine("Zombie defending " + player.Name);
        }
    }
}
