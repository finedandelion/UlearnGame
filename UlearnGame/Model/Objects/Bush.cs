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
            StartCapacity = BushCapicty * Game.CapacityHardnessMultiplier;
            Capacity = StartCapacity;
            Image = Texture.Bush;
            Image2 = Texture.Bush2;
            ResourcesDrop = resourcesDrop;
        }

        public override Resource[] GenerateResources()
        {
            return new Resource[]
            {
                new Fiber() { Amount = resourcesRandom.Next(2, 6) + Game.ResourceBonus },
                new Berries() { Amount = resourcesRandom.Next(0, 7) + Game.ResourceBonus },
                new Leaf() { Amount = resourcesRandom.Next(0, 3) + Game.ResourceBonus }
            };
        }

        public override void ChangeState()
        {
            Capacity -= Game.ClickPower;
        }

        public override void GainExperience()
        {
            Game.AddExperience(BushExperience * Game.ExperienceMultiplier);
        }
    }
}
