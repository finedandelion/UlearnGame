using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;

namespace UlearnGame.Model.Crafts
{
    public class InstrumentCraft : Craft
    {
        public InstrumentCraft(Game game) : base(game)
        {
            Description = "Незаменимая вещь в ремесле! Даже силы духов небезграничны, так что приходится как-то упрощать свою работу" +
                " — с помощью инструментов в том числе.";
        }

        protected override Resource ReturnCraftResult()
        {
            return new Instrument() { Amount = 1 };
        }

        protected override Resource[] ReturnCraftResources()
        {
            return new Resource[]
            {
                new IronIngot() { Amount = 4 },
                new CoalLump() { Amount = 2 },
                new SlimeDrop() { Amount = 1 },
            };
        }
    }
}
