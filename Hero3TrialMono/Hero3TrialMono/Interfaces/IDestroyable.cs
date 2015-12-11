using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hero3TrialMono.Interfaces
{
    interface IDestroyable
    {
        int Health { get; private set; }
    }
}
