using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Visual;

namespace UlearnGame.Model.Resources
{
    public class UpgradeNecklace : Resource
    {
        public UpgradeNecklace()
        {
            Name = "ОЖЕРЕЛЬЕ ИЗ КОСТЕЙ";
            Description = "Кости придают устрашающий вид.";
            ImagePath = Texture.UpgradedNecklace;
            ImagePath2 = Texture.UpgradedNecklace2;
        }
    }
}
