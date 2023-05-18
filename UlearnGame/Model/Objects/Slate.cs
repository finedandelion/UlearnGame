using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;
using UlearnGame.Visual;

namespace UlearnGame.Model.Objects
{
    public class Slate : GameObject
    {
        private static int SlateCapicty = 30;
        private static double SlateExperience = 10;
        private Resource[] resourcesDrop => GenerateResources();
        public Slate(Game game)
        {
            Game = game;
            ResourceRandomCapFirst = 3;
            ResourceRandomCapSecond = 5;
            StartCapacity = SlateCapicty * Game.CapacityHardnessMultiplier;
            Capacity = StartCapacity;
            ImagePath = Texture.Slate;
            ResourcesDrop = resourcesDrop;
        }

        public override Resource[] GenerateResources()
        {
            return new Resource[]
            {
                new Rock() { Amount = resourcesRandom.Next(1, ResourceRandomCapSecond + 1) + Game.ResourceBonus},
                new CoalLump() { Amount = 3 + Game.ResourceBonus},
                new GoldenIngot() { Amount = resourcesRandom.Next(1, ResourceRandomCapFirst + 1) + Game.ResourceBonus},
                new IronIngot() { Amount = resourcesRandom.Next(1, ResourceRandomCapFirst + 1) + Game.ResourceBonus},
                new CrystalShard() { Amount = resourcesRandom.Next(1, ResourceRandomCapFirst + 1 + Game.ResourceBonus)}
            };
        }

        public override void ChangeState()
        {
            Capacity -= Game.ClickPower;
        }

        public override void GainExperience()
        {
            Game.AddExperience(SlateExperience * Game.ExperienceMultiplier);
        }
    }
}
