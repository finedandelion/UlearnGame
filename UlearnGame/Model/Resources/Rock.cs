using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Visual;

namespace UlearnGame.Model.Resources
{
    public class Rock : Resource
    {
        public Rock()
        {
            Name = "КАМУШЕК";
            Description = "Раздробленные части небольшого камня.";
            ImagePath = Texture.Rock;
            ImagePath2 = Texture.Rock2;
        }
    }
}
