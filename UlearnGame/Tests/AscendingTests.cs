using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model;
using UlearnGame.Model.Resources;

namespace UlearnGame.Tests
{
    [TestFixture]
    public class AscendingTests
    {
        private static Game Game;
        private static Inventory Inventory;
        private static AscendingSystem AscendingSystem;

        [SetUp]
        protected virtual void Setup()
        {
            Game = new Game();
            Inventory = Game.Inventory;
            AscendingSystem = Game.AscendingSystem;
        }

        [Test] // Проверка на условие возвышения
        public void IsPossibleToAscendTest()
        {
            Assert.IsFalse(AscendingSystem.IsAscendable());
            var current = AscendingSystem.CurrentResources;
            Inventory.AddItem(current);
            Assert.IsTrue(AscendingSystem.IsAscendable());
        }

        [Test]
        public void ResouceUsingTest() // После возывшения из инвентаря пропадают ресурсы
        {
            var current = AscendingSystem.CurrentResources;
            Inventory.AddItem(current);
            AscendingSystem.Ascend();
            Assert.That(Inventory.AmountOf(current[0]), Is.EqualTo(0));
        }

        [Test]
        public void GetAllAscendingsTest() // После получения всех возвышений, игра должна считаться оконченной 
        {
            for (var i = 0; i < AscendingSystem.AscendLevelCap; i++)
            {
                var current = AscendingSystem.CurrentResources;
                Inventory.AddItem(current);
                AscendingSystem.Ascend();
            }
            Assert.IsTrue(AscendingSystem.IsGameCompleted);
        }
    }
}
