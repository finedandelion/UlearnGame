using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Visual;

namespace UlearnGame.Model.Resources
{
    public class FilledCrystal : Resource
    {
        public FilledCrystal() 
        {
            Name = "ЗАРЯЖ. КРИСТАЛЛ";
            Description = "Первосходный магический инструмент.";
            Image = Texture.FilledCrystal;
            Image2 = Texture.FilledCrystal2;
        }
    }
}
