using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Visual;

namespace UlearnGame.Model.Resources
{
    public class Meat : Resource
    {
        public Meat() 
        {
            Name = "МЯСО";
            Description = "Что-то заставляет тебя почувстовать голод. Духи. Не. Голодают.";
            ImagePath = Texture.Meat;
            ImagePath2 = Texture.Meat2;
        }
    }
}
