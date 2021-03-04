namespace Rogue.Creature
{
    /// <summary>
    /// An interface modeling a life for a Creature.
    /// </summary>
    public interface ILife
    {
        /// <summary>
        /// Hurts the creature.
        /// </summary>
        /// <param name="damage">The quantity to subtract to health points.</param>
        void Hurt(int damage);

        /// <summary>
        /// Determines whether the creature is dead or still alive.
        /// </summary>
        /// <returns>true if the creature is dead, false otherwise.</returns>
        bool IsDead();
    }
}