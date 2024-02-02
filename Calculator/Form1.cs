using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace Calc2
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        string Operation;
        double Store;
        double min;
        List<string> InputHistory = new List<string>();
        int dotCtr = 0;
        int minCtr = 0;
        private bool isNegative = false;
        public Form1()
        {
            InitializeComponent();
        }



        private void n1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Contains("Error"))
            {
                textBox1.Text = textBox1.Text;
            }
            else if ((textBox1.Text == "0" || textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/") && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
            AppendToInputHistory("1");
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("Error"))
            {
                textBox1.Text = textBox1.Text;
            }
            else if ((textBox1.Text == "0" || textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/") && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
            AppendToInputHistory("2");
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("Error"))
            {
                textBox1.Text = textBox1.Text;
            }
            else if ((textBox1.Text == "0" || textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/") && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
            AppendToInputHistory("3");
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("Error"))
            {
                textBox1.Text = textBox1.Text;
            }
            else if ((textBox1.Text == "0" || textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/") && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
            AppendToInputHistory("4");
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("Error"))
            {
                textBox1.Text = textBox1.Text;
            }
            else if ((textBox1.Text == "0" || textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/") && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
            AppendToInputHistory("5");
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("Error"))
            {
                textBox1.Text = textBox1.Text;
            }
            else if ((textBox1.Text == "0" || textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/") && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
            AppendToInputHistory("6");
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("Error"))
            {
                textBox1.Text = textBox1.Text;
            }
            else if ((textBox1.Text == "0" || textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/") && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
            AppendToInputHistory("8");
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("Error"))
            {
                textBox1.Text = textBox1.Text;
            }
            else if ((textBox1.Text == "0" || textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/") && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
            AppendToInputHistory("7");
        }

        private void n0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("Error"))
            {
                textBox1.Text = textBox1.Text;
            }
            else if ((textBox1.Text == "0" || textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/") && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
            AppendToInputHistory("0");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void n9_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("Error"))
            {
                textBox1.Text = textBox1.Text;
            }
            else if ((textBox1.Text == "0" || textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/") && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
            AppendToInputHistory("9");
        }

        private void bad_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox1.Text) && textBox1.Text != "+" && textBox1.Text != "Cannot divide by zero" && textBox1.Text != ".")
                {
                    if (Operation != null)
                    {
                        double SecondNumber = Convert.ToDouble(textBox1.Text);
                        double Result = PerformOperation(FirstNumber, SecondNumber, Operation);

                        textBox1.Text = Convert.ToString(Result);
                        FirstNumber = Result;
                    }
                    else
                    {
                        FirstNumber = Convert.ToDouble(textBox1.Text);
                    }

                    textBox1.Text = "+";
                    Operation = "+";
                    dotCtr = 0;
                }
                AppendToInputHistory("+");
            }
            catch (Exception ex)
            {
                textBox1.Text = "Error";
                dotCtr = 0;
                // Handle the exception or log the error message
                Console.WriteLine(ex.Message);
            }

            
        }


        private void bsub_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox1.Text) && textBox1.Text != "Cannot divide by zero" && textBox1.Text != ".")
                {
                    if (Operation != null)
                    {
                        double SecondNumber = Convert.ToDouble(textBox1.Text);
                        if (textBox1.Text.StartsWith("-"))
                        {
                            SecondNumber *= -1;
                        }

                        double Result = PerformOperation(FirstNumber, SecondNumber, Operation);

                        textBox1.Text = Convert.ToString(Result);
                        FirstNumber = Result;
                    }
                    else
                    {
                        FirstNumber = Convert.ToDouble(textBox1.Text);
                    }

                    textBox1.Text = "-";
                    Operation = "-";
                    dotCtr = 0;
                }
                AppendToInputHistory("-");
            }
            catch (Exception ex)
            {
                textBox1.Text = "Error";
                dotCtr = 0;
                // Handle the exception or log the error message
                Console.WriteLine(ex.Message);
            }
           
        }

        private void bmult_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox1.Text) && textBox1.Text != "*" && textBox1.Text != "Cannot divide by zero" && textBox1.Text != ".")
                {
                    if (Operation != null)
                    {
                        double SecondNumber = Convert.ToDouble(textBox1.Text);
                        double Result = PerformOperation(FirstNumber, SecondNumber, Operation);

                        textBox1.Text = Convert.ToString(Result);
                        FirstNumber = Result;
                    }
                    else
                    {
                        FirstNumber = Convert.ToDouble(textBox1.Text);
                    }

                    textBox1.Text = "*";
                    Operation = "*";
                    dotCtr = 0;
                }
                AppendToInputHistory("*");
            }
            catch (Exception ex)
            {
                textBox1.Text = "Error";
                dotCtr = 0;
                // Handle the exception or log the error message
                Console.WriteLine(ex.Message);
            }
        }

        private void bdiv_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox1.Text) && textBox1.Text != "/" && textBox1.Text != "Cannot divide by zero" && textBox1.Text != ".")
                {
                    if (Operation != null)
                    {
                        double SecondNumber = Convert.ToDouble(textBox1.Text);
                        double Result = PerformOperation(FirstNumber, SecondNumber, Operation);

                        textBox1.Text = Convert.ToString(Result);
                        FirstNumber = Result;
                    }
                    else
                    {
                        FirstNumber = Convert.ToDouble(textBox1.Text);
                    }

                    textBox1.Text = "/";
                    Operation = "/";
                    dotCtr = 0;
                }
                AppendToInputHistory("/");
            }
            catch(Exception ex)
            {
                textBox1.Text = "Error";
                dotCtr = 0;
                // Handle the exception or log the error message
                Console.WriteLine(ex.Message);
            }
            
        }

        private void bc_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            dotCtr = 0;
        }

        private void ndot_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Contains (".") || textBox1.Text.Contains("Error"))
            {
                textBox1.Text = textBox1.Text;
            }
            else if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
            {
                textBox1.Text = "0" + ".";
            }
            else
            {
                textBox1.Text = textBox1.Text + ".";
                dotCtr = 1;
            }

        }

        private void nequal_Click(object sender, EventArgs e)
        {
            try
            {
                if (Operation != null)
                {
                    double SecondNumber = Convert.ToDouble(textBox1.Text);
                    if (SecondNumber == 0 && Operation == "/")
                    {
                        textBox1.Text = "Error";
                    }
                    else
                    {
                        double Result = PerformOperation(FirstNumber, SecondNumber, Operation);
                        textBox1.Text = Convert.ToString(Result);
                        FirstNumber = Result;
                        Operation = null;
                        // Clear input history before appending the new result
                        ClearInputHistory();
                        // Append the equals and result to the input history
                        AppendToInputHistory("=" + Result);
                    }



                    dotCtr = 0;


                }
            }
            catch(Exception ex )
            {
                textBox1.Text = "Error";
                dotCtr = 0;
                // Handle the exception or log the error message
                Console.WriteLine(ex.Message);
            }
            
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bce_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && textBox1.Text != "Cannot divide by zero")
            {
                if(textBox1.Text == "Error")
                {
                    textBox1.Text = "0";
                }
                else if (textBox1.Text.Length > 1)
                {
                    // Remove the last character from the text
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                }
                else
                {
                    // If there's only one character, set the text to "0"
                    textBox1.Text = "0";
                }
            }
        }
        private double PerformOperation(double firstNumber, double secondNumber, string operation)
        {
            try
            {
                switch (operation)
                {
                    case "+":
                        return firstNumber + secondNumber;
                    case "-":
                        return firstNumber - secondNumber;
                    case "*":
                        return firstNumber * secondNumber;
                    case "/":
                        if (Math.Abs(secondNumber) < double.Epsilon)
                        {
                            textBox1.Text = "Cannot divide by zero";
                            dotCtr = 0;
                            // Handle the error differently based on your requirements
                            return 0;
                        }
                        else
                        {
                            return firstNumber / secondNumber;
                        }
                    default:
                        throw new InvalidOperationException("Invalid operation");
                }
            }
            catch (Exception ex)
            {
                textBox1.Text = "Error";
                dotCtr = 0;
                // Handle the exception or log the error message
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        private void AppendToInputHistory(string input)
        {
            // Only add entries that represent answers (start with '=')
            if (input.StartsWith("="))
            {
                InputHistory.Add(input);
                // Display the input history horizontally in a ListBox
                listBoxInputHistory.Items.Add(string.Join(" ", InputHistory));
            }
        }
        private void listBoxInputHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Set the textbox text to the selected item in the input history
            if (listBoxInputHistory.SelectedIndex >= 0 && listBoxInputHistory.SelectedIndex < InputHistory.Count)
            {
                textBox1.Text = InputHistory[listBoxInputHistory.SelectedIndex];
            }
        }
        private void textBoxInputHistory_TextChanged(object sender, EventArgs e)
        {
            // Optionally handle events when the input history textbox text changes
        }
        private void ClearInputHistory()
        {
            InputHistory.Clear();
            listBoxInputHistory.Items.Clear();
        }

        private void bPlusMinus_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox1.Text) && textBox1.Text != "+" && textBox1.Text != "Cannot divide by zero" && textBox1.Text != ".")
                {
                    double currentInput = Convert.ToDouble(textBox1.Text);
                    currentInput = -currentInput;

                    textBox1.Text = Convert.ToString(currentInput);
                    isNegative = !isNegative;

                    // Update the input history with the current state of the sign
                    if (isNegative)
                    {
                        AppendToInputHistory("(-)");
                    }
                    else
                    {
                        AppendToInputHistory("(+)");
                    }
                }
            }
            catch(Exception ex) 
            {
                textBox1.Text = "Error";
                dotCtr = 0;
                // Handle the exception or log the error message
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
