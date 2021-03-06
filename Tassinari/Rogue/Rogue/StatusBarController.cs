using System;
using System.Linq;
using Rogue.Creature;

namespace Rogue
{
    public class StatusBarController
    {
        /// <summary>
        /// Creates a new StatusBarControllerImpl
        /// </summary>
        /// <param name="life">the player life.</param>
        public StatusBarController(IPlayer player)
        {
            player.Life.PlayerLifeChanged += OnLifeChange;
            foreach (var (attribute, value) in player.Life.Values)
            {
                OnLifeChange(attribute, value);
            }
        }

        private static void OnLifeChange(PlayerAttribute attribute, int value)
        {
            Console.WriteLine(Enum.GetName(attribute.GetType(), attribute) + " = " + value);
        }
    }
}