using AnimaTechCreator.Common;
using System.Collections.Generic;


namespace AnimaTechCreator.Models
{
    public class EffectModel
    {
        public EffectModel(
            string name, 
            int primaryKiCost, 
            int secondaryKiCost, 
            int mkCost, 
            int maintenanceCost, 
            int minorSustinanceCost, 
            int greatorSustinanceCost,
            List<OptionalCharacteristic> optionalCharacteristics,
            List<Enums.Element> elements,
            List<EffectOption> effectOptions,
            Enums.Characteristic primaryCharacteristic,
            Enums.Frequency frequency, 
            Enums.ActionType actionType,   
            Enums.Level minimumLevel
            )
        {
            Name = name;
            PrimaryKiCost = primaryKiCost;
            SecondaryKiCost = secondaryKiCost;
            MkCost = mkCost;
            MaintenanceCost = maintenanceCost;
            MinorSustinanceCost = minorSustinanceCost;
            GreatorSustinanceCost = greatorSustinanceCost;            
            OptionalCharacteristics = optionalCharacteristics;
            Elements = elements;
            EffectOptions = effectOptions;
            PrimaryCharacteristic = primaryCharacteristic;
            Frequency = frequency;
            ActionType = actionType;
            MinimumLevel = MinimumLevel;
            
        }

        public string Name { get; } = "";
        public int PrimaryKiCost { get; } = 1;
        public int SecondaryKiCost { get; } = 1;
        public int MkCost { get; } = 1;
        public int MaintenanceCost { get; }
        public int MinorSustinanceCost { get; } = 1;
        public int GreatorSustinanceCost { get; } = 1;
        public List<OptionalCharacteristic> OptionalCharacteristics { get; } = new List<OptionalCharacteristic>();
        public List<Enums.Element> Elements { get; } = new List<Enums.Element>();
        public List<EffectOption> EffectOptions { get; } = new List<EffectOption>();
        public Enums.Characteristic PrimaryCharacteristic { get; } = Enums.Characteristic.Strength;
        public Enums.Frequency Frequency { get; } = Enums.Frequency.Action;
        public Enums.ActionType ActionType { get; } = Enums.ActionType.Attack;
        public Enums.Level MinimumLevel { get; } = Enums.Level.One;
        
    }
}
