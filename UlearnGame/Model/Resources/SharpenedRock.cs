﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Visual;

namespace UlearnGame.Model.Resources
{
    public class SharpenedRock : Resource
    {
        public SharpenedRock()
        {
            Name = "ЗАОСТР. КАМЕНЬ";
            Description = "Острый как бритва. Незаменимая вещь в ремесле.";
            Image = Texture.SharpenedRock;
            Image2 = Texture.SharpenedRock2;
        }
    }
}
