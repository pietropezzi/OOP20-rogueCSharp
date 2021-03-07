using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;

namespace Rogue.Creature
{
    /// <summary>
    /// This class represents the standard strategy with which increase the max hp value.
    /// </summary>
    public class StandardMaxHpIncreaseStrategy : IMaxHpIncreaseStrategy
    {
        private const int Delta = 12;

        /// <inheritdoc cref="IMaxHpIncreaseStrategy"/>
        public int MaxHp(int level) => level * Delta;
    }
}