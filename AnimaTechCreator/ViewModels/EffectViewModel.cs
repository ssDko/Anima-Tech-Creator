
using AnimaTechCreator.Common;
using AnimaTechCreator.Entities;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;

namespace AnimaTechCreator.ViewModels
{
    public partial class EffectViewModel : ObservableObject
    {
        private Effect effect;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(CurrentKiCost))]
        private ObservableCollection<OptionalCharacteristicDetailsViewModel> observableOptionalCharacteristicDetailsViewModels = 
            new ObservableCollection<OptionalCharacteristicDetailsViewModel>();

        [ObservableProperty]
        private bool isPrimary = false;

        public string Name => effect.Name;
        public int PrimaryKiCost => effect.PrimaryKiCost;
        public int SecondaryKiCost => effect.SecondaryKiCost;
        public int MkCost => effect.MkCost;
        public int MaintenanceCost => effect.MaintenanceCost;
        public int MinorSustinanceCost => effect.MinorSustinanceCost;
        public int GreatorSustinanceCost => effect.GreatorSustinanceCost;
        public List<OptionalCharacteristic> OptionalCharacteristics => effect.OptionalCharacteristics;
        public List<Enums.Element> Elements => effect.Elements;
        public List<EffectOption> EffectOptions => effect.EffectOptions;
        public Enums.Characteristic PrimaryCharacteristic => effect.PrimaryCharacteristic;
        public Enums.Frequency Frequency => effect.Frequency;
        public Enums.ActionType ActionType => effect.ActionType;
        public Enums.Level MinimumLevel => effect.MinimumLevel;

        public int MinimumLevelInt => (int)MinimumLevel;
 
        public EffectViewModel(Effect effect, bool isPrimary = false)
        {
            this.effect = effect ?? throw new ArgumentNullException(nameof(effect));

            IsPrimary = isPrimary;
            // Populate the ObservableCollection from the Effect's data
            foreach (var details in effect.OptionalCharacteristicDetails)
            {
                var viewModel = new OptionalCharacteristicDetailsViewModel(details);
                viewModel.PropertyChanged += OptionalCharacteristicDetailsViewModel_PropertyChanged;
                ObservableOptionalCharacteristicDetailsViewModels.Add(viewModel);
            }

            ObservableOptionalCharacteristicDetailsViewModels.CollectionChanged += OptionalCharacteristicDetailsViewModels_CollectionChanged;
        }

        private void OptionalCharacteristicDetailsViewModel_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(OptionalCharacteristicDetailsViewModel.PointCost))
                OnPropertyChanged(nameof(CurrentKiCost));
        }

        private void OptionalCharacteristicDetailsViewModels_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
        {            

            // Handle added items
            if (args.NewItems != null)
            {
                foreach (OptionalCharacteristicDetailsViewModel newItem in args.NewItems)
                {
                    effect.OptionalCharacteristicDetails.Add(newItem.OptionalCharacteristicDetails);
                    newItem.PropertyChanged += OptionalCharacteristicDetailsViewModel_PropertyChanged;
                }
            }

            // Handle removed items
            if (args.OldItems != null)
            {
                foreach (OptionalCharacteristicDetailsViewModel oldItem in args.OldItems)
                {
                    effect.OptionalCharacteristicDetails.Remove(oldItem.OptionalCharacteristicDetails);
                    oldItem.PropertyChanged -= OptionalCharacteristicDetailsViewModel_PropertyChanged;
                }
            }
        }

        public int KiCost
        {
            get => IsPrimary ? PrimaryKiCost : SecondaryKiCost;
            
        }

        public int CurrentKiCost
        { 
            get
            {
                int kiCost = KiCost;

                foreach (var details in ObservableOptionalCharacteristicDetailsViewModels)
                    kiCost -= details.PointCost;

                return kiCost;
            }
        }
    }
}
