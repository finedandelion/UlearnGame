using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Visual;

namespace UlearnGame.Model.Resources
{
    public class DullTotem : Resource
    {
        public DullTotem()
        {
            Name = "ПУСТОЙ ТОТЕМ";
            Description = "Оболочка тотема. Не излучает жизненных сил.";
            Image = Texture.DullTotem;
            Image2 = Texture.DullTotem2;
        }
    }
}
