using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Hero3TrialMono
{
    public struct Position
    {
        public Position(Vector2 pos) : this()
        {

            this.Pos = pos;
        }

      public  Vector2 Pos { get; set; } 
        
    }
}
