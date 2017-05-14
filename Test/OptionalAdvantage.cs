using System.Collections.Generic;
using System.Runtime.Serialization;

namespace EffectLibrary
{
    [DataContract]
    public class OptionalAdvantage
    {
        //Variables
        private string name = "";
        private List<OptionalAdvantageStatLine> statLineList;

        //Accessors
        [DataMember]
        public string Name { get => name; set => name = value; }
        [DataMember(EmitDefaultValue = false)]
        public List<OptionalAdvantageStatLine> StatLineList { get => statLineList; set => statLineList = value; }

        //Constructor(s)
        public OptionalAdvantage()
        {
            statLineList = new List<OptionalAdvantageStatLine>();
        }

        public OptionalAdvantage(string name)
        {
            statLineList = new List<OptionalAdvantageStatLine>();
            this.name = name;
        }

        public OptionalAdvantage(string name, OptionalAdvantageStatLine optionalStat)
        {
            this.statLineList = new List<OptionalAdvantageStatLine>();
            this.name = name;
            this.statLineList.Add(optionalStat);
        }

        public OptionalAdvantage(string name, List<OptionalAdvantageStatLine> newStatList)
        {
            this.statLineList = new List<OptionalAdvantageStatLine>();
            this.name = name;
            AddListOfStats(newStatList);
        }

        public OptionalAdvantage(string name, string advantageName, int cost, int martialKnowlegeCost, int maintenance, int minorSustenance, int greatorSustenance)
        {
            OptionalAdvantageStatLine statTemp = new OptionalAdvantageStatLine(advantageName, cost, martialKnowlegeCost, maintenance, minorSustenance, greatorSustenance);
            statLineList = new List<OptionalAdvantageStatLine>();
            statLineList.Add(statTemp);
            this.name = name;            
        }

        //Methods       
        public override string ToString()
        {
            string returnValue = "";
            returnValue += ("Name: " + name + "\n");
            foreach (var stat in statLineList)
            {
                returnValue += (stat.Name +
                                ": Cost(" + stat.Cost +
                                "), MK(" + stat.MartialKnowlegeCost + 
                                "), Maint(" + stat.Maintenance + 
                                ") MiS(" + stat.MinorSustenance +
                                ") GiS(" + stat.GreatorSustenance + ")\n"
                               );
            }

            return returnValue;
        }

        public void AddStat(OptionalAdvantageStatLine newStat)
        {
            statLineList.Add(newStat);
        }

        public void AddListOfStats(List<OptionalAdvantageStatLine> newStatList)
        {
            foreach (var statLine in newStatList)
            {
                statLineList.Add(statLine);
            }
        }

        public void ReplaceListOfStats(List<OptionalAdvantageStatLine> newStatList)
        {
            statLineList = newStatList;
        }

        /// <summary>
        /// Removes a Optional Stat line at a given index.  
        /// </summary>
        /// <param name="index"> The index to be removed</param>
        /// <returns>Returns True if the removal was successfull, false otherwise.</returns>
        public bool RemoveStatAt(int index)
        {
            try
            {
                statLineList.RemoveAt(index);
            }
            catch
            {
                
                return false;
            }
            return true;
        }
        
        public OptionalAdvantage CopyAdvantage()
        {
            var newAdvantage = new OptionalAdvantage();
            newAdvantage.name = name;

            foreach (var statLine in statLineList)
            {
                newAdvantage.AddStat(statLine.CopyStatLine());
            }

            return newAdvantage;

        }
    }
}
