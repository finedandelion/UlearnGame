using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;

namespace UlearnGame.Model.Crafts
{
    public class NecklaceCraft : Craft
    {
        public NecklaceCraft(Game game) : base(game)
        {
            CraftTimes = 0;
            IsCraftableManyTime = true;
            Description = "";
        }

        protected override Resource ReturnCraftResult()
        {
            return new Necklace() { Amount = 1 };
        }

        protected override Resource[] ReturnCraftResources()
        {
            return new Resource[]
            { 
                new Rope() { Amount = 1 },
                new Rock() { Amount = 5 - ReduceCraft * 2 },
            };
        }
    }
}
