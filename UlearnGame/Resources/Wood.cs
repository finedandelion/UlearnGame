﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlearnGame.Resources
{
    internal class Wood : Resource
    {
        public Wood()
        {
            Amount = Game.resourcesRandom.Next(0, Game.resourceRandomCap);
        }
    }
}
