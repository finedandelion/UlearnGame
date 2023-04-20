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
            Capacity = TreeCapicty * CapacityHardnessMultiplier;
            ImagePath = Image.FromFile("D:\\GitHub Repository\\UlearnGame\\UlearnGame\\Images\\Tree.png");
            ResourcesDrop = resourcesDrop;
        }

        public override Resource GenerateResource()
        {
             return new Wood() { Amount = resourcesRandom.Next(0, ResourceRandomCap) };
        }

        public override void ChangeState(int clickPower)
        {
            Capacity -= clickPower;
        }
    }
}
