using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace EffectLibrary
{
    [DataContract]
    public class Effect
    {
        //Variables
        private String name = "";
        private List<EffectStatLine> effectStats;
        private Characteristic primaryCharacteristic = Characteristic.Strength;
        
        //optional characteristic costs; 
        private int optionalStrCost = 0;
        private int optionalAgiCost = 0;
        private int optionalDexCost = 0;
        private int optionalConCost = 0;
        private int optionalWPCost  = 0;
        private int optionalPowCost = 0;

        //Elements
        private bool air = false;
        private bool earth = false;
        private bool fire = false;
        private bool water = false;
        private bool light = false;
        private bool darkness = false;
        

        private Frequency frequency = Frequency.Action;
        private ActionType actionType = ActionType.Attack;        
        private List<OptionalAdvantage> optionalAdvantages;
        private List<EffectDisadvantage> optionalDisadvantages;

        //Accessors
        [DataMember(Order = 1)]
        public string Name { get => name; set => name = value; }
        [DataMember(Order = 2)]
        public Characteristic PrimaryCharacteristic { get => primaryCharacteristic; set => primaryCharacteristic = value; }
        [DataMember(Order = 3)]
        public int OptionalStrCost { get => optionalStrCost; set => optionalStrCost = value; }
        [DataMember(Order = 4)]
        public int OptionalAgiCost { get => optionalAgiCost; set => optionalAgiCost = value; }
        [DataMember(Order = 5)]
        public int OptionalDexCost { get => optionalDexCost; set => optionalDexCost = value; }
        [DataMember(Order = 6)]
        public int OptionalConCost { get => optionalConCost; set => optionalConCost = value; }
        [DataMember(Order = 7)]
        public int OptionalWPCost { get => optionalWPCost; set => optionalWPCost = value; }
        [DataMember(Order = 8)]
        public int OptionalPowCost { get => optionalPowCost; set => optionalPowCost = value; }
        [DataMember(Order = 9)]
        public Frequency Frequency { get => frequency; set => frequency = value; }
        [DataMember(Order = 10)]
        public ActionType ActionType { get => actionType; set => actionType = value; }
        [DataMember(Order = 11, EmitDefaultValue = false)]
        public List<EffectStatLine> EffectStats { get => effectStats; set => effectStats = value; }
        [DataMember(Order = 12, EmitDefaultValue = false)]
        public List<OptionalAdvantage> OptionalAdvantages { get => optionalAdvantages; set => optionalAdvantages = value; }
        [DataMember(Order = 13, EmitDefaultValue = false)]
        public List<EffectDisadvantage> OptionalDisadvantages { get => optionalDisadvantages; set => optionalDisadvantages = value; }
        [DataMember(Order = 14)]
        public bool Air { get => air; set => air = value; }
        [DataMember(Order = 15)]
        public bool Earth { get => earth; set => earth = value; }
        [DataMember(Order = 16)]
        public bool Fire { get => fire; set => fire = value; }
        [DataMember(Order = 17)]
        public bool Water { get => water; set => water = value; }
        [DataMember(Order = 18)]
        public bool Light { get => light; set => light = value; }
        [DataMember(Order = 19)]
        public bool Darkness { get => darkness; set => darkness = value; }

        // Constructor(s)
        public Effect()
        {
            effectStats = new List<EffectStatLine>();           
            
            optionalAdvantages = new List<OptionalAdvantage>();
            optionalDisadvantages = new List<EffectDisadvantage>();
        }


        //methods
        /// <summary>
        /// Adds a stat line level to the effect. Forces the level to be equal or higher then the previous level
        /// </summary>
        /// <param name="newLine">The stat line to add</param>
        /// <returns>Returns true if the stat line has been added successfully. Otherwise false.</returns>
        public bool AddStatLine(EffectStatLine newLine)
        {
            effectStats.Add(newLine);           


            return false;
        }

        /// <summary>
        /// Removes a stat line at a given index.  
        /// </summary>
        /// <param name="index"> The index to be removed</param>
        /// <returns>Returns True if the removal was successfull, false otherwise.</returns>
        public bool RemoveStatLineAt(int index)
        {
            try
            {
                effectStats.RemoveAt(index);
            }
            catch (System.IndexOutOfRangeException)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Attempts to remove a given stat line
        /// </summary>
        /// <param name="statLine">The stat line to remove</param>
        /// <returns>Returns true if the stat line was removed, false otherwise.</returns>
        public bool RemoveStatLine(EffectStatLine statLine)
        {
            return effectStats.Remove(statLine);
        }

        /// <summary>
        /// Adds a optional advantage
        /// </summary>
        /// <param name="newAdvantage">The advantage to add</param>
        public void AddAdvantage(OptionalAdvantage newAdvantage)
        {
            optionalAdvantages.Add(newAdvantage);            
        }

        public bool RemoveAdvantageAt(int index)
        {
            try
            {
                optionalAdvantages.RemoveAt(index);
            }
            catch (System.IndexOutOfRangeException)
            {
                return false;
            }

            return true;
        }

        public bool RemoveAdvantage(OptionalAdvantage advantage)
        {
            return optionalAdvantages.Remove(advantage);
        }

        public void AddDisadvantage(EffectDisadvantage newDisadvantage)
        {
            optionalDisadvantages.Add(newDisadvantage);
        }

        public bool RemoveDisadvantageAt(int index)
        {
            try
            {
                optionalDisadvantages.RemoveAt(index);
            }
            catch (System.IndexOutOfRangeException)
            {
                return false;
            }

            return true;
        }

        public bool RemoveDisadvantage(EffectDisadvantage disadvantage)
        {
            return optionalDisadvantages.Remove(disadvantage);
        }

        public int GetOptionalStat(Characteristic stat)
        {
            switch (stat)
            {
                case Characteristic.Strength:
                    return OptionalStrCost;
                    break;
                case Characteristic.Agility:
                    return OptionalAgiCost;
                    break;
                case Characteristic.Dexterity:
                    return OptionalDexCost;
                    break;
                case Characteristic.Constitution:
                    return OptionalConCost;
                    break;
                case Characteristic.WillPower:
                    return OptionalWPCost;
                    break;
                case Characteristic.Power:
                    return OptionalPowCost;
                    break;
                default:
                    return -1;
            }
        }
    }
}
