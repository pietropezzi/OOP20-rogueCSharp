namespace Rogue.Creature
{

	/// <summary>
	/// An interface modeling the Special skill for a <see cref="Monster"/>.
	/// </summary>
	public interface ISpecial {

		/// <summary>
    	/// return true if the monster is hostile.
    	/// </summary>
    	/// <returns>the monster is hostile.</returns>
    	bool isHostile();
	
    	/// <summary>
    	/// return true if the monster can fly.
    	/// </summary>
    	/// <returns>the monster can fly.</returns>
    	bool isFlying();

    	/// <summary>
    	/// return true if the monster attempt to pick up gold
    	/// </summary>
    	/// <returns>the monster attempt to pick up gold</returns>
    	bool isGreedy();
	
    	/// <summary>
	    /// return true if the monster flies randomly.
	    /// </summary>
	    /// <returns>the monster flies randomly.</returns>
	    bool isFlyingRandom();

	    /// <summary>
	    /// return true if the monster can poison the player.
	    /// </summary>
	    /// <returns>the monster can poison the player.</returns>
	    bool isPoisonous();
    
	    /// <summary>
	    /// return true if the monster can steal life from the player.
	    /// </summary>
	    /// <returns>the monster can steal life from the player.</returns>
	    bool isDrainLife();
    
	    /// <summary>
	    /// the monster become hostile.
	    /// </summary>
	    void becomeHostile();
	}
}
