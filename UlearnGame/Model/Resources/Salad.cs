using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UlearnGame.Visual;

namespace UlearnGame.Model.Resources
{
    public class Salad : Resource
    {
        public Salad() 
        {
            Name = "МАЛ. ПОДНОШЕНИЕ";
            Description = "Толчёные ягоды и листья. Надейся на милость.";
            Image = Texture.Salad;
            Image2 = Texture.Salad2;
        }

    }
}
