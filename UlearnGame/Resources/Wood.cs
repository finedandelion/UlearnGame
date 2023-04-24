using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlearnGame.Resources
{
    internal class Wood : Resource
    {
        public Wood()
        {
            Name = "Древесина";
            Description = "Довольно крепкая древесина твёрдых пород.";
            ImagePath = GameForm.GetImage("Wood.png");
            ImagePath2 = GameForm.GetImage("SelectedWood.png");
        }
    }
}
