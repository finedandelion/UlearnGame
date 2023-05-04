using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Visual;

namespace UlearnGame.Model.Upgrades
{
    public class Upgrade : IUpgrade
    {
        public Image ImagePath1 { get; set; }

        public Image ImagePath2 { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsObtained { get; set; }
        public Upgrade[] Previous { get; set; }
        public Game Game { get; set; }

        public override int GetHashCode()
        {
            return Title.GetHashCode();
        }

        public virtual bool IsObtainable()
        {
            return Previous == null ? true : Previous.All(prev => prev.IsObtained == true);
        }

        public virtual void ObtainUpgrade()
        {

        }
    }
}
