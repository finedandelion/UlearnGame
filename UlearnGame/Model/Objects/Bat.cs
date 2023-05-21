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
        private static double BatExperience = 10;
        private Resource[] resourcesDrop => GenerateResources();
        public Bat(Game game)
        {
            Game = game;
            ResourceRandomCapFirst = 3;
            ResourceRandomCapSecond = 5;
            StartCapacity = BatCapicty;
            Capacity = StartCapacity;
            ImagePath = Texture.Bat;
            ResourcesDrop = resourcesDrop;
        }

        public override Resource[] GenerateResources()
        {
            return new Resource[]
            {
                new Leather() { Amount = resourcesRandom.Next(3, ResourceRandomCapSecond + 1) + Game.ResourceBonus},
                new Meat() { Amount = resourcesRandom.Next(1, ResourceRandomCapFirst + 1) + Game.ResourceBonus},
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
