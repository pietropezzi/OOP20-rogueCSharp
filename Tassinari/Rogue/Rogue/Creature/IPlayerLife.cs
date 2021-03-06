namespace Rogue.Creature
{
    /// <summary>
    /// An interface modeling a specific <see cref="ILife"/> for the Player.
    /// </summary>
    public interface IPlayerLife : ILife
    {
        /// <summary>
        /// Increases the player experience.
        /// </summary>
        /// <param name="amount">the quantity to add to the player experience.</param>
        void IncreaseExperience(int amount);

        /// <summary>
        /// Increases the player health points.
        /// </summary>
        /// <param name="amount">the quantity to add to the player health points.</param>
        void PowerUp(int amount);
        
        /// <summary>
        /// Gets the max health points.
        /// </summary>
        int MaxHealthPoints { get; }

        /// <summary>
        /// Increases the player strength.
        /// </summary>
        /// <param name="amount">the quantity to add to the player strength.</param>
        void AddStrength(int amount);
        
        /// <summary>
        /// Gets the strength.
        /// </summary>
        int Strength { get; }

        /// <summary>
        /// Increases the leftover player food.
        /// </summary>
        /// <param name="amount">the quantity to add to the leftover food.</param>
        void IncreaseFood(int amount);

        /// <summary>
        /// Decreases the leftover player food.
        /// </summary>
        /// <param name="amount">the quantity to subtract to the leftover food.</param>
        void DecreaseFood(int amount);
        
        /// <summary>
        /// Gets the food level.
        /// </summary>
        int Food { get; }
        
        /// <summary>
        /// Gets the max food.
        /// </summary>
        int MaxFood { get; }
        
        /// <summary>
        /// Gets the player's level.
        /// </summary>
        int Level { get; } 
        
        /// <summary>
        /// Adds the given amount of coins to the player.
        /// </summary>
        /// <param name="amount">the amount of coins to add.</param>
        void AddCoins(int amount);

        /// <summary>
        /// Subtracts the given amount of coins to the player.
        /// </summary>
        /// <param name="amount">the amount of coins to subtract.</param>
        void SubCoins(int amount);
        
        /// <summary>
        /// Gets the coins value.
        /// </summary>
        int Coins { get; }
    }
}