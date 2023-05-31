using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Visual;

namespace UlearnGame.Model.Resources
{
    public class Bone : Resource
    {
        public Bone()
        {
            Name = "КОСТЬ";
            Description = "Люди считают убийство диКОСТЬю. Однако это правила природы.";
            Image = Texture.Bone;
            Image2 = Texture.Bone2;
        }
    }
}
