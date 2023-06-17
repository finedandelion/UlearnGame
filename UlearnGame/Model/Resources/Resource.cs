using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlearnGame.Model.Resources
{
    public class Resource : IResource
    {
        public int Amount { get; set; }
        public Image? Image { get; set; }
        public Image? Image2 { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
