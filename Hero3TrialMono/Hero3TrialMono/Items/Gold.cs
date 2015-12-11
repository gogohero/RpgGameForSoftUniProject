using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hero3TrialMono.Interfaces;

namespace Hero3TrialMono.Items
{
    public abstract class Gold : Item
    {
        public Gold(Position position, int itemCount) 
            : base(position, itemCount)
        {

        }
    }
}
