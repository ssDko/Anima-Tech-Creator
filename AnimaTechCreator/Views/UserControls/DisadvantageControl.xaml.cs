using AnimaTechCreator.Entities;
using AnimaTechCreator.ViewModels;
using System.Windows.Controls;

namespace AnimaTechCreator.Views.UserControls
{
    /// <summary>
    /// Interaction logic for DisadvantageControl.xaml
    /// </summary>
    public partial class DisadvantageControl : UserControl
    {
        private DisadvantageViewModel viewModel;
        public DisadvantageControl(Disadvantage disadvantage)
        {
            InitializeComponent();

            viewModel = new DisadvantageViewModel(disadvantage);
            DataContext = viewModel;
        }
    }
}
