using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Visual;

namespace UlearnGame.Model.Resources
{
    public class Parchment : Resource
    {
        public Parchment()
        {
            Name = "ПИСАНИЕ";
            Description = "Слова звучат мелодично и передают суть происходящих событий.";
            Image = Texture.Parchment;
            Image2 = Texture.Parchment2;
        }
    }
}
