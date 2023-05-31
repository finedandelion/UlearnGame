using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Visual;

namespace UlearnGame.Model.Resources
{
    public class Wine : Resource
    {
        public Wine() 
        {
            Name = "ВИНО";
            Description = "Искуственно выдержано годами. То, чего так не хватает Божеству.";
            Image = Texture.Wine;
            Image2 = Texture.Wine2;
        }
    }
}
