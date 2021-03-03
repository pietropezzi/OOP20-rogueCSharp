namespace rogue
{
    public abstract class AbstractLife : ILife
    {
        public int HealthPoints { get; protected set; }
        public int Experience { get; protected set; }

        protected AbstractLife(int healthPoints, int experience)
        {
            this.Experience = experience;
            this.HealthPoints = healthPoints;
        }

        protected int checkNotNegative(int value) => value < 0 ? 0 : value;

        public virtual void hurt(int damage) => 
            this.HealthPoints = checkNotNegative(this.HealthPoints - damage);

        public virtual bool isDead() => this.HealthPoints == 0;
    }
}