using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimaTechCreator.Common
{
    public class EffectOption
    {
       

        string Name { get; }
        int KiCostModifier { get; }
        int MkCostModifier { get; }
        int MaintenanceCostModifier { get; }
        int MinorSustinanceCostModifier { get; }
        int GreatorSustinanceCostModifier { get; }
        bool IsDisadvantage { get; }

        public EffectOption(
           string name = "",
           int kiCostModifier = 1,
           int mkCostModifier = 1,
           int maintenanceCostModifier = 0,
           int minorSustinanceCostModifier = 0,
           int greatorSustinanceCostModifier = 0,
           bool isDisadvantage = false)
        {
            Name = name;
            KiCostModifier = kiCostModifier;
            MkCostModifier = mkCostModifier;
            MaintenanceCostModifier = maintenanceCostModifier;
            MinorSustinanceCostModifier = minorSustinanceCostModifier;
            GreatorSustinanceCostModifier = greatorSustinanceCostModifier;
            IsDisadvantage = isDisadvantage;
        }


    }
}
