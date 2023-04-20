using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlearnGame.Upgrades
{
    internal interface IUpgrade
    {
        public void UpgradeChanges(Game game);
    }
}
