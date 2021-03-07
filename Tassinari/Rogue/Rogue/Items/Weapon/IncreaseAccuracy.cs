namespace Rogue.Weapon
{
    /// <summary>
    /// A concrete decorator to increase the weapon accuracy.
    /// </summary>
    public class IncreaseAccuracy : WeaponDecorator
    {
        private const int AdditionalAccuracy = 2;

        /// <summary>
        /// Creates a new IncreaseAccuracy decorator.
        /// </summary>
        /// <param name="weapon">the <see cref="IWeapon"/> to decorate. </param>
        public IncreaseAccuracy(IWeapon weapon) : base(weapon){}

        /// <inheritdoc cref="IWeapon"/>
        public override int Accuracy() => base.Accuracy() + AdditionalAccuracy;

        /// <inheritdoc cref="ToString"/>
        public override string ToString() => base.ToString() + " IA";
        
    }
}