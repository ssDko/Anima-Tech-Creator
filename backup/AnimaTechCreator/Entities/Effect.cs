﻿using AnimaTechCreator.Common;
using AnimaTechCreator.Models;
using System.Collections.Generic;

namespace AnimaTechCreator.Entities
{
    public class Effect
    {
        

        // Properties
        public EffectModel Model { get; set; }        
        public List<OptionalCharacteristicDetails> OptionalCharacteristicDetails { get; } = new List<OptionalCharacteristicDetails>();
        public List<EffectOptionDetails> EffectOptionDetails { get; } = new List<EffectOptionDetails>();
        public string Name { get { return Model.Name; } }
        public string Bonus { get { return Model.Bonus; } }
        public int PrimaryKeyCost { get { return Model.PrimaryKeyCost; } }
        public int SecondaryKeyCost { get { return Model.SecondaryKeyCost; } }
        public int MkCost { get { return Model.MkCost; }  }
        public int MaintenanceCost { get { return Model.MaintenanceCost; } }
        public int MinorSustinanceCost { get { return Model.MinorSustinanceCost; } }
        public int GreatorSustinanceCost { get { return Model.GreatorSustinanceCost; } }
        public List<OptionalCharacteristic> OptionalCharacteristics { get { return Model.OptionalCharacteristics; } }
        public List<Enums.Element> Elements { get { return Model.Elements; } }
        public List<EffectOption> EffectOptions { get { return Model.EffectOptions; } }
        public Enums.Characteristic PrimaryCharacteristic { get { return Model.PrimaryCharacteristic; } }
        public Enums.Frequency Frequency { get { return Model.Frequency; } }
        public Enums.ActionType ActionType { get { return Model.ActionType; } }
        public Enums.Level MinimumLevel { get { return Model.MinimumLevel; } }
        

        public Effect(EffectModel model)
        {
            Model = model;            

            foreach ( var optionalCharacteristic in OptionalCharacteristics)
                OptionalCharacteristicDetails.Add(new Common.OptionalCharacteristicDetails(optionalCharacteristic));

            foreach (var effectOption in EffectOptions)
                EffectOptionDetails.Add(new Common.EffectOptionDetails(effectOption));

        }

    }
}
