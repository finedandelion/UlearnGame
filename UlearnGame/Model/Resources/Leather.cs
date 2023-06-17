using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Visual;

namespace UlearnGame.Model.Resources
{
    public class Leather : Resource
    {
        public Leather()
        {
            Name = "КОЖА";
            Description = "Содрана идеальна. Где-то ты её уже видел. В другой жизни?";
            Image = Texture.Leather;
            Image2 = Texture.Leather2;
        }
    }
}
