using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;

namespace UlearnGame.Model.Crafts
{
    public class FiberManageCraft : Craft
    {
        public FiberManageCraft(Game game) : base(game)
        {
            Description = "Магические свойства пыли могут помочь с преобразованием древесины в волокна.";
        }

        protected override Resource ReturnCraftResult()
        {
            return new Fiber() { Amount = 2 };
        }

        protected override Resource[] ReturnCraftResources()
        {
            return new Resource[]
            {
                new Wood() { Amount = 3},
                new SharpenedRock() { Amount = 1 },
                new Powder() { Amount = 1 }
            };
        }
    }
}
