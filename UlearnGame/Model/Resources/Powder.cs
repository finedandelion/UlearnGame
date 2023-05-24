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
            ImagePath = Texture.Powder;
            ImagePath2 = Texture.Powder2;
        }
    }
}
