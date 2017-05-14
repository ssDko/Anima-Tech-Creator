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
        Effect selectedEffect;
        EffectStatLine selectedStats;
        
        int currentMainKiCost = 0;
        private Dictionary<Characteristic, int> modifiedCharacteristics;
        int currentModKiCost = 0;

        public Tech_Creator()
        {
            InitializeComponent();
        }

        private void Tech_Creator_Load(object sender, EventArgs e)
        {
            modifiedCharacteristics = new Dictionary<Characteristic, int>();
            modifiedCharacteristics.Add(Characteristic.Strength, 0);
            modifiedCharacteristics.Add(Characteristic.Agility, 0);
            modifiedCharacteristics.Add(Characteristic.Dexterity, 0);
            modifiedCharacteristics.Add(Characteristic.Constitution, 0);
            modifiedCharacteristics.Add(Characteristic.WillPower, 0);
            modifiedCharacteristics.Add(Characteristic.Power, 0);
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
                        txtBoxEffectFilePath.Text = openWindow.FileName;
                        txtBoxEffectFilePath.TextAlign = HorizontalAlignment.Left;
                        effects = (List<Effect>)serializer.ReadObject(reader);
                        numUDPowerLevel.Enabled = true;
                    }
                    cBoxEffectList.Enabled = true;
                    foreach (Effect effect in effects)
                    {
                        cBoxEffectList.Items.Add(effect.Name);
                    }

                    cBoxEffectList.SelectedIndex = 0;

                 
                }
                catch (SerializationException)
                {
                    MessageBox.Show("Error! File isn't a properly formated JSON file.", "Error! Incorrect File Type.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cBoxEffectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeSelectedEffect(cBoxEffectList.SelectedIndex);
            
            numUDPowerLevel.Value = 1;
            numUDPowerLevel.Maximum = selectedEffect.EffectStats.Count;
            cBoxIsSecondary.Checked = false;
            cBoxIsSecondary.Enabled = true;

            numUDStr.Enabled = true;
            numUDAgi.Enabled = true;
            numUDDex.Enabled = true;
            numUDCon.Enabled = true;
            numUDWP.Enabled = true;
            numUDPow.Enabled = true;

            ResetStatNUMUDControls();

            txtBoxStrOptionalCost.Text = selectedEffect.OptionalStrCost.ToString();
            txtBoxAgiOptionalCost.Text = selectedEffect.OptionalAgiCost.ToString();
            txtBoxDexOptionalCost.Text = selectedEffect.OptionalDexCost.ToString();
            txtBoxConOptionalCost.Text = selectedEffect.OptionalConCost.ToString();
            txtBoxWPOptionalCost.Text = selectedEffect.OptionalWPCost.ToString();
            txtBoxPowOptionalCost.Text = selectedEffect.OptionalPowCost.ToString();
            UpdateCurrentMainKiCost();
            UpdateModifiedMainKiCost();
            UpdateEffectStatsControls();
        }

        
        private void numUDPowerLevel_ValueChanged(object sender, EventArgs e)
        {
            selectedStats = selectedEffect.EffectStats[((int)numUDPowerLevel.Value) - 1];
            ResetStatNUMUDControls();

            UpdateCurrentMainKiCost();
            UpdateModifiedMainKiCost();

            UpdateEffectStatsControls();
        }

        
        private void cBoxIsSecondary_CheckedChanged(object sender, EventArgs e)
        {
            ResetStatNUMUDControls();
            UpdateCurrentMainKiCost();
            UpdateModifiedMainKiCost();
            UpdateEffectStatsControls();
        }

        
        private void ChangeSelectedEffect(int index)
        {
            selectedEffect = effects[index];
            selectedStats = selectedEffect.EffectStats[0];
            UpdateCurrentMainKiCost();
            UpdateModifiedMainKiCost();
        }

        private void UpdateCurrentMainKiCost()
        {
            currentMainKiCost = (cBoxIsSecondary.Checked) ?
                                selectedStats.SecondaryKiCost : selectedStats.PrimaryKiCost;
        }

        private void UpdateModifiedMainKiCost()
        {
            int tempCost = currentMainKiCost - (int)(numUDStr.Value + numUDAgi.Value + 
                                                     numUDDex.Value + numUDCon.Value + 
                                                     numUDWP.Value + numUDPow.Value);

            switch (selectedEffect.PrimaryCharacteristic)
            {
                case Characteristic.Strength:
                    modifiedCharacteristics[Characteristic.Strength] = tempCost;
                    break;

                case Characteristic.Agility:
                    modifiedCharacteristics[Characteristic.Agility] = tempCost;
                    break;

                case Characteristic.Dexterity:
                    modifiedCharacteristics[Characteristic.Dexterity] = tempCost;
                    break;

                case Characteristic.Constitution:
                    modifiedCharacteristics[Characteristic.Constitution] = tempCost;
                    break;

                case Characteristic.WillPower:
                    modifiedCharacteristics[Characteristic.WillPower] = tempCost;
                    break;

                case Characteristic.Power:
                    modifiedCharacteristics[Characteristic.Power] = tempCost;
                    break;
            }
            currentModKiCost = tempCost;
        }

        private void UpdateEffectStatsControls()
        {

            lblStr.Text = "Str";
            lblAgi.Text = "Agi";
            lblDex.Text = "Dex";
            lblCon.Text = "Con";
            lblWP.Text = "WP";
            lblPow.Text = "POW";

            txtBoxStrOptionalCost.Text = 
                modifiedCharacteristics[Characteristic.Strength].ToString();
            txtBoxAgiOptionalCost.Text =
                modifiedCharacteristics[Characteristic.Agility].ToString();
            txtBoxDexOptionalCost.Text =
                modifiedCharacteristics[Characteristic.Dexterity].ToString();
            txtBoxConOptionalCost.Text =
                modifiedCharacteristics[Characteristic.Constitution].ToString();
            txtBoxWPOptionalCost.Text =
                modifiedCharacteristics[Characteristic.WillPower].ToString();
            txtBoxPowOptionalCost.Text =
                modifiedCharacteristics[Characteristic.Power].ToString();

            txtBoxEffectBonus.Text = selectedStats.Bonus;

            switch (selectedEffect.PrimaryCharacteristic)
            {
                case Characteristic.Strength:
                    lblStr.Text = "*Str*";
                    txtBoxStrOptionalCost.Text =
                        modifiedCharacteristics[Characteristic.Strength].ToString();
                    numUDStr.Enabled = false;
                    break;
                case Characteristic.Agility:
                    lblAgi.Text = "*Agi*";
                    txtBoxAgiOptionalCost.Text =
                        modifiedCharacteristics[Characteristic.Agility].ToString();
                    numUDAgi.Enabled = false;
                    break;
                case Characteristic.Dexterity:
                    lblDex.Text = "*Dex*";
                    txtBoxDexOptionalCost.Text =
                        modifiedCharacteristics[Characteristic.Dexterity].ToString();
                    numUDDex.Enabled = false;
                    break;
                case Characteristic.Constitution:
                    lblCon.Text = "*Con*";
                    txtBoxConOptionalCost.Text =
                        modifiedCharacteristics[Characteristic.Constitution].ToString();
                    numUDCon.Enabled = false;
                    break;
                case Characteristic.WillPower:
                    lblWP.Text = "*WP*";
                    txtBoxWPOptionalCost.Text =
                        modifiedCharacteristics[Characteristic.WillPower].ToString();
                    numUDWP.Enabled = false;
                    break;
                case Characteristic.Power:
                    lblPow.Text = "*Pow*";
                    txtBoxPowOptionalCost.Text =
                        modifiedCharacteristics[Characteristic.Power].ToString();
                    numUDPow.Enabled = false;
                    break;
            }
        }

        private void ResetStatNUMUDControls()
        {
            numUDStr.Value = 0;
            numUDAgi.Value = 0;
            numUDDex.Value = 0;
            numUDCon.Value = 0;
            numUDWP.Value = 0;
            numUDPow.Value = 0;

            


        }

        private void UpdateStatChanges(object sender, Characteristic stat)
        {
            string oldNumberText = ((UpDownBase)sender).Text;
            int previousValue = Int32.Parse(oldNumberText);
            int statAdder = selectedEffect.GetOptionalStat(stat);



            UpdateCurrentMainKiCost();
            UpdateModifiedMainKiCost();

            //We want to keep positive values
            if (currentModKiCost < 0 || statAdder == 0)
                ((NumericUpDown)sender).Value = previousValue;



            if (((NumericUpDown)sender).Value != 0)
            {
                modifiedCharacteristics[stat] =
                    statAdder + (int)((NumericUpDown)sender).Value;
            }
            else
            {
                modifiedCharacteristics[stat] = 0;
            }
            UpdateEffectStatsControls();
        }

        private void numUDAgi_ValueChanged(object sender, EventArgs e)
        {
            UpdateStatChanges(sender, Characteristic.Agility);
        }

        private void numUDStr_ValueChanged(object sender, EventArgs e)
        {
            UpdateStatChanges(sender, Characteristic.Strength);
        }

        private void numUDDex_ValueChanged(object sender, EventArgs e)
        {
            UpdateStatChanges(sender, Characteristic.Dexterity);
        }

        private void numUDCon_ValueChanged(object sender, EventArgs e)
        {
            UpdateStatChanges(sender, Characteristic.Constitution);
        }

        private void numUDWP_ValueChanged(object sender, EventArgs e)
        {
            UpdateStatChanges(sender, Characteristic.WillPower);
        }

        private void numUDPow_ValueChanged(object sender, EventArgs e)
        {
            UpdateStatChanges(sender, Characteristic.Power);
        }
    }
}
