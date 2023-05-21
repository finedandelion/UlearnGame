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
        private static double StarExperience = 20;
        private Resource[] resourcesDrop => GenerateResources();
        public Star(Game game)
        {
            Game = game;
            ResourceRandomCapFirst = 0;
            ResourceRandomCapSecond = 0;
            StartCapacity = StarCapicty;
            Capacity = StartCapacity;
            ImagePath = Texture.Star;
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
