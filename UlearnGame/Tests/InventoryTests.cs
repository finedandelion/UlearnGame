using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Resources;
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
    public class InventoryTests
    {
        private static Game Game;
        private static Inventory Inventory;
        private static CraftSystem CraftSystem;
        private static GameField GameField;

        [SetUp]
        protected virtual void Setup()
        {
            Game = new Game();
            Inventory = Game.Inventory;
            CraftSystem = Game.CraftSystem;
        }

        [Test]
        public void StartInventoryIsEmptyTest() // В начале инвентарь пустой
        {
            Assert.IsTrue(!Inventory.GetStorage().Any());
        }

        [Test]
        public void ResourceAddTest() // Добавление ресурса в инвентарь
        {
            var resource = new Wood() { Amount = 11 };
            Inventory.AddItem(new Resource[] { resource });
            var resInStorage = Inventory.GetStorage()[0];
            Assert.That(resource.Amount, Is.EqualTo(resInStorage.Amount));
            Assert.That(resource.Image, Is.EqualTo(resInStorage.Image));
            Assert.That(resource.Description, Is.EqualTo(resInStorage.Description));
        }

        [Test]
        public void InventoryConsumptionTest() // При нулевом количестве ресурса он удаляется из инвентаря
        {
            var resource = new Wood() { Amount = 8 };
            Inventory.AddItem(new Resource[] { resource });
            Inventory.UseItem(resource);
            Assert.IsTrue(Inventory.Count == 0);
        }

        [Test]
        public void InventoryZeroAmountAdditionTest() // При добавлении ресурса с количеством ноль, состояние инвентаря не меняется 
        {
            var resource = new Wood() { Amount = 0 };
            Inventory.AddItem(new Resource[] { resource });
            Assert.IsTrue(Inventory.Count == 0);
        }

        [Test]
        public void InventoryIsNotChangedIfHaveNoEnoughResourcesTest() // При нулевом количестве ресурса он удаляется из инвентаря
        {
            var resource = new Wood() { Amount = 3 };
            var resourceToUse = new Wood() { Amount = 5 };
            Inventory.AddItem(new Resource[] { resource });
            Inventory.UseItem(resourceToUse);
            Assert.IsTrue(Inventory.AmountOf(new Wood()) == 3);
        }


    }
}
