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
            LeftDescription = "Время таймера уменьшается на 1с.";
            RightDescription = "+10% шанс появления доп. объекта на поле.";
        }

        public override void LeftBlessingChanges()
        {
            Game.ChangeFieldUpdateRate(-1);
        }

        public override void RightBlessingChanges()
        {
            Game.Field.ChangeDoubleGenerationChance(0.1);
        }
    }
}
