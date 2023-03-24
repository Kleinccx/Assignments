namespace BankAccount
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ServiceChargerBtn = new System.Windows.Forms.RadioButton();
            this.CheckrBtn = new System.Windows.Forms.RadioButton();
            this.DepositrBtn = new System.Windows.Forms.RadioButton();
            this.AmounTxtBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.BalanceTxtBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ServiceChargerBtn);
            this.groupBox1.Controls.Add(this.CheckrBtn);
            this.groupBox1.Controls.Add(this.DepositrBtn);
            this.groupBox1.Location = new System.Drawing.Point(54, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transaction";
            // 
            // ServiceChargerBtn
            // 
            this.ServiceChargerBtn.AutoSize = true;
            this.ServiceChargerBtn.Location = new System.Drawing.Point(37, 66);
            this.ServiceChargerBtn.Name = "ServiceChargerBtn";
            this.ServiceChargerBtn.Size = new System.Drawing.Size(98, 17);
            this.ServiceChargerBtn.TabIndex = 2;
            this.ServiceChargerBtn.TabStop = true;
            this.ServiceChargerBtn.Text = "Service Charge";
            this.ServiceChargerBtn.UseVisualStyleBackColor = true;
            // 
            // CheckrBtn
            // 
            this.CheckrBtn.AutoSize = true;
            this.CheckrBtn.Location = new System.Drawing.Point(37, 42);
            this.CheckrBtn.Name = "CheckrBtn";
            this.CheckrBtn.Size = new System.Drawing.Size(56, 17);
            this.CheckrBtn.TabIndex = 1;
            this.CheckrBtn.TabStop = true;
            this.CheckrBtn.Text = "Check";
            this.CheckrBtn.UseVisualStyleBackColor = true;
            // 
            // DepositrBtn
            // 
            this.DepositrBtn.AutoSize = true;
            this.DepositrBtn.Location = new System.Drawing.Point(37, 19);
            this.DepositrBtn.Name = "DepositrBtn";
            this.DepositrBtn.Size = new System.Drawing.Size(61, 17);
            this.DepositrBtn.TabIndex = 0;
            this.DepositrBtn.TabStop = true;
            this.DepositrBtn.Text = "Deposit";
            this.DepositrBtn.UseVisualStyleBackColor = true;
            // 
            // AmounTxtBox
            // 
            this.AmounTxtBox.Location = new System.Drawing.Point(54, 10);
            this.AmounTxtBox.Name = "AmounTxtBox";
            this.AmounTxtBox.Size = new System.Drawing.Size(152, 20);
            this.AmounTxtBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(284, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(284, 94);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(284, 123);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Summary";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(2, 147);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(46, 13);
            this.balanceLabel.TabIndex = 7;
            this.balanceLabel.Text = "Balance";
            // 
            // BalanceTxtBox
            // 
            this.BalanceTxtBox.Location = new System.Drawing.Point(54, 147);
            this.BalanceTxtBox.Name = "BalanceTxtBox";
            this.BalanceTxtBox.Size = new System.Drawing.Size(152, 20);
            this.BalanceTxtBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 172);
            this.Controls.Add(this.BalanceTxtBox);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AmounTxtBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(2, 3, 1, 2);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ServiceChargerBtn;
        private System.Windows.Forms.RadioButton CheckrBtn;
        private System.Windows.Forms.RadioButton DepositrBtn;
        private System.Windows.Forms.TextBox AmounTxtBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.TextBox BalanceTxtBox;
    }
}

