
using AnimaTechCreator.Common;
using AnimaTechCreator.Entities;
using CommunityToolkit.Mvvm.ComponentModel;
using System;

namespace AnimaTechCreator.ViewModels
{
    public partial class DisadvantageViewModel : ObservableObject
    {
        [ObservableProperty]
        private Disadvantage disadvantage;
        

        public DisadvantageViewModel(Disadvantage disadvantage)
        {
            this.disadvantage = disadvantage ?? throw new ArgumentNullException(nameof(disadvantage));
        }
    }
}
