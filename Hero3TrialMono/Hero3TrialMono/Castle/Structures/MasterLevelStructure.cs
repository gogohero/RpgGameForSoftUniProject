using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hero3TrialMono.Castle.Structures
{
    using Army;

    public class MasterLevelStructure : Structure
    {
        private string name;
        private MasterLevelSoldier masterLevelSoldier;

        public MasterLevelStructure(Position position, string name)
            : base(position, name)
        {
            this.Position = position;
            this.Name = name;
            this.MasterLevelSoldier = masterLevelSoldier;
        }

        public string Name { get; set; }
        public MasterLevelSoldier MasterLevelSoldier { get; set; }
    }
}
