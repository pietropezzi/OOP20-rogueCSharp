namespace Rogue.Creature
{
    /// <summary>
    /// An interface modeling a factory for the <see cref="IPlayer"/>
    /// </summary>
    public interface IPlayerFactory
    {

        /// <summary>
        /// Creates a new <see cref="IPlayer"/> with defaults life settings.
        /// </summary>
        /// <returns>a new <see cref="IPlayer"/> instance.</returns>
        IPlayer Create();
        
        /// <summary>
        /// Creates a new <see cref="IPlayer"/> with the given life.
        /// </summary>
        /// <param name="life">the player life.</param>
        /// <returns>a new <see cref="IPlayer"/> instance.</returns>
        IPlayer CreateByLife(IPlayerLife life);
    }
}