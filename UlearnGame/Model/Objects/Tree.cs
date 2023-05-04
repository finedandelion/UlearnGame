using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;
using UlearnGame.Visual;

namespace UlearnGame.Model.Objects
{
    public class Tree : GameObject, IObject
    {
        private static int TreeCapicty = 10;
        private static double TreeExperience = 700;

        private Resource[] resourcesDrop => GenerateResources();
        public Tree(Game game)
        {
            Game = game;
            ResourceRandomCapFirst = 2;
            ResourceRandomCapSecond = 4;
            StartCapacity = TreeCapicty * CapacityHardnessMultiplier;
            Capacity = StartCapacity;
            ImagePath = Texture.Tree;
            ResourcesDrop = resourcesDrop;
        }

        public override Resource[] GenerateResources()
        {
            return new Resource[2]
            {
                new Wood() { Amount = resourcesRandom.Next(Game.ResourceLowCap + 1, ResourceRandomCapFirst + 1) },
                new Leaf() { Amount = resourcesRandom.Next(Game.ResourceLowCap + 2, ResourceRandomCapSecond + 1)}
            };
        }

        public override void ChangeState()
        {
            Capacity -= Game.ClickPower;
        }

        public override void GainExperience()
        {
            Game.AddExperience(TreeExperience * ExperienceMultiplier);
        }
    }
}
