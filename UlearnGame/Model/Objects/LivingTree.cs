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
        private static double LivingTreeExperience = 8;
        private Resource[] resourcesDrop => GenerateResources();
        public LivingTree(Game game)
        {
            Game = game;
            StartCapacity = LivingTreeCapicty * Game.CapacityHardnessMultiplier;
            Capacity = StartCapacity;
            Image = Texture.LivingTree;
            Image2 = Texture.LivingTree2;
            ResourcesDrop = resourcesDrop;
        }

        public override Resource[] GenerateResources()
        {
            return new Resource[]
            {
                new Wood() { Amount = 5 + Game.ResourceBonus},
                new Essence() { Amount = 2 },
                new Fiber() { Amount = resourcesRandom.Next(3, 5) + Game.ResourceBonus},
                new Leaf() { Amount = 4 + Game.ResourceBonus},
                new Berries() { Amount = resourcesRandom.Next(3, 6) + Game.ResourceBonus}
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
