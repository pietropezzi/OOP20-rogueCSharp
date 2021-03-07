namespace Rogue.Creature
{
    /// <summary>
    /// This interface manages the strategy with which to increase the player's max health points.
    /// </summary>
    public interface IMaxHpIncreaseStrategy
    {
        /// <summary>
        /// Gets the corresponding maximum health points to the given level.
        /// </summary>
        /// <param name="level">the current level value</param>
        /// <returns>an <see cref="int"/> describing the max health point value.</returns>
        int MaxHp(int level);
    }
}