using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using Hero3TrialMono.Castle.Army;

namespace Hero3TrialMono.Castle.Structures
{
    public class LegionLevelStructure : Structure
    {
        private string name;
        private LegionLevelSoldier legionLevelSoldier;
        
        public LegionLevelStructure(Position position, string name) 
            : base(position, name)
        {
            this.LegionLevelSoldier = legionLevelSoldier;
            this.Position = position;
            this.Name = name;
        }

        public LegionLevelSoldier LegionLevelSoldier { get; set; }
        public string Name { get; set; }
    }
}






