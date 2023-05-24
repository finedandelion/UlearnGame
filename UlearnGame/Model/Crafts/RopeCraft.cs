using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;

namespace UlearnGame.Model.Crafts
{
    public class RopeCraft : Craft
    {
        public RopeCraft(Game game) : base(game)
        {
            Description = "Обычно верёвку плетут из более крепких органических волокон, но местная флора не располагает подходящими растениям. " +
                "Довольствуемся тем, что есть.";
        }

        protected override Resource ReturnCraftResult()
        {
            return new Rope() { Amount = 2 };
        }

        protected override Resource[] ReturnCraftResources()
        {
            if (ReduceCraft == 0)
            {
                return new Resource[]
                {
                    new Fiber() { Amount = 14 },
                    new SharpenedRock() { Amount = 1 }
                };
            }
            else
            {
                return new Resource[]
                {
                    new Fiber() { Amount = 14 },
                };
            }
        }
    }
}
