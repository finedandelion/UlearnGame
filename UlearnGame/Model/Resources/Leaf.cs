using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Visual;

namespace UlearnGame.Model.Resources
{
    public class Leaf : Resource
    {
        public Leaf()
        {
            Name = "ЛИСТОК";
            Description = "Животные едят листья. Почему бы не попробовать?";
            Image = Texture.Leaf;
            Image2 = Texture.Leaf2;
        }
    }
}
