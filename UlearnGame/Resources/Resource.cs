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
        public Image ImagePath { get; set; }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            var resource = obj as Resource;
            return resource != null
                && this.Amount == resource.Amount
                && this.ImagePath.GetHashCode() == resource.ImagePath.GetHashCode();
        }
    }
}
