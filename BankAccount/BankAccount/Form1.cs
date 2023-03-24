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

namespace BankAccount
{
    public partial class Form1 : Form
    {
        double balance = 0.0;
        int numDeposits = 0;
        double totalDeposits = 0.0;
        int numChecks = 0;
        double totalChecks = 0.0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double amount = 0.0;

                if (double.TryParse(AmounTxtBox.Text, out amount))
                {
                    if (DepositrBtn.Checked)
                    {
                        balance += amount;
                        numDeposits++;
                        totalDeposits += amount;

                    }
                    else if (CheckrBtn.Checked)
                    {
                        if (balance - amount < 0)
                        {
                            MessageBox.Show("Insufficient Funds");
                            balance -= 10;
                        }
                        else
                        {
                            balance -= amount;
                            numChecks++;
                            totalChecks += amount;
                        }
                    }
                    else if (ServiceChargerBtn.Checked)
                    {
                        balance -= amount;
                    }

                    if (balance < 0)
                    {
                        MessageBox.Show("New Balance is Negative");
                        balance = 0;
                    }

                    BalanceTxtBox.Text = balance.ToString("C");
                }
                else
                {
                    MessageBox.Show("Invalid Input");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            balance = 0.0;
            numDeposits = 0;
            totalDeposits = 0.0;
            numChecks = 0;
            totalChecks = 0.0;

            BalanceTxtBox.Text = balance.ToString("C");
            AmounTxtBox.Text = "";
            DepositrBtn.Checked = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Number of Deposits: " + numDeposits + "\nTotal Deposit Amount: " + totalDeposits.ToString("C") + "\nNumber of Checks: " + numChecks + "\nTotal Check Amount: " + totalChecks.ToString("C"));       
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}