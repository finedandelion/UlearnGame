﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Visual;

namespace UlearnGame.Model.Resources
{
    public class Necklace : Resource
    {
        public Necklace()
        {
            Name = "ОЖЕРЕЛЬЕ";
            Description = "Украшения, что носят на шее, пользуются особым почтением.";
            Image = Texture.Necklace;
            Image2 = Texture.Necklace2;
        }
    }
}
