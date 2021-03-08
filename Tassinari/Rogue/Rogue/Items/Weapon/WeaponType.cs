using System;
using System.Collections.Generic;
using System.Linq;

namespace Rogue.Items.Weapon
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

        private readonly Dictionary<IWeapon.WeaponUse, Tuple<int, int>> _damages =
            new Dictionary<IWeapon.WeaponUse, Tuple<int, int>>();
        private readonly Random _rnd = new Random();
        
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
            this._damages.Add(IWeapon.WeaponUse.Thrown, thrownDamage);
            this._damages.Add(IWeapon.WeaponUse.Handled, handledDamage);
        }

        /// <summary>
        /// Gets the damage generation function.
        /// </summary>
        /// <param name="weaponUse"> the <see cref="IWeapon.WeaponUse"/> of the weapon.</param>
        /// <returns>the <see cref="Func{TResult}"/> which express the damage generation function.</returns>
        public Func<int> GetDamage(IWeapon.WeaponUse weaponUse)
        {
            return () => Enumerable.Sum(Enumerable
                .Range(0, _damages[weaponUse].Item1)
                .Select(i => _rnd.Next(_damages[weaponUse].Item2) + 1));
        }

    }
}