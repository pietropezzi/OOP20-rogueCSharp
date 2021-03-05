namespace Rogue.Weapon
{
    /// <summary>
    /// A decorator for a <see cref="BaseWeapon"/>
    /// </summary>
    public abstract class WeaponDecorator : IWeapon
    {
        private readonly IWeapon _weapon;
        
        protected WeaponDecorator(IWeapon weapon) => this._weapon = weapon;

        /// <inheritdoc cref="IWeapon"/>
        public int Accuracy() => this._weapon.Accuracy();

        /// <inheritdoc cref="IWeapon"/>
        public int Damage(IWeapon.Use use) => this._weapon.Damage(use);

        /// <inheritdoc cref="IItem"/>
        public bool Use(Player player) => this._weapon.Use(player);

        /// <inheritdoc cref="Equals(Rogue.Weapon.WeaponDecorator)"/>
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