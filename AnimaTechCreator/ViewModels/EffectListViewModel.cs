

using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace AnimaTechCreator.ViewModels
{
    public partial class EffectListViewModel : ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(SelectedViewCollection))]
        private EffectViewModel? selectedView = null;

        private ObservableCollection<EffectViewModel> selectedViewCollection = new ObservableCollection<EffectViewModel>();

        partial void OnSelectedViewChanged(EffectViewModel? value)
        {
            Debug.WriteLine("here");
            SelectedViewChanged?.Invoke();
        }

        public ObservableCollection<EffectViewModel> EffectViews { get; set; } = new ObservableCollection<EffectViewModel>();

        public ObservableCollection<EffectViewModel> SelectedViewCollection { 
            get {
                selectedViewCollection.Clear();

                if (SelectedView != null) selectedViewCollection.Add(SelectedView);

                return selectedViewCollection;
            } 
        }

        public event Action? SelectedViewChanged;
    }
}
