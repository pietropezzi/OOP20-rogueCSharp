using System;
using System.Collections.Generic;
using System.Text;

namespace Pezzi.potion
{
    /// <summary>
    /// Class representing a game <see cref="IPotion"/>.
    /// </summary>
    public class PotionImpl : IPotion
    {
        private readonly PotionType potion;
        private readonly int hpValue;

        public PotionImpl(PotionType potion) =>
            (this.potion, this.hpValue) = (potion, potion.GenerateHpValue());

        /// <summary>
        /// Uses the potion.
        /// </summary>
        /// <param name="player">on which to use the potion.</param>
        /// <returns>true if used correctly, false otherwise.</returns>
        public bool Use(Player player)
        {
            if (GetEffect().Equals(PotionEffect.HEAL))
            {
                // HEAL
                int increase = hpValue;
                if (player.GetHealth() != player.GetMaxHealth())
                {
                    if (player.GetHealth() + increase > player.GetMaxHealth())
                    {
                        // Can exceede max health.
                        player.AddHealth(player.GetMaxHealth() - player.GetHealth());
                    } else
                    {
                        // Simply increase
                        player.AddHealth(increase);
                    }
                    return true;
                } else
                {
                    // Already at max
                    return false;
                }
            } else
            {
                // HURT
                int decrease = hpValue;
                if (player.GetHealth() + decrease < 0)
                {
                    // Cant go below 0.
                    player.AddHealth(-player.GetHealth());
                } else
                {
                    // Simply decrease
                    player.AddHealth(decrease);
                }
                return true;
            }
        }

        /// <summary>
        /// Gets the potion's effect.
        /// </summary>
        /// <returns>the potion's effect.</returns>
        public PotionEffect GetEffect() => this.potion.GetEffect();

        /// <summary>
        /// Gets the potion's health points.
        /// </summary>
        /// <returns>the potion's health points.</returns>
        public int GetHpValue() => this.hpValue;

    }
}
