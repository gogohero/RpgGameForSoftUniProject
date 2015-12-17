using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hero3TrialMono.Castle
{
    using Army;
    using Structures;

   public class AngelCastle : Castle
   {
       private const string Name = "Jesus";
       
       
       public AngelCastle(Position position, string name, BunnyLevelStructure bunnyLevelStructure, FootLevelStructure footLevelStructure, LegionLevelStructure legionLevelStructure, CaptainLevelStructure captainLevelStructure, GeneralLevelStructure generalLevelStructure, MasterLevelStructure masterLevelStructure, LegendaryLevelStructure legendaryLevelStructure) : base(position, name, bunnyLevelStructure, footLevelStructure, legionLevelStructure, captainLevelStructure, generalLevelStructure, masterLevelStructure, legendaryLevelStructure)
       {
       }
    }
}
