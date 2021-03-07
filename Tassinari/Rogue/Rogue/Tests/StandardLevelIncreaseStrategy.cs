using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rogue.Creature;

namespace Rogue.Tests
{
    [TestClass]
    public class StandardLevelIncreaseStrategyTest
    {
        const int LEVEL_12 = 12;
        const int EXP_LEVEL_12 = 789;
        const int EXP_LEVEL_20 = 12_000;
        const int LEVEL_20 = 20;
        const int EXP_LEVEL_2 = 7;
        const int LEVEL_2 = 2;
        const int EXP_LEVEL_19 = 8501;
        const int LEVEL_19 = 19;

        private StandardLevelIncreaseStrategy _strategy;
        
        [TestMethod]
        public void test()
        {
            _strategy = new StandardLevelIncreaseStrategy();
            Assert.AreEqual(LEVEL_2, this._strategy.Level(EXP_LEVEL_2));
            Assert.AreEqual(LEVEL_20, this._strategy.Level(EXP_LEVEL_20));
            Assert.AreEqual(LEVEL_12, this._strategy.Level(EXP_LEVEL_12));
            Assert.AreEqual(LEVEL_19, this._strategy.Level(EXP_LEVEL_19));
        }
    }
}