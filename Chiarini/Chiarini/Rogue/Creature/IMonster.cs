namespace Rogue.Creature
{
	/// <summary>
	/// An interface modeling the enemy/monster.
	/// </summary>
	public interface IMonster  {

    	/// <summary>
    	/// return the type of the monster
    	/// </summary>
    	/// <returns>the type of the monster</returns>
    	MonsterType getMonsterType();
    	
    	/// <summary>
    	/// return the monster's life  
    	/// </summary>
    	/// <returns>the monster life </returns>
    	MonsterLife getMonsterLife();

    	/// <summary>
    	/// return the Armor Class of the monster
    	/// </summary>
    	/// <returns>the Armor Class of the monster </returns>
    	int getAC();

    	/// <summary>
    	/// return the maximum damage the monster can do the minimum is 1 
    	/// </summary>
    	/// <returns>the maximum damage the monster can do the minimum is 1 </returns>
    	Pair<int, int> getDamage();

    	/// <summary>
    	/// return the monster's special skill
    	/// </summary>
    	/// <returns>the monster's special skill</returns>
    	Special getSpecial();

    	/// <summary>
    	/// return the amount of money of the monster 
    	/// </summary>
    	/// <returns>the amount of money of the monster </returns>
    	int getMoney();
    
    	/// <summary>
    	/// return the item's possibility to drop
    	/// </summary>
    	/// <returns>the item's possibility to drop</returns>
    	int getItemChange();
    
    	/// <summary>
    	/// return the damage that the monster does for that single attack 
    	/// </summary>
    	/// <returns>the damage that the monster does for that single attack </returns>
    	int attackDamage();
    
    	//Potion getItem();
    
    	/// <summary>
    	/// return a random number of the item drop
    	/// </summary>
    	/// <returns>a random number of the item drop</returns>
    	int dropItem();

    	//Direction monsterMove(Direction playerDirection);
	}
}
