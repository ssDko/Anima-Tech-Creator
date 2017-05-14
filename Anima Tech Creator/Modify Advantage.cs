using EffectLibrary;
using System;
using System.Media;
using System.Windows.Forms;

namespace Anima_Tech_Creator
{
    public partial class formModifyAdvantage : Form
    {
        
        private OptionalAdvantage advantage = new OptionalAdvantage();

        public formModifyAdvantage()
        {
            InitializeComponent();
            advantage.Name = "New Advantage";
            advantage.AddStat(new OptionalAdvantageStatLine("New", 0, 0, 0, 0, 0));
        }

        public formModifyAdvantage(OptionalAdvantage modAdvantage)
        {
            InitializeComponent();
            advantage = modAdvantage;
        }

        private void formModifyAdvantage_Load(object sender, EventArgs e)
        {
           
            dgvStats.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvcName.Width = 200;  

            updateFormData();
        }

        private void updateFormData()
        {
            txtBoxName.Text = advantage.Name;
            dgvStats.Rows.Clear();
            foreach (var statLine in advantage.StatLineList)
            {
                dgvStats.Rows.Add(statLine.Name, statLine.Cost, statLine.MartialKnowlegeCost, statLine.Maintenance, statLine.MinorSustenance, statLine.GreatorSustenance);
            }
        }

        public OptionalAdvantage getAdvantage()
        {
            
            return advantage;
        }           

        private void btnOk_Click(object sender, EventArgs e)
        {           
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }       

        private void dgvStats_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            dgvStats.EndEdit();
        }

        private void dgvStats_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dgvStats.CurrentRow.Index;
            int columnIndex = dgvStats.CurrentCell.ColumnIndex;
            string strValue = dgvStats.CurrentCell.Value.ToString();

            int prevValue = 0;
            int newValue = 0;

            int.TryParse(dgvStats.Tag.ToString(), out prevValue);
            bool isNumerical = int.TryParse(strValue, out newValue);

            SetStatLineCellValue(rowIndex, columnIndex, strValue, prevValue, newValue, isNumerical);
        }
        
        private void SetStatLineCellValue(int rowIndex, int columnIndex, string strValue, int prevValue, int newValue, bool isNumerical)
        {
            if (columnIndex == 0) // name
            {
                advantage.StatLineList[rowIndex].Name = strValue;
            }
            else if (isNumerical)
            {
                switch (columnIndex)
                {
                    case 1: // cost
                        advantage.StatLineList[rowIndex].Cost = newValue;
                        break;
                    case 2: // martial knowlege
                        advantage.StatLineList[rowIndex].MartialKnowlegeCost = newValue;
                        break;
                    case 3: // maintence
                        advantage.StatLineList[rowIndex].Maintenance = newValue;
                        break;
                    case 4: // minor sustenance 
                        advantage.StatLineList[rowIndex].MinorSustenance = newValue;
                        break;
                    case 5: // greator sustenance
                        advantage.StatLineList[rowIndex].GreatorSustenance = newValue;
                        break;
                }                
            }
            else
            {
                // Invalid input. Warn user and change the shown value to a valid one
                SystemSounds.Beep.Play();
                dgvStats.CurrentCell.Value = prevValue;
            }            
        }

        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {
            advantage.Name = txtBoxName.Text;            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            advantage.AddStat(new OptionalAdvantageStatLine("New", 0, 0, 0, 0, 0));
            updateFormData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                advantage.RemoveStatAt(dgvStats.CurrentCell.RowIndex);
                updateFormData();
            }
            catch (System.NullReferenceException)
            {
                //No more cells to delete
                SystemSounds.Beep.Play();
            }
        }

        private void dgvStats_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvStats.Tag = dgvStats.CurrentCell.Value; // save previous data
        }
    }
}
