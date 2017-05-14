using System;
using System.Runtime.Serialization;
namespace EffectLibrary
{
    [DataContract]
    public class EffectStatLine  
    {
        //Variables
        private String bonus = "";
        private int primaryKiCost = 0;
        private int secondaryKiCost = 0;
        private int martialKnowlegeCost = 0;
        private int maintenance = 0;
        private int minorSustenance = 0;
        private int greatorSustenance = 0;
        private int powerLevel = 1;

        //Accessors
        [DataMember]
        public string Bonus { get => bonus; set => bonus = value; }
        [DataMember]
        public int PrimaryKiCost { get => primaryKiCost; set => primaryKiCost = value; }
        [DataMember]
        public int SecondaryKiCost { get => secondaryKiCost; set => secondaryKiCost = value; }
        [DataMember]
        public int MartialKnowlegeCost { get => martialKnowlegeCost; set => martialKnowlegeCost = value; }
        [DataMember]
        public int Maintenance { get => maintenance; set => maintenance = value; }
        [DataMember]
        public int MinorSustenance { get => minorSustenance; set => minorSustenance = value; }
        [DataMember]
        public int GreatorSustenance { get => greatorSustenance; set => greatorSustenance = value; }
        [DataMember]
        public int PowerLevel
        {
            get => powerLevel;
            set
            {
                if (value < 0)
                {
                    powerLevel = 0;
                } else if (value > 3)
                {
                    powerLevel = 3;
                }
                else
                {
                    powerLevel = value;
                }
            }
        }

        //Constructor(s)

        public EffectStatLine()
        {
        }

        public EffectStatLine(string bonus, int primaryKiCost, int secondaryKiCost, int martialKnowlegeCost, int maintenance, int minorSustenance, int greatorSustenance, int powerLevel)
        {
            this.bonus = bonus;
            this.primaryKiCost = primaryKiCost;
            this.secondaryKiCost = secondaryKiCost;
            this.martialKnowlegeCost = martialKnowlegeCost;
            this.maintenance = maintenance;
            this.minorSustenance = minorSustenance;
            this.greatorSustenance = greatorSustenance;
            this.PowerLevel = powerLevel;
        }

        public EffectStatLine(EffectStatLine statLine)
        {
            this.bonus = statLine.bonus;
            this.primaryKiCost = statLine.primaryKiCost;
            this.secondaryKiCost = statLine.secondaryKiCost;
            this.martialKnowlegeCost = statLine.martialKnowlegeCost;
            this.maintenance = statLine.maintenance;
            this.minorSustenance = statLine.minorSustenance;
            this.greatorSustenance = statLine.greatorSustenance;
            this.PowerLevel = statLine.powerLevel;
        }
    }
}
