using DesignPatterns.FactoryPattern;

namespace DesignPatterns.Loose_Coupling
{
    public class Sword : IWeapon
    {
        private int _damage;
        public int Damage { get => _damage; }

        private int _ArmorDamage;
        private int ArmorDamage { get => _ArmorDamage; }
        public Sword(int damage, int armorDamage)
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
