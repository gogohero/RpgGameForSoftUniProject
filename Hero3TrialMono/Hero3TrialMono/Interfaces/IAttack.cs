using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hero3TrialMono.Characters;

namespace Hero3TrialMono.Interfaces
{
   public interface IAttack
    {
        int Damage { get; }
        void Attack(Champion enemy);
    }
}
