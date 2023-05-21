using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;

namespace UlearnGame.Model.Crafts
{
    public class FilledTotemCraft : Craft
    {
        public FilledTotemCraft(Game game) : base(game)
        {
            CraftTimes = 0;
            IsCraftableManyTime = true;
            Description = "";
        }

        protected override Resource ReturnCraftResult()
        {
            return new FilledTotem() { Amount = 1 };
        }

        protected override Resource[] ReturnCraftResources()
        {
            return new Resource[]
            {
                new DullTotem() { Amount = 1 },
                new Essence() { Amount = 5 - ReduceCraft * 2 }
            };
        }
    }
}
