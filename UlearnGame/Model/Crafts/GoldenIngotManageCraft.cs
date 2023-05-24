using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;

namespace UlearnGame.Model.Crafts
{
    public class GoldenIngotManageCraft : Craft
    {
        public GoldenIngotManageCraft(Game game) : base(game)
        {
            Description = "";
        }

        protected override Resource ReturnCraftResult()
        {
            return new GoldenIngot() { Amount = 1 };
        }

        protected override Resource[] ReturnCraftResources()
        {
            return new Resource[]
            {
                new IronIngot() { Amount = 3 },
                new Rock() { Amount = 2 },
                new Powder() { Amount = 1 }
            };
        }
    }
}
