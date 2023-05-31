using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Visual;

namespace UlearnGame.Model.Resources
{
    public class Chalice : Resource
    {
        public Chalice()
        {
            Name = "КУБОК";
            Description = "Драгоценная посудина для подношений.";
            Image = Texture.Chalice;
            Image2 = Texture.Chalice2;
        }
    }
}
