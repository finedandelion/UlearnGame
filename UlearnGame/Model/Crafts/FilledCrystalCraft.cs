using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;

namespace UlearnGame.Model.Crafts
{
    public class FilledCrystalCraft : Craft
    {
        public FilledCrystalCraft(Game game) : base(game)
        {
            Description = "Целая сотня душ может поместиться в небольшой кристалл — эхо сотни живых существ треплется внутри.";
        }

        protected override Resource ReturnCraftResult()
        {
            return new FilledCrystal() { Amount = 1 };
        }

        protected override Resource[] ReturnCraftResources()
        {
            return new Resource[]
            {
                new CrystalShard() { Amount = 2},
                new Essence() { Amount = 5 - ReduceCraft},
            };
        }
    }
}
