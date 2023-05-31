using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;
using UlearnGame.Visual;

namespace UlearnGame.Model.Objects
{
    public class Gold : GameObject
    {
        private static int GoldCapicty = 15;
        private static double GoldExperience = 8;

        private Resource[] resourcesDrop => GenerateResources();
        public Gold(Game game)
        {
            Game = game;
            StartCapacity = GoldCapicty * Game.CapacityHardnessMultiplier;
            Capacity = StartCapacity;
            Image = Texture.Gold;
            Image2 = Texture.Gold2;
            ResourcesDrop = resourcesDrop;
        }

        public override Resource[] GenerateResources()
        {
            return new Resource[]
            {
                new Rock() { Amount = resourcesRandom.Next(1, 3)},
                new GoldenIngot() { Amount = resourcesRandom.Next(1, 3) + Game.ResourceBonus }
            };
        }

        public override void ChangeState()
        {
            Capacity -= Game.ClickPower;
        }

        public override void GainExperience()
        {
            Game.AddExperience(GoldExperience * Game.ExperienceMultiplier);
        }
    }
}
