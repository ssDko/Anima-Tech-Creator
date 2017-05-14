using System.Runtime.Serialization;
namespace EffectLibrary
{
    [DataContract]
    public class OptionalAdvantageStatLine
    {
        //Variables
        private string name = "";
        private int cost = 0;
        private int martialKnowlegeCost = 0;
        private int maintenance = 0;
        private int minorSustenance = 0;
        private int greatorSustenance = 0;

        //Accessors
        [DataMember]
        public string Name { get => name; set => name = value; }
        [DataMember]
        public int Cost { get => cost; set => cost = value; }
        [DataMember]
        public int MartialKnowlegeCost { get => martialKnowlegeCost; set => martialKnowlegeCost = value; }
        [DataMember]
        public int Maintenance { get => maintenance; set => maintenance = value; }
        [DataMember]
        public int MinorSustenance { get => minorSustenance; set => minorSustenance = value; }
        [DataMember]
        public int GreatorSustenance { get => greatorSustenance; set => greatorSustenance = value; }

        
        //Constructor(s)
        public OptionalAdvantageStatLine()
        {
        }
        
        public OptionalAdvantageStatLine(string name, int cost, int martialKnowlegeCost, int maintenance, int minorSustenance, int greatorSustenance)
        {
            this.name = name;
            this.cost = cost;
            this.martialKnowlegeCost = martialKnowlegeCost;
            this.maintenance = maintenance;
            this.minorSustenance = minorSustenance;
            this.greatorSustenance = greatorSustenance;
        }

        public override string ToString()
        {
            return (name + " (Cost: " + cost + 
                           ", MK: " + martialKnowlegeCost + 
                           ", Maint: " + maintenance + 
                           ", MiS: " + minorSustenance + 
                           ", GiS: " + greatorSustenance + ")");
        }

        public OptionalAdvantageStatLine CopyStatLine()
        {
            var statLineTemp = new OptionalAdvantageStatLine();

            statLineTemp.name = name;
            statLineTemp.cost = cost;
            statLineTemp.martialKnowlegeCost = martialKnowlegeCost;
            statLineTemp.maintenance = maintenance;
            statLineTemp.minorSustenance = minorSustenance;
            statLineTemp.greatorSustenance = greatorSustenance;

            return statLineTemp;
        }

    }

}
