using EffectLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anima_Tech_Creator
{
    public class SecondaryEffectEventArgs : EventArgs
    {

        public Dictionary<Characteristic, int> SecondaryStatTotals { get; private set; }
        public SecondaryEffectEventArgs(Dictionary<Characteristic, int> secondaryStatTotals)
        {
            this.SecondaryStatTotals = secondaryStatTotals;
        }
    }
}
