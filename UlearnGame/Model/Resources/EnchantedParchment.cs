using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Visual;

namespace UlearnGame.Model.Resources
{
    public class EnchantedParchment : Resource
    {
        public EnchantedParchment()
        {
            Name = "СВ. ПИСАНИЕ";
            Description = "На слова наложено зачарование. Хей, они светятся даже в темноте!";
            Image = Texture.EnchantedParchment;
            Image2 = Texture.EnchantedParchment2;
        }
    }
}
