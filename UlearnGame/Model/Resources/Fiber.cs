using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Visual;

namespace UlearnGame.Model.Resources
{
    public class Fiber : Resource
    {
        public Fiber()
        {
            Name = "ВОЛОКНО";
            Description = "Тонкие органические волокна. Пригодны для вязаяния.";
            Image = Texture.Fiber;
            Image2 = Texture.Fiber2;
        }
    }
}
