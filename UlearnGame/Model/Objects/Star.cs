using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;
using UlearnGame.Visual;

namespace UlearnGame.Model.Objects
{
    public class Star : GameObject
    {
        private static int StarCapicty = 1;
        private static double StarExperience = 15;
        private Resource[] resourcesDrop => GenerateResources();
        public Star(Game game)
        {
            Game = game;
            StartCapacity = StarCapicty;
            Capacity = StartCapacity;
            ImagePath = Texture.Star;
            ImagePath2 = Texture.Star2;
            ResourcesDrop = resourcesDrop;
        }

        public override Resource[] GenerateResources()
        {
            return new Resource[0];
        }

        public override void ChangeState()
        {
            Capacity -= Game.ClickPower;
        }

        public override void GainExperience()
        {
            Game.AddExperience(StarExperience * Game.ExperienceMultiplier);
        }
    }
}
