using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlearnGame.Model.Upgrades
{
    public class Upgrade : IUpgrade
    {
        public Image ImagePath { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsObtained { get; set; }
        public Upgrade Previous { get; set; }

        public override int GetHashCode()
        {
            return Title.GetHashCode();
        }

        public virtual bool IsObtainable()
        {
            return true;
        }

        public virtual void UpgradeChanges(Game game)
        {

        }
    }
}
