using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Rogue.Creature
{
    /// <summary>
    /// Represents an enumeration for declaring player attributes.
    /// </summary>
    public enum PlayerAttribute
    {
        /// <summary>Maximum health point value.</summary>
        MaxHp,
        /// <summary>Maximum health point value.</summary>
        Hp,
        /// <summary>Maximum health point value.</summary>
        Coins,
        /// <summary>Maximum health point value.</summary>
        Level,
        /// <summary>Maximum health point value.</summary>
        Strength,
        /// <summary>Maximum health point value.</summary>
        Experience,
        /// <summary>Maximum health point value.</summary>
        Food
    }

    public class PlayerLife : AbstractLife, IPlayerLife
    {
        /// <inheritdoc cref="IPlayerLife"/>
        public event Action<PlayerAttribute, int> PlayerLifeChanged;
        
        private const int MaxFoodLevel = 100;
        private int _maxHealthPoints;
        private int _strength;
        private int _food;
        private int _level;
        private int _coins;
        
        // add strategies ...

        /// <inheritdoc cref="IPlayerLife"/>
        public IEnumerable<Tuple<PlayerAttribute, int>> Values
        {
            get
            {
                yield return Tuple.Create(PlayerAttribute.MaxHp, this._maxHealthPoints);
                yield return Tuple.Create(PlayerAttribute.Hp, this.HealthPoints);
                yield return Tuple.Create(PlayerAttribute.Coins, this._coins);
                yield return Tuple.Create(PlayerAttribute.Level, this._level);
                yield return Tuple.Create(PlayerAttribute.Strength, this._strength);
                yield return Tuple.Create(PlayerAttribute.Experience, this.Experience);
                yield return Tuple.Create(PlayerAttribute.Food, this._food);
            }
        }

        private void invokeAction(PlayerAttribute attribute, int value) =>
            this.PlayerLifeChanged?.Invoke(attribute, value);

        /// <inheritdoc cref="IPlayerLife"/>
        public int MaxFood => MaxFoodLevel;

        /// <inheritdoc cref="IPlayerLife"/>
        public int MaxHealthPoints
        {
            get => this._maxHealthPoints;
            private set
            {
                this._maxHealthPoints = value;
                this.invokeAction(PlayerAttribute.MaxHp, this._maxHealthPoints);
            }
        }

        /// <inheritdoc cref="IPlayerLife"/>
        public int Strength
        {
            get => this._strength;
            private set
            {
                this._strength = value;
                this.invokeAction(PlayerAttribute.Strength, this._strength);
            }
        }
        
        /// <inheritdoc cref="IPlayerLife"/>
        public int Food 
        {
            get => this._food;
            private set
            {
                this._food = value;
                this.invokeAction(PlayerAttribute.Food, this._food);
            }
        }

        /// <inheritdoc cref="IPlayerLife"/>
        public int Level
        {
            get => this._level;
            private set
            {
                this._level = value;
                this.invokeAction(PlayerAttribute.Level, this._level);
            }
        }

        /// <inheritdoc cref="IPlayerLife"/>
        public int Coins
        {
            get => this._coins;
            private set
            {
                this._coins = value;
                this.invokeAction(PlayerAttribute.Coins, this._coins);
            }
        }

        private PlayerLife(int experience, int healthPoints, int maxHealthPoints,
            int strength, int food, int level, int coins) : base(healthPoints, experience)
        {
            this.MaxHealthPoints = maxHealthPoints;
            this.Strength = strength;
            this.Food = food;
            this.Level = level;
            this.Coins = coins;
        }

        private static int CheckNotExceeding(int val, int max) => val > max ? max : val;

        /// <inheritdoc cref="ILife"/>
        public override void Hurt(int damage)
        {
            base.Hurt(damage);
            this.invokeAction(PlayerAttribute.Hp, this.HealthPoints);
        }
        
        /// <inheritdoc cref="IPlayerLife"/>
        public void IncreaseExperience(int amount)
        {
            this.Experience += amount;
            this.invokeAction(PlayerAttribute.Experience, this.Experience);
        } 

        /// <inheritdoc cref="IPlayerLife"/>
        public void PowerUp(int amount)
        {
            this.HealthPoints += CheckNotExceeding(this.HealthPoints + amount, MaxHealthPoints);
            this.PlayerLifeChanged?.Invoke(PlayerAttribute.Hp, this.HealthPoints);
        }
        
        /// <inheritdoc cref="IPlayerLife"/>
        public void AddStrength(int amount) => this.Strength += amount;

        private void UpdateFood(int amount)
        {
            var newFood = this.Food + amount;
            this.Food = CheckNotNegative(CheckNotExceeding(newFood, MaxFoodLevel));
        }

        /// <inheritdoc cref="IPlayerLife"/>
        public void IncreaseFood(int amount) => this.UpdateFood(amount);

        /// <inheritdoc cref="IPlayerLife"/>
        public void DecreaseFood(int amount) => this.UpdateFood(-amount);

        private void UpdateCoins(int amount) => this.Coins = CheckNotNegative(this.Coins + amount);

        /// <inheritdoc cref="IPlayerLife"/>
        public void AddCoins(int amount) => this.UpdateCoins(amount);

        /// <inheritdoc cref="IPlayerLife"/>
        public void SubCoins(int amount) => this.UpdateCoins(-amount);

        /// <inheritdoc cref="ILife"/>
        public override bool IsDead() => base.IsDead() || this.Food == 0;

        public class Builder
        {
            // Default values
            private const int MaxHealthPoints = 12;
            private const int HealthPoints = 12;
            private const int Food = 50;
            private const int Experience = 0;
            private const int Strength = 16;
            private const int Coins = 0;
            private const int Level = 1;

            // insert strategies
            
            private int _maxHealthPoints = MaxHealthPoints;
            private int _healthPoints = HealthPoints;
            private int _food = Food;
            private int _experience = Experience;
            private int _strength = Strength;
            private int _level = Level;
            private int _coins = Coins;
            private bool _consumed;

            /// <summary>
            /// Initialize the player maximum health points.
            /// </summary>
            /// <param name="maxHealthPoints">the max player health points.</param>
            /// <returns>this Builder for chaining</returns>
            public Builder InitMaxHealthPoints(int maxHealthPoints)
            {
                this._maxHealthPoints = maxHealthPoints;
                return this;
            }
            
            /// <summary>
            /// Initialize the player health points.
            /// </summary>
            /// <param name="healthPoints">the initial player health points.</param>
            /// <returns>this Builder for chaining</returns>
            public Builder InitHealthPoints(int healthPoints)
            {
                this._healthPoints = healthPoints;
                return this;
            }
            
            /// <summary>
            /// Initialize the food.
            /// </summary>
            /// <param name="food">the initial food quantity.</param>
            /// <returns>this Builder for chaining</returns>
            public Builder InitFood(int food)
            {
                this._food = food;
                return this;
            }
            
            /// <summary>
            /// Initialize the player experience.
            /// </summary>
            /// <param name="experience">the initial player experience.</param>
            /// <returns>this Builder for chaining</returns>
            public Builder InitExperience(int experience)
            {
                this._experience = experience;
                return this;
            }

            /// <summary>
            /// Initialize the player strength.
            /// </summary>
            /// <param name="strength">the initial player strength.</param>
            /// <returns>this Builder for chaining</returns>
            public Builder InitStrength(int strength)
            {
                this._strength = strength;
                return this;
            }

            /// <summary>
            /// Initialize the player level.
            /// </summary>
            /// <param name="level">the initial player level.</param>
            /// <returns>this Builder for chaining</returns>
            public Builder InitLevel(int level)
            {
                this._level = level;
                return this;
            }
            
            /// <summary>
            /// Initialize the amount of coins.
            /// </summary>
            /// <param name="coins">the initial amount of coins.</param>
            /// <returns>this Builder for chaining</returns>
            public Builder InitCoins(int coins)
            {
                this._coins = coins;
                return this;
            }

            /// <summary>
            /// Builds a new PlayerLifeImpl.
            /// </summary>
            /// <returns>a new PlayerLifeImpl</returns>
            /// <exception cref="InvalidOperationException">if a PlayerLifeImpl was already created.</exception>
            public PlayerLife Build()
            {
                if (_consumed)
                {
                    throw new InvalidOperationException("Cannot build twice!");
                }

                _consumed = true;
                return new PlayerLife(_experience, _healthPoints, _maxHealthPoints, _strength, _food, _level, _coins);
            }
            
        }
        
    }
}