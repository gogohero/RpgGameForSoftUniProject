using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Hero3TrialMono.Castle.Structures
{
    using Army;

    public class CaptainLevelStructure : Structure
    {
        private string name;
        private CaptainLevelSoldier captainLevelSoldier;

        public CaptainLevelStructure(Vector2 position, string name)
            : base(position, name)
        {
            this.Position = position;
            this.CaptainLevelSoldier = captainLevelSoldier;
            this.Name = name;
        }

        public CaptainLevelSoldier CaptainLevelSoldier { get; set; }
        public string Name { get; set; }
    }
}
