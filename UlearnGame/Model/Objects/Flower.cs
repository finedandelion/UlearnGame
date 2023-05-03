using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;

namespace UlearnGame.Model.Objects
{
    public class Flower : GameObject
    {
        private static int FlowerCapicty = 4;
        private static double FlowerExperience = 2;
        private static Random textureRandom = new Random();
        private Resource[] resourcesDrop => GenerateResources();
        public Flower(Game game)
        {
            Game = game;
            ResourceRandomCapFirst = 2;
            ResourceRandomCapSecond = 6;
            StartCapacity = FlowerCapicty * CapacityHardnessMultiplier;
            Capacity = StartCapacity;
            ImagePath = ChooseTexture(textureRandom.Next(1, 6));
            ResourcesDrop = resourcesDrop;
        }

        public override Resource[] GenerateResources()
        {
            return new Resource[2]
            {
                new Fiber() { Amount = resourcesRandom.Next(Game.ResourceLowCap + 0, ResourceRandomCapFirst + 1) },
                new Petals() { Amount = resourcesRandom.Next(Game.ResourceLowCap + 2, ResourceRandomCapSecond+ 1) }
            };
        }

        public override void ChangeState()
        {
            Capacity -= Game.ClickPower;
        }

        public override void GainExperience()
        {
            Game.AddExperience(FlowerExperience * ExperienceMultiplier);
        }

        private Image ChooseTexture(int textureVariant)
        {
            return ProgramInitials.GetImage($"Flower{textureVariant}.png");
        }
    }
}
