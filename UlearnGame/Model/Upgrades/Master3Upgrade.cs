using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Visual;

namespace UlearnGame.Model.Upgrades
{
    public class Master3Upgrade : Upgrade
    {
        public Master3Upgrade(Game game, Upgrade[] previous = null)
        {
            IsObtained = false;
            Game = game;
            Previous = previous;
            ImagePath1 = Texture.Master3Icon;
            ImagePath2 = Texture.Master3Icon2;
            Title = "МАСТЕР III";
            Description = "Почётное звание заслуживают лишь трудом и упорством.\n" +
                "Некоторые крафты дают дополнительные ресурсы.\n" +
                "-1c. Таймера.\n" +
                "+10% шанс появления доп. объекта на поле.";
        }

        public override void ObtainUpgrade()
        {
            if (!IsObtained)
            {
                IsObtained = true;
            }
        }
    }
}
