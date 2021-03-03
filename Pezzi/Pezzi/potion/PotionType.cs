using System;
using System.Collections.Generic;
using System.Text;

namespace Pezzi.potion
{
    /// <summary>
    /// Class that represents a <see cref="Potion"/> type.
    /// </summary>
    public class PotionType
    {
        // POTIONS
        public static readonly PotionType POTION_I = new PotionType(PotionEffect.HEAL, new KeyValuePair<int, int>(5, 10));
        public static readonly PotionType POTION_II = new PotionType(PotionEffect.HEAL, new KeyValuePair<int, int>(15, 20));
        public static readonly PotionType POTION_III = new PotionType(PotionEffect.HEAL, new KeyValuePair<int, int>(25, 33));
        public static readonly PotionType POTION_IV = new PotionType(PotionEffect.HEAL, new KeyValuePair<int, int>(40, 50));
        public static readonly PotionType POTION_V = new PotionType(PotionEffect.HEAL, new KeyValuePair<int, int>(100, 100));
        public static readonly PotionType CORRUPT_POTION_I = new PotionType(PotionEffect.HURT, new KeyValuePair<int, int>(1, 3));
        public static readonly PotionType CORRUPT_POTION_II = new PotionType(PotionEffect.HURT, new KeyValuePair<int, int>(3, 5));

        public static IEnumerable<PotionType> Values
        { 
            get
            {
                yield return POTION_I;
                yield return POTION_II;
                yield return POTION_III;
                yield return POTION_IV;
                yield return POTION_V;
                yield return CORRUPT_POTION_I;
                yield return CORRUPT_POTION_II;
            }
        }

        private PotionEffect effect;
        private KeyValuePair<int, int> hpValue;

        PotionType(PotionEffect effect, KeyValuePair<int, int> value) =>
            (this.effect, this.hpValue) = (effect, value);

        /// <summary>
        /// Generates the helth points of the potion.
        /// </summary>
        /// <returns>the health points of the potion.</returns>
        public int GenerateHpValue()
        {
            int ret = new Random().Next(hpValue.Key, hpValue.Value + 1);
            if (this.effect.Equals(PotionEffect.HURT))
            {
                return ret * -1;
            } else
            {
                return ret;
            }
        }

        /// <summary>
        /// Gets the potion's effect.
        /// </summary>
        /// <returns>the potion's effect.</returns>
        public PotionEffect GetEffect() => this.effect;
    }
}
