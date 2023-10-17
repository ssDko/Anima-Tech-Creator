
using System;
using System.Windows;
using AnimaTechCreator.Technique;

namespace AnimaTechCreator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TechniqueViewModel techniqueViewModel {  get; set; }
        public MainWindow()
        {
            techniqueViewModel = new TechniqueViewModel();
            Technique.Technique T1 = new Technique.Technique { Name = "Test1", Level = Levels.LevelNum.One, Maintained= false, Combinable=true, Sustained=false};
            Technique.Technique T2 = new Technique.Technique { Name = "Test1", Level = Levels.LevelNum.Two, Maintained = true, Combinable = false, Sustained = false };
            Technique.Technique T3 = new Technique.Technique { Name = "Test1", Level = Levels.LevelNum.Three, Maintained = false, Combinable = false, Sustained = true };


            techniqueViewModel.Techniques.Add(T1);
            techniqueViewModel.Techniques.Add(T2);
            techniqueViewModel.Techniques.Add(T3);


            DataContext = techniqueViewModel;
            InitializeComponent();


        }
    }
}
