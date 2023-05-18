using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;
using UlearnGame.Visual;

namespace UlearnGame.Model.Objects
{
    public class Slime : GameObject
    {
        private static int SlimeCapicty = 20;
        private static double SlimeExperience = 10;

        private Resource[] resourcesDrop => GenerateResources();
        public Slime(Game game)
        {
            Game = game;
            ResourceRandomCapFirst = 4;
            StartCapacity = SlimeCapicty * Game.CapacityHardnessMultiplier;
            Capacity = StartCapacity;
            ImagePath = Texture.Slime;
            ResourcesDrop = resourcesDrop;
        }

        public override Resource[] GenerateResources()
        {
            return new Resource[1]
            {
                new SlimeDrop() { Amount = resourcesRandom.Next(2, ResourceRandomCapFirst + 1) + Game.ResourceBonus }
            };
        }

        public override void ChangeState()
        {
            Capacity -= Game.ClickPower;
        }

        public override void GainExperience()
        {
            Game.AddExperience(SlimeExperience * Game.ExperienceMultiplier);
        }
    }
}
