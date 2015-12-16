using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hero3TrialMono.Castle.Structures
{
    using Army;
    using Items;

    public class FootLevelStructure : Structure
    {
        const int goldCost = 500;
        const int rockCost = 10;


        public FootLevelStructure(Position position, string name) 
            : base(position, name)
        {
        }
    }
}
