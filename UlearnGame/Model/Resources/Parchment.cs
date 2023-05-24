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
            Description = "Слова звучат мелодично и передаёт суть происходящих событий.";
            ImagePath = Texture.Parchment;
            ImagePath2 = Texture.Parchment2;
        }
    }
}
