using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hero3TrialMono.Interfaces
{
    using Items;

    interface IItem
    {
       

        int ItemCount { get; }

        ItemState ItemState { get; }
    }
}
