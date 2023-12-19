/*using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace AnimaTechCreator.Technique
{   

    internal class TechniqueViewModel : INotifyPropertyChanged
    {
        private Technique selectedItem;
    
        protected virtual void OnPropertyChanged(string propertyName)
        {
            switch (propertyName)
            {
                case nameof(SelectedItem):

                    break;

                default: throw new ArgumentException("Invalid property name");
            }

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ObservableCollection<Technique> Techniques { get; set; } = new ObservableCollection<Technique>();
        public Technique SelectedItem
        {
            get { return selectedItem; }
            set
            {
                if (selectedItem != value)
                {
                    selectedItem = value;
                    OnPropertyChanged(nameof(SelectedItem));
                }
            }
        }        

        public ObservableCollection<int> AvailableLevels { get; } = new ObservableCollection<int> { 1, 2, 3 };

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
*/