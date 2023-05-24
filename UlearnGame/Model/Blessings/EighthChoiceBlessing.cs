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
            LeftDescription = "Время таймера уменьшается до трёх секунд.";
            RightDescription = "+50% шанс появления доп. объекта на поле.";
        }

        public override void LeftBlessingChanges()
        {
            Game.ChangeFieldUpdateRate(3);
        }

        public override void RightBlessingChanges()
        {
            Game.Field.ChangeDoubleGenerationChance(0.1);
        }
    }
}
