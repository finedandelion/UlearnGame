using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;

namespace UlearnGame.Model.Crafts
{
    public class SharpenedRockCraft : Craft
    {
        public SharpenedRockCraft(Game game) : base(game)
        {
            Description = "Это можно было бы сделать проще, но почему бы не заострить камень путём долбления двух камней друг о друга? Прямо как в старые добрые!";
        }

        protected override Resource ReturnCraftResult()
        {
            return new SharpenedRock() { Amount = 1 };
        }

        protected override Resource[] ReturnCraftResources()
        {
            return new Resource[1] { new Rock() { Amount = 2 } };
        }
    }
}
