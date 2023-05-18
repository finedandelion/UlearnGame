using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Visual;

namespace UlearnGame.Model.Resources
{
    public class CrystalShard : Resource
    {
        public CrystalShard()
        {
            Name = "Кристалл";
            Description = "Кристаллы считаются мощными сосудами для хранения жизненной энергии.";
            ImagePath = Texture.CrystalShard;
            ImagePath2 = Texture.CrystalShard2;
        }
    }
}
