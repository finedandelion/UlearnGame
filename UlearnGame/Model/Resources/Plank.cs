﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Visual;

namespace UlearnGame.Model.Resources
{
    public class Plank : Resource
    {
        public Plank()
        {
            Name = "ДОСКА";
            Description = "Приобрётшая новый вид древесина. Гладкая на ощупь.";
            Image = Texture.Plank;
            Image2 = Texture.Plank2;
        }
    }
}
