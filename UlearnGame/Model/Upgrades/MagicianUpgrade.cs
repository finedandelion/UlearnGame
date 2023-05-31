using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Visual;

namespace UlearnGame.Model.Upgrades
{
    public class MagicianUpgrade : Upgrade
    {
        public MagicianUpgrade(Game game, Upgrade[] previous = null) : base(game)
        {
            IsObtained = false;
            Previous = previous;
            ImagePath1 = Texture.MagicianIcon;
            ImagePath2 = Texture.MagicianIcon2;
            Title = "ВОЛШЕБНИК";
            Description = "Силы природы наполняют и усиляют вас.\n" +
                "На поле появляются звёзды.\n" +
                "С живых существ начинают выпадать эссенции.";
        }

        public override void ObtainUpgrade()
        {
            if (!IsObtained)
            {
                Game.Field.MagicianUpgrade();
                Game.ChangeEssenceDrop();
                IsObtained = true;
            }
        }
    }
}
