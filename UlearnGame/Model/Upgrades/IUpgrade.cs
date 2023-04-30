using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlearnGame.Model.Upgrades
{
    public interface IUpgrade
    {
        public void UpgradeChanges(Game game);
        public bool IsObtainable();
    }
}
