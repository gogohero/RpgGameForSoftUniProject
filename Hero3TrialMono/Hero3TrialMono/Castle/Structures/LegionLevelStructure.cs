using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Hero3TrialMono.Castle.Structures
{
    using Army;

    public class LegionLevelStructure : Structure
    {
        private string name;
        private LegionLevelSoldier legionLevelSoldier;

        public LegionLevelStructure(Vector2 position, string name)
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






