namespace Factory.Lib.Base
{
    public abstract class Hero
    {
        private int _health;
        public int Health
        {
            get => _health;
            set => _health = value < 0 ? 0 : value;
        }
        
        public int Damage { get; set; }

        public void Attack(Hero enemy)
        {
            enemy.Health -= Damage;
        }

        public bool IsAlive()
        {
            return _health > 0;
        }
    }
}