using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hero3TrialMono.Items
{
    public abstract class Mercury : Item
    {
        public Mercury(Position position, int itemCount) : base(position, itemCount)
        {
        }
    }
}
