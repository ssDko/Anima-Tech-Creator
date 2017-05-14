namespace Anima_Tech_Creator
{
    partial class formModifyAdvantage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.dgvStats = new System.Windows.Forms.DataGridView();
            this.dgvcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcMartialKnowlege = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcMaintenance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcMiS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcGiS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStats)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(16, 30);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(397, 20);
            this.txtBoxName.TabIndex = 1;
            this.txtBoxName.TextChanged += new System.EventHandler(this.txtBoxName_TextChanged);
            // 
            // dgvStats
            // 
            this.dgvStats.AllowUserToAddRows = false;
            this.dgvStats.AllowUserToDeleteRows = false;
            this.dgvStats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcName,
            this.dgvcCost,
            this.dgvcMartialKnowlege,
            this.dgvcMaintenance,
            this.dgvcMiS,
            this.dgvcGiS});
            this.dgvStats.Location = new System.Drawing.Point(16, 56);
            this.dgvStats.Name = "dgvStats";
            this.dgvStats.RowHeadersVisible = false;
            this.dgvStats.Size = new System.Drawing.Size(397, 260);
            this.dgvStats.TabIndex = 2;
            this.dgvStats.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStats_CellEndEdit);
            this.dgvStats.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStats_CellEnter);
            this.dgvStats.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStats_CellLeave);
            // 
            // dgvcName
            // 
            this.dgvcName.HeaderText = "Name";
            this.dgvcName.Name = "dgvcName";
            // 
            // dgvcCost
            // 
            this.dgvcCost.HeaderText = "Cost";
            this.dgvcCost.Name = "dgvcCost";
            // 
            // dgvcMartialKnowlege
            // 
            this.dgvcMartialKnowlege.HeaderText = "MK";
            this.dgvcMartialKnowlege.Name = "dgvcMartialKnowlege";
            // 
            // dgvcMaintenance
            // 
            this.dgvcMaintenance.HeaderText = "Maint.";
            this.dgvcMaintenance.Name = "dgvcMaintenance";
            // 
            // dgvcMiS
            // 
            this.dgvcMiS.HeaderText = "MiS";
            this.dgvcMiS.Name = "dgvcMiS";
            // 
            // dgvcGiS
            // 
            this.dgvcGiS.HeaderText = "GiS";
            this.dgvcGiS.Name = "dgvcGiS";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(257, 322);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(338, 323);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(97, 322);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 322);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // formModifyAdvantage
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(425, 358);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dgvStats);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formModifyAdvantage";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Modify Advantage";
            this.Load += new System.EventHandler(this.formModifyAdvantage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.DataGridView dgvStats;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcMartialKnowlege;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcMaintenance;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcMiS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcGiS;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
    }
}