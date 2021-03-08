using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rogue.Creature;

namespace Rogue.Tests
{
    [TestClass]
    public class StandardLevelIncreaseStrategyTest
    {
        private const int Level12 = 12;
        private const int ExpLevel12 = 789;
        private const int ExpLevel20 = 12_000;
        private const int Level20 = 20;
        private const int ExpLevel2 = 7;
        private const int Level2 = 2;
        private const int ExpLevel19 = 8501;
        private const int Level19 = 19;

        private StandardLevelIncreaseStrategy _strategy;
        
        [TestMethod]
        public void Test()
        {
            _strategy = new StandardLevelIncreaseStrategy();
            Assert.AreEqual(Level2, this._strategy.Level(ExpLevel2));
            Assert.AreEqual(Level20, this._strategy.Level(ExpLevel20));
            Assert.AreEqual(Level12, this._strategy.Level(ExpLevel12));
            Assert.AreEqual(Level19, this._strategy.Level(ExpLevel19));
        }
    }
}