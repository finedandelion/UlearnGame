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
                    new Wood() { Amount = 8 },
                },
                new Resource[]
                {
                    new DullTotem() { Amount = 5 },
                    new Berries() { Amount = 15 },
                    new Wreath() { Amount = 3}
                },
                new Resource[]
                {
                    new DullTotem() { Amount = 5 },
                    new Salad() { Amount = 5 },
                    new Necklace() { Amount = 3 }
                },
                new Resource[]
                {
                    new Dish() { Amount = 3 },
                    new Salad() { Amount = 3},
                    new DullTotem { Amount = 10 },
                    new Necklace() { Amount = 5 },
                },
                new Resource[]
                {
                    new Parchment() { Amount = 5 },
                    new UpgradedNecklace() { Amount = 5 },
                    new Wreath() { Amount = 5},
                    new FilledTotem() { Amount = 5 },
                },
                new Resource[]
                {
                    new Wine() { Amount = 10 },
                    new Dish() { Amount = 8 },
                    new Parchment() { Amount = 5 },
                    new FilledTotem() { Amount = 10}
                },
                new Resource[]
                {
                    new DullTotem() { Amount = 20},
                    new FilledTotem() { Amount = 5 },
                    new GoldenTotem() { Amount = 5 },
                    new Wreath() { Amount = 3},
                    new EnchantedParchment() { Amount = 3},
                    new UpgradedNecklace() { Amount = 5}
                },
                new Resource[]
                {
                    new GoldenTotem() { Amount = 15},
                    new EnchantedParchment(){ Amount = 8},
                    new UpgradedNecklace() { Amount = 5 },
                    new Wine() { Amount = 5 }
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
                new FourthChoiceBlessing(Game),
                new FifthChoiceBlessing(Game),
                new SixthChoiceBlessing(Game),
                new SeventhChoiceBlessing(Game),
                new EighthChoiceBlessing(Game),
            };
            return ascendings;
        }
    }
}
