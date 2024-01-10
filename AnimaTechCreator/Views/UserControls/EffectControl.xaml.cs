using AnimaTechCreator.Common;
using AnimaTechCreator.Entities;
using AnimaTechCreator.ViewModels;
using HandyControl.Controls;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;


namespace AnimaTechCreator.Views.UserControls
{
    /// <summary>
    /// Interaction logic for EffectControl.xaml
    /// </summary>
    public partial class EffectControl : UserControl
    {
        private EffectListViewModel? viewModel;
        
        public EffectControl(List<Effect> Effects, bool isPrimary = false, int selectedIndex = -1)
        {
            InitializeComponent();
            if (Effects is null) return;
            if (Effects.Count == 0) return;

            // This looks complicated but it just sets up of viewModel so everything updates properly on the control
            ObservableCollection<EffectViewModel> viewModels = new ObservableCollection<EffectViewModel>();
            viewModel = new EffectListViewModel();
            foreach (Effect effect in Effects)
                viewModel.EffectViews.Add(new EffectViewModel(effect, isPrimary));            
            
            DataContext = viewModel;

            //Setup after the control loads

            this.Loaded += (sender, args) =>
            {
                //Setup events
                if (DataContext is EffectListViewModel vm)
                    vm.SelectedViewChanged += UpdateKiCostsGrid;

                // Select our initial effect
                viewModel.SelectedView = viewModel.EffectViews[0];
                if (selectedIndex > -1)
                    viewModel.SelectedView = viewModel.EffectViews[selectedIndex];
            };

            this.Unloaded += (sender, args) =>
            {
                //Remove events
                if (DataContext is EffectListViewModel vm)
                    vm.SelectedViewChanged -= UpdateKiCostsGrid;
            };           

        }
        
        private void UpdateKiCostsGrid()
        {
            if (viewModel is null || viewModel.SelectedView is null) return;

            KiCostGrid.ColumnDefinitions.Clear();
            KiCostGrid.Children.Clear();

            // First setup
            if (KiCostGrid.RowDefinitions.Count != 2)
            {
                RowDefinition costHeadersRow = new RowDefinition();
                RowDefinition dataRow = new RowDefinition();


                KiCostGrid.RowDefinitions.Add(costHeadersRow);
                KiCostGrid.RowDefinitions.Add(dataRow);
            }


            for (int i = 0; i < viewModel.SelectedView.OptionalCharacteristics.Count + 1; i++)
            {
                CreateKiCostColumn(i);
            }
        }

        private void CreateKiCostColumn(int index)
        {
            const int HEADER_ROW = 0;
            const int DATA_ROW = 1;
            if (viewModel is null || viewModel.SelectedView is null) return;

            bool isPrimary = index == 0;
            string headerStr = (isPrimary ?
                viewModel.SelectedView.PrimaryCharacteristic.ToString() :
                viewModel.SelectedView.OptionalCharacteristics[index - 1].Characteristic.ToString() ?? "Null");

            string optionalCharacteristicPath = "ObservableOptionalCharacteristicDetailsViewModels[" + (index - 1) + "]";

            string totalCostPath = (isPrimary ?
                "CurrentKiCost" :
                optionalCharacteristicPath + ".TotalCost"
                );

            int gridIndex = index * 2;


            if (viewModel is null || viewModel.SelectedView is null) return;
            ColumnDefinition columnOne = new ColumnDefinition();
            columnOne.Width = GridLength.Auto;
            ColumnDefinition columnTwo = new ColumnDefinition();
            columnOne.Width = GridLength.Auto;
            KiCostGrid.ColumnDefinitions.Add(columnOne);
            KiCostGrid.ColumnDefinitions.Add(columnTwo);

            //Create header
            TextBlock header = new TextBlock();
            header.Text = headerStr;
            header.HorizontalAlignment = HorizontalAlignment.Center;
            header.FontWeight = FontWeights.Bold;

            Grid.SetColumn(header, gridIndex);
            Grid.SetRow(header, HEADER_ROW);
            Grid.SetColumnSpan(header, 2);

            KiCostGrid.Children.Add(header);

            if (!isPrimary)
            {
                NumericUpDown numericUpDown = new NumericUpDown();
                numericUpDown.Minimum = 0;
                numericUpDown.Maximum = 100;

                Binding numUpDownBinding = new Binding
                {
                    Source = viewModel.SelectedView,
                    Path = new PropertyPath(optionalCharacteristicPath + ".PointCost"),
                    Mode = BindingMode.TwoWay
                };
                numericUpDown.SetBinding(NumericUpDown.ValueProperty, numUpDownBinding);
                numericUpDown.ValueChanged += OnKiCostNumericChanged;
                Grid.SetColumn(numericUpDown, gridIndex);
                Grid.SetRow(numericUpDown, DATA_ROW);

                KiCostGrid.Children.Add(numericUpDown);
            }


            //Create cost display
            TextBlock display = new TextBlock();
            display.HorizontalAlignment = (isPrimary ? HorizontalAlignment.Center : HorizontalAlignment.Left);
            display.VerticalAlignment = VerticalAlignment.Center;
            Binding textBinding = new Binding
            {
                Source = viewModel.SelectedView,
                Path = new PropertyPath(totalCostPath),
                Mode = BindingMode.OneWay,
            };

            display.SetBinding(TextBlock.TextProperty, textBinding);

            Grid.SetColumn(display, (isPrimary ? gridIndex : gridIndex + 1));
            Grid.SetRow(display, DATA_ROW);

            if (isPrimary) Grid.SetColumnSpan(display, 2);

            KiCostGrid.Children.Add(display);
        }

        private void OnKiCostNumericChanged(object? sender, HandyControl.Data.FunctionEventArgs<double> e)
        {            
            if (viewModel is null) return;

            var selectedView = viewModel.SelectedView;

            if (selectedView is null || selectedView.CurrentKiCost >= 0) return;

            NumericUpDown? numericUpDown = e.Source as NumericUpDown;
            if (numericUpDown is null) return;
            numericUpDown.Value = e.Info - 1;
        }
    }
}
