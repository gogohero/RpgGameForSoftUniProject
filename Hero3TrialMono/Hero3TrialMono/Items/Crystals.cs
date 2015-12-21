using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Hero3TrialMono.Items
{
    public abstract class Crystals :Item
    {
        public Crystals(Vector2 position, int itemCount) 
            : base(position, itemCount)
        {
        }
    }
}
