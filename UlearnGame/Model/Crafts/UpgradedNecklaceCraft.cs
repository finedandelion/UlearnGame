using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;

namespace UlearnGame.Model.Crafts
{
    public class UpgradedNecklaceCraft : Craft
    {
        public UpgradedNecklaceCraft(Game game) : base(game)
        {
            Description = "";
        }

        protected override Resource ReturnCraftResult()
        {
            return new UpgradeNecklace() { Amount = 1 };
        }

        protected override Resource[] ReturnCraftResources()
        {
            return new Resource[]
            {
                new HardenedRope() { Amount = 1 },
                new Bone() { Amount = 10 - ReduceCraft * 2 }
            };
        }
    }
}
