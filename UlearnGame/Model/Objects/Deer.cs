using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;
using UlearnGame.Visual;

namespace UlearnGame.Model.Objects
{
    public class Deer : GameObject
    {
        private static int DeerCapicty = 24;
        private static double DeerExperience = 10;
        private Resource[] resourcesDrop => GenerateResources();
        public Deer(Game game)
        {
            Game = game;
            ResourceRandomCapFirst = 5;
            ResourceRandomCapSecond = 3;
            StartCapacity = DeerCapicty;
            Capacity = StartCapacity;
            ImagePath = Texture.Deer;
            ResourcesDrop = resourcesDrop;
        }

        public override Resource[] GenerateResources()
        {
            return new Resource[]
            {
                new Bone() { Amount = resourcesRandom.Next(0, ResourceRandomCapSecond + 1) + Game.ResourceBonus},
                new Meat() { Amount = resourcesRandom.Next(2, ResourceRandomCapFirst + 1) + Game.ResourceBonus},
                new Leather() { Amount = resourcesRandom.Next(1, ResourceRandomCapSecond + 1) + Game.ResourceBonus},
                new Essence() { Amount = Game.EssenceDrop }
            };
        }

        public override void ChangeState()
        {
            Capacity -= Game.ClickPower;
        }

        public override void GainExperience()
        {
            Game.AddExperience(DeerExperience * Game.ExperienceMultiplier);
        }
    }
}
