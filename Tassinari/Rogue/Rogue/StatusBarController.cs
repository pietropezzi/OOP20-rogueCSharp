using System;
using Rogue.Creature;

namespace Rogue
{
    /// <summary>
    /// The status bar controller.
    /// </summary>
    public class StatusBarController
    {
        /// <summary>
        /// Creates a new StatusBarControllerImpl
        /// </summary>
        /// <param name="player">the player life.</param>
        public StatusBarController(IPlayer player)
        {
            player.Life.PlayerLifeChanged += OnLifeChange;
            foreach (var (attribute, value) in player.Life.Values)
            {
                OnLifeChange(attribute, value);
            }
        }

        /// <summary>
        /// Notifies the view that the life changed.
        /// TODO: Now it is limited to writing on console!
        /// </summary>
        /// <param name="attribute"></param>
        /// <param name="value"></param>
        private static void OnLifeChange(PlayerAttribute attribute, int value)
        {
            Console.WriteLine(Enum.GetName(attribute.GetType(), attribute) + " = " + value);
        }
    }
}