namespace Rogue.Items.Weapon
{
    /// <summary>
    /// An interface for modeling a game weapon.
    /// </summary>
    public interface IWeapon : IItem
    {
        /// <summary>
        /// Represents an enumeration for declaring weapon use.
        /// </summary>
        enum WeaponUse {HANDLED, THROWN}

        /// <summary>
        /// Gets the weapon damage.
        /// </summary>
        /// <param name="weaponUse"> how the Weapon is used (by hand or thrown)</param>
        /// <returns>the weapon's damage.</returns>
        int Damage(WeaponUse weaponUse);

        /// <summary>
        /// Gets the weapon accuracy.
        /// </summary>
        /// <returns>an <see cref="int"/> representing the weapon accuracy.</returns>
        int Accuracy();

    }
}