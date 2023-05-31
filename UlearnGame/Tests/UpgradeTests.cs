using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model;

namespace UlearnGame.Tests
{
    [TestFixture]
    public class UpgradeTests
    {
        private static Game Game;
        private static Inventory Inventory;
        private static GameField GameField;
        private static UpgradeSystem UpgradeSystem;

        [SetUp]
        protected virtual void Setup()
        {
            Game = new Game();
            Inventory = Game.Inventory;
            GameField = Game.Field;
            UpgradeSystem = Game.UpgradeSystem;
        }
        [Test]
        public void RightExperienceAdditionTest() // Правильный переход между уровнями
        {
            Game.AddExperience(120);
            Assert.That(Game.Level, Is.EqualTo(1));
            Game.AddExperience(120);
            Assert.That(Game.Experience, Is.EqualTo(120));
        }

        [Test]
        public void UpgradeCantObtainWithoutLeveLPointsTest()
        {
            Assert.That(Game.Level, Is.EqualTo(0));
            Assert.IsFalse(UpgradeSystem.upgrades[0].IsObtainable());
        }

        [Test]
        public void UpgradeCantObtainObtainedUpgradeTest()
        {
            Game.AddExperience(120);
            UpgradeSystem.upgrades[0].ObtainUpgrade();
            Assert.That(UpgradeSystem.AvailableUpgradePoints,Is.EqualTo(0));
            Assert.IsFalse(UpgradeSystem.upgrades[0].IsObtainable());
        }

        [Test]
        public void UpgradeCantBeObtainedIfPreviousNotObtainedTest()
        {
            Game.AddExperience(120);
            Assert.That(UpgradeSystem.AvailableUpgradePoints, Is.EqualTo(1));
            Assert.IsFalse(UpgradeSystem.upgrades[1].IsObtainable());
        }

        //[Test]
        //public void GathererUpgradeTest()
        //{
        //    UpgradeSystem.upgrades[0].ObtainUpgrade();
        //}

        //upgrades.Add(0, gatherer);
        //    upgrades.Add(1, craftsman);
        //    upgrades.Add(2, master1);
        //    upgrades.Add(3, master2);
        //    upgrades.Add(4, master3);
        //    upgrades.Add(5, adventurer);
        //    upgrades.Add(6, archeologist);
        //    upgrades.Add(7, hunter);
        //    upgrades.Add(8, spelunker);
        //    upgrades.Add(9, explorer);
        //    upgrades.Add(10, magician);
        //    upgrades.Add(11, priest);
        //    upgrades.Add(12, chronomancer);
    }
}
