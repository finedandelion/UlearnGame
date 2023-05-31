using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;
using UlearnGame.Visual;

namespace UlearnGame.Model.Objects
{
    public class Remains : GameObject
    {
        private static int RemainsCapicty = 22;
        private static double RemainsExperience = 8;
        private Resource[] resourcesDrop => GenerateResources();
        public Remains(Game game)
        {
            Game = game;
            StartCapacity = RemainsCapicty * Game.CapacityHardnessMultiplier;
            Capacity = StartCapacity;
            Image = Texture.Remains;
            Image2 = Texture.Remains2;
            ResourcesDrop = resourcesDrop;
        }

        public override Resource[] GenerateResources()
        {
            return new Resource[]
            {
                new Bone() { Amount = resourcesRandom.Next(4, 12) + Game.ResourceBonus},
                new Essence() { Amount = Game.EssenceDrop }
            };
        }

        public override void ChangeState()
        {
            Capacity -= Game.ClickPower;
        }

        public override void GainExperience()
        {
            Game.AddExperience(RemainsExperience * Game.ExperienceMultiplier);
        }
    }
}
