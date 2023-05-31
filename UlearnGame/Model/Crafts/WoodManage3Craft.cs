using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;

namespace UlearnGame.Model.Crafts
{
    public class WoodManage3Craft : Craft
    {
        public WoodManage3Craft(Game game) : base(game)
        {
            Description = "Магические свойства пыли могут помочь с преобразованием камней в древесину.";
        }

        protected override Resource ReturnCraftResult()
        {
            return new Wood() { Amount = 1 };
        }

        protected override Resource[] ReturnCraftResources()
        {
            return new Resource[]
            {
                new Rock() { Amount = 3 },
                new Powder() { Amount = 1 }
            };
        }
    }
}
