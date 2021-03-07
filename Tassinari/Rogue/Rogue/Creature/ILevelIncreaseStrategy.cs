namespace Rogue.Creature
{
    /// <summary>
    /// This interface manages the strategy with which to increase the player's level.
    /// </summary>
    public interface ILevelIncreaseStrategy
    {
        /// <summary>
        /// Gets the corresponding level to the given experience.
        /// </summary>
        /// <param name="experience">the current experience value.</param>
        /// <returns>an <see cref="int"/> describing the level.</returns>
        int Level(int experience);
    }
}