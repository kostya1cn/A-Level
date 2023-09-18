namespace Lesson8HW.Enemies
{
    public abstract class Enemy
    {
        public string Name { get; protected set; }
        public int Health { get; protected set; }
        public int Damage { get; protected set; }
        public bool DontTakeDamage { get; set; } = false;

        protected Enemy(string name, int health, int damage)
        {
            Name = name;
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