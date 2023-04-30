using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Upgrades;

namespace UlearnGame.Model
{
    public class UpgradeSystem
    {
        private readonly HashSet<Upgrade> upgrades;

        public int UsedUpgradePoints
        {
            get
            {
                return upgrades.Count(upgrade => upgrade.IsObtained == true);
            }
        }
        public int AvailableUpgradePoints { get; private set; }

        public UpgradeSystem()
        {
            upgrades = new HashSet<Upgrade>();
        }

        public void ObtainUpgrade(Upgrade upgrade, Game game)
        {
            upgrade.UpgradeChanges(game);
        }

        private void UpdatePoints(Game game)
        {
            AvailableUpgradePoints = game.Level - UsedUpgradePoints;
        }

        private Upgrade GatheringUpgrade()
        {
            return new Upgrade()
            {

            };
        }
    }
}
