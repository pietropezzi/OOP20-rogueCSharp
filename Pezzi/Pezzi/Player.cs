using System;
using System.Collections.Generic;
using System.Text;

namespace Pezzi
{
    /// <summary>
    /// Class that represents a game's Player.
    /// </summary>
    public class Player
    {
        private const int MAX_HEALTH = 50;

        private int health;
        private int strength;

        public Player() => (this.health, this.strength) = (MAX_HEALTH, 2);

        /// <summary>
        /// Gets the player's health.
        /// </summary>
        /// <returns>the player's health</returns>
        public int GetHealth() => this.health;

        /// <summary>
        /// Gets the player's max health.
        /// </summary>
        /// <returns>the player's max health.</returns>
        public int GetMaxHealth() => MAX_HEALTH;

        /// <summary>
        /// Gets the player's strength.
        /// </summary>
        /// <returns>the player's strength.</returns>
        public int GetStrength() => this.strength;

        /// <summary>
        /// Increases or decreases the player's health.
        /// </summary>
        /// <param name="amount">to add or remove to the player's health.</param>
        public void AddHealth(int amount) => this.health += amount;

        /// <summary>
        /// Increases or decreases the player's strength.
        /// </summary>
        /// <param name="amount">to add or remove to the player's strength</param>
        public void AddStrength(int amount) => this.strength += amount;

    }
}
