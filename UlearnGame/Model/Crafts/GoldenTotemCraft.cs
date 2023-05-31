using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;

namespace UlearnGame.Model.Crafts
{
    public class GoldenTotemCraft : Craft
    {
        public GoldenTotemCraft(Game game) : base(game)
        {
            Description = "Золотые тотемы пригодны для красоты, но не для волшебства, ведь они не имеют магических свойств.";
        }

        protected override Resource ReturnCraftResult()
        {
            return new GoldenTotem() { Amount = 1 };
        }

        protected override Resource[] ReturnCraftResources()
        {
            return new Resource[]
            {
                new GoldenIngot() { Amount = 6 - ReduceCraft },
                new CrystalShard() { Amount = 5 },
                new DullTotem() { Amount = 3 },
            };
        }
    }
}
