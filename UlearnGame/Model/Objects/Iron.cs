using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;
using UlearnGame.Visual;

namespace UlearnGame.Model.Objects
{
    public class Iron : GameObject
    {
        private static int IronCapicty = 14;
        private static double IronExperience = 9;

        private Resource[] resourcesDrop => GenerateResources();
        public Iron(Game game)
        {
            Game = game;
            ResourceRandomCapFirst = 2;
            ResourceRandomCapSecond = 3;
            StartCapacity = IronCapicty * CapacityHardnessMultiplier;
            Capacity = StartCapacity;
            ImagePath = Texture.Iron;
            ResourcesDrop = resourcesDrop;
        }

        public override Resource[] GenerateResources()
        {
            return new Resource[2]
            {
                new Rock() { Amount = Game.ResourceLowCap + 2 },
                new IronIngot() { Amount = resourcesRandom.Next(Game.ResourceLowCap + 1, ResourceRandomCapFirst + 1) }
            };
        }

        public override void ChangeState()
        {
            Capacity -= Game.ClickPower;
        }

        public override void GainExperience()
        {
            Game.AddExperience(IronExperience * ExperienceMultiplier);
        }
    }
}
