using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hero3TrialMono.Interfaces
{
    using Castle.Army;
    using Castle.Structures;

    public interface ICastle
    {
         string Name { get; }

         BunnyLevelSoldier BunnyLevelSoldier { get; }

         FootLevelSoldier FootLevelSoldier { get; }

         LegionLevelSoldier LegionLevelSoldier { get; }

         CaptainLevelSoldier CaptainLevelSoldier { get; }

        GeneralLevelSoldier GneGeneralLevelSoldier { get; }

    MasterLevelSoldier MasterLevelSoldier { get; }

         LegendaryLevelSoldier LegendaryLevelSoldier { get; }

         BunnyLevelStructure BunnyLevelStructure { get; }

        FootLevelStructure FootLevelStructure { get; }

         LegionLevelStructure LegionLevelStructure { get; }

         CaptainLevelStructure CaptainLevelStructure { get; }

         GeneralLevelStructure GeneralLevelStructure { get; }

        MasterLevelStructure MasterLevelStructure { get; }

        LegendaryLevelStructure LegendaryLevelStructure { get; }

        void Enter();
    }
}
