using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;
using UlearnGame.Visual;

namespace UlearnGame.Model.Objects
{
    public class Bat : GameObject
    {
        private static int BatCapicty = 30;
        private static double BatExperience = 9;
        private Resource[] resourcesDrop => GenerateResources();
        public Bat(Game game)
        {
            Game = game;
            StartCapacity = BatCapicty + Game.MonsterAdditionalCapacity;
            Capacity = StartCapacity;
            Image = Texture.Bat;
            Image2 = Texture.Bat2;
            ResourcesDrop = resourcesDrop;
        }

        public override Resource[] GenerateResources()
        {
            return new Resource[]
            {
                new Leather() { Amount = resourcesRandom.Next(3, 6) + Game.ResourceBonus + Game.MonsterAdditionalResource},
                new Meat() { Amount = resourcesRandom.Next(1, 4) + Game.ResourceBonus + Game.MonsterAdditionalResource},
                new Essence { Amount = Game.EssenceDrop }
            };
        }

        public override void ChangeState()
        {
            Capacity -= Game.ClickPower;
        }

        public override void GainExperience()
        {
            Game.AddExperience(BatExperience * Game.ExperienceMultiplier);
        }
    }
}
