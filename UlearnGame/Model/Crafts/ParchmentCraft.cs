using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;

namespace UlearnGame.Model.Crafts
{
    public class ParchmentCraft : Craft
    {
        public ParchmentCraft(Game game) : base(game)
        {
            Description = "Из кожи получился бы неплохой пергамент. С помощью него можно передать Божеству любое послание, написать летопись или ещё чего.";
        }

        protected override Resource ReturnCraftResult()
        {
            return new Parchment() { Amount = 1 };
        }

        protected override Resource[] ReturnCraftResources()
        {
            return new Resource[]
            {
                new Leather() { Amount = 5 - ReduceCraft },
                new SharpenedRock() { Amount = 1 },
                new CoalLump() { Amount = 4 }
            };
        }
    }
}
