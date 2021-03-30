using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CalculatorLibrary;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }        

        private void Number_button_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(" ");
            MyButton myButton = (MyButton)sender;
            if  (Display.Value_Result == 0)
            {
                if (myButton.Value != 0)
                {
                    Display.Text = "";
                }
                if (myButton.Value == 0)
                {
                    return;
                }
            }
            Display.Value_Result += Display.Value_Result * 10 + myButton.Value;
            Display.Text = regex.Replace(Display.Text, string.Empty);
            Display.Text += myButton.Text + " ";
        }

        private void SignChange_Click(object sender, EventArgs e)
        {
            if (Display.Value_Result != 0)
            {
                if (Display.Text[0] == '-')
                {
                    Regex regex = new Regex("-");
                    Display.Text = regex.Replace(Display.Text, string.Empty);
                }
                else
                {                    
                    string tmp = "-";
                    tmp += Display.Text;
                    Display.Text = tmp;
                }
                Display.Value_Result *= -1;
            }
        }

        private void DecimalPoint_Click(object sender, EventArgs e)
        {
            bool check = false;
            for (int i = 0; i < Display.Text.Length; i++)
            {
                if (Display.Text[i] == ',')
                {
                    check = true;
                }
            }
            if (check)
            {
                return;
            }
            if (Display.Value_Result != 0)
            {
                Regex regex = new Regex(" ");
                Display.Text = regex.Replace(Display.Text, string.Empty);
                Display.Text += ", ";
            }
            else
            {
                Display.Text = "0, ";
            }
            
        }

        private void Subtraction_Click(object sender, EventArgs e)
        {
            Display.Value_Result -= Display.Value_Tmp;
            if (Display.Value_Result == 0)
            {
                Display.Text = "0 ";
            }
            else
            {
                Display.Text = Convert.ToString(Display.Value_Result) + " ";
            }

        }
        
        private void Addition_Click(object sender, EventArgs e)
        {
            Display.Value_Result += Display.Value_Tmp;
            if (Display.Value_Result == 0)
            {
                Display.Text = "0 ";
            }
            else
            {
                Display.Text = Convert.ToString(Display.Value_Result) + " ";
            }
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            Display.Value_Result *= Display.Value_Tmp;
            if (Display.Value_Result == 0)
            {
                Display.Text = "0 ";
            }
            else
            {
                Display.Text = Convert.ToString(Display.Value_Result) + " ";
            }
        }
        private void Division_Click(object sender, EventArgs e)
        {
            if (Display.Value_Tmp == 0)
            {
                throw new Exception("Нельзя так делать");
            }
            Display.Value_Result /= Display.Value_Tmp;
            if (Display.Value_Result == 0)
            {
                Display.Text = "0 ";
            }
            else
            {
                Display.Text = Convert.ToString(Display.Value_Result) + " ";
            }            
        }
        private void Solve_Click(object sender, EventArgs e)
        {
            Display.Value_Result -= Display.Value_Tmp;
            Display.Text = Convert.ToString(Display.Value_Result) + " ";
        }        
    }    
}
