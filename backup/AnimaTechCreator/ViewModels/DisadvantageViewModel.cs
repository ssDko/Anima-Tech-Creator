
using AnimaTechCreator.Common;
using AnimaTechCreator.Entities;
using CommunityToolkit.Mvvm.ComponentModel;
using System;

namespace AnimaTechCreator.ViewModels
{
    public partial class DisadvantageViewModel : ObservableObject
    {
        private Disadvantage disadvantage;

        public string Name => disadvantage.Name;
        public int MkReduction => disadvantage.MkReduction;
        public Enums.Level MinimumLevel => disadvantage.MinimumLevel;
        public Enums.ActionType ActionType => disadvantage.ActionType;

        public DisadvantageViewModel(Disadvantage disadvantage)
        {
            this.disadvantage = disadvantage ?? throw new ArgumentNullException(nameof(disadvantage));
        }

    }
}
