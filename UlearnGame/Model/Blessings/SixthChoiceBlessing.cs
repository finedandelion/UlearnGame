using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlearnGame.Model.Blessings
{
    public class SixthChoiceBlessing : Blessing
    {
        public SixthChoiceBlessing(Game game) : base(game)
        {
            LeftDescription = "Мгновенно даёт 1 уровень.";
            RightDescription = "Увеличивает множитель опыта на +0.1.";
        }

        public override void LeftBlessingChanges()
        {
            Game.AddExperience(Game.LevelExperienceCap - Game.Experience);
        }

        public override void RightBlessingChanges()
        {
            Game.ChangeExperienceMultiplier(0.1);
        }
    }
}
