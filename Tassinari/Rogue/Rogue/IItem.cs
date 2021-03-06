using Rogue.Creature;

namespace Rogue
{
    /// <summary>
    /// Interface that represents a games' Item.
    /// </summary>
    public interface IItem
    {

        /// <summary>
        /// Use the item.
        /// </summary>
        /// <param name="player">on which to use the item.</param>
        /// <returns>true if correctly used, false otherwise.</returns>
        bool Use(IPlayer player);

    }
}