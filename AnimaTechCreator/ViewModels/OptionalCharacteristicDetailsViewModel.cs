using AnimaTechCreator.Common;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.Specialized;


namespace AnimaTechCreator.ViewModels
{
    public class OptionalCharacteristicDetailsViewModel : ObservableObject
    {

        public OptionalCharacteristicDetails OptionalCharacteristicDetails { get;}

        public OptionalCharacteristic OptionalCharacteristic => OptionalCharacteristicDetails.OptionalCharacteristic;
        
        public int PointCost
        {
            get => OptionalCharacteristicDetails.PointCost;
            set 
            {
                if (OptionalCharacteristicDetails.PointCost == value)
                    return;

                OptionalCharacteristicDetails.PointCost = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(TotalCost));

            }
        }

        public int TotalCost => OptionalCharacteristicDetails.TotalCost;       

        public OptionalCharacteristicDetailsViewModel(OptionalCharacteristicDetails optionalCharacteristicDetails)
        {
            OptionalCharacteristicDetails = optionalCharacteristicDetails;
        }
    }
}
