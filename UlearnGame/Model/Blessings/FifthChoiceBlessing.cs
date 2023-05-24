using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlearnGame.Model.Blessings
{
    public class FifthChoiceBlessing : Blessing
    {
        public FifthChoiceBlessing(Game game) : base(game)
        {
            LeftDescription = "Заменяет все камни, появляемые на поле, на сланцы. Сланцы хранят различные минералы.";
            RightDescription = "Заменяет все деревья, появялемые на поле, на живые деревья. Живые деревья имеют эссенцию и доп. " +
                "органические ресуры.";
        }

        public override void LeftBlessingChanges()
        {
            Game.Field.SlateBlessing();
        }

        public override void RightBlessingChanges()
        {
            Game.Field.LivingTreeBlessing();
        }
    }
}
