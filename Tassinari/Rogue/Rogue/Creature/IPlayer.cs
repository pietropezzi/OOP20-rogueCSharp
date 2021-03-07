using Rogue.Items;

namespace Rogue.Creature
{
    /// <summary>
    /// An interface modeling the player.
    /// </summary>
    public interface IPlayer : ICreature<IPlayerLife>
    {
        /// <summary>
        /// Gets the player inventory.
        /// </summary>
        IInventory Inventory { get; }
        
        /// <summary>
        /// Gets the player equipment.
        /// </summary>
        IEquipment Equipment { get; }
    }
}