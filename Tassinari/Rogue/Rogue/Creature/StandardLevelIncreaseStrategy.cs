using System;
using System.Linq;

namespace Rogue.Creature
{
    /// <summary>
    /// This class represents the standard strategy with which increase the level value.
    /// </summary>
    public class StandardLevelIncreaseStrategy : ILevelIncreaseStrategy
    {
        /// <summary>
        /// An enumeration represents the level with the corresponding experience value.
        /// </summary>
        private enum ExpLevel
        {
            L1 = 0,     L2 = 7,     L3 = 16,    L4 = 30, 
            L5 = 50,    L6 = 75,    L7 = 115,   L8 = 170, 
            L9 = 250,   L10 = 355,  L11 = 525,  L12 = 725,
            L13 = 1050, L14 = 1475, L15 = 2125, L16 = 3000,
            L17 = 4250, L18 = 6000, L19 = 8500, L20 = 12_000
        }
        
        /// <inheritdoc cref="ILevelIncreaseStrategy"/>
        public int Level(int experience)
        {
            var l = Enum.GetValues(typeof(ExpLevel))
                .Cast<int>()
                .Where(i => i <= experience)
                .ToList();
            return l.Count;
        }

    }
}