using System;
using Rogue.Creature;

namespace Rogue
{
    public class Program
    {
        public static void Main()
        {
            var pl = new PlayerLifeImpl.Builder().Build();
            var sbc = new StatusBarControllerImpl(pl);
            pl.AddStrength(5);
        }
    }
}