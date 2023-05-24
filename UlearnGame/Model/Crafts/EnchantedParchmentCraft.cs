using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;

namespace UlearnGame.Model.Crafts
{
    public class EnchantedParchmentCraft : Craft
    {
        public EnchantedParchmentCraft(Game game) : base(game)
        {
            Description = "";
        }

        protected override Resource ReturnCraftResult()
        {
            return new EnchantedParchment() { Amount = 1 };
        }

        protected override Resource[] ReturnCraftResources()
        {
            return new Resource[]
            {
                new Parchment() { Amount = 2 },
                new FilledCrystal() { Amount = 1 },
            };
        }
    }
}
