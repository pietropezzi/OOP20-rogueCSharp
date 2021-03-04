using System;

namespace Rogue.Creature
{
    public class PlayerLifeImpl : AbstractLife, IPlayerLife
    {

        public Action<int> playerLifeChanged;

        private int maxHealthPoints;
        private int strength;
        private int food;
        private int level;
        private int coins;
        
        // add strategies ...
        public int MaxHealthPoints
        {
            get => this.maxHealthPoints;
            private set
            {
                this.maxHealthPoints = value;
                this.playerLifeChanged?.Invoke(this.maxHealthPoints);
            }
        }

        public int Strength
        {
            get => this.strength;
            private set
            {
                this.strength = value;
                this.playerLifeChanged?.Invoke(this.strength);
            }
        }
        public int Food 
        {
            get => this.food;
            private set
            {
                this.food = value;
                this.playerLifeChanged?.Invoke(this.food);
            }
        }

        public int Level
        {
            get => this.level;
            private set
            {
                this.level = value;
                this.playerLifeChanged?.Invoke(this.level);
            }
        }

        public int Coins
        {
            get => this.coins;
            private set
            {
                this.coins = value;
                this.playerLifeChanged?.Invoke(this.coins);
            }
        }

        private PlayerLifeImpl(int experience, int healthPoints, int maxHealthPoints,
            int strength, int food, int level, int coins) : base(healthPoints, experience)
        {
            this.MaxHealthPoints = maxHealthPoints;
            this.Strength = strength;
            this.Food = food;
            this.Level = level;
            this.Coins = coins;
        }

        private static int checkNotExceeding(int val, int max) => val > max ? max : val;

        public override void hurt(int damage)
        {
            base.hurt(damage);
            this.playerLifeChanged?.Invoke(this.HealthPoints);
        }

        public void increaseExperience(int amount)
        {
            this.Experience += amount;
            this.playerLifeChanged?.Invoke(this.Experience);
        } 

        public void powerUp(int amount)
        {
            this.HealthPoints += checkNotExceeding(this.HealthPoints + amount, MaxHealthPoints);
            this.playerLifeChanged?.Invoke(this.HealthPoints);
        }

        public void addStrength(int amount) => this.Strength += amount;

        private void updateFood(int amount)
        {
            var newFood = this.Food + amount;
            this.Food = checkNotNegative(checkNotExceeding(newFood, MaxHealthPoints));
        }

        public void increaseFood(int amount) => this.updateFood(amount);

        public void decreaseFood(int amount) => this.updateFood(-amount);

        private void updateCoins(int amount) => this.Coins = checkNotNegative(this.Coins + amount);

        public void addCoins(int amount) => this.updateCoins(amount);

        public void subCoins(int amount) => this.updateCoins(-amount);

        public override bool isDead() => base.isDead() || this.Food == 0;

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
            
            private int maxHealthPoints = MaxHealthPoints;
            private int healthPoints = HealthPoints;
            private int food = Food;
            private int experience = Experience;
            private int strength = Strength;
            private int level = Level;
            private int coins = Coins;
            private bool consumed = false;

            public Builder InitMaxHealthPoints(int maxHealthPoints)
            {
                this.maxHealthPoints = maxHealthPoints;
                return this;
            }
            
            public Builder InitHealthPoints(int healthPoints)
            {
                this.healthPoints = healthPoints;
                return this;
            }
            
            public Builder InitFood(int food)
            {
                this.food = food;
                return this;
            }
            
            public Builder InitExperience(int experience)
            {
                this.experience = experience;
                return this;
            }

            public Builder InitStrength(int strength)
            {
                this.strength = strength;
                return this;
            }

            public Builder InitLevel(int level)
            {
                this.level = level;
                return this;
            }

            public Builder InitCoins(int coins)
            {
                this.coins = coins;
                return this;
            }

            public PlayerLifeImpl Build()
            {
                if (consumed)
                {
                    throw new InvalidOperationException();
                }

                consumed = true;
                return new PlayerLifeImpl(experience, healthPoints, maxHealthPoints, strength, food, level, coins);
            }
            
        }
        
    }
}