using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Hero3TrialMono.Castle.Structures
{
    using Army;

    public class BunnyLevelStructure : Structure
    {
        private string name;
        private BunnyLevelSoldier bunnyLevelSoldier;

        public BunnyLevelStructure(Vector2 position, string name, BunnyLevelSoldier bunnyLevelSoldier)
            : base(position, name)
        {
            this.Position = position;
            this.BunnyLevelSoldier = bunnyLevelSoldier;
            this.Name = name;
        }

        public BunnyLevelSoldier BunnyLevelSoldier { get; set; }
        public string Name { get; set; }
    }
}
