using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UlearnGame.Visual;

namespace UlearnGame.Model.Resources
{
    public class Bowl : Resource
    {
        public Bowl()
        {
            Name = "МИСКА";
            Description = "В неё можно ложить еду для подношений.";
            ImagePath = Texture.Bowl;
            ImagePath2 = Texture.Bowl2;
        }
    }
}
