using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EffectLibrary;

namespace Anima_Tech_Creator
{
    public partial class SecondaryEffect : UserControl
    {
        List<Effect> effects;
        Effect selectedEffect;
        EffectStatLine selectedStats;
        private Dictionary<NumericUpDown, Label> statLabelControlDict = new Dictionary<NumericUpDown, Label>();
        private Dictionary<NumericUpDown, TextBox> statTextBoxControlDict = new Dictionary<NumericUpDown, TextBox>();
        private Dictionary<NumericUpDown, Characteristic> statCharacteristicDict = new Dictionary<NumericUpDown, Characteristic>();
        private Dictionary<Characteristic, int> secondaryStatTotals = new Dictionary<Characteristic, int>();

        private int currentMainKiCost = 0;
        private int currentModKiCost = 0;

        public Dictionary<Characteristic, int> SecondaryStatTotals { get => secondaryStatTotals; }

        // Events
        public event EventHandler ValuesUpdated;
        public void OnValuesChanged(SecondaryEffectEventArgs e)
        {
            EventHandler valuesUpdated = ValuesUpdated;
            if (valuesUpdated != null)
            {
                valuesUpdated(this, e);
            }
        }

        // Constructor
        public SecondaryEffect(List<Effect> newEffects)
        {
            InitializeComponent();
            effects= newEffects;
        }

        private void SecondaryEffect_Load(object sender, EventArgs e)
        {
            //We want to associate our num up down controls to many things. 
            statLabelControlDict.Add(numUDStr, lblStrTotal);
            statLabelControlDict.Add(numUDAgi, lblAgiTotal);
            statLabelControlDict.Add(numUDDex, lblDexTotal);
            statLabelControlDict.Add(numUDCon, lblConTotal);
            statLabelControlDict.Add(numUDWP, lblWPTotal);
            statLabelControlDict.Add(numUDPow, lblPowTotal);

            statTextBoxControlDict.Add(numUDStr, txtBoxStrOptionalCost);
            statTextBoxControlDict.Add(numUDAgi, txtBoxAgiOptionalCost);
            statTextBoxControlDict.Add(numUDDex, txtBoxDexOptionalCost);
            statTextBoxControlDict.Add(numUDCon, txtBoxConOptionalCost);
            statTextBoxControlDict.Add(numUDWP, txtBoxWPOptionalCost);
            statTextBoxControlDict.Add(numUDPow, txtBoxPowOptionalCost);

            statCharacteristicDict.Add(numUDStr, Characteristic.Strength);
            statCharacteristicDict.Add(numUDAgi, Characteristic.Agility);
            statCharacteristicDict.Add(numUDDex, Characteristic.Dexterity);
            statCharacteristicDict.Add(numUDCon, Characteristic.Constitution);
            statCharacteristicDict.Add(numUDWP, Characteristic.WillPower);
            statCharacteristicDict.Add(numUDPow, Characteristic.Power);

            secondaryStatTotals.Add(Characteristic.Strength, 0);
            secondaryStatTotals.Add(Characteristic.Agility, 0);
            secondaryStatTotals.Add(Characteristic.Dexterity, 0);
            secondaryStatTotals.Add(Characteristic.Constitution, 0);
            secondaryStatTotals.Add(Characteristic.WillPower, 0);
            secondaryStatTotals.Add(Characteristic.Power, 0);

            // Populate the effect list control
            foreach (Effect effect in effects)
            {
                cBoxEffectList.Items.Add(effect.Name);
            }
            cBoxEffectList.SelectedIndex = 0;

            
        }

        private void UpdateBonusControls()
        {
            UpdateKiCosts();
            UpdateSecondaryStatControls();
        }

        private void SelectEffect()
        {
            selectedEffect = new Effect(effects[cBoxEffectList.SelectedIndex]);
        }

        private void PopulateEffectControls()
        {
            // Select the current effect based on what we selected 
            SelectEffect();

            // Add each selectable Bonus
            cmbBoxEffectBonuses.Items.Clear();
            foreach (EffectStatLine stat in selectedEffect.EffectStats)
            {
                cmbBoxEffectBonuses.Items.Add(stat.Bonus);
            }

            cmbBoxEffectBonuses.Enabled = true;
            cmbBoxEffectBonuses.SelectedIndex = 0;

            PopulateBonusControls();
        }

        private void PopulateBonusControls()
        {
            SelectStats();
            UpdateKiCosts();

            lblStr.Text = "Str";
            lblAgi.Text = "Agi";
            lblDex.Text = "Dex";
            lblCon.Text = "Con";
            lblWP.Text = "WP";
            lblPow.Text = "Pow";



            //Show stat bonuses
            txtBoxStrOptionalCost.Text =
                selectedEffect.OptionalStatCosts[Characteristic.Strength].ToString();
            txtBoxAgiOptionalCost.Text =
                selectedEffect.OptionalStatCosts[Characteristic.Agility].ToString();
            txtBoxDexOptionalCost.Text =
                selectedEffect.OptionalStatCosts[Characteristic.Dexterity].ToString();
            txtBoxConOptionalCost.Text =
                selectedEffect.OptionalStatCosts[Characteristic.Constitution].ToString();
            txtBoxWPOptionalCost.Text =
                selectedEffect.OptionalStatCosts[Characteristic.WillPower].ToString();
            txtBoxPowOptionalCost.Text =
                selectedEffect.OptionalStatCosts[Characteristic.Power].ToString();


            //Reenable all stat numUD boxes
            numUDStr.Enabled = true;
            numUDAgi.Enabled = true;
            numUDDex.Enabled = true;
            numUDCon.Enabled = true;
            numUDWP.Enabled = true;
            numUDPow.Enabled = true;

            numUDStr.Value = 0;
            numUDAgi.Value = 0;
            numUDDex.Value = 0;
            numUDCon.Value = 0;
            numUDWP.Value = 0;
            numUDPow.Value = 0;

            //Disable the ones that have a 0 for an aditional cost
            foreach (KeyValuePair<Characteristic, int> entry in selectedEffect.OptionalStatCosts)
            {
                if (entry.Value == 0)
                {
                    switch (entry.Key)
                    {
                        case Characteristic.Strength:
                            numUDStr.Enabled = false;
                            break;
                        case Characteristic.Agility:
                            numUDAgi.Enabled = false;
                            break;
                        case Characteristic.Dexterity:
                            numUDDex.Enabled = false;
                            break;
                        case Characteristic.Constitution:
                            numUDCon.Enabled = false;
                            break;
                        case Characteristic.WillPower:
                            numUDWP.Enabled = false;
                            break;
                        case Characteristic.Power:
                            numUDPow.Enabled = false;
                            break;
                        default:
                            MessageBox.Show("Should not be here: File (Tech Creator.cs), Line: 198)");
                            break;
                    }
                }
            }


            //Display the primary stat ki cost
            UpdateSecondaryStatControls();
        }

        private void SelectStats()
        {
            selectedStats = selectedEffect.EffectStats[cmbBoxEffectBonuses.SelectedIndex];
        }

        private void UpdateKiCosts()
        {
            // currentMainKiCost is based on if this is a secondary effect or not
            currentMainKiCost = selectedStats.SecondaryKiCost;

            currentModKiCost = currentMainKiCost - (int)(numUDStr.Value + numUDAgi.Value +
                                                         numUDDex.Value + numUDCon.Value +
                                                         numUDWP.Value + numUDPow.Value);
        }

        private void UpdateSecondaryStatControls()
        {

            foreach (NumericUpDown control in panelSecondaryEffect.Controls.OfType<NumericUpDown>())
            {
                int optionaCost = selectedEffect.OptionalStatCosts[statCharacteristicDict[control]];
                // Set the label for every stat accordingly
                if (control.Value != 0)
                {
                    int totalCost = (int)control.Value + optionaCost;
                    statLabelControlDict[control].Text = totalCost.ToString();

                    secondaryStatTotals[statCharacteristicDict[control]] = totalCost;                    
                }
                else
                {
                    statLabelControlDict[control].Text = "0";
                    secondaryStatTotals[statCharacteristicDict[control]] = 0;
                }
            }


            string strPrimaryStat = currentModKiCost.ToString() + "/" + currentMainKiCost.ToString();
            switch (selectedEffect.PrimaryCharacteristic)
            {
                case Characteristic.Strength:
                    lblStrTotal.Text = strPrimaryStat;
                    lblStr.Text = "*STR*";
                    numUDStr.Enabled = false;
                    secondaryStatTotals[Characteristic.Strength] = currentModKiCost;
                    break;
                case Characteristic.Agility:
                    lblAgiTotal.Text = strPrimaryStat;
                    lblAgi.Text = "*AGI*";
                    numUDAgi.Enabled = false;
                    secondaryStatTotals[Characteristic.Agility] = currentModKiCost;
                    break;
                case Characteristic.Dexterity:
                    lblDexTotal.Text = strPrimaryStat;
                    lblDex.Text = "*DEX*";
                    numUDDex.Enabled = false;
                    secondaryStatTotals[Characteristic.Dexterity] = currentModKiCost;
                    break;
                case Characteristic.Constitution:
                    lblConTotal.Text = strPrimaryStat;
                    lblCon.Text = "*CON*";
                    numUDCon.Enabled = false;
                    secondaryStatTotals[Characteristic.Constitution] = currentModKiCost;
                    break;
                case Characteristic.WillPower:
                    lblWPTotal.Text = strPrimaryStat;
                    lblWP.Text = "*WP*";
                    numUDWP.Enabled = false;
                    secondaryStatTotals[Characteristic.WillPower] = currentModKiCost;
                    break;
                case Characteristic.Power:
                    lblPowTotal.Text = strPrimaryStat;
                    lblPow.Text = "*POW*";
                    numUDPow.Enabled = false;
                    secondaryStatTotals[Characteristic.Power] = currentModKiCost;
                    break;
                default:
                    MessageBox.Show("Should not be here: File (Tech Creator.cs), Line: 234");
                    break;

            }

            OnValuesChanged(new SecondaryEffectEventArgs(secondaryStatTotals));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.Parent.Controls.Remove(this);
        }

        private void cmbBoxEffectBonuses_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateBonusControls();
        }

        private void cBoxEffectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateEffectControls();
        }       

        private void numUDStr_ValueChanged(object sender, EventArgs e)
        {
            int previousValue = Int32.Parse(((UpDownBase)sender).Text);
            UpdateBonusControls();

            if (currentModKiCost < 0)
            {
                ((NumericUpDown)sender).Value = previousValue;
                UpdateBonusControls();
            }
        }        

        private void numUDAgi_ValueChanged(object sender, EventArgs e)
        {
            int previousValue = Int32.Parse(((UpDownBase)sender).Text);
            UpdateBonusControls();

            if (currentModKiCost < 0)
            {
                ((NumericUpDown)sender).Value = previousValue;
                UpdateBonusControls();
            }
        }

        private void numUDDex_ValueChanged(object sender, EventArgs e)
        {
            int previousValue = Int32.Parse(((UpDownBase)sender).Text);
            UpdateBonusControls();

            if (currentModKiCost < 0)
            {
                ((NumericUpDown)sender).Value = previousValue;
                UpdateBonusControls();
            }

        }

        private void numUDCon_ValueChanged(object sender, EventArgs e)
        {
            int previousValue = Int32.Parse(((UpDownBase)sender).Text);
            UpdateBonusControls();

            if (currentModKiCost < 0)
            {
                ((NumericUpDown)sender).Value = previousValue;
                UpdateBonusControls();
            }
        }

        private void numUDWP_ValueChanged(object sender, EventArgs e)
        {
            int previousValue = Int32.Parse(((UpDownBase)sender).Text);
            UpdateBonusControls();

            if (currentModKiCost < 0)
            {
                ((NumericUpDown)sender).Value = previousValue;
                UpdateBonusControls();
            }
        }

        private void numUDPow_ValueChanged(object sender, EventArgs e)
        {
            int previousValue = Int32.Parse(((UpDownBase)sender).Text);
            UpdateBonusControls();

            if (currentModKiCost < 0)
            {
                ((NumericUpDown)sender).Value = previousValue;
                UpdateBonusControls();
            }
        }
    }
}
