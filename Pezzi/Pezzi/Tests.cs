using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pezzi.potion;
using Pezzi.scroll;

namespace Pezzi
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void TestPotionUse()
        {
            Player player = new Player();
            Potion potion = new PotionImpl(PotionType.POTION_I);
            //use at max
            Assert.IsFalse(potion.Use(player));
            
            //use normal
            player.AddHealth(-30);
            int before = player.GetHealth();
            Assert.IsTrue(potion.Use(player));
            Assert.AreEqual(player.GetHealth(), before + potion.GetHpValue());

            //use to max
            player.AddHealth(player.GetMaxHealth() - player.GetHealth());
            player.AddHealth(-4);
            Assert.IsTrue(potion.Use(player));
            Assert.AreEqual(player.GetMaxHealth(), player.GetHealth());
        }

        [TestMethod]
        public void TestCorruptPotionUse()
        {
            Player player = new Player();
            Potion potion = new PotionImpl(PotionType.CORRUPT_POTION_I);

            //use normal
            int before = player.GetHealth();
            Assert.IsTrue(potion.Use(player));
            Assert.AreEqual(player.GetHealth(), before + potion.GetHpValue());

            //use below zero.
            player.AddHealth(player.GetMaxHealth() - player.GetHealth());
            player.AddHealth(-49);
            Assert.IsTrue(potion.Use(player));
            Assert.AreEqual(0, player.GetHealth());
        }

        [TestMethod]
        public void TestScrollUseAndRemove()
        {
            Player player = new Player();
            Scroll scroll = new ScrollImpl(ScrollType.SCROLL_III);

            //use and remove normal
            int before = player.GetStrength();
            Assert.IsTrue(scroll.Use(player));
            Assert.AreEqual(player.GetStrength(), before + scroll.GetEffectValue());
            scroll.Remove(player);
            Assert.AreEqual(player.GetStrength(), before);

        }

        [TestMethod]
        public void TestCorruptScrollUse()
        {
            Player player = new Player();
            Scroll scroll = new ScrollImpl(ScrollType.CORRUPT_SCROLL_II);

            //use below zero.
            Assert.IsTrue(scroll.Use(player));
            Assert.AreEqual(0, player.GetStrength());
        }
    }
}
