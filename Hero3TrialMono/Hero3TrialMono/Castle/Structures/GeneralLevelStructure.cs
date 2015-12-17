using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hero3TrialMono.Castle.Army;

namespace Hero3TrialMono.Castle.Structures
{
    public class GeneralLevelStructure : Structure
    {
        private string name;
        private GeneralLevelSoldier generalLevelSoldier;
        
        public GeneralLevelStructure(Position position, string name) 
            : base(position, name)
        {
            this.Position = position;
            this.GeneralLevelSoldier = generalLevelSoldier;
            this.Name = name;
        }

        public GeneralLevelSoldier GeneralLevelSoldier { get; set; }
        public string Name { get; set; }
    }
}
