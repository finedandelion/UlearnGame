﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Objects;
using UlearnGame.Crafts;

namespace UlearnGame
{
    internal class CraftStation
    {
        private Dictionary<int, Craft> CraftCollection;

        CraftStation() 
        {
            CraftCollection = new Dictionary<int, Craft>()
            {
                {0, new PlankCraft() }
            };
        }

        public void DoCraft(int craftNumber, Inventory inventory)
        {
            var craft = CraftCollection[craftNumber];
            if (craft.IsCraftableManyTime && craft.IsPossibleToCraft(inventory))
            {
                foreach (var resourceCraft in craft.CraftResources)
                    inventory.UseItem(resourceCraft);
                inventory.AddItem(craft.CraftResult);
                craft.CraftTimes++;
            }         
        }

        public bool IsAccessibleCraft(int gameCraftLock, int craftNumber)
        {
            return gameCraftLock >= CraftCollection[craftNumber].LockFactor;
        }
    }
}