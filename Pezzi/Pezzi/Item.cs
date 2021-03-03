using System;
using System.Collections.Generic;
using System.Text;

namespace Pezzi
{
    /// <summary>
    /// Interface that represents a games' Item.
    /// </summary>
    public interface Item
    {

        /// <summary>
        /// Use the item.
        /// </summary>
        /// <param name="player">on which to use the item.</param>
        /// <returns>true if correctly used, false otherwise.</returns>
        bool Use(Player player);

    }
}
