using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;

namespace UlearnGame.Model.Crafts
{
    public class PowderCraft : Craft
    {
        public PowderCraft(Game game) : base(game)
        {
            Description = "Эта магическая пыль способна творить удивительные вещи! Инструкции не прилагаются, но ты можешь попробовать" +
                " преобразовать одни ресурсы в другие, например.";
        }

        protected override Resource ReturnCraftResult()
        {
            return new Powder() { Amount = 5 };
        }

        protected override Resource[] ReturnCraftResources()
        {
            return new Resource[]
            {
                new Essence() { Amount = 2 },
                new Bone() { Amount = 5 - ReduceCraft},
                new Sand() { Amount = 5 - ReduceCraft}
            };
        }
    }
}
