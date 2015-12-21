using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hero3TrialMono.Interfaces;
using Microsoft.Xna.Framework;

namespace Hero3TrialMono.Items
{
    public abstract class Gold : Item
    {
        public Gold(Vector2 position, int itemCount) 
            : base(position, itemCount)
        {

        }
    }
}
