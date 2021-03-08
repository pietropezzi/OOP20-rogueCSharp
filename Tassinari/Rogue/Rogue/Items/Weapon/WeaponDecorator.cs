using Rogue.Creature;

namespace Rogue.Items.Weapon
{
    /// <summary>
    /// A decorator for a <see cref="BaseWeapon"/>
    /// </summary>
    public abstract class WeaponDecorator : IWeapon
    {
        private readonly IWeapon _weapon;
        
        /// <summary>
        /// Creates a weapon decorator.
        /// </summary>
        /// <param name="weapon">the weapon to decorate.</param>
        protected WeaponDecorator(IWeapon weapon) => this._weapon = weapon;

        /// <inheritdoc cref="IWeapon"/>
        public WeaponType Weapon => this._weapon.Weapon;

        /// <inheritdoc cref="IWeapon"/>
        public virtual int Accuracy() => this._weapon.Accuracy();

        /// <inheritdoc cref="IWeapon"/>
        public virtual int Damage(IWeapon.WeaponUse weaponUse) => this._weapon.Damage(weaponUse);

        /// <inheritdoc cref="IItem"/>
        public bool Use(IPlayer player) => this._weapon.Use(player);

        /// <inheritdoc cref="Equals(Rogue.Items.Weapon.WeaponDecorator)"/>
        private bool Equals(WeaponDecorator other)
        {
            return Equals(_weapon, other._weapon);
        }
        
        /// <inheritdoc cref="object.Equals(object?)"/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((WeaponDecorator) obj);
        }

        /// <inheritdoc cref="object.GetHashCode"/>
        public override int GetHashCode()
        {
            return (_weapon != null ? _weapon.GetHashCode() : 0);
        }

        /// <inheritdoc cref="ToString"/>
        public override string ToString() => this._weapon.ToString();
    }
}