using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Visual;

namespace UlearnGame.Model.Resources
{
    public class IronIngot : Resource
    {
        public IronIngot()
        {
            Name = "ЖЕЛЕЗНАЯ РУДА";
            Description = "Железо течёт в крови. Именно поэтому оно нравится божеству.";
            Image = Texture.IronIngot;
            Image2 = Texture.IronIngot2;
        }
    }
}
