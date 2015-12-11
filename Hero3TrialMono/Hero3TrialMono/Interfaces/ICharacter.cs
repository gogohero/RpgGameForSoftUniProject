using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hero3TrialMono.Interfaces
{
    public interface ICharacter : IAttack
    {
        Position Position { get; }
        string Name { get; }
    }
}
