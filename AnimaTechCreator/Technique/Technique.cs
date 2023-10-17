using System;
using System.ComponentModel;
using Xceed.Wpf.Toolkit.Primitives;

namespace AnimaTechCreator.Technique
{    
    internal class Technique : INotifyPropertyChanged
    {
        private string name = "";
        private Levels.LevelNum level = Levels.LevelNum.One;
        private bool maintained = false;
        private bool combinable = false;
        private bool sustained = false;


        private void UpdateCheckboxesEnabled()
        {
            OnPropertyChanged(nameof(MaintainedEnabled));
            OnPropertyChanged(nameof(CombineableEnabled));
            OnPropertyChanged(nameof(SustainedEnabled));
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public Levels.LevelNum Level { 
            get { return level; } 
            set {
                if (level != value)
                {
                    level = value;
                    OnPropertyChanged(nameof(Level));
                    UpdateCheckboxesEnabled();
                }

            } }
        public int LevelInt { 
            get {          
                return (int) level; }
            set
            {                
                if (value < 1 || value > 3)
                    throw new ArgumentOutOfRangeException(nameof(Level));

                Level = (Levels.LevelNum)value;
                
            }
        }
        public bool Maintained
        {
            get { return maintained; }
            set
            {
                if (maintained != value)
                {
                    maintained = value;
                    OnPropertyChanged(nameof(Maintained));
                    UpdateCheckboxesEnabled();

                }
            }
        }

        public bool Combinable
        {
            get { return combinable; }
            set
            {
                if (combinable != value)
                {
                    combinable = value;
                    OnPropertyChanged(nameof(Combinable));
                    UpdateCheckboxesEnabled();
                }
            }
        }
        
        public bool Sustained
        {
            get { return sustained; }
            set
            {
                if (sustained != value)
                {
                    sustained = value;
                    OnPropertyChanged(nameof(Sustained));
                    UpdateCheckboxesEnabled();
                }
            }
        }


        public Levels.Level LevelData
        {
            get
            {
                return Levels.GetLevel(LevelInt - 1);
            }
        }
        public string MinMKDisplayValue
        {
            get
            {                
                return "Min MK: " + LevelData.MinMk;
            }
        }

        public string MaxMKDisplayValue
        {
            get
            {
                return "Max MK: " + LevelData.MaxMk;
            }
        }

        public string MaxDisadvantages
        {
            get
            {
                return "Max Disadvantages: " + LevelData.MaxDisadvantages;
            }
        }

        public bool MaintainedEnabled
        {
            get { return !Sustained; }
        }

        public bool CombineableEnabled
        {
            get { return true; }
        }

        public bool SustainedEnabled
        {
            get { return !Maintained && LevelInt > 1; }
        }        

        public string GetLevelStr(bool numrical = true)
        {
            if (numrical)
                return LevelInt.ToString();
            return level.ToString();
            
        }
        
        
    }
}
