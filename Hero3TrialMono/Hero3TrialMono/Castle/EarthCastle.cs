using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hero3TrialMono.Castle.Structures;

namespace Hero3TrialMono.Castle
{
    public class EarthCastle : Castle
    {
        public EarthCastle(Position position, string name, BunnyLevelStructure bunnyLevelStructure, FootLevelStructure footLevelStructure, LegionLevelStructure legionLevelStructure, CaptainLevelStructure captainLevelStructure, GeneralLevelStructure generalLevelStructure, MasterLevelStructure masterLevelStructure, LegendaryLevelStructure legendaryLevelStructure) : base(position, name, bunnyLevelStructure, footLevelStructure, legionLevelStructure, captainLevelStructure, generalLevelStructure, masterLevelStructure, legendaryLevelStructure)
        {
        }
    }
}
