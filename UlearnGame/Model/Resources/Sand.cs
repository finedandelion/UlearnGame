﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Visual;

namespace UlearnGame.Model.Resources
{
    public class Sand : Resource
    {
        public Sand()
        {
            Name = "Песок";
            Description = "Однажды всё обратится в пыль. А пока можно строить песочные замки!";
            ImagePath = Texture.Sand;
            ImagePath2 = Texture.Sand2;
        }
    }
}