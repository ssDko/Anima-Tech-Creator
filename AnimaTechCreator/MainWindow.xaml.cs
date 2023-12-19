using AnimaTechCreator.Common;
using AnimaTechCreator.Entities;
using AnimaTechCreator.Models;
using AnimaTechCreator.ViewModels;
using AnimaTechCreator.Views.UserControls;
using System.Diagnostics;
using System.Windows;


namespace AnimaTechCreator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            

            InitializeComponent();

            List<Effect> effects = new List<Effect>();
            List<OptionalCharacteristic> charList1 = new List<OptionalCharacteristic>()
            {
                new OptionalCharacteristic(Enums.Characteristic.Dexterity, 1),
                new OptionalCharacteristic(Enums.Characteristic.Perception,2)
            };

            List<OptionalCharacteristic> charList2 = new List<OptionalCharacteristic>()
            {
                new OptionalCharacteristic(Enums.Characteristic.Strength, 1),
                new OptionalCharacteristic(Enums.Characteristic.Constitution,2),
                new OptionalCharacteristic(Enums.Characteristic.Agility,3)
            };

            Effect effect1 = new Effect (new EffectModel(
                "effect1",
                1,
                2,
                1,
                1,
                1,
                1,
                charList1,
                new List<Enums.Element> {Enums.Element.Air, Enums.Element.Fire, Enums.Element.Earth, Enums.Element.Fire },
                new List<EffectOption> { new EffectOption("option 1") },
                Enums.Characteristic.Strength,
                Enums.Frequency.Action,
                Enums.ActionType.Attack,
                Enums.Level.One
            ));

            Effect effect2 = new Effect(new EffectModel(
                "effect2",
                2,
                3,
                4,
                5,
                6,
                7,
                charList2,
                new List<Enums.Element> { Enums.Element.Darkness, Enums.Element.Light },
                new List<EffectOption> { new EffectOption("effect 2"), new EffectOption("effect 3", 1,2,3,4,5, true) },
                Enums.Characteristic.Constitution,
                Enums.Frequency.Mixed,
                Enums.ActionType.Counterattack,
                Enums.Level.Three
            ));

            effects.Add(effect1);
            effects.Add(effect2);
            
            EffectControl effectControl = new EffectControl(effects, false);
            
            this.TestGrid.Children.Add(effectControl);
        }
    }
}