using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;
using UlearnGame.Visual;

namespace UlearnGame.Model.Objects
{
    public class Stone : GameObject
    {
        private static int StoneCapicty = 12;
        private static double StoneExperience = 8;
        private Resource[] resourcesDrop => GenerateResources();
        public Stone(Game game)
        {
            Game = game;
            ResourceRandomCapFirst = 2;
            StartCapacity = StoneCapicty * CapacityHardnessMultiplier;
            Capacity = StartCapacity;
            ImagePath = Texture.Stone;
            ResourcesDrop = resourcesDrop;
        }

        public override Resource[] GenerateResources()
        {
            return new Resource[1]
            {
                new Rock() { Amount = resourcesRandom.Next(Game.ResourceLowCap + 1, ResourceRandomCapFirst + 1) }
            };
        }

        public override void ChangeState()
        {
            Capacity -= Game.ClickPower;
        }

        public override void GainExperience()
        {
            Game.AddExperience(StoneExperience * ExperienceMultiplier);
        }
    }
}
