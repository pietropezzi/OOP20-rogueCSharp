namespace rogue
{
    public interface IPlayerLife : ILife
    {
        void increaseExperience(int amount);

        void powerUp(int amount);

        void addStrength(int amount);

        void increaseFood(int amount);

        void decreaseFood(int amount);

        void addCoins(int amount);

        void subCoins(int amount);
    }
}