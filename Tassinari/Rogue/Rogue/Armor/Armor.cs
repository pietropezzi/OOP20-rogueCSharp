namespace Rogue.Armor
{
    /// <summary>
    /// An interface modeling a game armor.
    /// </summary>
    public interface Armor
    {
        /// <summary>
        /// Increases the armor's AC of the given value.
        /// </summary>
        /// <param name="amount">the value to add to the armor's AC.</param>
        void increaseAC(int amount);
        
        /// <summary>
        /// Decreases the armor's AC of the given value.
        /// </summary>
        /// <param name="amount">the value to subtract to the armor's AC.</param>
        void decreaseAC(int amount);

    }
}