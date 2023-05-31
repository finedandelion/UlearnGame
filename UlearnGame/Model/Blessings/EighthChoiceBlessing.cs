using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlearnGame.Model.Blessings
{
    public class EighthChoiceBlessing : Blessing
    {
        public EighthChoiceBlessing(Game game) : base(game)
        {
            LeftDescription = "БОЖЕСТВО УСЛЫШАЛО ВАШИ ПРОСЬБЫ.";
            RightDescription = "БОЖЕСТВО УСЛЫШАЛО ВАШИ ПРОСЬБЫ.";
        }

        public override void LeftBlessingChanges()
        {

        }

        public override void RightBlessingChanges()
        {

        }
    }
}
