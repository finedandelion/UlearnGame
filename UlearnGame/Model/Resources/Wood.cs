using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Visual;

namespace UlearnGame.Model.Resources
{
    public class Wood : Resource
    {
        public Wood()
        {
            Name = "ДРЕВЕСИНА";
            Description = "Довольно крепкая древесина твёрдых пород.";
            ImagePath = Texture.Wood;
            ImagePath2 = Texture.Wood2;
        }
    }
}
