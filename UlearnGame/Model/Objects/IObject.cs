using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;

namespace UlearnGame.Model.Objects
{
    public interface IObject
    {
        Resource[] GenerateResources();
        void GainExperience();
        void ChangeState();
    }
}
