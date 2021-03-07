namespace Rogue.Creature
{
    /// <summary>
    /// An abstract implementation for a creature <see cref="ILife"/>.
    /// </summary>
    public abstract class AbstractLife : ILife
    {
        public int HealthPoints { get; protected set; }
        public int Experience { get; protected set; }

        /// <summary>
        /// Creates a new AbstractLife.
        /// </summary>
        /// <param name="healthPoints">the health points value.</param>
        /// <param name="experience">the experience value.</param>
        protected AbstractLife(int healthPoints, int experience)
        {
            this.Experience = experience;
            this.HealthPoints = healthPoints;
        }

        /// <summary>
        /// Check if value is negative or not.
        /// </summary>
        /// <param name="value">the value to check.</param>
        /// <returns>the value given if it's positive, 0 otherwise.</returns>
        protected static int CheckNotNegative(int value) => value < 0 ? 0 : value;

        /// <inheritdoc cref="ILife"/>
        public virtual void Hurt(int damage) => 
            this.HealthPoints = CheckNotNegative(this.HealthPoints - damage);

        /// <inheritdoc cref="ILife"/>
        public virtual bool IsDead() => this.HealthPoints == 0;
    }
}