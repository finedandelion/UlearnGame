using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;
using UlearnGame.Visual;

namespace UlearnGame.Model.Objects
{
    public class Slime : GameObject
    {
        private static int SlimeCapicty = 20;
        private static double SlimeExperience = 7;

        private Resource[] resourcesDrop => GenerateResources();
        public Slime(Game game)
        {
            Game = game;
            StartCapacity = SlimeCapicty + Game.MonsterAdditionalCapacity;
            Capacity = StartCapacity;
            Image = Texture.Slime;
            Image2 = Texture.Slime2;
            ResourcesDrop = resourcesDrop;
        }

        public override Resource[] GenerateResources()
        {
            return new Resource[]
            {
                new SlimeDrop()
                { 
                    Amount = resourcesRandom.Next(2, 5)
                    + Game.ResourceBonus
                    + Game.MonsterAdditionalResource
                }
            };
        }

        public override void ChangeState()
        {
            Capacity -= Game.ClickPower;
        }

        public override void GainExperience()
        {
            Game.AddExperience(SlimeExperience * Game.ExperienceMultiplier);
        }
    }
}
