using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Visual;

namespace UlearnGame.Model.Resources
{
    public class Essence : Resource
    {
        public Essence()
        {
            Name = "ЭССЕНЦИЯ";
            Description = "Всякое существо обладает дающей жизнь энергией.";
            Image = Texture.Essence;
            Image2 = Texture.Essence2;
        }
    }
}
