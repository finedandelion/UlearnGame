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
        private static double DeerExperience = 9;
        private Resource[] resourcesDrop => GenerateResources();
        public Deer(Game game)
        {
            Game = game;
            StartCapacity = DeerCapicty + Game.MonsterAdditionalCapacity;
            Capacity = StartCapacity;
            Image = Texture.Deer;
            Image2 = Texture.Deer2;
            ResourcesDrop = resourcesDrop;
        }

        public override Resource[] GenerateResources()
        {
            return new Resource[]
            {
                new Bone() { Amount = resourcesRandom.Next(0, 4) + Game.ResourceBonus + Game.MonsterAdditionalResource},
                new Meat() { Amount = resourcesRandom.Next(2, 6) + Game.ResourceBonus + Game.MonsterAdditionalResource},
                new Leather() { Amount = resourcesRandom.Next(1, 4) + Game.ResourceBonus + Game.MonsterAdditionalResource},
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
