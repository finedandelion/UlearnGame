using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlearnGame.Model.Blessings
{
    public class ThirdChoiceBlessing : Blessing
    {
        public ThirdChoiceBlessing(Game game) : base(game)
        {
            LeftDescription = "Мгновенно даёт 1 уровень.";
            RightDescription = "Кол-во выпадаемого опыта увеличено.";
        }

        public override void LeftBlessingChanges()
        {

        }

        public override void RightBlessingChanges()
        {

        }
    }
}
