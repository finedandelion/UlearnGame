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
        private static double RemainsExperience = 10;
        private Resource[] resourcesDrop => GenerateResources();
        public Remains(Game game)
        {
            Game = game;
            ResourceRandomCapFirst = 0;
            ResourceRandomCapSecond = 11;
            StartCapacity = RemainsCapicty * Game.CapacityHardnessMultiplier;
            Capacity = StartCapacity;
            ImagePath = Texture.Remains;
            ResourcesDrop = resourcesDrop;
        }

        public override Resource[] GenerateResources()
        {
            return new Resource[]
            {
                new Bone() { Amount = resourcesRandom.Next(4, ResourceRandomCapSecond + 1) + Game.ResourceBonus},
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
