using AnimaTechCreator.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimaTechCreator.Entities
{
    public class Technique
    {
        private Enums.Level level = Enums.Level.One;
        
        public string Name { get; set; } = "";
        public Enums.Level Level { get { return level; } set { ChangeLevel(value);} } 
        public bool Maintained { get; set; } = false;
        public bool Sustained { get; set; } = false;
        public bool Combinable { get; set; } = false;
        public Effect PrimaryEffect { get; set; } = null;
        public List<Effect> SecondaryEffects { get; } = new List<Effect>();
        public List<Disadvantage> Disadvantages { get; } = new List<Disadvantage>();

        public Technique(
            string name, 
            Enums.Level level, 
            bool maintained, 
            bool sustained, 
            bool combinable, 
            Effect primaryEffect, 
            List<Effect> secondaryEffects, 
            List<Disadvantage> disadvantages)
        {
            Name = name;
            Level = level;
            Maintained = maintained;
            Sustained = sustained;
            Combinable = combinable;
            PrimaryEffect = primaryEffect;
            SecondaryEffects = secondaryEffects;
            Disadvantages = disadvantages;
        }

        public void RemoveSecondaryEffect(int index) { SecondaryEffects.RemoveAt(index); }

        public void RemoveDisadvantage(int index) {  Disadvantages.RemoveAt(index); }

        public void ChangeLevel(Enums.Level newLevel) 
        {
            if (level == newLevel) return;

            //Remove any Effects and Disadvantages that aren't the proper level
            if (PrimaryEffect.MinimumLevel > newLevel)
                PrimaryEffect = null;

            SecondaryEffects.RemoveAll(effect => effect.MinimumLevel > newLevel);
            Disadvantages.RemoveAll(disadvantage => disadvantage.MinimumLevel > newLevel);

            level = newLevel;
        }

    }
}
