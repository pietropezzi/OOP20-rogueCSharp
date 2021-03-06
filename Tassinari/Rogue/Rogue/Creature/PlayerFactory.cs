using System;

namespace Rogue.Creature
{
    /// <summary>
    /// An implementation for <see cref="IPlayerFactory"/> which encapsulates the 
    /// implementation of <see cref="IPlayer"/>
    /// </summary>
    public class PlayerFactory : IPlayerFactory
    {
        private class Player : AbstractCreature<IPlayerLife>, IPlayer
        {
            /// <inheritdoc cref="IPlayer"/>
            public IEquipment Equipment { get; }
            
            /// <inheritdoc cref="IPlayer"/>
            public IInventory Inventory { get; }

            public Player(IPlayerLife life) : base(life)
            {
                this.Equipment = null;
                this.Inventory = null;
            }
        }

        /// <inheritdoc cref="IPlayerFactory"/>
        public IPlayer Create() => CreateByLife(new PlayerLifeImpl.Builder().Build());
        
        /// <inheritdoc cref="IPlayerFactory"/>
        public IPlayer CreateByLife(IPlayerLife life)
        {
            if (life == null)
            {
                throw new NullReferenceException();
            }

            return new Player(life);
        }
    }
}