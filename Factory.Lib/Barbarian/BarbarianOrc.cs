using Factory.Lib.Base;

namespace Factory.Lib.Barbarian
{
    public class BarbarianOrc : Hero, IOrc
    {
        public BarbarianOrc()
        {
            Health = 110;
            Damage = 120;
        }
    }
}