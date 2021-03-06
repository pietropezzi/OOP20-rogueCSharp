using System;
using Rogue.Creature;

namespace Rogue
{
    public class Program
    {
        public static void Main()
        {
            var player = new PlayerFactory().Create();
            var sbc = new StatusBarController(player);
            player.Life.AddStrength(5);
        }
    }
}