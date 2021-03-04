using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using rogue;

namespace Rogue
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var pl = new PlayerLifeImpl.Builder().Build();
            Assert.AreEqual(16, pl.Strength);
        }
    }
}