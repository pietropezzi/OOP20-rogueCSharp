using System;
using Rogue.Creature;

namespace Rogue
{
    public class StatusBarControllerImpl : StatusBarController
    {
        /// <summary>
        /// Creates a new StatusBarControllerImpl
        /// </summary>
        /// <param name="life">the player life.</param>
        public StatusBarControllerImpl(PlayerLifeImpl life)
        {
            life.PlayerLifeChanged += OnLifeChange;
        }

        private static void OnLifeChange(PlayerAttribute attribute, int value)
        {
            Console.WriteLine(Enum.GetName(attribute.GetType(), attribute) + " changed: " + value);
        }
    }
}