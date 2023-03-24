namespace DepreciationCalculator
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.initialCostTextBox = new System.Windows.Forms.TextBox();
            this.salvageValueTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sumOfTheYearsDigitsRadioButton = new System.Windows.Forms.RadioButton();
            this.straightLineRadioButton = new System.Windows.Forms.RadioButton();
            this.usefulLifeComboBox = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.depreciationScheduleListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Initial Cost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Salvage Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Life";
            // 
            // initialCostTextBox
            // 
            this.initialCostTextBox.Location = new System.Drawing.Point(94, 6);
            this.initialCostTextBox.Name = "initialCostTextBox";
            this.initialCostTextBox.Size = new System.Drawing.Size(153, 20);
            this.initialCostTextBox.TabIndex = 1;
            // 
            // salvageValueTextBox
            // 
            this.salvageValueTextBox.Location = new System.Drawing.Point(94, 32);
            this.salvageValueTextBox.Name = "salvageValueTextBox";
            this.salvageValueTextBox.Size = new System.Drawing.Size(153, 20);
            this.salvageValueTextBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sumOfTheYearsDigitsRadioButton);
            this.groupBox1.Controls.Add(this.straightLineRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(306, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Depreciation";
            // 
            // sumOfTheYearsDigitsRadioButton
            // 
            this.sumOfTheYearsDigitsRadioButton.AutoSize = true;
            this.sumOfTheYearsDigitsRadioButton.Location = new System.Drawing.Point(41, 54);
            this.sumOfTheYearsDigitsRadioButton.Name = "sumOfTheYearsDigitsRadioButton";
            this.sumOfTheYearsDigitsRadioButton.Size = new System.Drawing.Size(88, 17);
            this.sumOfTheYearsDigitsRadioButton.TabIndex = 1;
            this.sumOfTheYearsDigitsRadioButton.TabStop = true;
            this.sumOfTheYearsDigitsRadioButton.Text = "Sum of Years";
            this.sumOfTheYearsDigitsRadioButton.UseVisualStyleBackColor = true;
            // 
            // straightLineRadioButton
            // 
            this.straightLineRadioButton.AutoSize = true;
            this.straightLineRadioButton.Location = new System.Drawing.Point(41, 23);
            this.straightLineRadioButton.Name = "straightLineRadioButton";
            this.straightLineRadioButton.Size = new System.Drawing.Size(84, 17);
            this.straightLineRadioButton.TabIndex = 0;
            this.straightLineRadioButton.TabStop = true;
            this.straightLineRadioButton.Text = "Straight Line";
            this.straightLineRadioButton.UseVisualStyleBackColor = true;
            this.straightLineRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // usefulLifeComboBox
            // 
            this.usefulLifeComboBox.FormattingEnabled = true;
            this.usefulLifeComboBox.Location = new System.Drawing.Point(94, 59);
            this.usefulLifeComboBox.Name = "usefulLifeComboBox";
            this.usefulLifeComboBox.Size = new System.Drawing.Size(87, 21);
            this.usefulLifeComboBox.TabIndex = 4;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold);
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(91, 108);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(153, 15);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Depreciation Schedule";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // depreciationScheduleListBox
            // 
            this.depreciationScheduleListBox.FormattingEnabled = true;
            this.depreciationScheduleListBox.Location = new System.Drawing.Point(67, 135);
            this.depreciationScheduleListBox.Name = "depreciationScheduleListBox";
            this.depreciationScheduleListBox.Size = new System.Drawing.Size(239, 121);
            this.depreciationScheduleListBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Update Schedule";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(328, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 268);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.depreciationScheduleListBox);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.usefulLifeComboBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.salvageValueTextBox);
            this.Controls.Add(this.initialCostTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox initialCostTextBox;
        private System.Windows.Forms.TextBox salvageValueTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton sumOfTheYearsDigitsRadioButton;
        private System.Windows.Forms.RadioButton straightLineRadioButton;
        private System.Windows.Forms.ComboBox usefulLifeComboBox;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ListBox depreciationScheduleListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

