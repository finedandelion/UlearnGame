using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;

namespace UlearnGame.Model.Crafts
{
    public class DishCraft : Craft
    {
        public DishCraft(Game game) : base(game)
        {
            Description = "Блюдо из плоти живых существ. Мясо до сих пор кровоточит — будет чем порадовать Божество.";
        }

        protected override Resource ReturnCraftResult()
        {
            return new Dish() { Amount = 1 };
        }

        protected override Resource[] ReturnCraftResources()
        {
            return new Resource[]
            {
                new Bowl() { Amount = 1},
                new Meat() { Amount = 4 - ReduceCraft},
                new Bone() { Amount = 1}
            };
        }
    }
}
