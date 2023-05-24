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
            StartCapacity = StoneCapicty * Game.CapacityHardnessMultiplier;
            Capacity = StartCapacity;
            ImagePath = Texture.Stone;
            ImagePath2 = Texture.Stone2;
            ResourcesDrop = resourcesDrop;
        }

        public override Resource[] GenerateResources()
        {
            return new Resource[]
            {
                new Rock() { Amount = resourcesRandom.Next(1, 3) + Game.ResourceBonus }
            };
        }

        public override void ChangeState()
        {
            Capacity -= Game.ClickPower;
        }

        public override void GainExperience()
        {
            Game.AddExperience(StoneExperience * Game.ExperienceMultiplier);
        }
    }
}
