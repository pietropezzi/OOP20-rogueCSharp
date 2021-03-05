namespace Rogue.Weapon
{
    /// <summary>
    /// A concrete decorator to increase the weapon damage.
    /// </summary>
    public class IncreaseDamage : WeaponDecorator
    {
        private const int AdditionalDamage = 3;

        /// <summary>
        /// Creates a new IncreaseDamage decorator.
        /// </summary>
        /// <param name="weapon">the <see cref="IWeapon"/> to decorate. </param>
        public IncreaseDamage(IWeapon weapon) : base(weapon) {}

        /// <inheritdoc cref="IWeapon"/>
        public override int Damage(IWeapon.Use use) => base.Damage(use) + AdditionalDamage;

        /// <inheritdoc cref="ToString"/>
        public override string ToString() => base.ToString() + " ID";
        
    }
}