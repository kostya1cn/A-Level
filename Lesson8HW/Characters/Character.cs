namespace Lesson8HW.Characters
{
    public enum EquipmentType
    {
        Sword,
        Wand,
        Bow
    }

    public abstract class Character
    {
        public string Name { get; set; }
        public EquipmentType Equipment { get; protected set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public bool DontTakeDamage { get; set; } = false;
        protected Character(string name, EquipmentType equipment, int health, int damage)
        {
            Name = name;
            Equipment = equipment;
            Health = health;
            Damage = damage;
        }
        public void TakeDamage(int damage)
        {
            if (!DontTakeDamage)
            {
                Health -= damage;
            }
        }
    }
}