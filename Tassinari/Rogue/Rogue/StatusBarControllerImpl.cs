using System;
using System.Linq;
using Rogue.Creature;

namespace Rogue
{
    public class StatusBarControllerImpl : StatusBarController
    {
        /// <summary>
        /// Creates a new StatusBarControllerImpl
        /// </summary>
        /// <param name="life">the player life.</param>
        public StatusBarControllerImpl(PlayerLife life)
        {
            life.PlayerLifeChanged += OnLifeChange;
            foreach (var attribute in life.Values)
            {
                OnLifeChange(attribute.Item1, attribute.Item2);
            }
        }

        private static void OnLifeChange(PlayerAttribute attribute, int value)
        {
            Console.WriteLine(Enum.GetName(attribute.GetType(), attribute) + " changed: " + value);
        }
    }
}