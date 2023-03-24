using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operators
{
    public partial class Form1 : Form
    {
        private double accumulator = 0.0;

        public Form1()
        {
            InitializeComponent();
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Please enter a valid input.");
                return;
            }

            string op = "";
            double operand = 0.0;
            ScanData(input, out op, out operand);

            if (op == "q")
            {
                Results.Items.Add($"Final result " + accumulator);
                accumulator = 0.0;

                return;
            }
            DoNextOperation(op, operand, ref accumulator);
           
        }


        private void ScanData(string input, out string op, out double operand)
        {
            string[] parts = input.Split(' ');

            if (parts.Length != 2)
            {
                op = "";
                operand = 0.0;
                MessageBox.Show("Invalid input format. Please enter an operator followed by a number.");
                return;
            }

            op = parts[0];
            double.TryParse(parts[1], out operand);
        }

        private void DoNextOperation(string op, double operand, ref double accumulator)
        {
            switch (op)
            {
                case "+":
                    accumulator += operand;
                    Results.Items.Add($"result so far is {accumulator}.0");
                    textBox1.Text = "";
                    break;

                case "-":
                    accumulator -= operand;
                    Results.Items.Add($"the result so far is {accumulator}");
                    textBox1.Text = "";
                    break;

                case "q":
                    accumulator *= operand;  
                    break;

                case "/":
                    if (operand != 0)
                    {
                        accumulator /= operand;
                        Results.Items.Add($"the result so far is {accumulator}");
                        textBox1.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Cannot divide by zero.");
                    }
                    break;

                case "^":
                    accumulator = Math.Pow(accumulator, operand);
                    Results.Items.Add($"the result so far is {accumulator}.");
                    textBox1.Text = ""; 
                    break;

                default:
                    MessageBox.Show($"Unknown operator: {op}");
                    break;
            }
        }
    }
    }
