using System;
using System.Collections.Generic;
using System.Text;

namespace Pezzi.scroll
{
    /// <summary>
    /// Enumeration that represents the effect of a Scroll.
    /// </summary>
    public enum ScrollEffect
    {
        GAIN,
        LOSE
    }

    /// <summary>
    /// An interface modeling a game's Scroll.
    /// </summary>
    public interface Scroll : Item
    {
        /// <summary>
        /// Remove the scroll's effect
        /// </summary>
        /// <param name="player">on which to remove the scroll.</param>
        void Remove(Player player);

        /// <summary>
        /// Gets the scroll effect value.
        /// </summary>
        /// <returns>the scroll effect value.</returns>
        int GetEffectValue();

        /// <summary>
        /// Gets the scroll duration.
        /// </summary>
        /// <returns>the scroll's duration.</returns>
        int GetEffectDuration();
    }
}
