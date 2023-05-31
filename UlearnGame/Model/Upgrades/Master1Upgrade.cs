using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Visual;

namespace UlearnGame.Model.Upgrades
{
    public class Master1Upgrade : Upgrade
    {
        public Master1Upgrade(Game game, Upgrade[] previous = null) : base(game)
        {
            IsObtained = false;
            Previous = previous;
            ImagePath1 = Texture.Master1Icon;
            ImagePath2 = Texture.Master1Icon2;
            Title = "МАСТЕР I";
            Description = "Почётное звание заслуживают лишь трудом и упорством.\n" +
                "+0.2 ко множителю опыта.\n" +
                "Сила клика увеличивается на +1.";
        }

        public override void ObtainUpgrade()
        {
            Game.MasterIUpgrade();
            if (!IsObtained)
            {
                IsObtained = true;
            }
        }
    }
}
