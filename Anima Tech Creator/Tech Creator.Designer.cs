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
            this.label5 = new System.Windows.Forms.Label();
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
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBoxEffectBonuses = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpBoxSecondaryEffects = new System.Windows.Forms.GroupBox();
            this.panelSecondaryEffects = new System.Windows.Forms.Panel();
            this.btnAddSecondaryEffect = new System.Windows.Forms.Button();
            this.panelPrimaryEffect = new System.Windows.Forms.Panel();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUDStr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDAgi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDDex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDCon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDWP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDPow)).BeginInit();
            this.grpBoxSecondaryEffects.SuspendLayout();
            this.panelPrimaryEffect.SuspendLayout();
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
            this.btnLoad.Location = new System.Drawing.Point(398, 25);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Primary Effect";
            // 
            // cBoxEffectList
            // 
            this.cBoxEffectList.Enabled = false;
            this.cBoxEffectList.FormattingEnabled = true;
            this.cBoxEffectList.Location = new System.Drawing.Point(89, 81);
            this.cBoxEffectList.Name = "cBoxEffectList";
            this.cBoxEffectList.Size = new System.Drawing.Size(265, 21);
            this.cBoxEffectList.TabIndex = 3;
            this.cBoxEffectList.SelectedIndexChanged += new System.EventHandler(this.cBoxEffectList_SelectedIndexChanged);
            // 
            // txtBoxStrOptionalCost
            // 
            this.txtBoxStrOptionalCost.Enabled = false;
            this.txtBoxStrOptionalCost.Location = new System.Drawing.Point(6, 32);
            this.txtBoxStrOptionalCost.Name = "txtBoxStrOptionalCost";
            this.txtBoxStrOptionalCost.Size = new System.Drawing.Size(31, 20);
            this.txtBoxStrOptionalCost.TabIndex = 4;
            // 
            // txtBoxPowOptionalCost
            // 
            this.txtBoxPowOptionalCost.Enabled = false;
            this.txtBoxPowOptionalCost.Location = new System.Drawing.Point(191, 32);
            this.txtBoxPowOptionalCost.Name = "txtBoxPowOptionalCost";
            this.txtBoxPowOptionalCost.Size = new System.Drawing.Size(31, 20);
            this.txtBoxPowOptionalCost.TabIndex = 5;
            // 
            // txtBoxWPOptionalCost
            // 
            this.txtBoxWPOptionalCost.Enabled = false;
            this.txtBoxWPOptionalCost.Location = new System.Drawing.Point(154, 32);
            this.txtBoxWPOptionalCost.Name = "txtBoxWPOptionalCost";
            this.txtBoxWPOptionalCost.Size = new System.Drawing.Size(31, 20);
            this.txtBoxWPOptionalCost.TabIndex = 6;
            // 
            // txtBoxConOptionalCost
            // 
            this.txtBoxConOptionalCost.Enabled = false;
            this.txtBoxConOptionalCost.Location = new System.Drawing.Point(117, 32);
            this.txtBoxConOptionalCost.Name = "txtBoxConOptionalCost";
            this.txtBoxConOptionalCost.Size = new System.Drawing.Size(31, 20);
            this.txtBoxConOptionalCost.TabIndex = 7;
            // 
            // txtBoxDexOptionalCost
            // 
            this.txtBoxDexOptionalCost.Enabled = false;
            this.txtBoxDexOptionalCost.Location = new System.Drawing.Point(80, 32);
            this.txtBoxDexOptionalCost.Name = "txtBoxDexOptionalCost";
            this.txtBoxDexOptionalCost.Size = new System.Drawing.Size(31, 20);
            this.txtBoxDexOptionalCost.TabIndex = 8;
            // 
            // txtBoxAgiOptionalCost
            // 
            this.txtBoxAgiOptionalCost.Enabled = false;
            this.txtBoxAgiOptionalCost.Location = new System.Drawing.Point(43, 32);
            this.txtBoxAgiOptionalCost.Name = "txtBoxAgiOptionalCost";
            this.txtBoxAgiOptionalCost.Size = new System.Drawing.Size(31, 20);
            this.txtBoxAgiOptionalCost.TabIndex = 9;
            // 
            // lblStr
            // 
            this.lblStr.AutoSize = true;
            this.lblStr.Location = new System.Drawing.Point(111, 148);
            this.lblStr.Name = "lblStr";
            this.lblStr.Size = new System.Drawing.Size(20, 13);
            this.lblStr.TabIndex = 10;
            this.lblStr.Text = "Str";
            // 
            // lblAgi
            // 
            this.lblAgi.AutoSize = true;
            this.lblAgi.Location = new System.Drawing.Point(149, 148);
            this.lblAgi.Name = "lblAgi";
            this.lblAgi.Size = new System.Drawing.Size(22, 13);
            this.lblAgi.TabIndex = 11;
            this.lblAgi.Text = "Agi";
            // 
            // lblDex
            // 
            this.lblDex.AutoSize = true;
            this.lblDex.Location = new System.Drawing.Point(183, 148);
            this.lblDex.Name = "lblDex";
            this.lblDex.Size = new System.Drawing.Size(26, 13);
            this.lblDex.TabIndex = 12;
            this.lblDex.Text = "Dex";
            // 
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.Location = new System.Drawing.Point(220, 148);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(26, 13);
            this.lblCon.TabIndex = 13;
            this.lblCon.Text = "Con";
            // 
            // lblWP
            // 
            this.lblWP.AutoSize = true;
            this.lblWP.Location = new System.Drawing.Point(257, 148);
            this.lblWP.Name = "lblWP";
            this.lblWP.Size = new System.Drawing.Size(25, 13);
            this.lblWP.TabIndex = 14;
            this.lblWP.Text = "WP";
            // 
            // lblPow
            // 
            this.lblPow.AutoSize = true;
            this.lblPow.Location = new System.Drawing.Point(294, 148);
            this.lblPow.Name = "lblPow";
            this.lblPow.Size = new System.Drawing.Size(28, 13);
            this.lblPow.TabIndex = 15;
            this.lblPow.Text = "Pow";
            // 
            // numUDStr
            // 
            this.numUDStr.Enabled = false;
            this.numUDStr.Location = new System.Drawing.Point(5, 6);
            this.numUDStr.Name = "numUDStr";
            this.numUDStr.Size = new System.Drawing.Size(31, 20);
            this.numUDStr.TabIndex = 16;
            this.numUDStr.ValueChanged += new System.EventHandler(this.numUDStr_ValueChanged);
            // 
            // numUDAgi
            // 
            this.numUDAgi.Enabled = false;
            this.numUDAgi.Location = new System.Drawing.Point(43, 6);
            this.numUDAgi.Name = "numUDAgi";
            this.numUDAgi.Size = new System.Drawing.Size(30, 20);
            this.numUDAgi.TabIndex = 17;
            this.numUDAgi.ValueChanged += new System.EventHandler(this.numUDAgi_ValueChanged);
            // 
            // numUDDex
            // 
            this.numUDDex.Enabled = false;
            this.numUDDex.Location = new System.Drawing.Point(79, 6);
            this.numUDDex.Name = "numUDDex";
            this.numUDDex.Size = new System.Drawing.Size(31, 20);
            this.numUDDex.TabIndex = 18;
            this.numUDDex.ValueChanged += new System.EventHandler(this.numUDDex_ValueChanged);
            // 
            // numUDCon
            // 
            this.numUDCon.Enabled = false;
            this.numUDCon.Location = new System.Drawing.Point(117, 6);
            this.numUDCon.Name = "numUDCon";
            this.numUDCon.Size = new System.Drawing.Size(30, 20);
            this.numUDCon.TabIndex = 19;
            this.numUDCon.ValueChanged += new System.EventHandler(this.numUDCon_ValueChanged);
            // 
            // numUDWP
            // 
            this.numUDWP.Enabled = false;
            this.numUDWP.Location = new System.Drawing.Point(153, 6);
            this.numUDWP.Name = "numUDWP";
            this.numUDWP.Size = new System.Drawing.Size(31, 20);
            this.numUDWP.TabIndex = 20;
            this.numUDWP.ValueChanged += new System.EventHandler(this.numUDWP_ValueChanged);
            // 
            // numUDPow
            // 
            this.numUDPow.Enabled = false;
            this.numUDPow.Location = new System.Drawing.Point(190, 6);
            this.numUDPow.Name = "numUDPow";
            this.numUDPow.Size = new System.Drawing.Size(31, 20);
            this.numUDPow.TabIndex = 21;
            this.numUDPow.ValueChanged += new System.EventHandler(this.numUDPow_ValueChanged);
            // 
            // lblStrTotal
            // 
            this.lblStrTotal.AutoSize = true;
            this.lblStrTotal.Location = new System.Drawing.Point(15, 56);
            this.lblStrTotal.Name = "lblStrTotal";
            this.lblStrTotal.Size = new System.Drawing.Size(13, 13);
            this.lblStrTotal.TabIndex = 22;
            this.lblStrTotal.Text = "0";
            // 
            // lblAgiTotal
            // 
            this.lblAgiTotal.AutoSize = true;
            this.lblAgiTotal.Location = new System.Drawing.Point(52, 56);
            this.lblAgiTotal.Name = "lblAgiTotal";
            this.lblAgiTotal.Size = new System.Drawing.Size(13, 13);
            this.lblAgiTotal.TabIndex = 23;
            this.lblAgiTotal.Text = "0";
            // 
            // lblDexTotal
            // 
            this.lblDexTotal.AutoSize = true;
            this.lblDexTotal.Location = new System.Drawing.Point(89, 56);
            this.lblDexTotal.Name = "lblDexTotal";
            this.lblDexTotal.Size = new System.Drawing.Size(13, 13);
            this.lblDexTotal.TabIndex = 24;
            this.lblDexTotal.Text = "0";
            // 
            // lblConTotal
            // 
            this.lblConTotal.AutoSize = true;
            this.lblConTotal.Location = new System.Drawing.Point(126, 56);
            this.lblConTotal.Name = "lblConTotal";
            this.lblConTotal.Size = new System.Drawing.Size(13, 13);
            this.lblConTotal.TabIndex = 25;
            this.lblConTotal.Text = "0";
            // 
            // lblWPTotal
            // 
            this.lblWPTotal.AutoSize = true;
            this.lblWPTotal.Location = new System.Drawing.Point(163, 56);
            this.lblWPTotal.Name = "lblWPTotal";
            this.lblWPTotal.Size = new System.Drawing.Size(13, 13);
            this.lblWPTotal.TabIndex = 26;
            this.lblWPTotal.Text = "0";
            // 
            // lblPowTotal
            // 
            this.lblPowTotal.AutoSize = true;
            this.lblPowTotal.Location = new System.Drawing.Point(200, 56);
            this.lblPowTotal.Name = "lblPowTotal";
            this.lblPowTotal.Size = new System.Drawing.Size(13, 13);
            this.lblPowTotal.TabIndex = 27;
            this.lblPowTotal.Text = "0";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 40;
            // 
            // cmbBoxEffectBonuses
            // 
            this.cmbBoxEffectBonuses.Enabled = false;
            this.cmbBoxEffectBonuses.FormattingEnabled = true;
            this.cmbBoxEffectBonuses.Location = new System.Drawing.Point(179, 113);
            this.cmbBoxEffectBonuses.Name = "cmbBoxEffectBonuses";
            this.cmbBoxEffectBonuses.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxEffectBonuses.TabIndex = 31;
            this.cmbBoxEffectBonuses.SelectedIndexChanged += new System.EventHandler(this.cmbBoxEffectBonuses_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "*Additioanl Cost:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Bonus";
            // 
            // grpBoxSecondaryEffects
            // 
            this.grpBoxSecondaryEffects.Controls.Add(this.panelSecondaryEffects);
            this.grpBoxSecondaryEffects.Location = new System.Drawing.Point(12, 243);
            this.grpBoxSecondaryEffects.Name = "grpBoxSecondaryEffects";
            this.grpBoxSecondaryEffects.Size = new System.Drawing.Size(380, 357);
            this.grpBoxSecondaryEffects.TabIndex = 37;
            this.grpBoxSecondaryEffects.TabStop = false;
            this.grpBoxSecondaryEffects.Text = "Secondary Effects";
            // 
            // panelSecondaryEffects
            // 
            this.panelSecondaryEffects.AutoScroll = true;
            this.panelSecondaryEffects.Location = new System.Drawing.Point(7, 20);
            this.panelSecondaryEffects.Name = "panelSecondaryEffects";
            this.panelSecondaryEffects.Size = new System.Drawing.Size(367, 329);
            this.panelSecondaryEffects.TabIndex = 0;
            this.panelSecondaryEffects.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.panelSecondaryEffects_ControlRemoved);
            // 
            // btnAddSecondaryEffect
            // 
            this.btnAddSecondaryEffect.Enabled = false;
            this.btnAddSecondaryEffect.Location = new System.Drawing.Point(398, 263);
            this.btnAddSecondaryEffect.Name = "btnAddSecondaryEffect";
            this.btnAddSecondaryEffect.Size = new System.Drawing.Size(75, 23);
            this.btnAddSecondaryEffect.TabIndex = 38;
            this.btnAddSecondaryEffect.Text = "Add";
            this.btnAddSecondaryEffect.UseVisualStyleBackColor = true;
            this.btnAddSecondaryEffect.Click += new System.EventHandler(this.btnAddSecondaryEffect_Click);
            // 
            // panelPrimaryEffect
            // 
            this.panelPrimaryEffect.Controls.Add(this.txtBoxStrOptionalCost);
            this.panelPrimaryEffect.Controls.Add(this.txtBoxPowOptionalCost);
            this.panelPrimaryEffect.Controls.Add(this.txtBoxWPOptionalCost);
            this.panelPrimaryEffect.Controls.Add(this.txtBoxConOptionalCost);
            this.panelPrimaryEffect.Controls.Add(this.txtBoxDexOptionalCost);
            this.panelPrimaryEffect.Controls.Add(this.txtBoxAgiOptionalCost);
            this.panelPrimaryEffect.Controls.Add(this.lblPowTotal);
            this.panelPrimaryEffect.Controls.Add(this.lblWPTotal);
            this.panelPrimaryEffect.Controls.Add(this.lblConTotal);
            this.panelPrimaryEffect.Controls.Add(this.lblDexTotal);
            this.panelPrimaryEffect.Controls.Add(this.lblAgiTotal);
            this.panelPrimaryEffect.Controls.Add(this.numUDStr);
            this.panelPrimaryEffect.Controls.Add(this.lblStrTotal);
            this.panelPrimaryEffect.Controls.Add(this.numUDAgi);
            this.panelPrimaryEffect.Controls.Add(this.numUDPow);
            this.panelPrimaryEffect.Controls.Add(this.numUDDex);
            this.panelPrimaryEffect.Controls.Add(this.numUDWP);
            this.panelPrimaryEffect.Controls.Add(this.numUDCon);
            this.panelPrimaryEffect.Location = new System.Drawing.Point(102, 166);
            this.panelPrimaryEffect.Name = "panelPrimaryEffect";
            this.panelPrimaryEffect.Size = new System.Drawing.Size(228, 71);
            this.panelPrimaryEffect.TabIndex = 39;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Location = new System.Drawing.Point(12, 607);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(276, 13);
            this.lblGrandTotal.TabIndex = 41;
            this.lblGrandTotal.Text = "Grand Total: Str: 0, Agi: 0, Dex: 0, Con: 0, WP: 0, Pow: 0";
            // 
            // Tech_Creator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 642);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.lblAgi);
            this.Controls.Add(this.panelPrimaryEffect);
            this.Controls.Add(this.cBoxEffectList);
            this.Controls.Add(this.btnAddSecondaryEffect);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grpBoxSecondaryEffects);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblStr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDex);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCon);
            this.Controls.Add(this.txtBoxEffectFilePath);
            this.Controls.Add(this.cmbBoxEffectBonuses);
            this.Controls.Add(this.lblWP);
            this.Controls.Add(this.lblPow);
            this.Name = "Tech_Creator";
            this.Text = "Tech_Creator";
            this.Load += new System.EventHandler(this.Tech_Creator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUDStr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDAgi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDDex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDCon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDWP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDPow)).EndInit();
            this.grpBoxSecondaryEffects.ResumeLayout(false);
            this.panelPrimaryEffect.ResumeLayout(false);
            this.panelPrimaryEffect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxEffectFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBoxEffectBonuses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpBoxSecondaryEffects;
        private System.Windows.Forms.Button btnAddSecondaryEffect;
        private System.Windows.Forms.Panel panelSecondaryEffects;
        private System.Windows.Forms.Panel panelPrimaryEffect;
        private System.Windows.Forms.Label lblGrandTotal;
    }
}