using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Visual;

namespace UlearnGame.Model.Resources
{
    public class Berries : Resource
    {
        public Berries()
        {
            Name = "ЯГОДЫ";
            Description = "Ягоды, собранные с куста. На вид выглядят сочно!";
            Image = Texture.Berries;
            Image2 = Texture.Berries2;
        }
    }
}
