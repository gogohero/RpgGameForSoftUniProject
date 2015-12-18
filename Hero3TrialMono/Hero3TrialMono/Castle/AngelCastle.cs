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
        public AngelCastle(Position position, 
            string name,
            BunnyLevelStructure bunnyLevelStructure, 
            FootLevelStructure footLevelStructure, 
            LegionLevelStructure legionLevelStructure, 
            CaptainLevelStructure captainLevelStructure, 
            GeneralLevelStructure generalLevelStructure, 
            MasterLevelStructure masterLevelStructure, 
            LegendaryLevelStructure legendaryLevelStructure, 
            BunnyLevelSoldier bunnyLevelSoldier, 
            FootLevelSoldier footLevelSoldier, 
            LegionLevelSoldier legionLevelSoldier, 
            CaptainLevelSoldier captainLevelSoldier, 
            GeneralLevelSoldier generalLevelSoldier, 
            MasterLevelSoldier masterLevelSoldier, 
            LegendaryLevelSoldier legendaryLevelSoldier) 
            : base(position, 
                  name, 
                  bunnyLevelStructure, 
                  footLevelStructure, 
                  legionLevelStructure, 
                  captainLevelStructure, 
                  generalLevelStructure, 
                  masterLevelStructure, 
                  legendaryLevelStructure, 
                  bunnyLevelSoldier, 
                  footLevelSoldier, 
                  legionLevelSoldier, 
                  captainLevelSoldier, 
                  generalLevelSoldier, 
                  masterLevelSoldier, 
                  legendaryLevelSoldier)
        {
            this.Name = "Valhala";
            this.BunnyLevelStructure = new BunnyLevelStructure(new Position(50,200), "Miro");
            this.FootLevelStructure = new FootLevelStructure(new Position(90, 80), "E");
            this.LegionLevelStructure = new LegionLevelStructure(new Position(100, 200), "Mnou");
            this.CaptainLevelStructure = new CaptainLevelStructure(new Position(500,100), "Typ");
            this.GeneralLevelStructure = new GeneralLevelStructure(new Position(600,500), "Nimoa");
            this.MasterLevelStructure = new MasterLevelStructure(new Position(700,50), "go");
            this.LegendaryLevelStructure = new LegendaryLevelStructure(new Position(300 ,700), "turpa.");
            //this.BunnyLevelSoldier = new BunnyLevelSoldier(new Po);
            
        }
    }
}
