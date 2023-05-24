using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Visual;

namespace UlearnGame.Model.Resources
{
    public class Wreath : Resource
    {
        public Wreath()
        {
            Name = "ВЕНОК";
            Description = "Он хорошо бы смотрелся на голове! Не на твоей.";
            ImagePath = Texture.Wreath;
            ImagePath2 = Texture.Wreath2;
        }
    }
}
