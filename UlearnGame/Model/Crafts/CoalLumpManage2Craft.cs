using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;

namespace UlearnGame.Model.Crafts
{
    public class CoalLumpManage2Craft : Craft
    {
        public CoalLumpManage2Craft(Game game) : base(game)
        {
            Description = "Магические свойства пыли могут помочь с преобразованием камней в уголь.";
        }

        protected override Resource ReturnCraftResult()
        {
            return new CoalLump() { Amount = 1 };
        }

        protected override Resource[] ReturnCraftResources()
        {
            return new Resource[]
            {
                new Rock() { Amount = 4 - ReduceCraft },
                new Powder() { Amount = 1 }
            };
        }
    }
}
