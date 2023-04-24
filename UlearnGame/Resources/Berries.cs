using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlearnGame.Resources
{
    internal class Berries : Resource
    {
        public Berries() 
        {
            Name = "ЯГОДЫ";
            Description = "Ягоды, собранные с куста. На вид выглядят сочно!";
            ImagePath = GameForm.GetImage("Berries.png");
            ImagePath2 = GameForm.GetImage("SelectedBerries.png");
        }
    }
}
