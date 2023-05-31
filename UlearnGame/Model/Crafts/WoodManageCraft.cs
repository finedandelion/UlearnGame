using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;

namespace UlearnGame.Model.Crafts
{
    public class WoodManageCraft : Craft
    {
        public WoodManageCraft(Game game) : base(game)
        {
            Description = "Магические свойства пыли могут помочь с преобразованием лепестков в древесину.";
        }

        protected override Resource ReturnCraftResult()
        {
            return new Wood() { Amount = 1 };
        }

        protected override Resource[] ReturnCraftResources()
        {
            return new Resource[]
            {
                new Petals() { Amount = 4 - ReduceCraft },
                new Powder() { Amount = 1 }
            };
        }
    }
}
