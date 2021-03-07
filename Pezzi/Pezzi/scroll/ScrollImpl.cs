using System;
using System.Collections.Generic;
using System.Text;

namespace Pezzi.scroll
{
    /// <summary>
    /// Class representing a game <see cref="IScroll"/>.
    /// </summary>
    public class ScrollImpl : IScroll
    {
        private readonly ScrollType scroll;
        private readonly int scrollValue;

        public ScrollImpl(ScrollType scroll) =>
            (this.scroll, this.scrollValue) = (scroll, scroll.GenerateScrollValue());

        /// <summary>
        /// Use the scroll.
        /// </summary>
        /// <param name="player">on which to use the scroll.</param>
        /// <returns>true if correctly used, false otherwise.</returns>
        public bool Use(Player player)
        {
            if (this.scroll.GetEffect().Equals(ScrollEffect.GAIN))
            {
                // Add scroll value.
                player.AddStrength(scrollValue);
                return true;
            } else
            {
                int decrease = scrollValue;
                if (player.GetStrength() + decrease < 0)
                {
                    // set to 0
                    player.AddStrength(-player.GetStrength());
                } else
                {
                    // decrease
                    player.AddStrength(decrease);
                }
                return true;
            }
        }

        /// <summary>
        /// Removes the scroll's effect.
        /// </summary>
        /// <param name="player">on which to remove the scroll effect.</param>
        public void Remove(Player player)
        {
            if (player.GetStrength() - this.scrollValue < 0)
            {
                // Set to 0
                player.AddStrength(-player.GetStrength());
            }
            else
            {
                // Remove scroll's value.
                player.AddStrength(-this.scrollValue);
            }
        }

        /// <summary>
        /// Gets the scroll effect duration.
        /// </summary>
        /// <returns>the scroll's effect duration.</returns>
        public int GetEffectDuration() => scroll.GetEffectDuration();

        /// <summary>
        /// Gets the scroll value.
        /// </summary>
        /// <returns>the scroll value.</returns>
        public int GetEffectValue() => scrollValue;

    }
}
