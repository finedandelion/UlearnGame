using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;

namespace UlearnGame.Model.Crafts
{
    public class IronIngotManageCraft : Craft
    {
        public IronIngotManageCraft(Game game) : base(game)
        {
            Description = "";
        }

        protected override Resource ReturnCraftResult()
        {
            return new IronIngot() { Amount = 1 };
        }

        protected override Resource[] ReturnCraftResources()
        {
            return new Resource[]
            {
                new GoldenIngot() { Amount = 3 },
                new Rock() { Amount = 2 },
                new Powder() { Amount = 1 }
            };
        }
    }
}
