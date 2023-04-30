using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;

namespace UlearnGame.Model.Objects
{
    public class Bush : GameObject
    {
        private static int BushCapicty = 6;
        private static double BushExperience = 6;
        private Resource[] resourcesDrop => GenerateResources();
        public Bush()
        {
            ResourceRandomCapFirst = 6;
            ResourceRandomCapSecond = 5;
            StartCapacity = BushCapicty * CapacityHardnessMultiplier;
            Capacity = StartCapacity;
            ImagePath = ProgramInitials.GetImage("Bush.png");
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

        public override double GainExperience()
        {
            return BushExperience;
        }
    }
}
