namespace Rogue.Creature
{
    /// <summary>
    /// An interface modeling a game Creature: monsters or player.
    /// </summary>
    /// <typeparam name="TLife">the creature's life type.</typeparam>
    public interface ICreature<out TLife> where TLife : ILife
    {
        /// <summary>
        /// Gets the <see cref="ICreature{TLife}"/> life.
        /// </summary>
        public TLife Life { get; }
    }
}