 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Crafts;
using UlearnGame.Model.Objects;
using UlearnGame.Model.Resources;

namespace UlearnGame.Model
{
    public class CraftStation
    {
        private List<Craft> craftCollection;
        public List<Craft> Crafts => craftCollection;
        public int Count => craftCollection.Count;

        public CraftStation()
        {
            craftCollection = new List<Craft>()
            {
                new PlankCraft(),
            };
        }

        public void DoCraft(int craftNumber, Inventory inventory)
        {
            var craft = craftCollection[craftNumber];
            if (craft.IsCraftableManyTime && craft.IsPossibleToCraft(inventory))
            {
                foreach (var resourceCraft in craft.CraftResources)
                    inventory.UseItem(resourceCraft);
                inventory.AddItem(new Resource[1] { craft.CraftResult });
                craft.CraftTimes++;
            }
        }
    }
}
