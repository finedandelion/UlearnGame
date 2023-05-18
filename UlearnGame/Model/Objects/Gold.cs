﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;
using UlearnGame.Visual;

namespace UlearnGame.Model.Objects
{
    public class Gold : GameObject
    {
        private static int GoldCapicty = 15;
        private static double GoldExperience = 9;

        private Resource[] resourcesDrop => GenerateResources();
        public Gold(Game game)
        {
            Game = game;
            ResourceRandomCapFirst = 2;
            ResourceRandomCapSecond = 3;
            StartCapacity = GoldCapicty * Game.CapacityHardnessMultiplier;
            Capacity = StartCapacity;
            ImagePath = Texture.Gold;
            ResourcesDrop = resourcesDrop;
        }

        public override Resource[] GenerateResources()
        {
            return new Resource[2]
            {
                new Rock() { Amount =  2 + Game.ResourceBonus},
                new GoldenIngot() { Amount = resourcesRandom.Next(1, ResourceRandomCapFirst + 1) + Game.ResourceBonus }
            };
        }

        public override void ChangeState()
        {
            Capacity -= Game.ClickPower;
        }

        public override void GainExperience()
        {
            Game.AddExperience(GoldExperience * Game.ExperienceMultiplier);
        }
    }
}
