using System;
using Rogue.Creature;

namespace Rogue
{
    /// <summary>
    /// The main point of application.
    /// </summary>
    public class Program
    {
        public static void Main()
        {
            var player = new PlayerFactory().Create();
            var sbc = new StatusBarController(player);
        }
    }
}