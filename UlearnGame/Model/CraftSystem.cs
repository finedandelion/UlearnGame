 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Crafts;
using UlearnGame.Model.Objects;
using UlearnGame.Model.Resources;

namespace UlearnGame.Model
{
    public class CraftSystem
    {
        private List<Craft> craftCollection;
        public List<Craft> Crafts => craftCollection;
        public int Count => craftCollection.Count;

        private Game Game { get; set; }

        public CraftSystem(Game game)
        {
            Game = game;
            craftCollection = new List<Craft>()
            {
                new PlankCraft(game),
                new SharpenedRockCraft(game),
                new InstrumentCraft(game),
                new FilledCrystalCraft(game),
                new PowderCraft(game),
                new BowlCraft(game),
                new SaladCraft(game),
                new DishCraft(game),
                new DullTotemCraft(game),
                new FilledTotemCraft(game),
                new RopeCraft(game),
                new WreathCraft(game),
                new NecklaceCraft(game),
                new HardenedRopeCraft(game),
                new UpgradedNecklaceCraft(game),
                new ParchmentCraft(game),
                new EnchantedParchmentCraft(game),
                new ChaliceCraft(game),
                new WineCraft(game),
                new GoldenTotemCraft(game),
                new WoodManageCraft(game),
                new WoodManage2Craft(game),
                new WoodManage3Craft(game),
                new RockManageCraft(game),
                new SandManageCraft(game),
                new BerriesManageCraft(game),
                new GoldenIngotManageCraft(game),
                new IronIngotManageCraft(game),
                new LeatherManageCraft(game),
                new MeatManageCraft(game),
                new SaladManageCraft(game),
                new DishManageCraft(game),
            };
        }

        public void DoCraft(int craftNumber)
        {
            var inventory = Game.Inventory;
            var craft = craftCollection[craftNumber];
            if (craft.IsCraftableManyTime && craft.IsPossibleToCraft(inventory))
            {
                foreach (var resourceCraft in craft.CraftResources)
                    inventory.UseItem(resourceCraft);
                inventory.AddItem(new Resource[1] { craft.CraftResult });
                craft.CraftTimes++;
                Game.UpdateTotalCrafts();
                Game.UpdateTotalResourcesCraft(craft.CraftResult.Amount);
            }
        }
    }
}
