using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;

namespace UlearnGame.Model.Crafts
{
    public class ChaliceCraft : Craft
    {
        public ChaliceCraft(Game game) : base(game)
        {
            Description = "В отличие от других посудин этот кубок сделан из золота, делающего его лучшим выбором среди других ёмкостей для подношений.";
        }

        protected override Resource ReturnCraftResult()
        {
            return new Chalice() { Amount = 1 };
        }

        protected override Resource[] ReturnCraftResources()
        {
            return new Resource[]
            {
                new GoldenIngot() { Amount = 4 },
                new Instrument() { Amount = 1 },
            };
        }
    }
}
