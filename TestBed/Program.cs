using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EffectLibrary;

using System.Runtime.Serialization;
using System.IO;

namespace TestBed
{
    class Program
    {
        static void Main(string[] args)
        {

            var serializer = new DataContractSerializer(typeof(Effect));

            var testEffect = new Effect();
            
            var testAdvantStat = new OptionalAdvantageStatLine("Test", 1, 2, 3, 4, 5);
            var testAdvantage = new OptionalAdvantage("I'm Optional", testAdvantStat);

            testEffect.AddAdvantage(testAdvantage);




            using (FileStream writer = new FileStream("Test.xml", FileMode.Create))
            {
                serializer.WriteObject(writer, testEffect);
            }     

            

            
            
        }
    }
}
