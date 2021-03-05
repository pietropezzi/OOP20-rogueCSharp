using System;
using System.Collections.Generic;
using System.Linq;

namespace Rogue.Weapon
{
    /// <summary>
    /// A class for declaring weapon types.
    /// </summary>
    public class WeaponType
    {
        public static readonly WeaponType Mace = 
            new WeaponType(Tuple.Create(2, 4), Tuple.Create(1, 3), "Mace");
        public static readonly WeaponType LongSword = 
            new WeaponType(Tuple.Create(3, 4), Tuple.Create(1, 2), "Long sword");
        public static readonly WeaponType ShortBow = 
            new WeaponType(Tuple.Create(1, 1), Tuple.Create(1, 1), "Short Bow");

        private const int WeaponAccuracy = 0;

        private readonly Dictionary<IWeapon.Use, Tuple<int, int>> damages =
            new Dictionary<IWeapon.Use, Tuple<int, int>>();
        private readonly Random rnd = new Random();
        
        /// <summary>
        /// Gets the weapon name.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the weapon accuracy.
        /// </summary>
        public static int Accuracy => WeaponAccuracy;

        private WeaponType(Tuple<int, int> handledDamage, Tuple<int, int> thrownDamage, string name)
        {
            this.Name = name;
            this.damages.Add(IWeapon.Use.THROWN, thrownDamage);
            this.damages.Add(IWeapon.Use.HANDLED, handledDamage);
        }

        /// <summary>
        /// Gets the damage generation function.
        /// </summary>
        /// <param name="use"> the <see cref="IWeapon.Use"/> of the weapon.</param>
        /// <returns>the <see cref="Func{TResult}"/> which express the damage generation function.</returns>
        public Func<int> GetDamage(IWeapon.Use use)
        {
            return () => Enumerable.Sum(Enumerable
                .Range(0, damages[use].Item1)
                .Select(i => rnd.Next(damages[use].Item2) + 1));
        }

    }
}