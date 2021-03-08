using Rogue.Creature;

namespace Rogue.Items.Weapon
{
    /// <summary>
    /// A minimal implementation for a <see cref="IWeapon"/>.
    /// </summary>
    public sealed class BaseWeapon : IWeapon
    {
        /// <summary>
        /// Creates a new BaseWeapon.
        /// </summary>
        /// <param name="weapon">The <see cref="WeaponType"/>.</param>
        public BaseWeapon(WeaponType weapon) => Weapon = weapon;
        
        /// <inheritdoc cref="IWeapon"/>
        public WeaponType Weapon { get; }

        /// <inheritdoc cref="IWeapon"/>
        public int Damage(IWeapon.WeaponUse weaponUse) => this.Weapon.GetDamage(weaponUse).Invoke();

        /// <inheritdoc cref="IWeapon"/>
        public int Accuracy() => WeaponType.Accuracy;

        /// <inheritdoc cref="IItem"/>
        public bool Use(IPlayer player)
        {
            // TODO (intentionally empty): to put this weapon on equipment.
            throw new System.NotImplementedException();
        }

        /// <inheritdoc cref="Equals(Rogue.Items.Weapon.BaseWeapon)"/>
        private bool Equals(BaseWeapon other)
        {
            return Equals(Weapon, other.Weapon);
        }
        
        /// <inheritdoc cref="object.Equals(object?)"/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((BaseWeapon) obj);
        }
        
        /// <inheritdoc cref="object.GetHashCode"/>
        public override int GetHashCode()
        {
            return (Weapon != null ? Weapon.GetHashCode() : 0);
        }

        /// <inheritdoc cref="ToString"/>
        public override string ToString() => this.Weapon.Name;
    }
}