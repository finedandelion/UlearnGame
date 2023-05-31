using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlearnGame.Model.Blessings
{
    public class FourthChoiceBlessing : Blessing
    {
        public FourthChoiceBlessing(Game game) : base(game)
        {
            LeftDescription = "Увеличивает количество камня в вашем инвентаре вдвое.";
            RightDescription = "Увеличивает количество древесниы в вашем инвентаре вдвое.";
        }

        public override void LeftBlessingChanges()
        {
            Game.Inventory.ForthBlessingLeft();
        }

        public override void RightBlessingChanges()
        {
            Game.Inventory.FourthBlessingRight();
        }
    }
}
