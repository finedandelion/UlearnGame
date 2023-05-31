using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Visual;

namespace UlearnGame.Model.Resources
{
    public class Powder : Resource
    {
        public Powder()
        {
            Name = "ПЫЛЬЦА";
            Description = "Магический ингридиент, служащий для преобразования ресурсов!";
            Image = Texture.Powder;
            Image2 = Texture.Powder2;
        }
    }
}
