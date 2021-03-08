 namespace Rogue.Creature
{
/// <summary>
 /// Class representing a game <see cref="ISpecial"/> 
 /// </summary>
public class Special : ISpecial
{
    	private bool hostile;
	    private readonly bool flying;
    	private readonly bool greedy;
    	private readonly bool flyingRandom;
    	private readonly bool poisonous;
    	private readonly bool drainLife;
	

    	/// <summary>
    	/// The class constructor.
    	/// </summary>
    	/// <param name="hostile">the monster is hostile</param>
    	/// <param name="flying">the monster is flying</param>
    	/// <param name="greedy">the monster is greedy</param>
    	/// <param name="flyingRandom">the monster flies randomly</param>
    	/// <param name="poisonous">the monster is poisonus</param>
    	/// <param name="drainLife">the monster can drain life</param>
    	public Special(bool hostile, bool flying, bool greedy, bool flyingRandom, bool poisonous, bool drainLife) {
    	    this.flying = flying;
    	    this.greedy = greedy;
    	    this.flyingRandom = flyingRandom;
    	    this.poisonous = poisonous;
    	    this.drainLife = drainLife;
    	    this.hostile = hostile;
    	}

    	/// <summary>
    	/// The class constructor.
    	/// </summary>
    	/// <param name="hostile">the monster is hostile</param>
    	public Special(bool hostile)
    	{
    	    this.flying = false;
    	    this.greedy = false;
    	    this.flyingRandom = false;
    	    this.poisonous = false;
    	    this.drainLife = false;
    	    this.hostile = hostile;
    	}

    	/// <summary>
    	/// The class constructor.
    	/// </summary>
    	public Special()
    	{
    	    this.flying = false;
    	    this.greedy = false;
    	    this.flyingRandom = false;
    	    this.poisonous = false;
    	    this.drainLife = false;
    	    this.hostile = false;
    	}

    	/// <summary>
    	/// return true if the monster is hostile.
    	/// </summary>
    	/// <returns>the monster is hostile.</returns>
    	public bool isHostile() {
    	    return this.hostile;
    	}

    	/// <summary>
    	/// return true if the monster can fly.
    	/// </summary>
    	/// <returns>the monster can fly.</returns>
    	public bool isFlying() {
    	    return this.flying;
    	}

    	/// <summary>
    	/// return true if the monster attempt to pick up gold
    	/// </summary>
    	/// <returns>the monster attempt to pick up gold</returns>
    	public bool isGreedy() {
    	    return this.greedy;
    	}
    
    	/// <summary>
    	/// return true if the monster flies randomly.
    	/// </summary>
    	/// <returns>the monster flies randomly.</returns>
    	public bool isFlyingRandom() {
    	    return this.flyingRandom;
    	}

    	/// <summary>
    	/// return true if the monster can poison the player.
    	/// </summary>
    	/// <returns>the monster can poison the player.</returns>
    	public bool isPoisonous() {
    	    return this.poisonous;
    	}

    	/// <summary>
    	/// return true if the monster can steal life from the player.
    	/// </summary>
    	/// <returns>the monster can steal life from the player.</returns>
    	public bool isDrainLife() {
    	    return this.drainLife;
    	}

    	/// <summary>
    	/// the monster become hostile.
    	/// </summary>
    	public void becomeHostile() {
    	    this.hostile = true;
    	}
	}	
}