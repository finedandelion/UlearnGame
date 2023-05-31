using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;

namespace UlearnGame.Model.Crafts
{
    public class SandManageCraft : Craft
    {
        public SandManageCraft(Game game) : base(game)
        {
            Description = "Магические свойства пыли могут помочь с преобразованием камня в песок.";
        }

        protected override Resource ReturnCraftResult()
        {
            return new Sand() { Amount = 5 };
        }

        protected override Resource[] ReturnCraftResources()
        {
            return new Resource[]
            {
                new Rock() { Amount = 5 },
                new Instrument() { Amount = 1 },
                new Bowl() { Amount = 1 }
            };
        }
    }
}
