using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Visual;

namespace UlearnGame.Model.Resources
{
    public class CoalLump : Resource
    {
        public CoalLump()
        {
            Name = "УГОЛЬ";
            Description = "В нём ещё теплится старая жизнь. Нужно лишь зажечь её. Буквально.";
            Image = Texture.CoalLump;
            Image2 = Texture.CoalLump2;
        }
    }
}
