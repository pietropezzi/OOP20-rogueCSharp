using System;
using Rogue.Creature;

namespace Rogue.Items.Armor
{
    /// <summary>
    /// Represents a simple implementation for a game <see cref="IArmor"/>.
    /// </summary>
    public class Armor : IArmor
    {
        /// <summary>
        /// Gets the <see cref="ArmorType"/>.
        /// </summary>
        public ArmorType ArmorType { get; private set; }
        
        /// <summary>
        /// Gets the armor AC.
        /// </summary>
        public int Ac { get; private set; }

        public Armor(ArmorType armor)
        {
            this.ArmorType = armor;
            this.Ac = armor.Ac;
        }

        private void UpdateAc(int amount) => this.Ac = this.Ac + amount > 0 ? this.Ac + amount : 0;

        /// <inheritdoc cref="IArmor"/>
        public void DecreaseAC(int amount) => this.UpdateAc(-amount);

        /// <inheritdoc cref="IArmor"/>
        public void IncreaseAC(int amount) => this.UpdateAc(amount);

        /// <inheritdoc cref="IItem"/>
        public bool Use(IPlayer player)
        {
            throw new System.NotImplementedException();
        }
        
        /// <inheritdoc cref="Equals(Rogue.Armor.ArmorImpl)"/>
        private bool Equals(Armor other)
        {
            return Equals(ArmorType, other.ArmorType) && Ac == other.Ac;
        }

        /// <inheritdoc cref="object.Equals(object?)"/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Armor) obj);
        }
        
        /// <inheritdoc cref="object.GetHashCode"/>
        public override int GetHashCode()
        {
            return HashCode.Combine(ArmorType, Ac);
        }

        /// <inheritdoc cref="ToString"/>
        public override string ToString() => this.ArmorType.Name + " (" + this.Ac + ")";
        
    }
}