using Factory.Lib.Base;

namespace Factory.Lib.Archer
{
    public class ArcherHuman : Hero, IHuman
    {
        public ArcherHuman()
        {
            Health = 130;
            Damage = 100;
        }
    }
}