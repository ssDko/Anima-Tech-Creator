using EffectLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anima_Tech_Creator
{
    public partial class Tech_Creator : Form
    {
        private DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Effect>));
        private List<Effect> effects = new List<Effect>();
        private Effect primaryEffect;
        private EffectStatLine selectedStats;

        private int currentMainKiCost = 0;
        private int currentModKiCost = 0;

        // These are to establish a link between then numeric controls and the stats they 
        private Dictionary<NumericUpDown, Label> statLabelControlDict = new Dictionary<NumericUpDown, Label>();
        private Dictionary<NumericUpDown, TextBox> statTextBoxControlDict = new Dictionary<NumericUpDown, TextBox>();
        private Dictionary<NumericUpDown, Characteristic> statCharacteristicDict = new Dictionary<NumericUpDown, Characteristic>();
        private Dictionary<Characteristic, int> primaryStatTotals = new Dictionary<Characteristic, int>();
        private Dictionary<Characteristic, int> grandStatTotals = new Dictionary<Characteristic, int>();
        
        // Secondary Effect Even handlers
        

           
        

        public Tech_Creator()
        {
            InitializeComponent();
        }

        private void Tech_Creator_Load(object sender, EventArgs e)
        {            
            //We want to associate our num up down controls to many things. 
            statLabelControlDict.Add(numUDStr, lblStrTotal);
            statLabelControlDict.Add(numUDAgi, lblAgiTotal);
            statLabelControlDict.Add(numUDDex, lblDexTotal);
            statLabelControlDict.Add(numUDCon, lblConTotal);
            statLabelControlDict.Add(numUDWP,  lblWPTotal);
            statLabelControlDict.Add(numUDPow, lblPowTotal);

            statTextBoxControlDict.Add(numUDStr, txtBoxStrOptionalCost);
            statTextBoxControlDict.Add(numUDAgi, txtBoxAgiOptionalCost);
            statTextBoxControlDict.Add(numUDDex, txtBoxDexOptionalCost);
            statTextBoxControlDict.Add(numUDCon, txtBoxConOptionalCost);
            statTextBoxControlDict.Add(numUDWP,  txtBoxWPOptionalCost);
            statTextBoxControlDict.Add(numUDPow, txtBoxPowOptionalCost);

            statCharacteristicDict.Add(numUDStr, Characteristic.Strength);
            statCharacteristicDict.Add(numUDAgi, Characteristic.Agility);
            statCharacteristicDict.Add(numUDDex, Characteristic.Dexterity);
            statCharacteristicDict.Add(numUDCon, Characteristic.Constitution);
            statCharacteristicDict.Add(numUDWP,  Characteristic.WillPower);
            statCharacteristicDict.Add(numUDPow, Characteristic.Power);

            primaryStatTotals.Add(Characteristic.Strength, 0);
            primaryStatTotals.Add(Characteristic.Agility, 0);
            primaryStatTotals.Add(Characteristic.Dexterity, 0);
            primaryStatTotals.Add(Characteristic.Constitution, 0);
            primaryStatTotals.Add(Characteristic.WillPower, 0);
            primaryStatTotals.Add(Characteristic.Power, 0);

            grandStatTotals.Add(Characteristic.Strength, 0);
            grandStatTotals.Add(Characteristic.Agility, 0);
            grandStatTotals.Add(Characteristic.Dexterity, 0);
            grandStatTotals.Add(Characteristic.Constitution, 0);
            grandStatTotals.Add(Characteristic.WillPower, 0);
            grandStatTotals.Add(Characteristic.Power, 0);

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var openWindow = new OpenFileDialog();
            openWindow.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            openWindow.InitialDirectory = Directory.GetCurrentDirectory();

            if (openWindow.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream reader = new FileStream(openWindow.FileName, FileMode.Open))
                    {
                        // Make the file path viewable
                        txtBoxEffectFilePath.Text = openWindow.FileName;
                        txtBoxEffectFilePath.TextAlign = HorizontalAlignment.Left;

                        // Populate effects from the file
                        effects = (List<Effect>)serializer.ReadObject(reader);                        
                    }
                    
                    // Add all effects to the dropdown and enable it.
                    foreach (Effect effect in effects)
                    {
                        cBoxEffectList.Items.Add(effect.Name);
                    }
                    
                    cBoxEffectList.Enabled = true;
                    cBoxEffectList.SelectedIndex = 0;

                    btnAddSecondaryEffect.Enabled = true;          
                    

                 
                }
                catch (SerializationException)
                {
                    MessageBox.Show("Error! File isn't a properly formated JSON file.", "Error! Incorrect File Type.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // SelectEffect Must be used anytime cBoxEffectList's selected index is changed.
        private void SelectEffect()
        {
            primaryEffect = new Effect(effects[cBoxEffectList.SelectedIndex]);
        }

        private void SelectStats()
        {
            selectedStats = primaryEffect.EffectStats[cmbBoxEffectBonuses.SelectedIndex];
        }       

        private void UpdateKiCosts()
        {
            // currentMainKiCost is based on if this is a secondary effect or not
            currentMainKiCost = selectedStats.PrimaryKiCost;

            currentModKiCost = currentMainKiCost - (int)(numUDStr.Value + numUDAgi.Value +
                                                         numUDDex.Value + numUDCon.Value +
                                                         numUDWP.Value + numUDPow.Value);
            
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
                primaryEffect.OptionalStatCosts[Characteristic.Strength].ToString();
            txtBoxAgiOptionalCost.Text =
                primaryEffect.OptionalStatCosts[Characteristic.Agility].ToString();
            txtBoxDexOptionalCost.Text =
                primaryEffect.OptionalStatCosts[Characteristic.Dexterity].ToString();
            txtBoxConOptionalCost.Text =
                primaryEffect.OptionalStatCosts[Characteristic.Constitution].ToString();
            txtBoxWPOptionalCost.Text =
                primaryEffect.OptionalStatCosts[Characteristic.WillPower].ToString();
            txtBoxPowOptionalCost.Text =
                primaryEffect.OptionalStatCosts[Characteristic.Power].ToString();


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
            foreach (KeyValuePair<Characteristic, int> entry in primaryEffect.OptionalStatCosts)
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
            UpdatePrimaryStatControls();

        }        

        private void UpdatePrimaryStatControls()
        {

            // Format and display the secondary characteristics
            // while also storing the total values
            foreach (NumericUpDown control in panelPrimaryEffect.Controls.OfType<NumericUpDown>())
            {
                int optionaCost = primaryEffect.OptionalStatCosts[statCharacteristicDict[control]];
                // Set the label for every stat accordingly
                if (control.Value != 0)
                {
                    int totalCost = (int)control.Value + optionaCost;
                    statLabelControlDict[control].Text = totalCost.ToString();

                    primaryStatTotals[statCharacteristicDict[control]] = totalCost;
                }
                else
                {
                    statLabelControlDict[control].Text = "0";
                    primaryStatTotals[statCharacteristicDict[control]] = 0;
                }
            }


            string strPrimaryStat = currentModKiCost.ToString() + "/" + currentMainKiCost.ToString();


            // Format and display the primary characteristic
            // Also store the value
            switch (primaryEffect.PrimaryCharacteristic)
            {
                case Characteristic.Strength:
                    lblStrTotal.Text = strPrimaryStat;
                    lblStr.Text = "*STR*";
                    numUDStr.Enabled = false;
                    primaryStatTotals[Characteristic.Strength] = currentModKiCost;
                    break;
                case Characteristic.Agility:
                    lblAgiTotal.Text = strPrimaryStat;
                    lblAgi.Text = "*AGI*";
                    numUDAgi.Enabled = false;
                    primaryStatTotals[Characteristic.Agility] = currentModKiCost;
                    break;
                case Characteristic.Dexterity:
                    lblDexTotal.Text = strPrimaryStat;
                    lblDex.Text = "*DEX*";
                    numUDDex.Enabled = false;
                    primaryStatTotals[Characteristic.Dexterity] = currentModKiCost;
                    break;
                case Characteristic.Constitution:
                    lblConTotal.Text = strPrimaryStat;
                    lblCon.Text = "*CON*";
                    numUDCon.Enabled = false;
                    primaryStatTotals[Characteristic.Constitution] = currentModKiCost;
                    break;
                case Characteristic.WillPower:
                    lblWPTotal.Text = strPrimaryStat;
                    lblWP.Text = "*WP*";
                    numUDWP.Enabled = false;
                    primaryStatTotals[Characteristic.WillPower] = currentModKiCost;
                    break;
                case Characteristic.Power:
                    lblPowTotal.Text = strPrimaryStat;
                    lblPow.Text = "*POW*";
                    numUDPow.Enabled = false;
                    primaryStatTotals[Characteristic.Power] = currentModKiCost;
                    break;
                default:
                    MessageBox.Show("Should not be here: File (Tech Creator.cs), Line: 234");
                    break;

            }

            //update and display the grand total
            UpdateAndDisplayGrandTotal();

        }

        private void UpdateAndDisplayGrandTotal()
        {
            foreach (Characteristic stat in Enum.GetValues(typeof(Characteristic)))
            {
                int total = 0;
                total += primaryStatTotals[stat];
                
                // add secondary effects
                foreach (SecondaryEffect effectControl in panelSecondaryEffects.Controls)
                {
                    total += effectControl.SecondaryStatTotals[stat];
                }


                grandStatTotals[stat] = total;
            }

            lblGrandTotal.Text =
                "Grand Total: Str: " + grandStatTotals[Characteristic.Strength] +
                ", Agi: " + grandStatTotals[Characteristic.Agility] +
                ", Dex: " + grandStatTotals[Characteristic.Dexterity] +
                ", Con: " + grandStatTotals[Characteristic.Constitution] +
                ", WP: " + grandStatTotals[Characteristic.WillPower] +
                ", Pow: " + grandStatTotals[Characteristic.Power];
        }

        private void UpdateBonusControls()
        {
            UpdateKiCosts();
            UpdatePrimaryStatControls();
        }

        // Used when a Effect is chosen
        private void PopulateEffectControls()
        {
            // Select the current effect based on what we selected 
            SelectEffect();

            // Add each selectable Bonus
            cmbBoxEffectBonuses.Items.Clear();
            foreach(EffectStatLine stat in primaryEffect.EffectStats)
            {
                cmbBoxEffectBonuses.Items.Add(stat.Bonus);
            }

            cmbBoxEffectBonuses.Enabled = true;
            cmbBoxEffectBonuses.SelectedIndex = 0;

            

            PopulateBonusControls();            

        }

        private void cBoxEffectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateEffectControls();
        }

        private void cmbBoxEffectBonuses_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateBonusControls();
        }

        private void chkBoxIsSecondary_CheckedChanged(object sender, EventArgs e)
        {            
            UpdateBonusControls();

            if (currentModKiCost < 0)
            {
                numUDStr.Value = 0;
                numUDAgi.Value = 0;
                numUDDex.Value = 0;
                numUDCon.Value = 0;
                numUDWP.Value = 0;
                numUDPow.Value = 0;
            }
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

        private void btnAddSecondaryEffect_Click(object sender, EventArgs e)
        {
            SecondaryEffect newEffectControl = new SecondaryEffect(effects);

            // Update Position
            int position = panelSecondaryEffects.Controls.Count;                      
            newEffectControl.Location = DetermineEffectControlLocation(newEffectControl, position);

            // Add event handler
            newEffectControl.ValuesUpdated += NewEffectControl_ValuesUpdated;

            // Add to the list
            panelSecondaryEffects.Controls.Add(newEffectControl);                 
        }

        private void NewEffectControl_ValuesUpdated(object sender, EventArgs e)
        {
            UpdateAndDisplayGrandTotal();
        }

        private void panelSecondaryEffects_ControlRemoved(object sender, ControlEventArgs e)
        {
            int count = 0;
            //We need to recalculate the effect control's positions
            foreach (SecondaryEffect effectControl in panelSecondaryEffects.Controls)
            {      
                
                effectControl.Location = DetermineEffectControlLocation(effectControl, count);

                count++;
            }
        }

        private Point DetermineEffectControlLocation(SecondaryEffect effect ,int count)
        {
            Point newLocation = new Point(0, 0);
            int offset = 0;
            
            // adjust for scrolling
            if (count > 0)
            {
                offset = panelSecondaryEffects.Controls[0].Location.Y;
            }

            newLocation.Y = (effect.Height * count) + offset;                        

            return newLocation;
        }        
    }
}
