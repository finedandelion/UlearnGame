using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;
using UlearnGame.Visual;

namespace UlearnGame.Model.Objects
{
    public class Bush : GameObject
    {
        private static int BushCapicty = 6;
        private static double BushExperience = 6;
        private Resource[] resourcesDrop => GenerateResources();
        public Bush(Game game)
        {
            Game = game;
            ResourceRandomCapFirst = 6;
            ResourceRandomCapSecond = 5;
            StartCapacity = BushCapicty * CapacityHardnessMultiplier;
            Capacity = StartCapacity;
            ImagePath = Texture.Bush;
            ResourcesDrop = resourcesDrop;
        }

        public override Resource[] GenerateResources()
        {
            return new Resource[2]
            {
                new Fiber() { Amount = resourcesRandom.Next(Game.ResourceLowCap + 2, ResourceRandomCapSecond + 1) },
                new Berries() { Amount = resourcesRandom.Next(Game.ResourceLowCap + 0, ResourceRandomCapFirst + 1) }
            };
        }

        public override void ChangeState()
        {
            Capacity -= Game.ClickPower;
        }

        public override void GainExperience()
        {
            Game.AddExperience(BushExperience * ExperienceMultiplier);
        }
    }
}
