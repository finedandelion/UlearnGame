using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlearnGame.Model.Upgrades
{
    public class FieldExtensionUpgrade : Upgrade, IUpgrade
    {
        FieldExtensionUpgrade()
        {
            ImagePath = Image.FromFile("");
            Title = "Расширение поля #1";
            Description = "Увеличивает кол-во клеток поля на 2";
            IsObtained = false;
        }
        public override void UpgradeChanges(Game game)
        {
            game.Field.ExtendField(2);
            IsObtained = true;
        }
    }
}
