﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Visual;

namespace UlearnGame.Model.Resources
{
    public class Rope : Resource
    {
        public Rope()
        {
            Name = "ВЕРЁВКА";
            Description = "Сплетённые воедино органические волокна.";
            Image = Texture.Rope;
            Image2 = Texture.Rope2;
        }
    }
}
