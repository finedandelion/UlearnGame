using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;
using UlearnGame.Visual;

namespace UlearnGame.Model.Objects
{
    public class Crystal : GameObject
    {
        private static int CrystalCapicty = 26;
        private static double CrystalExperience = 11;
        private Resource[] resourcesDrop => GenerateResources();
        public Crystal(Game game)
        {
            Game = game;
            ResourceRandomCapFirst = 4;
            ResourceRandomCapSecond = 0;
            StartCapacity = CrystalCapicty * Game.CapacityHardnessMultiplier;
            Capacity = StartCapacity;
            ImagePath = Texture.Crystal;
            ResourcesDrop = resourcesDrop;
        }

        public override Resource[] GenerateResources()
        {
            return new Resource[]
            {
                new Rock() { Amount = 2 + Game.ResourceBonus},
                new CrystalShard() { Amount = resourcesRandom.Next(2, ResourceRandomCapFirst + 1) + Game.ResourceBonus}
            };
        }

        public override void ChangeState()
        {
            Capacity -= Game.ClickPower;
        }

        public override void GainExperience()
        {
            Game.AddExperience(CrystalExperience * Game.ExperienceMultiplier);
        }
    }
}
