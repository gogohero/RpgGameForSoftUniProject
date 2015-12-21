using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Hero3TrialMono.Castle.Structures
{
    using Army;

    public class GeneralLevelStructure : Structure
    {
        private string name;
        private GeneralLevelSoldier generalLevelSoldier;

        public GeneralLevelStructure(Vector2 position, string name)
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

