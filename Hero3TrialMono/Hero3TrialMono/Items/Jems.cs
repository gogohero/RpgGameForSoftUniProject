using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hero3TrialMono.Items
{
    public abstract class Jems : Item
    {
        public Jems(Position position, int itemCount) : base(position, itemCount)
        {
        }
    }
}
