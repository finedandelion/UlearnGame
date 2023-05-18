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
        private static int CoalCapicty = 15;
        private static double CoalExperience = 9;
        private Resource[] resourcesDrop => GenerateResources();
        public Coal(Game game)
        {
            Game = game;
            ResourceRandomCapFirst = 3;
            StartCapacity = CoalCapicty * Game.CapacityHardnessMultiplier;
            Capacity = StartCapacity;
            ImagePath = Texture.Coal;
            ResourcesDrop = resourcesDrop;
        }

        public override Resource[] GenerateResources()
        {
            return new Resource[2]
            {
                new Rock() { Amount = resourcesRandom.Next(1, ResourceRandomCapFirst + 1) + Game.ResourceBonus },
                new CoalLump() { Amount = resourcesRandom.Next(1, ResourceRandomCapFirst + 1) + Game.ResourceBonus }
            };
        }

        public override void ChangeState()
        {
            Capacity -= Game.ClickPower;
        }

        public override void GainExperience()
        {
            Game.AddExperience(CoalExperience * Game.ExperienceMultiplier);
        }
    }
}

