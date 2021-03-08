using System;
using Rogue.Creature;

namespace Rogue
{
    /// <summary>
    /// The application entry point.
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