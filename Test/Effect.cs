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
        private Dictionary<Characteristic, int> optionalStatCosts;

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
        public Dictionary<Characteristic, int> OptionalStatCosts { get => optionalStatCosts; set => optionalStatCosts = value; }
        [DataMember(Order = 4)]
        public Frequency Frequency { get => frequency; set => frequency = value; }
        [DataMember(Order = 5)]
        public ActionType ActionType { get => actionType; set => actionType = value; }
        [DataMember(Order = 6, EmitDefaultValue = false)]
        public List<EffectStatLine> EffectStats { get => effectStats; set => effectStats = value; }
        [DataMember(Order = 7, EmitDefaultValue = false)]
        public List<OptionalAdvantage> OptionalAdvantages { get => optionalAdvantages; set => optionalAdvantages = value; }
        [DataMember(Order = 8, EmitDefaultValue = false)]
        public List<EffectDisadvantage> OptionalDisadvantages { get => optionalDisadvantages; set => optionalDisadvantages = value; }
        [DataMember(Order = 9)]
        public bool Air { get => air; set => air = value; }
        [DataMember(Order = 10)]
        public bool Earth { get => earth; set => earth = value; }
        [DataMember(Order = 11)]
        public bool Fire { get => fire; set => fire = value; }
        [DataMember(Order = 12)]
        public bool Water { get => water; set => water = value; }
        [DataMember(Order = 13)]
        public bool Light { get => light; set => light = value; }
        [DataMember(Order = 14)]
        public bool Darkness { get => darkness; set => darkness = value; }
        

        // Constructor(s)
        public Effect()
        {
            EffectStats = new List<EffectStatLine>();
            OptionalStatCosts = new Dictionary<Characteristic, int>();
            OptionalStatCosts.Add(Characteristic.Strength, 0);
            OptionalStatCosts.Add(Characteristic.Agility, 0);
            OptionalStatCosts.Add(Characteristic.Dexterity, 0);
            OptionalStatCosts.Add(Characteristic.Constitution, 0);
            OptionalStatCosts.Add(Characteristic.WillPower, 0);
            OptionalStatCosts.Add(Characteristic.Power, 0);
            OptionalAdvantages = new List<OptionalAdvantage>();
            OptionalDisadvantages = new List<EffectDisadvantage>();
        }

        public Effect(Effect origional) : this()
        {
            this.Name = origional.Name;
            this.EffectStats = new List<EffectStatLine>(origional.EffectStats);
            this.PrimaryCharacteristic = origional.PrimaryCharacteristic;
            this.OptionalStatCosts = new Dictionary<Characteristic, int>(origional.OptionalStatCosts);
            this.Air = origional.Air;
            this.Earth = origional.Earth;
            this.Fire = origional.Fire;
            this.Water = origional.Water;
            this.Light = origional.Light;
            this.Darkness = origional.Darkness;
            this.Frequency = origional.Frequency;
            this.ActionType = origional.ActionType;
            this.OptionalAdvantages = new List<OptionalAdvantage>(origional.OptionalAdvantages);
            this.OptionalDisadvantages = new List<EffectDisadvantage>(origional.OptionalDisadvantages);
    }


        //methods
        /// <summary>
        /// Adds a stat line level to the effect. Forces the level to be equal or higher then the previous level
        /// </summary>
        /// <param name="newLine">The stat line to add</param>
        /// <returns>Returns true if the stat line has been added successfully. Otherwise false.</returns>
        public bool AddStatLine(EffectStatLine newLine)
        {
            EffectStats.Add(newLine);           


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
                EffectStats.RemoveAt(index);
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
            return EffectStats.Remove(statLine);
        }

        /// <summary>
        /// Adds a optional advantage
        /// </summary>
        /// <param name="newAdvantage">The advantage to add</param>
        public void AddAdvantage(OptionalAdvantage newAdvantage)
        {
            OptionalAdvantages.Add(newAdvantage);            
        }

        public bool RemoveAdvantageAt(int index)
        {
            try
            {
                OptionalAdvantages.RemoveAt(index);
            }
            catch (System.IndexOutOfRangeException)
            {
                return false;
            }

            return true;
        }

        public bool RemoveAdvantage(OptionalAdvantage advantage)
        {
            return OptionalAdvantages.Remove(advantage);
        }

        public void AddDisadvantage(EffectDisadvantage newDisadvantage)
        {
            OptionalDisadvantages.Add(newDisadvantage);
        }

        public bool RemoveDisadvantageAt(int index)
        {
            try
            {
                OptionalDisadvantages.RemoveAt(index);
            }
            catch (System.IndexOutOfRangeException)
            {
                return false;
            }

            return true;
        }

        public bool RemoveDisadvantage(EffectDisadvantage disadvantage)
        {
            return OptionalDisadvantages.Remove(disadvantage);
        }        
    }
}
