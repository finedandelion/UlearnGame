using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Visual;

namespace UlearnGame.Model.Resources
{
    public class UpgradedNecklace : Resource
    {
        public UpgradedNecklace()
        {
            Name = "ОЖЕРЕЛЬЕ ИЗ КОСТЕЙ";
            Description = "Кости придают устрашающий вид.";
            Image = Texture.UpgradedNecklace;
            Image2 = Texture.UpgradedNecklace2;
        }
    }
}
