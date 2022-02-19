using Factory.Lib.Base;

namespace Factory.Lib.Barbarian
{
    public class BarbarianHuman : Hero, IHuman
    {
        public BarbarianHuman()
        {
            Health = 100;
            Damage = 110;
        }
    }
}