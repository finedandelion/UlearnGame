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
        private static double CoalExperience = 8;
        private Resource[] resourcesDrop => GenerateResources();
        public Coal(Game game)
        {
            Game = game;
            StartCapacity = CoalCapicty * Game.CapacityHardnessMultiplier;
            Capacity = StartCapacity;
            Image = Texture.Coal;
            Image2 = Texture.Coal2;
            ResourcesDrop = resourcesDrop;
        }

        public override Resource[] GenerateResources()
        {
            return new Resource[]
            {
                new Rock() { Amount = resourcesRandom.Next(1, 3) },
                new CoalLump() { Amount = resourcesRandom.Next(1, 4) + Game.ResourceBonus }
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

