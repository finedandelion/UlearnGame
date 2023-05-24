using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;

namespace UlearnGame.Model.Crafts
{
    public class BerriesManageCraft : Craft
    {
        public BerriesManageCraft(Game game) : base(game)
        {
            Description = "";
        }

        protected override Resource ReturnCraftResult()
        {
            return new Berries() { Amount = 5 };
        }

        protected override Resource[] ReturnCraftResources()
        {
            return new Resource[]
            {
                new Leaf() { Amount = 7 - ReduceCraft * 2 },
                new Powder() { Amount = 1 }
            };
        }
    }
}
