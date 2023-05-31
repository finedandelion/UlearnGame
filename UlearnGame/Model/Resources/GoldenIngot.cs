using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UlearnGame.Visual;

namespace UlearnGame.Model.Resources
{
    public class GoldenIngot : Resource
    {
        public GoldenIngot()
        {
            Name = "ЗОЛОТАЯ РУДА";
            Description = "Блестит! Самый настоящий и неподдельный самородок.";
            Image = Texture.GoldenIngot;
            Image2 = Texture.GoldenIngot2;
        }
    }
}
