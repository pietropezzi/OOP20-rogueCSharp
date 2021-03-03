using System;
using System.Collections.Generic;
using System.Text;

namespace Pezzi.potion
{

    /// <summary>
    /// Enumeration that represents the effect of a Potion.
    /// </summary>
    public enum PotionEffect
    {
        HEAL,
        HURT
    }

    /// <summary>
    /// An interface modeling a game's Potion.
    /// </summary>
    public interface Potion : Item
    {
        /// <summary>
        /// Gets the potion's helth points.
        /// </summary>
        /// <returns>the potion's health points</returns>
        int GetHpValue();
    }

}
