using System.Runtime.Serialization;
namespace EffectLibrary
{
    [DataContract]
    public class EffectDisadvantage
    {
        //Variables
        private string name = "";
        private int costReduction = 0;
        private int martialKnowlegeReduction = 0;

        //Accessors
        [DataMember]
        public string Name { get => name; set => name = value; }
        [DataMember]
        public int CostReduction { get => costReduction; set => costReduction = value; }
        [DataMember]
        public int MartialKnowlegeReduction { get => martialKnowlegeReduction; set => martialKnowlegeReduction = value; }

        //constructor(s)
        public EffectDisadvantage()
        {
        }

        public EffectDisadvantage(string name, int costReduction, int martialKnowlegeReduction)
        {
            this.name = name;
            this.costReduction = costReduction;
            this.martialKnowlegeReduction = martialKnowlegeReduction;
        }
    }
}
