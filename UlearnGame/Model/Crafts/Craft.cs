using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;

namespace UlearnGame.Model.Crafts
{
    public class Craft
    {
        protected static double CraftTimeMultiplier = 1;
        public double CraftTimes { get; set; }
        public Resource[] CraftResources
        {
            get
            {
                return ReturnCraftResources();
            }
            set { }
        }
        public Resource CraftResult
        {
            get
            {
                return ReturnCraftResult();
            }
            set { }
        }

        public Game Game { get; set; }

        protected int ReduceCraft => Game.FirstCraftSimplifier;

        public string Description { get; set; }
        public bool IsCraftableManyTime { get; set; }

        public Craft(Game game)
        {
            Game = game;
        }

        public bool IsPossibleToCraft(Inventory inventory)
        {
            var storage = inventory.ReturnStorage();
            return CraftResources.All(resource => storage.ContainsKey(resource.GetType())
                    && storage[resource.GetType()].Amount >= resource.Amount);
        }

        public virtual bool IsCraftableManyTimes()
        {
            throw new NotImplementedException();
        }

        protected virtual Resource[] ReturnCraftResources()
        {
            throw new NotImplementedException();
        }

        protected virtual Resource ReturnCraftResult()
        {
            throw new NotImplementedException();
        }
    }
}
