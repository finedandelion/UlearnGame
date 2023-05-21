using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Visual;

namespace UlearnGame.Model.Upgrades
{
    public class Master2Upgrade : Upgrade
    {
        public Master2Upgrade(Game game, Upgrade[] previous = null)
        {
            IsObtained = false;
            Game = game;
            Previous = previous;
            ImagePath1 = Texture.Master2Icon;
            ImagePath2 = Texture.Master2Icon2;
            Title = "МАСТЕР II";
            Description = "Почётное звание заслуживают лишь трудом и упорством.\n" +
                "Увеличивает прочность предметов в 2 раза! (Не действует на существ и звёзды)\n" +
                "+2 к количеству собираемых ресурсов. (кроме эссенций)";
        }

        public override void ObtainUpgrade()
        {
            if (!IsObtained)
            {
                Game.ChangeCapacityMultiplier();
                Game.ChangeResourceBonus(2);
                IsObtained = true;
            }
        }
    }
}
