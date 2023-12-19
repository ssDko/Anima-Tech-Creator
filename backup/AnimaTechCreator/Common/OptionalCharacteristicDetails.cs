using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimaTechCreator.Common
{
    public class OptionalCharacteristicDetails
    {        
        public OptionalCharacteristic OptionalCharacteristic { get; }
        public int PointCost { get; set; } = 0;
        public int TotalCost { 
            get 
            { 
                int cost = 0;

                if (PointCost > 0) { cost = PointCost + OptionalCharacteristic.AddedCost; }

                return cost;
            } 
        }
        public OptionalCharacteristicDetails(OptionalCharacteristic optionalCharacteristic)
        {
            OptionalCharacteristic = optionalCharacteristic;
        }
    }
}
