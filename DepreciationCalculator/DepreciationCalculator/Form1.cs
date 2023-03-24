using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepreciationCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                decimal cost = decimal.Parse(initialCostTextBox.Text);
                decimal salvageValue = decimal.Parse(salvageValueTextBox.Text);
                int usefulLife = int.Parse(usefulLifeComboBox.SelectedItem.ToString());

                // Compute depreciation schedule
                List<(int year, decimal depreciation, decimal bookValue)> depreciationSchedule = new List<(int, decimal, decimal)>();

                decimal bookValue = cost;
                decimal depreciationPerYear = 0;

                for (int year = 1; year <= usefulLife; year++)
                {
                    if (straightLineRadioButton.Checked)
                    {
                        depreciationPerYear = SLN(cost, salvageValue, usefulLife);
                    }
                    else if (sumOfTheYearsDigitsRadioButton.Checked)
                    {
                        depreciationPerYear = SYD(cost, salvageValue, usefulLife, year);
                    }

                    bookValue -= depreciationPerYear;
                    depreciationSchedule.Add((year, depreciationPerYear, bookValue));
                }

                // Display depreciation schedule in list box
                depreciationScheduleListBox.Items.Clear();
                depreciationScheduleListBox.Items.Add($"Year\tDepreciation\tBook Value");

                foreach (var item in depreciationSchedule)
                {
                    depreciationScheduleListBox.Items.Add($"{item.year}\t {item.depreciation:C}\t\t {item.bookValue:C}");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter valid numeric values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    
            private decimal SLN(decimal cost, decimal salvageValue, int usefulLife)
        {
            return (cost - salvageValue) / usefulLife;
        }

        private decimal SYD(decimal cost, decimal salvageValue, int usefulLife, int period)
        {
            int remainingLife = usefulLife - period + 1;
            int totalPeriods = (usefulLife * (usefulLife + 1)) / 2;

            return remainingLife * (cost - salvageValue) / totalPeriods;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                usefulLifeComboBox.Items.Add(i);
            }
            // Set the default value to 5.
            usefulLifeComboBox.SelectedIndex = 4;

    

        }
    }
}
