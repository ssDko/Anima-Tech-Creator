using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EffectLibrary;
using System.Media;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Json;

namespace Anima_Tech_Creator
{
    public partial class formEffect_Creator : Form
    {
        private List<Effect> effects = new List<Effect>();
        private Effect currentEffect = new Effect();
        private int currentEffectIndex = 0;
        private formModifyAdvantage modifyAdvantageForm = new formModifyAdvantage();
        private DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Effect>));

        public List<Effect> Effects { get => effects; set => effects = value; }
        public Effect CurrentEffect { get => currentEffect; set => currentEffect = value; }
        public int CurrentEffectIndex
        {
            get => currentEffectIndex;
            set
            {
                if (value > Effects.Count - 1)
                {
                    value = Effects.Count - 1;
                }

                if (value < 0)
                {
                    value = 0;
                }

                currentEffectIndex = value;
            }
        }
        public formModifyAdvantage ModifyAdvantageForm { get => modifyAdvantageForm; set => modifyAdvantageForm = value; }
        

        public formEffect_Creator()
        {
            InitializeComponent();
        }

        private void Effect_Creator_Load(object sender, EventArgs e)
        {        
            // Probibly not temp code
            //dgvDisadvantages.Columns[0].Width = 200;
            dgvEffects.Columns[0].Width = 300;
            
            UpdateCurrentEffect();
        }

        

        // Advantage Controls
        private void UpdateAdvantageTreeView()
        {
            tvAdvantages.Nodes.Clear();

            foreach (var advantage in CurrentEffect.OptionalAdvantages)
            {
                tvAdvantages.Nodes.Add(advantage.Name);
                foreach (var statLine in advantage.StatLineList)
                {
                    tvAdvantages.Nodes[tvAdvantages.Nodes.Count - 1].Nodes.Add(statLine.ToString());
                }                
            }

            tvAdvantages.ExpandAll();

            if (CurrentEffect.OptionalAdvantages.Count == 0 || tvAdvantages.SelectedNode == null)
            {
                btnDeleteAdvantage.Enabled = false;
                btnAdvantageEdit.Enabled = false;
            }
        }

        private void btnAddAdvantage_Click(object sender, EventArgs e)
        {
            ModifyAdvantageForm = new formModifyAdvantage();
                      

            if (ModifyAdvantageForm.ShowDialog() == DialogResult.OK)
            {
                CurrentEffect.AddAdvantage(ModifyAdvantageForm.getAdvantage());
            }

            UpdateAdvantageTreeView();
        }

        private void btnDeleteAdvantage_Click(object sender, EventArgs e)
        {
            
            CurrentEffect.RemoveAdvantageAt(tvAdvantages.SelectedNode.Index);

            UpdateAdvantageTreeView();
        }       

        private void tvAdvantages_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != tvAdvantages.SelectedNode || tvAdvantages.SelectedNode.Level != 0)
            {
                btnDeleteAdvantage.Enabled = false;
                btnAdvantageEdit.Enabled = false;

            }
            else
            {
                btnDeleteAdvantage.Enabled = true;
                btnAdvantageEdit.Enabled = true;

            }
        }
                
        private void btnAdvantageEdit_Click(object sender, EventArgs e)
        {
            int index = tvAdvantages.SelectedNode.Index;
            ModifyAdvantageForm = new formModifyAdvantage(CurrentEffect.OptionalAdvantages[index].CopyAdvantage());
           

            if (ModifyAdvantageForm.ShowDialog() == DialogResult.OK) // We accepted any changes.
            {
                CurrentEffect.OptionalAdvantages[index] = ModifyAdvantageForm.getAdvantage();                
            }

            UpdateAdvantageTreeView();
        }

        // Disadvantage Controls
        private void btnAddDisadvantage_Click(object sender, EventArgs e)
        {
            CurrentEffect.AddDisadvantage(new EffectDisadvantage());
            UpdateDisadvantageDataGrid();
        }

        private void btnDeleteDisadvantage_Click(object sender, EventArgs e)
        {
            try
            {
                CurrentEffect.RemoveDisadvantageAt(dgvDisadvantages.CurrentCell.RowIndex);
                UpdateDisadvantageDataGrid();
            }
            catch (System.NullReferenceException)
            {
                //No more cells to delete (not technically required)
                SystemSounds.Beep.Play();
            }

        }

        private void dgvDisadvantages_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvDisadvantages.Tag = dgvDisadvantages.CurrentCell.Value;  // save the previous value
        }

        private void dgvDisadvantages_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            dgvDisadvantages.EndEdit();
        }

        private void dgvDisadvantages_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dgvDisadvantages.CurrentRow.Index;
            int columnIndex = dgvDisadvantages.CurrentCell.ColumnIndex;
            string strValue = dgvDisadvantages.CurrentCell.Value.ToString();

            int prevValue = 0;
            int newValue = 0;

            int.TryParse(dgvDisadvantages.Tag.ToString(), out prevValue);
            bool isNumerical = int.TryParse(strValue, out newValue);

            SetDisadvantageCellValue(rowIndex, columnIndex, strValue, prevValue, newValue, isNumerical);

        }

        private void SetDisadvantageCellValue(int rowIndex, int columnIndex, string strValue, int prevValue, int newValue, bool isNumerical)
        {
            if (columnIndex == 0) // name
            {
                CurrentEffect.OptionalDisadvantages[rowIndex].Name = strValue;
            }
            else if (isNumerical)
            {
                if (columnIndex == 1) // cost
                {
                    CurrentEffect.OptionalDisadvantages[rowIndex].CostReduction = newValue;
                }

                if (columnIndex == 2) // martial knowlege
                {
                    CurrentEffect.OptionalDisadvantages[rowIndex].MartialKnowlegeReduction = newValue;
                }
            }
            else
            {
                // Invalid input. Warn user and change the shown value to a valid one
                SystemSounds.Beep.Play();

                dgvDisadvantages.CurrentCell.Value = prevValue;
            }
        }

        private void dgvDisadvantages_SelectionChanged(object sender, EventArgs e)
        {
            // Disable the Delete Button if there is no selection
            if (dgvDisadvantages.SelectedCells.Count == 0)
            {
                btnDeleteDisadvantage.Enabled = false;
            }
            else
            {
                btnDeleteDisadvantage.Enabled = true;
            }
        }

        public void UpdateDisadvantageDataGrid()
        {
            dgvDisadvantages.Rows.Clear();
            foreach (var disadvantage in CurrentEffect.OptionalDisadvantages)
            {
                string name = disadvantage.Name;
                int cost = disadvantage.CostReduction;
                int mk = disadvantage.MartialKnowlegeReduction;

                dgvDisadvantages.Rows.Add(name, cost, mk);
            }

            if (dgvDisadvantages.Rows.Count == 0)
            {
                btnDeleteDisadvantage.Enabled = false;
            }
            else
            {
                btnDeleteDisadvantage.Enabled = true;
            }
        }

        // Effect Controls
        public void UpdateEffectDataGrid()
        {
            dgvEffects.Rows.Clear();
            foreach (var effectStat in CurrentEffect.EffectStats)
            {
                string bonus = effectStat.Bonus;
                int prim = effectStat.PrimaryKiCost;
                int sec = effectStat.SecondaryKiCost;
                int mk = effectStat.MartialKnowlegeCost;
                int maint = effectStat.Maintenance;
                int mis = effectStat.MinorSustenance;
                int grs = effectStat.GreatorSustenance;
                string level = effectStat.PowerLevel.ToString();

                dgvEffects.Rows.Add(bonus, prim, sec, mk, maint, mis, grs);
                dgvEffects.Rows[dgvEffects.Rows.Count - 1].Cells[dgvcPowerLevel.Index].Value = level; // set Power Level
                
            }

            if (dgvEffects.Rows.Count == 0)
            {
                btnDeleteEffectStat.Enabled = false;
            }
            else
            {
                btnDeleteEffectStat.Enabled = true;
            }
        }

        private void btnAddEffectStat_Click(object sender, EventArgs e)
        {
            CurrentEffect.AddStatLine(new EffectStatLine());
            UpdateEffectDataGrid();
        }

        private void btnDeleteEffectStat_Click(object sender, EventArgs e)
        {
            try
            {
                CurrentEffect.RemoveStatLineAt(dgvEffects.CurrentCell.RowIndex);
                UpdateEffectDataGrid();
            }
            catch (System.NullReferenceException)
            {
                //No more cells to delete (not technically required)
                SystemSounds.Beep.Play();
            }
        }

        private void dgvEffects_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvEffects.Tag = dgvEffects.CurrentCell.Value;  // save the previous value
        }

        private void dgvEffects_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            dgvEffects.EndEdit();
        }

        private void SetEffectCellValue(int rowIndex, int columnIndex, string strValue, int prevValue, int newValue, bool isNumerical)
        {
            if (columnIndex == 0) // bonus
            {
                CurrentEffect.EffectStats[rowIndex].Bonus = strValue;
            }
            else if (isNumerical)
            {
                switch (columnIndex)
                {
                    case 1: // Primary
                        CurrentEffect.EffectStats[rowIndex].PrimaryKiCost = newValue;
                        break;

                    case 2: // Secondary
                        CurrentEffect.EffectStats[rowIndex].SecondaryKiCost = newValue;
                        break;

                    case 3: // MK
                        CurrentEffect.EffectStats[rowIndex].MartialKnowlegeCost = newValue;
                        break;

                    case 4: // Maint
                        CurrentEffect.EffectStats[rowIndex].Maintenance = newValue;
                        break;

                    case 5: // MiS
                        CurrentEffect.EffectStats[rowIndex].MinorSustenance = newValue;
                        break;

                    case 6: // GrS
                        CurrentEffect.EffectStats[rowIndex].GreatorSustenance = newValue;
                        break;

                    case 7: // Level
                        CurrentEffect.EffectStats[rowIndex].PowerLevel = newValue;
                        break;


                }                
            }
            else
            {
                // Invalid input. Warn user and change the shown value to a valid one
                SystemSounds.Beep.Play();

                dgvEffects.CurrentCell.Value = prevValue;
            }
        }

        private void dgvEffects_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dgvEffects.CurrentRow.Index;
            int columnIndex = dgvEffects.CurrentCell.ColumnIndex;
            string strValue = dgvEffects.CurrentCell.Value.ToString();

            int prevValue = 0;
            int newValue = 0;

            int.TryParse(dgvEffects.Tag.ToString(), out prevValue);
            bool isNumerical = int.TryParse(strValue, out newValue);

            SetEffectCellValue(rowIndex, columnIndex, strValue, prevValue, newValue, isNumerical);
        }

        private void dgvEffects_SelectionChanged(object sender, EventArgs e)
        {
            // Disable the Delete Button if there is no selection
            if (dgvEffects.SelectedCells.Count == 0)
            {
               btnDeleteEffectStat.Enabled = false;
            }
            else
            {
                btnDeleteEffectStat.Enabled = true;
            }
        }

        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {
            CurrentEffect.Name = txtBoxName.Text;           
        }

        // Effect Selection Controls

        private void UpdateCurrentEffect()
        {
            try
            {
                CurrentEffect = Effects[CurrentEffectIndex];

                foreach (Control control in this.Controls)
                {
                    control.Enabled = true;
                }

                // Update our controls
                UpdateDisadvantageDataGrid();
                UpdateAdvantageTreeView();
                UpdateEffectDataGrid();
                UpdateCurrentFrequency();
                UpdateCurrentActionType();
                UpdatePrimaryCharacteristic();
                UpdateElements();
                UpdateOptionalCharacteristics();


                txtBoxName.Text = CurrentEffect.Name;
                txtBoxIndex.Text = (CurrentEffectIndex + 1).ToString();
                lblIndex.Text = "of " + Effects.Count.ToString();
            }
            catch  // No more Effects
            {
                foreach (Control control in this.Controls)
                {
                    control.Enabled = false;
                }

                btnAddEffect.Enabled = true;
                btnLoad.Enabled = true;
                txtBoxIndex.Text = "0";
                lblIndex.Text = "of 0";

                cBoxPrimaryCharacteristic.SelectedIndex = 0;

                foreach(Control ctrl in gBoxElements.Controls)
                {
                    if (ctrl is CheckBox)
                    {
                        ((CheckBox)ctrl).Checked = false;
                    }
                }
                
                foreach(Control ctrl in gboxOptionalCharacteristics.Controls)
                {
                    if (ctrl is NumericUpDown)
                    {
                        ((NumericUpDown)ctrl).Value = 0;
                    }
                }


                txtBoxName.Text = "";
                dgvEffects.Rows.Clear();
                dgvDisadvantages.Rows.Clear();
                tvAdvantages.Nodes.Clear();




            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            CurrentEffectIndex++;          

            UpdateCurrentEffect();

        }        

        private void btnBack_Click(object sender, EventArgs e)
        {
            CurrentEffectIndex--;
            
            UpdateCurrentEffect();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            CurrentEffectIndex = 0;

            UpdateCurrentEffect();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            CurrentEffectIndex = Effects.Count - 1;

            UpdateCurrentEffect();
        }

        private void btnEffectAdd_Click(object sender, EventArgs e)
        {
            Effects.Add(new Effect());

            CurrentEffectIndex = Effects.Count - 1;

            UpdateCurrentEffect();
        }

        private void btnDeleteEffect_Click(object sender, EventArgs e)
        {
            Effects.RemoveAt(CurrentEffectIndex);

            if (CurrentEffectIndex > Effects.Count - 1)
            {
                CurrentEffectIndex = Effects.Count - 1;
            }

            if (CurrentEffectIndex < 0)
            {
                CurrentEffectIndex = 0;
            }


            UpdateCurrentEffect();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var saveWindow = new SaveFileDialog();
            saveWindow.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            saveWindow.InitialDirectory = Directory.GetCurrentDirectory();
           

            if (saveWindow.ShowDialog() == DialogResult.OK)
            {
                using (FileStream writer = new FileStream(saveWindow.FileName, FileMode.Create))
                {
                    serializer.WriteObject(writer, effects);
                }
            }
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
                        effects = (List<Effect>)serializer.ReadObject(reader);

                        UpdateCurrentEffect();
                    }
                }                
                catch (SerializationException)
                {
                    MessageBox.Show("Error! File isn't a properly formated JSON file.", "Error! Incorrect File Type.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        //Frequency controlls

        private void rBtnAction_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnAction.Checked == true)
                currentEffect.Frequency = Frequency.Action;
        }

        private void rBtnTurn_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnTurn.Checked == true)
                currentEffect.Frequency = Frequency.Turn;
        }

        private void UpdateCurrentFrequency()
        {
            if (currentEffect.Frequency == Frequency.Action)
            {
                rBtnAction.Checked = true;
            }
            else
            {
                rBtnTurn.Checked = true;
            }
        }

        
        //Action Type Controls

        private void rBtnAttack_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnAttack.Checked == true)
                currentEffect.ActionType = ActionType.Attack;
        }

        private void rBtnCounter_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnCounter.Checked == true)
                currentEffect.ActionType = ActionType.CounterAttack;
        }

        private void rBtnDefense_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnDefense.Checked == true)
                currentEffect.ActionType = ActionType.Defense;
        }

        private void rBtnVariable_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnVariable.Checked == true)
                currentEffect.ActionType = ActionType.Variable;
        }

        private void UpdateCurrentActionType()
        {
            switch (currentEffect.ActionType)
            {
                case (ActionType.Attack):
                    rBtnAttack.Checked = true;
                    break;

                case (ActionType.CounterAttack):
                    rBtnCounter.Checked = true;
                    break;

                case (ActionType.Defense):
                    rBtnDefense.Checked = true;
                    break;

                case (ActionType.Variable):
                    rBtnVariable.Checked = true;
                    break;

                default:
                    MessageBox.Show("You somehow got a invalid Action Type!");
                    break;
            }

        }

        //Primary Characteristic Controls
        private void cBoxPrimaryCharacteristic_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Enable all the Optional characteristics. We will disable the appropriate one after
            foreach (Control ctrl in gboxOptionalCharacteristics.Controls)
            {
                ctrl.Enabled = true;
            }

            
            switch (cBoxPrimaryCharacteristic.SelectedIndex)
            {                
                case 0: //Strength
                    currentEffect.PrimaryCharacteristic = Characteristic.Strength;
                    numUDStrength.Value = 0;
                    numUDStrength.Enabled = false;
                    break;

                case 1: //Agility
                    currentEffect.PrimaryCharacteristic = Characteristic.Agility;
                    numUDAgility.Value = 0;
                    numUDAgility.Enabled = false;
                    break;

                case 2: //Dexterity
                    currentEffect.PrimaryCharacteristic = Characteristic.Dexterity;
                    numUDDexterity.Value = 0;
                    numUDDexterity.Enabled = false;
                    break;

                case 3: //Constitution
                    currentEffect.PrimaryCharacteristic = Characteristic.Constitution;
                    numUDConstitution.Value = 0;
                    numUDConstitution.Enabled = false;
                    break;

                case 4: //Will Power
                    currentEffect.PrimaryCharacteristic = Characteristic.WillPower;
                    numUDWillPower.Value = 0;
                    numUDWillPower.Enabled = false;
                    break;

                case 5: //Power
                    currentEffect.PrimaryCharacteristic = Characteristic.Power;
                    numUDPower.Value = 0;
                    numUDPower.Enabled = false;
                    break;

                default:
                    MessageBox.Show("You somehow got a invalid Characteristic!");
                    break;

            }
        }

        private void UpdatePrimaryCharacteristic()
        {
            cBoxPrimaryCharacteristic.SelectedIndex = (int) currentEffect.PrimaryCharacteristic;
        }

        
        //Elements Contols
        private void cBoxAir_CheckedChanged(object sender, EventArgs e)
        {
            currentEffect.Air = cBoxAir.Checked; 
            
        }

        private void cBoxEarth_CheckedChanged(object sender, EventArgs e)
        {
            currentEffect.Earth = cBoxEarth.Checked;
        }

        private void cBoxFire_CheckedChanged(object sender, EventArgs e)
        {
            currentEffect.Fire = cBoxFire.Checked;
        }

        private void cBoxWater_CheckedChanged(object sender, EventArgs e)
        {
            currentEffect.Water = cBoxWater.Checked;
        }

        private void cBoxLight_CheckedChanged(object sender, EventArgs e)
        {
            currentEffect.Light = cBoxLight.Checked;
        }

        private void cBoxDarkness_CheckedChanged(object sender, EventArgs e)
        {
            currentEffect.Darkness = cBoxDarkness.Checked;
        }

        private void UpdateElements()
        {
            cBoxAir.Checked = currentEffect.Air;
            cBoxEarth.Checked = currentEffect.Earth;
            cBoxFire.Checked = currentEffect.Fire;
            cBoxWater.Checked = currentEffect.Water;
            cBoxLight.Checked = currentEffect.Light;
            cBoxDarkness.Checked = currentEffect.Darkness;
           
        }

        //Optional Characteristics
        private void numUDStrength_ValueChanged(object sender, EventArgs e)
        {
            currentEffect.OptionalStrCost = Convert.ToInt32(numUDStrength.Value);
        }

        private void numUDAgility_ValueChanged(object sender, EventArgs e)
        {
            currentEffect.OptionalAgiCost = Convert.ToInt32(numUDAgility.Value);
        }

        private void numUDDexterity_ValueChanged(object sender, EventArgs e)
        {
            currentEffect.OptionalDexCost = Convert.ToInt32(numUDDexterity.Value);
        }

        private void numUDConstitution_ValueChanged(object sender, EventArgs e)
        {
            currentEffect.OptionalConCost = Convert.ToInt32(numUDConstitution.Value);
        }

        private void numUDWillPower_ValueChanged(object sender, EventArgs e)
        {
            currentEffect.OptionalWPCost = Convert.ToInt32(numUDWillPower.Value);
        }

        private void numUDPower_ValueChanged(object sender, EventArgs e)
        {
            currentEffect.OptionalPowCost = Convert.ToInt32(numUDPower.Value);
        }

        private void UpdateOptionalCharacteristics()
        {
            numUDStrength.Value = currentEffect.OptionalStrCost;
            numUDAgility.Value = currentEffect.OptionalAgiCost;
            numUDConstitution.Value = currentEffect.OptionalConCost;
            numUDDexterity.Value = currentEffect.OptionalDexCost;
            numUDWillPower.Value = currentEffect.OptionalWPCost;
            numUDPower.Value = currentEffect.OptionalPowCost;
        }

        private void Effect_Creator_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Got here");
        }
    }
}
