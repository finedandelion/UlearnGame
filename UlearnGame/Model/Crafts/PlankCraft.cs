using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;

namespace UlearnGame.Model.Crafts
{
    public class PlankCraft : Craft
    {
        public PlankCraft(Game game) : base(game)
        {
            Description = "Ты когда-нибудь пробовал расколоть бревно голыми руками? Ладно, руки тебе не понадобятся." +
                " Духу вообще ничего нужно, разве что немного магических сил.";
        }

        protected override Resource ReturnCraftResult()
        {
            return new Plank() { Amount = 2 };
        }

        protected override Resource[] ReturnCraftResources()
        {
            return new Resource[] { new Wood() { Amount = 1 } };
        }
    }
}
