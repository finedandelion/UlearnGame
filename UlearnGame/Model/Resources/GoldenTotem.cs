using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Visual;

namespace UlearnGame.Model.Resources
{
    public class GoldenTotem : Resource
    {
        public GoldenTotem()
        {
            Name = "ЗОЛОТОЙ ТОТЕМ";
            Description = "СЛАВЬ СВОЁ БОЖЕСТВО! СЛАВЬ СВОЁ БОЖЕСТВО!";
            ImagePath = Texture.GoldenTotem;
            ImagePath2 = Texture.GoldenTotem2;
        }
    }
}
