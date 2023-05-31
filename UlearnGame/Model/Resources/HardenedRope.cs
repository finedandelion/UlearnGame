using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Visual;

namespace UlearnGame.Model.Resources
{
    public class HardenedRope : Resource
    {
        public HardenedRope()
        {
            Name = "ТВЁРД. ВЕРЁВКА";
            Description = "До сих пор сохраняет свои эластичные свойства. Вряд ли порвётся.";
            Image = Texture.HardenedRope;
            Image2 = Texture.HardenedRope2;
        }
    }
}
