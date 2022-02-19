using Factory.Lib.Base;

namespace Factory.Lib.Mage
{
    public class MageOrc : Hero, IOrc
    {
        public MageOrc()
        {
            Health = 160;
            Damage = 100;
        }
    }
}