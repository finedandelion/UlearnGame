using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;
using UlearnGame.Visual;

namespace UlearnGame.Model.Objects
{
    public class Obelisk : GameObject
    {
        private static int ObeliskCapicty = 17;
        private static double ObeliskExperience = 7;
        private Resource[] resourcesDrop => GenerateResources();
        public Obelisk(Game game)
        {
            Game = game;
            StartCapacity = ObeliskCapicty * Game.CapacityHardnessMultiplier;
            Capacity = StartCapacity;
            Image = Texture.Obelisk;
            Image2 = Texture.Obelisk2;
            ResourcesDrop = resourcesDrop;
        }

        public override Resource[] GenerateResources()
        {
            return new Resource[]
            {
                new Wood() { Amount = resourcesRandom.Next(2, 4) + Game.ResourceBonus },
                new Essence { Amount = Game.EssenceDrop }
            };
        }

        public override void ChangeState()
        {
            Capacity -= Game.ClickPower;
        }

        public override void GainExperience()
        {
            Game.AddExperience(ObeliskExperience * Game.ExperienceMultiplier);
        }
    }
}
