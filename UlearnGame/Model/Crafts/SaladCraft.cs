using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;

namespace UlearnGame.Model.Crafts
{
    public class SaladCraft : Craft
    {
        public SaladCraft()
        {
            CraftTimes = 0;
            IsCraftableManyTime = true;
            Description = "Немного ягод, немного листьев — сам бы ты такое не съел, но что не сделаешь ради любимого божества?";
        }

        protected override Resource ReturnCraftResult()
        {
            return new Salad() { Amount = 1 };
        }

        protected override Resource[] ReturnCraftResources()
        {
            return new Resource[3]
            {
                new Bowl() { Amount = 1 },
                new Berries() { Amount = 10 },
                new Leaf() { Amount = 5 }
            };
        }
    }
}
