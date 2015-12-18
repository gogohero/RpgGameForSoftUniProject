using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hero3TrialMono.Castle.Structures
{
    using Army;

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
