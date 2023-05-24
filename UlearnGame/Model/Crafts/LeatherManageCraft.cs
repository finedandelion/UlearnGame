using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;

namespace UlearnGame.Model.Crafts
{
    public class LeatherManageCraft : Craft
    {
        public LeatherManageCraft(Game game) : base(game)
        {
            Description = "";
        }

        protected override Resource ReturnCraftResult()
        {
            return new Leather() { Amount = 1 };
        }

        protected override Resource[] ReturnCraftResources()
        {
            return new Resource[]
            {
                new Meat() { Amount = 1 },
                new Bone() { Amount = 3 },
                new Powder() { Amount = 1 }
            };
        }
    }
}
