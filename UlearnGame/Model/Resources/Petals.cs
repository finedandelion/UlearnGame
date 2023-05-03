using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UlearnGame.Visual;

namespace UlearnGame.Model.Resources
{
    public class Petals : Resource
    {
        public Petals()
        {
            Name = "ЛЕПЕСТКИ";
            Description = "Из них получился бы красивый венок.";
            ImagePath = Texture.Petals;
            ImagePath2 = Texture.Petals2;
        }
    }
}
