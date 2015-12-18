using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hero3TrialMono.Castle
{
    using System.Runtime.Remoting.Activation;
    using Army;
    using Army.Intefaces;
    using Interfaces;
    using Structures;

    public abstract class Castle : GameObject, ICastle
    {
        private string name;
        private BunnyLevelStructure bunnyLevelStructure;
        private FootLevelStructure footLevelStructure;
        private LegionLevelStructure legionLevelStructure;
        private CaptainLevelStructure captainLevelStructure;
        private GeneralLevelStructure generalLevelStructure;
        private MasterLevelStructure masterLevelStructure;
        private LegendaryLevelStructure legendaryLevelStructure;

        private BunnyLevelSoldier bunnyLevelSoldier;
        private FootLevelSoldier footLevelSoldier;
        private LegionLevelSoldier legionLevelSoldier;
        private CaptainLevelSoldier captainLevelSoldier;
        private GeneralLevelSoldier generalLevelSoldier;
        private MasterLevelSoldier masterLevelSoldier;
        private LegendaryLevelSoldier legendaryLevelSoldier;

        public Castle(Position position, 
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
            LegendaryLevelSoldier legendaryLevelSoldier
            ) 
            : base(position)
        {
            
        }


        public string Name { get; set; }

        public BunnyLevelSoldier BunnyLevelSoldier { get; set; }

        public FootLevelSoldier FootLevelSoldier { get; set; }

        public LegionLevelSoldier LegionLevelSoldier { get; set; }

        public CaptainLevelSoldier CaptainLevelSoldier { get; set; }

        public GeneralLevelSoldier GneGeneralLevelSoldier { get; set; }

        public MasterLevelSoldier MasterLevelSoldier { get; set; }

        public LegendaryLevelSoldier LegendaryLevelSoldier { get; set; }

        public BunnyLevelStructure BunnyLevelStructure { get; set; }

        public FootLevelStructure FootLevelStructure { get; set; }

        public LegionLevelStructure LegionLevelStructure { get; set; }

        public CaptainLevelStructure CaptainLevelStructure { get; set; }

        public GeneralLevelStructure GeneralLevelStructure { get; set; }

        public MasterLevelStructure MasterLevelStructure { get; set; }

        public LegendaryLevelStructure LegendaryLevelStructure { get; set; }

        public void Enter()
        {
           
            throw new NotImplementedException();
        }
    }
}
