using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;

namespace UlearnGame.Model.Crafts
{
    public class WineCraft : Craft
    {
        public WineCraft(Game game) : base(game)
        {
            Description = "Только вино, выдержанное годами, удостоено того, чтобы быть приподнесёно Божеству. К счастью магическая пыль способна" +
                " воздействовать даже на время.";
        }

        protected override Resource ReturnCraftResult()
        {
            return new Wine() { Amount = 1 };
        }

        protected override Resource[] ReturnCraftResources()
        {
            return new Resource[]
            {
                new Chalice() { Amount = 1 },
                new Berries() { Amount = 15 },
                new Powder() { Amount = 1 }
            };
        }
    }
}
