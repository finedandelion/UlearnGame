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
        private Resource resourcesDrop => GenerateResource();
        public Tree()
        {
            ResourceRandomCap = 2;
            StartCapacity = TreeCapicty * CapacityHardnessMultiplier;
            Capacity = StartCapacity;
            ImagePath = GameForm.GetImage("Tree.png");
            ResourcesDrop = resourcesDrop;
        }

        public override Resource GenerateResource()
        {
             return new Wood() { Amount = resourcesRandom.Next(1, ResourceRandomCap + 1) };
        }

        public override void ChangeState(int clickPower)
        {
            Capacity -= clickPower;
        }
    }
}
