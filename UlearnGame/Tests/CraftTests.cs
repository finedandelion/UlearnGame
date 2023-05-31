using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using UlearnGame.Model;
using UlearnGame.Model.Resources;

namespace UlearnGame.Tests
{
    [TestFixture]
    public class CraftTests
    {
        private static Game Game;
        private static Inventory Inventory;
        private static AscendingSystem AscendingSystem;
        private static CraftSystem CraftSystem;

        [SetUp]
        protected virtual void Setup()
        {
            Game = new Game();
            Inventory = Game.Inventory;
            AscendingSystem = Game.AscendingSystem;
            CraftSystem = Game.CraftSystem;
        }

        [Test]
        public void DoCraftWithResourceConsumptionTest() // При крафте состояние инвентаря меняется
        {
            var resource = new Wood() { Amount = 1 };
            Inventory.AddItem(new Resource[] { resource });
            CraftSystem.DoCraft(0);
            Assert.IsTrue(Inventory.Count == 1);
            Assert.IsTrue(Inventory.AmountOf(new Wood()) == 0);
            Assert.IsTrue(Inventory.AmountOf(new Plank()) == 2);
        }

        public void DoCraftWithoutResourceDoesntChangeInventoryStateTest() // Если нет необходимых ресурсов, состояние инвентаря не меняется
        {
            var resource = new Rock() { Amount = 1 };
            Inventory.AddItem(new Resource[] { resource });
            CraftSystem.DoCraft(0);
            Assert.IsTrue(Inventory.Count == 1);
            Assert.IsTrue(Inventory.AmountOf(new Plank()) == 0);
            Assert.IsTrue(Inventory.AmountOf(new Rock()) == 1);
        }
    }
}
