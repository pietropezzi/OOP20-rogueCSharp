using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rogue.Creature;

namespace Rogue
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var pl = new PlayerLifeImpl.Builder().Build();
            var sbc = new StatusBarControllerImpl(pl);
            Assert.AreEqual(16, pl.Strength);
            pl.addStrength(2);
            Assert.AreEqual(18, pl.Strength);
        }
        
    }
}