using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hero3TrialMono.Castle.Army.Intefaces
{
    using Interfaces;
    interface ISoldier : IMovable , IAttack
    {
         int SoldierCount { get;  }

         string Name { get;  }

         int Damage { get; set; }

        SoldierState SoldierState { get;  }

         int Speed { get; }
    }
}
