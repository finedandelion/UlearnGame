using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;

namespace UlearnGame.Model.Crafts
{
    public class HardenedRopeCraft : Craft
    {
        public HardenedRopeCraft(Game game) : base(game)
        {
            Description = "";
        }

        protected override Resource ReturnCraftResult()
        {
            return new HardenedRope() { Amount = 1 };
        }

        protected override Resource[] ReturnCraftResources()
        {
            return new Resource[]
            {
                new Rope() { Amount = 2 },
                new SlimeDrop() { Amount = 2 - ReduceCraft },
                new CoalLump() { Amount = 1}
            };
        }
    }
}
