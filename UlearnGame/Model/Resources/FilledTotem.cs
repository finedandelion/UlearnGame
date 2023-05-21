using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Visual;

namespace UlearnGame.Model.Resources
{
    public class FilledTotem : Resource
    {
        public FilledTotem() 
        {
            Name = "НАПОЛН. ТОТЕМ";
            Description = "Возможно, в нём таятся сотни живых душ.";
            ImagePath = Texture.FilledTotem;
            ImagePath2 = Texture.FilledTotem2;
        }
    }
}
