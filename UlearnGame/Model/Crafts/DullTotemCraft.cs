using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;

namespace UlearnGame.Model.Crafts
{
    public class DullTotemCraft : Craft
    {
        public DullTotemCraft()
        {
            CraftTimes = 0;
            IsCraftableManyTime = true;
            Description = "Вырезанная фигрука тотема, которую только предстоит наполнить жизненной энергии." +
                " Издревле тотемы применялись для обращения к божествам.";
        }

        protected override Resource ReturnCraftResult()
        {
            return new DullTotem() { Amount = 1 };
        }

        protected override Resource[] ReturnCraftResources()
        {
            return new Resource[2]
            {
                new Wood() { Amount = 3 },
                new SharpenedRock() { Amount = 2 }
            };
        }
    }
}
