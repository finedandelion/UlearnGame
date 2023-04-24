using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Resources;

namespace UlearnGame.Objects
{
    internal class Tree : GameObject, IObject
    {
        private static int TreeCapicty = 10;
        private Resource[] resourcesDrop => GenerateResources();
        public Tree()
        {
            ResourceRandomCapFirst = 2;
            StartCapacity = TreeCapicty * CapacityHardnessMultiplier;
            Capacity = StartCapacity;
            ImagePath = GameForm.GetImage("Tree.png");
            ResourcesDrop = resourcesDrop;
        }

        public override Resource[] GenerateResources()
        {
            return new Resource[1]
            {
                new Wood() { Amount = resourcesRandom.Next(1, ResourceRandomCapFirst + 1) }
            };
        }

        public override void ChangeState(int clickPower)
        {
            Capacity -= clickPower;
        }
    }
}
