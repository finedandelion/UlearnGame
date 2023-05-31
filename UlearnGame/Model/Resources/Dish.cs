using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UlearnGame.Visual;

namespace UlearnGame.Model.Resources
{
    public class Dish : Resource
    {
        public Dish()
        {
            Name = "МЯСНОЕ БЛЮДО";
            Description = "Сгодится. Божество будет радо кровавому пиршеству.";
            Image = Texture.Dish;
            Image2 = Texture.Dish2;
        }
    }
}
