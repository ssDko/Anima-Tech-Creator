namespace Anima_Tech_Creator
{
    partial class Tech_Creator
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
            this.txtBoxEffectFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.cBoxEffectList = new System.Windows.Forms.ComboBox();
            this.txtBoxStrOptionalCost = new System.Windows.Forms.TextBox();
            this.txtBoxPowOptionalCost = new System.Windows.Forms.TextBox();
            this.txtBoxWPOptionalCost = new System.Windows.Forms.TextBox();
            this.txtBoxConOptionalCost = new System.Windows.Forms.TextBox();
            this.txtBoxDexOptionalCost = new System.Windows.Forms.TextBox();
            this.txtBoxAgiOptionalCost = new System.Windows.Forms.TextBox();
            this.lblStr = new System.Windows.Forms.Label();
            this.lblAgi = new System.Windows.Forms.Label();
            this.lblDex = new System.Windows.Forms.Label();
            this.lblCon = new System.Windows.Forms.Label();
            this.lblWP = new System.Windows.Forms.Label();
            this.lblPow = new System.Windows.Forms.Label();
            this.numUDStr = new System.Windows.Forms.NumericUpDown();
            this.numUDAgi = new System.Windows.Forms.NumericUpDown();
            this.numUDDex = new System.Windows.Forms.NumericUpDown();
            this.numUDCon = new System.Windows.Forms.NumericUpDown();
            this.numUDWP = new System.Windows.Forms.NumericUpDown();
            this.numUDPow = new System.Windows.Forms.NumericUpDown();
            this.lblStrTotal = new System.Windows.Forms.Label();
            this.lblAgiTotal = new System.Windows.Forms.Label();
            this.lblDexTotal = new System.Windows.Forms.Label();
            this.lblConTotal = new System.Windows.Forms.Label();
            this.lblWPTotal = new System.Windows.Forms.Label();
            this.lblPowTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numUDPowerLevel = new System.Windows.Forms.NumericUpDown();
            this.cBoxIsSecondary = new System.Windows.Forms.CheckBox();
            this.txtBoxEffectBonus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUDStr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDAgi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDDex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDCon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDWP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDPow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDPowerLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxEffectFilePath
            // 
            this.txtBoxEffectFilePath.Enabled = false;
            this.txtBoxEffectFilePath.Location = new System.Drawing.Point(12, 25);
            this.txtBoxEffectFilePath.Name = "txtBoxEffectFilePath";
            this.txtBoxEffectFilePath.Size = new System.Drawing.Size(368, 20);
            this.txtBoxEffectFilePath.TabIndex = 0;
            this.txtBoxEffectFilePath.Text = "Load File";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Effect File";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(386, 23);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // cBoxEffectList
            // 
            this.cBoxEffectList.Enabled = false;
            this.cBoxEffectList.FormattingEnabled = true;
            this.cBoxEffectList.Location = new System.Drawing.Point(13, 51);
            this.cBoxEffectList.Name = "cBoxEffectList";
            this.cBoxEffectList.Size = new System.Drawing.Size(265, 21);
            this.cBoxEffectList.TabIndex = 3;
            this.cBoxEffectList.SelectedIndexChanged += new System.EventHandler(this.cBoxEffectList_SelectedIndexChanged);
            // 
            // txtBoxStrOptionalCost
            // 
            this.txtBoxStrOptionalCost.Enabled = false;
            this.txtBoxStrOptionalCost.Location = new System.Drawing.Point(15, 158);
            this.txtBoxStrOptionalCost.Name = "txtBoxStrOptionalCost";
            this.txtBoxStrOptionalCost.Size = new System.Drawing.Size(31, 20);
            this.txtBoxStrOptionalCost.TabIndex = 4;
            // 
            // txtBoxPowOptionalCost
            // 
            this.txtBoxPowOptionalCost.Enabled = false;
            this.txtBoxPowOptionalCost.Location = new System.Drawing.Point(200, 158);
            this.txtBoxPowOptionalCost.Name = "txtBoxPowOptionalCost";
            this.txtBoxPowOptionalCost.Size = new System.Drawing.Size(31, 20);
            this.txtBoxPowOptionalCost.TabIndex = 5;
            // 
            // txtBoxWPOptionalCost
            // 
            this.txtBoxWPOptionalCost.Enabled = false;
            this.txtBoxWPOptionalCost.Location = new System.Drawing.Point(163, 158);
            this.txtBoxWPOptionalCost.Name = "txtBoxWPOptionalCost";
            this.txtBoxWPOptionalCost.Size = new System.Drawing.Size(31, 20);
            this.txtBoxWPOptionalCost.TabIndex = 6;
            // 
            // txtBoxConOptionalCost
            // 
            this.txtBoxConOptionalCost.Enabled = false;
            this.txtBoxConOptionalCost.Location = new System.Drawing.Point(126, 158);
            this.txtBoxConOptionalCost.Name = "txtBoxConOptionalCost";
            this.txtBoxConOptionalCost.Size = new System.Drawing.Size(31, 20);
            this.txtBoxConOptionalCost.TabIndex = 7;
            // 
            // txtBoxDexOptionalCost
            // 
            this.txtBoxDexOptionalCost.Enabled = false;
            this.txtBoxDexOptionalCost.Location = new System.Drawing.Point(89, 158);
            this.txtBoxDexOptionalCost.Name = "txtBoxDexOptionalCost";
            this.txtBoxDexOptionalCost.Size = new System.Drawing.Size(31, 20);
            this.txtBoxDexOptionalCost.TabIndex = 8;
            // 
            // txtBoxAgiOptionalCost
            // 
            this.txtBoxAgiOptionalCost.Enabled = false;
            this.txtBoxAgiOptionalCost.Location = new System.Drawing.Point(52, 158);
            this.txtBoxAgiOptionalCost.Name = "txtBoxAgiOptionalCost";
            this.txtBoxAgiOptionalCost.Size = new System.Drawing.Size(31, 20);
            this.txtBoxAgiOptionalCost.TabIndex = 9;
            // 
            // lblStr
            // 
            this.lblStr.AutoSize = true;
            this.lblStr.Location = new System.Drawing.Point(14, 142);
            this.lblStr.Name = "lblStr";
            this.lblStr.Size = new System.Drawing.Size(20, 13);
            this.lblStr.TabIndex = 10;
            this.lblStr.Text = "Str";
            // 
            // lblAgi
            // 
            this.lblAgi.AutoSize = true;
            this.lblAgi.Location = new System.Drawing.Point(52, 142);
            this.lblAgi.Name = "lblAgi";
            this.lblAgi.Size = new System.Drawing.Size(22, 13);
            this.lblAgi.TabIndex = 11;
            this.lblAgi.Text = "Agi";
            // 
            // lblDex
            // 
            this.lblDex.AutoSize = true;
            this.lblDex.Location = new System.Drawing.Point(86, 142);
            this.lblDex.Name = "lblDex";
            this.lblDex.Size = new System.Drawing.Size(26, 13);
            this.lblDex.TabIndex = 12;
            this.lblDex.Text = "Dex";
            // 
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.Location = new System.Drawing.Point(123, 142);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(26, 13);
            this.lblCon.TabIndex = 13;
            this.lblCon.Text = "Con";
            // 
            // lblWP
            // 
            this.lblWP.AutoSize = true;
            this.lblWP.Location = new System.Drawing.Point(160, 142);
            this.lblWP.Name = "lblWP";
            this.lblWP.Size = new System.Drawing.Size(25, 13);
            this.lblWP.TabIndex = 14;
            this.lblWP.Text = "WP";
            // 
            // lblPow
            // 
            this.lblPow.AutoSize = true;
            this.lblPow.Location = new System.Drawing.Point(197, 142);
            this.lblPow.Name = "lblPow";
            this.lblPow.Size = new System.Drawing.Size(28, 13);
            this.lblPow.TabIndex = 15;
            this.lblPow.Text = "Pow";
            // 
            // numUDStr
            // 
            this.numUDStr.Enabled = false;
            this.numUDStr.Location = new System.Drawing.Point(15, 185);
            this.numUDStr.Name = "numUDStr";
            this.numUDStr.Size = new System.Drawing.Size(31, 20);
            this.numUDStr.TabIndex = 16;
            this.numUDStr.ValueChanged += new System.EventHandler(this.numUDStr_ValueChanged);
            // 
            // numUDAgi
            // 
            this.numUDAgi.Enabled = false;
            this.numUDAgi.Location = new System.Drawing.Point(53, 185);
            this.numUDAgi.Name = "numUDAgi";
            this.numUDAgi.Size = new System.Drawing.Size(30, 20);
            this.numUDAgi.TabIndex = 17;
            this.numUDAgi.ValueChanged += new System.EventHandler(this.numUDAgi_ValueChanged);
            // 
            // numUDDex
            // 
            this.numUDDex.Enabled = false;
            this.numUDDex.Location = new System.Drawing.Point(89, 185);
            this.numUDDex.Name = "numUDDex";
            this.numUDDex.Size = new System.Drawing.Size(31, 20);
            this.numUDDex.TabIndex = 18;
            this.numUDDex.ValueChanged += new System.EventHandler(this.numUDDex_ValueChanged);
            // 
            // numUDCon
            // 
            this.numUDCon.Enabled = false;
            this.numUDCon.Location = new System.Drawing.Point(127, 185);
            this.numUDCon.Name = "numUDCon";
            this.numUDCon.Size = new System.Drawing.Size(30, 20);
            this.numUDCon.TabIndex = 19;
            this.numUDCon.ValueChanged += new System.EventHandler(this.numUDCon_ValueChanged);
            // 
            // numUDWP
            // 
            this.numUDWP.Enabled = false;
            this.numUDWP.Location = new System.Drawing.Point(163, 185);
            this.numUDWP.Name = "numUDWP";
            this.numUDWP.Size = new System.Drawing.Size(31, 20);
            this.numUDWP.TabIndex = 20;
            this.numUDWP.ValueChanged += new System.EventHandler(this.numUDWP_ValueChanged);
            // 
            // numUDPow
            // 
            this.numUDPow.Enabled = false;
            this.numUDPow.Location = new System.Drawing.Point(200, 185);
            this.numUDPow.Name = "numUDPow";
            this.numUDPow.Size = new System.Drawing.Size(31, 20);
            this.numUDPow.TabIndex = 21;
            this.numUDPow.ValueChanged += new System.EventHandler(this.numUDPow_ValueChanged);
            // 
            // lblStrTotal
            // 
            this.lblStrTotal.AutoSize = true;
            this.lblStrTotal.Location = new System.Drawing.Point(21, 208);
            this.lblStrTotal.Name = "lblStrTotal";
            this.lblStrTotal.Size = new System.Drawing.Size(13, 13);
            this.lblStrTotal.TabIndex = 22;
            this.lblStrTotal.Text = "0";
            // 
            // lblAgiTotal
            // 
            this.lblAgiTotal.AutoSize = true;
            this.lblAgiTotal.Location = new System.Drawing.Point(61, 208);
            this.lblAgiTotal.Name = "lblAgiTotal";
            this.lblAgiTotal.Size = new System.Drawing.Size(13, 13);
            this.lblAgiTotal.TabIndex = 23;
            this.lblAgiTotal.Text = "0";
            // 
            // lblDexTotal
            // 
            this.lblDexTotal.AutoSize = true;
            this.lblDexTotal.Location = new System.Drawing.Point(99, 208);
            this.lblDexTotal.Name = "lblDexTotal";
            this.lblDexTotal.Size = new System.Drawing.Size(13, 13);
            this.lblDexTotal.TabIndex = 24;
            this.lblDexTotal.Text = "0";
            // 
            // lblConTotal
            // 
            this.lblConTotal.AutoSize = true;
            this.lblConTotal.Location = new System.Drawing.Point(136, 208);
            this.lblConTotal.Name = "lblConTotal";
            this.lblConTotal.Size = new System.Drawing.Size(13, 13);
            this.lblConTotal.TabIndex = 25;
            this.lblConTotal.Text = "0";
            // 
            // lblWPTotal
            // 
            this.lblWPTotal.AutoSize = true;
            this.lblWPTotal.Location = new System.Drawing.Point(172, 208);
            this.lblWPTotal.Name = "lblWPTotal";
            this.lblWPTotal.Size = new System.Drawing.Size(13, 13);
            this.lblWPTotal.TabIndex = 26;
            this.lblWPTotal.Text = "0";
            // 
            // lblPowTotal
            // 
            this.lblPowTotal.AutoSize = true;
            this.lblPowTotal.Location = new System.Drawing.Point(212, 208);
            this.lblPowTotal.Name = "lblPowTotal";
            this.lblPowTotal.Size = new System.Drawing.Size(13, 13);
            this.lblPowTotal.TabIndex = 27;
            this.lblPowTotal.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Power Level";
            // 
            // numUDPowerLevel
            // 
            this.numUDPowerLevel.Enabled = false;
            this.numUDPowerLevel.Location = new System.Drawing.Point(127, 120);
            this.numUDPowerLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDPowerLevel.Name = "numUDPowerLevel";
            this.numUDPowerLevel.Size = new System.Drawing.Size(33, 20);
            this.numUDPowerLevel.TabIndex = 29;
            this.numUDPowerLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDPowerLevel.ValueChanged += new System.EventHandler(this.numUDPowerLevel_ValueChanged);
            // 
            // cBoxIsSecondary
            // 
            this.cBoxIsSecondary.AutoSize = true;
            this.cBoxIsSecondary.Enabled = false;
            this.cBoxIsSecondary.Location = new System.Drawing.Point(210, 120);
            this.cBoxIsSecondary.Name = "cBoxIsSecondary";
            this.cBoxIsSecondary.Size = new System.Drawing.Size(114, 17);
            this.cBoxIsSecondary.TabIndex = 30;
            this.cBoxIsSecondary.Text = "Secondary Effect?";
            this.cBoxIsSecondary.UseVisualStyleBackColor = true;
            this.cBoxIsSecondary.CheckedChanged += new System.EventHandler(this.cBoxIsSecondary_CheckedChanged);
            // 
            // txtBoxEffectBonus
            // 
            this.txtBoxEffectBonus.Enabled = false;
            this.txtBoxEffectBonus.Location = new System.Drawing.Point(15, 119);
            this.txtBoxEffectBonus.Name = "txtBoxEffectBonus";
            this.txtBoxEffectBonus.Size = new System.Drawing.Size(100, 20);
            this.txtBoxEffectBonus.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Bonus";
            // 
            // Tech_Creator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 418);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxEffectBonus);
            this.Controls.Add(this.cBoxIsSecondary);
            this.Controls.Add(this.numUDPowerLevel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPowTotal);
            this.Controls.Add(this.lblWPTotal);
            this.Controls.Add(this.lblConTotal);
            this.Controls.Add(this.lblDexTotal);
            this.Controls.Add(this.lblAgiTotal);
            this.Controls.Add(this.lblStrTotal);
            this.Controls.Add(this.numUDPow);
            this.Controls.Add(this.numUDWP);
            this.Controls.Add(this.numUDCon);
            this.Controls.Add(this.numUDDex);
            this.Controls.Add(this.numUDAgi);
            this.Controls.Add(this.numUDStr);
            this.Controls.Add(this.lblPow);
            this.Controls.Add(this.lblWP);
            this.Controls.Add(this.lblCon);
            this.Controls.Add(this.lblDex);
            this.Controls.Add(this.lblAgi);
            this.Controls.Add(this.lblStr);
            this.Controls.Add(this.txtBoxAgiOptionalCost);
            this.Controls.Add(this.txtBoxDexOptionalCost);
            this.Controls.Add(this.txtBoxConOptionalCost);
            this.Controls.Add(this.txtBoxWPOptionalCost);
            this.Controls.Add(this.txtBoxPowOptionalCost);
            this.Controls.Add(this.txtBoxStrOptionalCost);
            this.Controls.Add(this.cBoxEffectList);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxEffectFilePath);
            this.Name = "Tech_Creator";
            this.Text = "Tech_Creator";
            this.Load += new System.EventHandler(this.Tech_Creator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUDStr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDAgi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDDex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDCon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDWP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDPow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDPowerLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxEffectFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ComboBox cBoxEffectList;
        private System.Windows.Forms.TextBox txtBoxStrOptionalCost;
        private System.Windows.Forms.TextBox txtBoxPowOptionalCost;
        private System.Windows.Forms.TextBox txtBoxWPOptionalCost;
        private System.Windows.Forms.TextBox txtBoxConOptionalCost;
        private System.Windows.Forms.TextBox txtBoxDexOptionalCost;
        private System.Windows.Forms.TextBox txtBoxAgiOptionalCost;
        private System.Windows.Forms.Label lblStr;
        private System.Windows.Forms.Label lblAgi;
        private System.Windows.Forms.Label lblDex;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.Label lblWP;
        private System.Windows.Forms.Label lblPow;
        private System.Windows.Forms.NumericUpDown numUDStr;
        private System.Windows.Forms.NumericUpDown numUDAgi;
        private System.Windows.Forms.NumericUpDown numUDDex;
        private System.Windows.Forms.NumericUpDown numUDCon;
        private System.Windows.Forms.NumericUpDown numUDWP;
        private System.Windows.Forms.NumericUpDown numUDPow;
        private System.Windows.Forms.Label lblStrTotal;
        private System.Windows.Forms.Label lblAgiTotal;
        private System.Windows.Forms.Label lblDexTotal;
        private System.Windows.Forms.Label lblConTotal;
        private System.Windows.Forms.Label lblWPTotal;
        private System.Windows.Forms.Label lblPowTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numUDPowerLevel;
        private System.Windows.Forms.CheckBox cBoxIsSecondary;
        private System.Windows.Forms.TextBox txtBoxEffectBonus;
        private System.Windows.Forms.Label label3;
    }
}