﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Hero3TrialMono.Castle.Structures
{
    using Army;
    using Items;

    public class FootLevelStructure : Structure
    {
        private string name;
        private FootLevelSoldier footLevelSoldier;


        public FootLevelStructure(Vector2 position, string name, FootLevelSoldier footLevelSoldier)
            : base(position, name)
        {
            this.Position = position;
            this.FootLevelSoldier = footLevelSoldier;
            this.Name = name;
        }

        public FootLevelSoldier FootLevelSoldier { get; set; }
        public string Name { get; set; }
    }
}

