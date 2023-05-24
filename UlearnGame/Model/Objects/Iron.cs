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
        private static double IronExperience = 8;

        private Resource[] resourcesDrop => GenerateResources();
        public Iron(Game game)
        {
            Game = game;
            StartCapacity = IronCapicty * Game.CapacityHardnessMultiplier;
            Capacity = StartCapacity;
            ImagePath = Texture.Iron;
            ImagePath2 = Texture.Iron2;
            ResourcesDrop = resourcesDrop;
        }

        public override Resource[] GenerateResources()
        {
            return new Resource[]
            {
                new Rock() { Amount = Game.ResourceBonus + 2 },
                new IronIngot() { Amount = resourcesRandom.Next(1, 3) + Game.ResourceBonus }
            };
        }

        public override void ChangeState()
        {
            Capacity -= Game.ClickPower;
        }

        public override void GainExperience()
        {
            Game.AddExperience(IronExperience * Game.ExperienceMultiplier);
        }
    }
}
