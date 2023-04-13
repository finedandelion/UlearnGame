using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlearnGame.Resources
{
    internal class Resource : IResource
    {
        public int Amount { get; set; }
        public string? ImagePath { get; set; }
    }
}
