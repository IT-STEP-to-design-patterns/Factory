using Factory.Lib.Base;

namespace Factory.Lib.Mage
{
    public class MageHuman : Hero, IHuman
    {
        public MageHuman()
        {
            Health = 150;
            Damage = 90;
        }
    }
}