using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;

namespace UlearnGame.Model.Crafts
{
    public class CoalLumpManageCraft : Craft
    {
        public CoalLumpManageCraft(Game game) : base(game)
        {
            Description = "Когда не хватает угля, достаточно лишь поджечь древесину.";
        }

        protected override Resource ReturnCraftResult()
        {
            return new CoalLump() { Amount = 2 };
        }

        protected override Resource[] ReturnCraftResources()
        {
            return new Resource[]
            {
                new Wood() { Amount = 3 },
                new CoalLump() { Amount = 1 }
            };
        }
    }
}
