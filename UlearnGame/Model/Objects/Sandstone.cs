﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;
using UlearnGame.Visual;

namespace UlearnGame.Model.Objects
{
    public class Sandstone : GameObject
    {
        private static int SandstoneCapicty = 18;
        private static double SandstoneExperience = 7;
        private Resource[] resourcesDrop => GenerateResources();
        public Sandstone(Game game)
        {
            Game = game;
            StartCapacity = SandstoneCapicty * Game.CapacityHardnessMultiplier;
            Capacity = StartCapacity;
            Image = Texture.Sandstone;
            Image2 = Texture.Sandstone2;
            ResourcesDrop = resourcesDrop;
        }

        public override Resource[] GenerateResources()
        {
            return new Resource[]
            {
                new Rock() { Amount = 2 },
                new Sand() { Amount = resourcesRandom.Next(1, 5) + Game.ResourceBonus}
            };
        }

        public override void ChangeState()
        {
            Capacity -= Game.ClickPower;
        }

        public override void GainExperience()
        {
            Game.AddExperience(SandstoneExperience * Game.ExperienceMultiplier);
        }
    }
}
