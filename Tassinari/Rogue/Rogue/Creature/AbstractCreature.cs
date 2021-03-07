namespace Rogue.Creature
{
    /// <summary>
    /// An abstract implementation for <see cref="ICreature{TLife}"/> common either for
    /// monsters and player.
    /// </summary>
    /// <typeparam name="TLife">the creature's life type.</typeparam>
    public abstract class AbstractCreature<TLife> : ICreature<TLife> where TLife : ILife
    {
        /// <inheritdoc cref="ICreature{TLife}"/>
        public TLife Life { get; }

        /// <summary>
        /// Creates a new <see cref="AbstractCreature{TLife}"/>.
        /// </summary>
        /// <param name="life">the creature's life</param>
        protected AbstractCreature(TLife life) => this.Life = life;
    }
}