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
        private static UpgradeSystem UpgradeSystem;

        [SetUp]
        protected virtual void Setup()
        {
            Game = new Game();
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
        public void UpgradeCantObtainWithoutLeveLPointsTest() // Невозможно получить навык, если недостаточно очков
        {
            Assert.That(Game.Level, Is.EqualTo(0));
            Assert.IsFalse(UpgradeSystem.upgrades[0].IsObtainable());
        }

        [Test]
        public void UpgradeCantObtainObtainedUpgradeTest()// Невозможно получить навык, если навык уже получен
        {
            Game.AddExperience(120);
            UpgradeSystem.upgrades[0].ObtainUpgrade();
            Assert.That(UpgradeSystem.AvailableUpgradePoints,Is.EqualTo(0));
            Assert.IsFalse(UpgradeSystem.upgrades[0].IsObtainable());
        }

        [Test]
        public void UpgradeCantBeObtainedIfPreviousNotObtainedTest() // Невозможно получить навык, если не получены предыдущие навыки
        {
            Game.AddExperience(120);
            Assert.That(UpgradeSystem.AvailableUpgradePoints, Is.EqualTo(1));
            Assert.IsFalse(UpgradeSystem.upgrades[1].IsObtainable());
        }
    }
}
