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
            Name = "КРИСТАЛЛ";
            Description = "Кристаллы считаются мощными сосудами для хранения жизненной энергии.";
            Image = Texture.CrystalShard;
            Image2 = Texture.CrystalShard2;
        }
    }
}
