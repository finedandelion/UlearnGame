using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;

namespace UlearnGame.Model.Crafts
{
    public class WreathCraft : Craft
    {
        public WreathCraft(Game game) : base(game)
        {
            Description = "Говорят, что, если надеть венок на голову в трудных ситуациях, это поможет помочь сохранить рассудок и спокойствие." +
                " Нет, у духов нет головы, так что крепись.";
        }

        protected override Resource ReturnCraftResult()
        {
            return new Wreath() { Amount = 1 };
        }

        protected override Resource[] ReturnCraftResources()
        {
            return new Resource[]
            {
                new Petals() { Amount = 15 - ReduceCraft * 3 },
                new Fiber() { Amount = 8 }
            };
        }
    }
}
