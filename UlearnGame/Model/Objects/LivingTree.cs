using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;
using UlearnGame.Visual;

namespace UlearnGame.Model.Objects
{
    public class LivingTree : GameObject
    {
        private static int LivingTreeCapicty = 20;
        private static double LivingTreeExperience = 10;
        private Resource[] resourcesDrop => GenerateResources();
        public LivingTree(Game game)
        {
            Game = game;
            ResourceRandomCapFirst = 4;
            ResourceRandomCapSecond = 5;
            StartCapacity = LivingTreeCapicty * Game.CapacityHardnessMultiplier;
            Capacity = StartCapacity;
            ImagePath = Texture.LivingTree;
            ResourcesDrop = resourcesDrop;
        }

        public override Resource[] GenerateResources()
        {
            return new Resource[]
            {
                new Wood() { Amount = 5 + Game.ResourceBonus},
                new Essence() { Amount = 2 },
                new Fiber() { Amount = resourcesRandom.Next(3, ResourceRandomCapFirst + 1) + Game.ResourceBonus},
                new Leaf() { Amount = 4 + Game.ResourceBonus},
                new Berries() { Amount = resourcesRandom.Next(3, ResourceRandomCapSecond + 1 + Game.ResourceBonus)}
            };
        }

        public override void ChangeState()
        {
            Capacity -= Game.ClickPower;
        }

        public override void GainExperience()
        {
            Game.AddExperience(LivingTreeExperience * Game.ExperienceMultiplier);
        }
    }
}
