﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Resources;

namespace UlearnGame.Objects
{
    internal class Stone : GameObject
    {
        private static int StoneCapicty = 12;
        private Resource[] resourcesDrop => GenerateResources();
        public Stone()
        {
            ResourceRandomCapFirst = 2;
            StartCapacity = StoneCapicty * CapacityHardnessMultiplier;
            Capacity = StartCapacity;
            ImagePath = GameForm.GetImage("Stone.png");
            ResourcesDrop = resourcesDrop;
        }

        public override Resource[] GenerateResources()
        {
            return new Resource[1]
            {
                new Rock() { Amount = resourcesRandom.Next(1, ResourceRandomCapFirst + 1) }
            };
        }


        public override void ChangeState(int clickPower)
        {
            Capacity -= clickPower;
        }
    }
}