using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Hero3TrialMono.Interfaces
{
    public interface ICharacter : IAttack
    {
        Vector2 Position { get; }
        string Name { get; }
    }
}
