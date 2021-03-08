namespace Rogue.Items.Armor
{
    /// <summary>
    /// An interface modeling a game armor.
    /// </summary>
    public interface IArmor : IItem
    {
        /// <summary>
        /// Gets the <see cref="ArmorType"/>.
        /// </summary>
        ArmorType ArmorType { get; }
        
        /// <summary>
        /// Gets the armor AC.
        /// </summary>
        int Ac { get; }
        
        /// <summary>
        /// Increases the armor's AC of the given value.
        /// </summary>
        /// <param name="amount">the value to add to the armor's AC.</param>
        void IncreaseAc(int amount);
        
        /// <summary>
        /// Decreases the armor's AC of the given value.
        /// </summary>
        /// <param name="amount">the value to subtract to the armor's AC.</param>
        void DecreaseAc(int amount);

    }
}