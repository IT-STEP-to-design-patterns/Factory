using Factory.Lib.Base;

namespace Factory.Lib.Archer
{
    public class ArcherOrc : Hero, IOrc
    {
        public ArcherOrc()
        {
            Health = 140;
            Damage = 110;
        }
    }
}