using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Blessings;
using UlearnGame.Model.Crafts;
using UlearnGame.Model.Resources;
using UlearnGame.Model.Upgrades;

namespace UlearnGame.Model
{
    public class AscendingSystem
    {
        private int AscendLevel;
        private Blessing[] Blessings;
        private Resource[][] Offerings;
        public Blessing CurrentBlessing => Blessings[AscendLevel];
        public Resource[] CurrentResources => Offerings[AscendLevel];
        public bool IsGameCompleted { get; private set; }
        public int AscendLevelCap => Blessings.Length;
        private Game Game { get; set; }
        public AscendingSystem(Game game)
        {
            Game = game;
            Offerings = InitializeOfferings();
            Blessings = InitializeBlessings();
        }

        public void Ascend()
        {
            if (IsAscendable())
            {
                foreach (var resource in CurrentResources)
                    Game.Inventory.UseItem(resource);
                if (AscendLevel == AscendLevelCap - 1)
                    IsGameCompleted = true;
                else
                {
                    AscendLevel++;
                    Game.UpdateTotalAscendingTimes();
                }
            }
        }

        public bool IsAscendable()
        {
            var storage = Game.Inventory.ReturnStorage();
            return !IsGameCompleted && Offerings[AscendLevel].All(resource => storage.ContainsKey(resource.GetType())
                    && storage[resource.GetType()].Amount >= resource.Amount);
        }

        private Resource[][] InitializeOfferings()
        {
            var oferrings = new Resource[][]
            {
                new Resource[]
                {
                    new Wood() { Amount = 5 },
                },
                new Resource[]
                {
                    new DullTotem() { Amount = 3 },
                },
                new Resource[]
                {
                    new DullTotem() { Amount = 5 },
                    new Salad() { Amount = 3 }
                },
                new Resource[]
                {
                    new DullTotem() { Amount = 5 },
                    new Salad() { Amount = 3 }
                },
            };
            return oferrings;
        }

        private Blessing[] InitializeBlessings()
        {
            var ascendings = new Blessing[]
            {
                new FirstChoiceBlessing(Game),
                new SecondChoiceBlessing(Game),
                new ThirdChoiceBlessing(Game),
            };
            return ascendings;
        }
    }
}
