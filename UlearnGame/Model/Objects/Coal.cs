using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;
using UlearnGame.Visual;

namespace UlearnGame.Model.Objects
{
    public class Coal : GameObject
    {
        private static int CoalCapicty = 6;
        private static double CoalExperience = 4;
        private Resource[] resourcesDrop => GenerateResources();
        public Coal(Game game)
        {
            Game = game;
            ResourceRandomCapFirst = 3;
            StartCapacity = CoalCapicty * CapacityHardnessMultiplier;
            Capacity = StartCapacity;
            ImagePath = Texture.Coal;
            ResourcesDrop = resourcesDrop;
        }

        public override Resource[] GenerateResources()
        {
            return new Resource[2]
            {
                new Rock() { Amount = resourcesRandom.Next(Game.ResourceLowCap + 1, ResourceRandomCapFirst + 1) },
                new CoalLump() { Amount = resourcesRandom.Next(Game.ResourceLowCap + 1, ResourceRandomCapFirst + 1) }
            };
        }

        public override void ChangeState()
        {
            Capacity -= Game.ClickPower;
        }

        public override void GainExperience()
        {
            Game.AddExperience(CoalExperience * ExperienceMultiplier);
        }
    }
}

