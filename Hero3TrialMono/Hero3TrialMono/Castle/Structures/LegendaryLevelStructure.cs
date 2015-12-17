using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hero3TrialMono.Castle.Army;

namespace Hero3TrialMono.Castle.Structures
{
    public class LegendaryLevelStructure : Structure
    {
        private string name;
        private LegendaryLevelSoldier legendaryLevelSoldier;
        
        public LegendaryLevelStructure(Position position, string name) 
            : base(position, name)
        {
            this.Position = position;
            this.Name = name;
            this.LegendaryLevelSoldier = legendaryLevelSoldier;
        }

        public LegendaryLevelSoldier LegendaryLevelSoldier { get; set; }
        public string Name { get; set; }
    }
}
