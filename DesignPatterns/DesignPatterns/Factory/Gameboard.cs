using DesignPatterns.Loose_Coupling;
using DesignPatterns.SingletonPattern;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.FactoryPattern
{
    public class Gameboard
    {
        private Player _player;
        public Gameboard()
        {
            _player = Player.Instance;
            //_player.Weapon = new Sword(12, 8);
            _player.WeaponList.Add(new M4(100, 12));
            _player.ActiveWeapon = _player.WeaponList.FirstOrDefault();
        }

        public void PlayArea(int lvl)
        {
            if (lvl == 1)
            {
                PLayFirstLevel();
            }
        }

        private void PLayFirstLevel()
        {
            const int currentLvl = 1;
            List<IEnemy> enemies = new List<IEnemy>();
            for (int i = 0; i < 10; i++)
            {
                enemies.Add(EnemyFactory.SpawnWolf(currentLvl));
            }

            for (int i = 0; i < 3; i++)
            {
                enemies.Add(EnemyFactory.SpawnZombie(currentLvl));
            }

            foreach (var enemy in enemies)
            {
                while(enemy.Health > 0 && _player.Health > 0)
                {
                    _player.ActiveWeapon.Use(enemy);                 
                    enemy.Attack(_player);
                }
            }
        }
    }
}
