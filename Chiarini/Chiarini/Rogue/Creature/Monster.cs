using System;
namespace Rogue.Creature
{
	 /// <summary>
	 /// Class representing a game <see cref="IMonster"/> 
	 /// </summary> 
	public class Monster : IMonster
	{
       

	  	private readonly MonsterType name;
	    private readonly MonsterLife life;
	    private readonly int AC;
    	private readonly int money;
    	private readonly int itemChange;
    	// private readonly Potion item;
    	private readonly Special special;
    	private readonly Pair<int, int> damage;


    	public Monster(MonsterType name)
    	{
    	    this.name = name;
    		Random rnd = new Random();
    		if(this.name.Equals(MonsterType.AIR_ELEMENTAL)) {
    		   this.life = new MonsterLife(rnd.Next(4, 33-4), 20);
    	       this.AC = 2;
    	       this.money = 0;
    	       this.itemChange = 20;
    	       this.special = new Special(true, true, false, false, false, false);
    	       this.damage = new Pair<int, int>(4, 24);
    	    }
    	
    		else if(this.name.Equals(MonsterType.BAT)) {
    		   this.life = new MonsterLife(rnd.Next(1, 8-1), 1);
    	       this.AC = 3;
    	       this.money = 0;
    	       this.itemChange = 0;
    	       this.special = new Special(false, true, false, true, false, false);
    	       this.damage = new Pair<int, int>(1, 2);
    	    }
    	
    	   else if(this.name.Equals(MonsterType.CENTAUR)) {
    		   this.life = new MonsterLife(rnd.Next(4, 32-4), 17);
    	       this.AC = 4;
    	       this.money = 51;
    	       this.itemChange = 10;
    	       this.special = new Special();
    	       this.damage = new Pair<int, int>(4, 24);
    	    }
    	}
    
    	/// <summary>
    	/// return the type of the monster
    	/// </summary>
    	/// <returns>the type of the monster</returns>    
    	public MonsterType getMonsterType() {
    		return this.name;
    	}
    
    	/// <summary>
    	/// return the monster's life  
    	/// </summary>
    	/// <returns>the monster life </returns>
    	public MonsterLife getMonsterLife() {
    		return this.life;
    	}
    
    	/// <summary>
    	/// return the Armor Class of the monster
    	/// </summary>
    	/// <returns>the Armor Class of the monster </returns>
    	public int getAC() {
    		return this.AC;
    	}
    
    	/// <summary>
    	/// return the maximum damage the monster can do the minimum is 1 
    	/// </summary>
    	/// <returns>the maximum damage the monster can do the minimum is 1 </returns>
    	public Pair<int, int> getDamage() {
    		return this.damage;
    	}

    	/// <summary>
    	/// return the monster's special skill
    	/// </summary>
    	/// <returns>the monster's special skill</returns>
    	public Special getSpecial() {
    		return this.special;
    	}

    	/// <summary>
    	/// return the amount of money of the monster 
    	/// </summary>
    	/// <returns>the amount of money of the monster </returns>
    	public int getMoney() {
    		return this.money;
    	}

    	/// <summary>
    	/// return the item's possibility to drop
    	/// </summary>
    	/// <returns>the item's possibility to drop</returns>
    	public int getItemChange() {
    		return this.itemChange;
    	}

    	/// <summary>
    	/// return the damage that the monster does for that single attack 
    	/// </summary>
    	/// <returns>the damage that the monster does for that single attack </returns>
    	public int attackDamage() {
    		Random rnd = new Random();
    		return rnd.Next(this.getDamage().GetFirst(), this.getDamage().GetSecond());
    	}
    	
    	/* public Potion getItem() {
    	 *     return this.item;
    	 * }
    	 */

    	/// <summary>
    	/// return a random number of the item drop
    	/// </summary>
    	/// <returns>a random number of the item drop</returns>
    	public int dropItem() {
    		Random rnd = new Random();
    		return rnd.Next(100);
    	}   
	}
}
