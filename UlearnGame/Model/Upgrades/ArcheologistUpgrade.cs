using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Visual;

namespace UlearnGame.Model.Upgrades
{
    public class ArcheologistUpgrade : Upgrade
    {
        public ArcheologistUpgrade(Game game, Upgrade[] previous = null) : base(game)
        {
            IsObtained = false;
            Previous = previous;
            ImagePath1 = Texture.ArcheologistIcon;
            ImagePath2 = Texture.ArcheologistIcon2;
            Title = "АРХЕОЛОГ";
            Description = "На поиски древних ископаемых!\n" +
                "Расширяет игровое поле на три клетки.\n" +
                "На поле появляются песчаник и ископаемые.\n" +
                "+0.2 ко множителю опыта.";
        }

        public override void ObtainUpgrade()
        {
            if (!IsObtained)
            {
                Game.Field.ArcheologistUpgrade();
                Game.ChangeExperienceMultiplier(0.2);
                IsObtained = true;
            }
        }
    }
}
