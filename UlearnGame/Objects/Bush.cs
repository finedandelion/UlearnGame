using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Resources;

namespace UlearnGame.Objects
{
    internal class Bush : GameObject
    {
        private static int BushCapicty = 6;
        private Resource[] resourcesDrop => GenerateResources();
        public Bush()
        {
            ResourceRandomCapFirst = 6;
            ResourceRandomCapSecond = 5;
            StartCapacity = BushCapicty * CapacityHardnessMultiplier;
            Capacity = StartCapacity;
            ImagePath = GameForm.GetImage("Bush.png");
            ResourcesDrop = resourcesDrop;
        }

        public override Resource[] GenerateResources()
        {
            return new Resource[2]
            {
                new Fiber() { Amount = resourcesRandom.Next(2, ResourceRandomCapFirst + 1) },
                new Berries() { Amount = resourcesRandom.Next(0, ResourceRandomCapFirst + 1) }
            };
        }

        public override void ChangeState(int clickPower)
        {
            Capacity -= clickPower;
        }
    }
}
