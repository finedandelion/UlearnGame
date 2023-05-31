using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;

namespace UlearnGame.Model.Crafts
{
    public class NecklaceCraft : Craft
    {
        public NecklaceCraft(Game game) : base(game)
        {
            Description = "Ожерелья всегда были эталоном красоты, однако если привязать к верёвке пару камней, это не сделает из неё ожерелья." +
                " Ладно, как знаешь.";
        }

        protected override Resource ReturnCraftResult()
        {
            return new Necklace() { Amount = 1 };
        }

        protected override Resource[] ReturnCraftResources()
        {
            return new Resource[]
            { 
                new Rope() { Amount = 1 },
                new Rock() { Amount = 5 - ReduceCraft * 2 },
            };
        }
    }
}
