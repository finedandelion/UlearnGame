using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;

namespace UlearnGame.Model.Crafts
{
    public class PlankCraft : Craft
    {
        private static double PlankCraftTime = 5;
        public PlankCraft()
        {
            CraftTimes = 0;
            CraftTime = PlankCraftTime * CraftTimeMultiplier;
            CraftResources = new Resource[1] { new Wood() { Amount = 1 } };
            CraftResult = new Plank() { Amount = 2 };
            LockFactor = 0;
            IsCraftableManyTime = true;
        }
    }
}
