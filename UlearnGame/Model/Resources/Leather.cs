﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Visual;

namespace UlearnGame.Model.Resources
{
    public class Leather : Resource
    {
        public Leather()
        {
            Name = "Кожа";
            Description = "Ай.";
            ImagePath = Texture.Leather;
            ImagePath2 = Texture.Leather2;
        }
    }
}