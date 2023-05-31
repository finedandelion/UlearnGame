using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Visual;

namespace UlearnGame.Model.Resources
{
    public class SlimeDrop : Resource
    {
        public SlimeDrop()
        {
            Name = "СЛИЗЬ";
            Description = "Склизкая и противная. Интересно, какая она на вкус?";
            Image = Texture.SlimeDrop;
            Image2 = Texture.SlimeDrop2;
        }
    }
}
