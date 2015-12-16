using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Hero3TrialMono.Castle
{
    using Army;
    using Structures;

    class AngelCastle : Castle
    {
        private Structure BunnyLevelStructure;
        private Structure FootLevelStructure;
        private Structure LegionLevelStructure;
        private Structure CaptainLevelStructure;
        private Structure GeneralLevelStructure;
        private Structure MasterLevelStructure;
        private Structure LegendaryLevelStructure;

        private Soldier BunnyLevelSoldier;
        private Soldier FootLevelSoldier;
        private Soldier LegionLevelSoldier;
        private Soldier CaptainLevelSoldier;
        private Soldier GeneralLevelSoldier;
        private Soldier MasterLevelSoldier;
        private Soldier LegendaryLevelSoldier;
        public AngelCastle(Vector2 position) 
            : base(position)
        {

        }
    }
}
