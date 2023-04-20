using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Resources;

namespace UlearnGame.Crafts
{
    internal class Craft
    {
        protected static double CraftTimeMultiplier = 1; 
        public double CraftTimes { get; set; }
        public Resource[] CraftResources { get; set; }
        public Resource CraftResult { get; set; }
        public int LockFactor { get; set; }
        public double CraftTime { get; set; }
        public bool IsCraftableManyTime { get; set; }

        public bool IsPossibleToCraft(Inventory inventory)
        {
            var storage = inventory.ReturnStorage();
            return CraftResources.All(resource => storage.ContainsKey(resource.GetType())
                    && storage[resource.GetType()].Amount >= resource.Amount);
        }
    }
}
