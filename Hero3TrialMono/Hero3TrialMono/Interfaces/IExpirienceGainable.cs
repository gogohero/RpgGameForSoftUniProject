using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hero3TrialMono.Interfaces
{
    public interface IExpirienceGainable
    {
        int Expirience { get; }

        void LevelUp();
    }
}
