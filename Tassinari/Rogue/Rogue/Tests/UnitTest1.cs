using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rogue.Creature;

namespace Rogue
{
    [TestClass]
    public class UnitTest1
    {

        private IPlayer _player;

        [TestMethod]
        public void TestDefaultsLife()
        {
            // with default configs
            this._player = new PlayerFactory().Create();

            // actual values
            var hp = _player.Life.MaxHealthPoints;
            var exp = _player.Life.Experience;
            var food = _player.Life.Food;
            
            // hurts the player => the expected value is hp - 10 and it's still alive.
            _player.Life.Hurt(10);
            Assert.AreEqual(hp - 10, _player.Life.HealthPoints);
            Assert.IsFalse(_player.Life.IsDead());
            // increases the experience => the expected value is exp + 10.
            _player.Life.IncreaseExperience(10);
            Assert.AreEqual(exp + 10, _player.Life.Experience);
            // decreases food => the expected value is food - 10 and it's still alive.
            _player.Life.DecreaseFood(10);
            Assert.IsFalse(_player.Life.IsDead());
            Assert.AreEqual(food - 10, _player.Life.Food);
            // decreases food by an amount to make it die.
            _player.Life.DecreaseFood(food - 10);
            Assert.IsTrue(_player.Life.IsDead());
        }
        
        [TestMethod]
        public void TestExplicitLife()
        {
            // with explicit configs
            const int hp   = 3;
            const int str  = 50;
            const int exp  = 20;
            const int food = 10;

            var lifeBuilder = new PlayerLifeImpl.Builder();
            this._player = new PlayerFactory().CreateByLife(lifeBuilder
                .InitHealthPoints(hp)
                .InitStrength(str)
                .InitExperience(exp)
                .InitFood(food).Build());
            
            // hurts the player => the expected value is 0 => died!
            _player.Life.Hurt(10);
            Assert.AreEqual(0, _player.Life.HealthPoints);
            Assert.IsTrue(_player.Life.IsDead());
            // increases the experience => the expected value is exp + 10.
            _player.Life.IncreaseExperience(10);
            Assert.AreEqual(exp + 10, _player.Life.Experience);
            // decreases food => the expected value is 0 and it's still died.
            _player.Life.DecreaseFood(10);
            Assert.IsTrue(_player.Life.IsDead());
            Assert.AreEqual(0, _player.Life.Food);
        }
        
        [TestMethod]
        public void TestMaxHp()
        {
            // with default configs
            this._player = new PlayerFactory().Create();
            // hp are maxed out
            Assert.AreEqual(_player.Life.MaxHealthPoints, _player.Life.HealthPoints);
            // TODO
        }
        
        [TestMethod]
        public void TestMaxFood()
        {
            // with default configs
            this._player = new PlayerFactory().Create();
            // exceeds max food
            _player.Life.IncreaseFood(_player.Life.MaxFood - _player.Life.Food + 1);
            Assert.AreEqual(_player.Life.MaxFood, _player.Life.Food);
            _player.Life.DecreaseFood(_player.Life.MaxFood + 1);
            Assert.AreEqual(0, _player.Life.Food);
        }
        
        
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "Cannot build twice!")]
        public void TestMultipleBuild()
        {
            var lifeBuilder = new PlayerLifeImpl.Builder();
            lifeBuilder.Build();
            lifeBuilder.Build();
        }
        
        
    }
}