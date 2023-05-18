using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;

namespace UlearnGame.Model.Crafts
{
    public class BowlCraft : Craft
    {
        public BowlCraft(Game game) : base(game)
        {
            CraftTimes = 0;
            IsCraftableManyTime = true;
            Description = "Не то чтобы божество обрадуется такой посудине, но похоже у нас нет другого выбора, да?";
        }

        protected override Resource ReturnCraftResult()
        {
            return new Bowl() { Amount = 1 };
        }

        protected override Resource[] ReturnCraftResources()
        {
            return new Resource[2]
            { 
                new Plank() { Amount = 4 },
                new SharpenedRock() { Amount = 1 }
            };
        }
    }
}
