using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlearnGame.Model.Resources
{
    public class SlimeDrop : Resource
    {
        public SlimeDrop()
        {
            Name = "СЛИЗЬ";
            Description = "Склизкая и противная. Интересно, какая она на вкус?";
            ImagePath = ProgramInitials.GetImage("SlimeDrop.png");
            ImagePath2 = ProgramInitials.GetImage("SelectedSlimeDrop.png");
        }
    }
}
