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
            Description = "Тотемы оживляют при помощи магической энергии, делая их отличными оберегами от порчи и плохих обстоятельств." +
                " Иногда их применяют для проведения ритуалов.";
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
                new FilledCrystal() { Amount = 2 }
            };
        }
    }
}
