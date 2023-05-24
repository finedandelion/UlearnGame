﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Visual;

namespace UlearnGame.Model.Resources
{
    public class Instrument : Resource
    {
        public Instrument()
        {
            Name = "ИНСТРУМЕНТ";
            Description = "Сгодится для более грубой работы.";
            ImagePath = Texture.Instrument;
            ImagePath2 = Texture.Instrument2;
        }
    }
}
