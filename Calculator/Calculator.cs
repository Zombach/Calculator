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

        // LastAction
        // 0 - небыло действий, 1 - сложение, 2 - вычитание
        // 3 - умножение, 4 - деление
        private void Number_button_Click(object sender, EventArgs e)
        {
            MyButton myButton = (MyButton)sender;
            Regex regex = new Regex(" ");
            Display.Check_Solve_Repeat = false;
            if (CheckFirstAction())
            {
                Display.Text = "0    ";
                Display.FirstAction = false;
            }

            if (Display.Text == "0    ")
            {
                if (myButton.Value != 0)
                {
                    Display.Text = "";
                }
                if (myButton.Value == 0)
                {
                    Display.Value_Tmp[0] = 0;
                    return;
                }
                Display.Value_Tmp[0] = 0;
            }

            Display.Check_E_Count++;

            if (Display.Check_E_Count > 19)
            {
                string plusOrMinus;
                if (Display.Value_Tmp[0] > 1 )
                {
                    plusOrMinus = "+";
                }
                else
                {
                    plusOrMinus = "-";
                }

                Display.Text = "1E" + plusOrMinus + Display.Check_E_Count + "    ";
                if (!Display.Check_Decimal_Point)
                {
                    Display.Value_Tmp[0] = Display.Value_Tmp[0] * 10 + myButton.Value;
                }
                else
                {
                    Display.Value_Tmp[1] = Display.Value_Tmp[0] * 10 + myButton.Value;
                    Display.Value_Tmp[3] += 1;
                }
                Display.Value_Tmp[0] = Display.Value_Tmp[0] + Display.Value_Tmp[1] / (Display.Value_Tmp[2] * 10);
                return;
            }
            if (!Display.Check_Decimal_Point)
            {
                Display.Value_Tmp[0] = Display.Value_Tmp[0] * 10 + myButton.Value;
            }
            else
            {
                Display.Value_Tmp[1] = Display.Value_Tmp[1] * 10 + myButton.Value;
                Display.Value_Tmp[2] += 1;
            }
            Display.Value_Tmp[0] = Display.Value_Tmp[0] + Display.Value_Tmp[1] / (Display.Value_Tmp[2] * 10);
            Display.Text = regex.Replace(Display.Text, string.Empty);
            Display.Text += myButton.Text + "    ";
        }

        private bool CheckFirstAction()
        {
            if (Display.FirstAction) return true;
            return false;
        }

        private void SignChange_Click(object sender, EventArgs e)
        {
            if (Display.Text != "0    ")
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
                Display.Value_Tmp[0] *= -1;
            }
        }

        private void DecimalPoint_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Display.Text.Length; i++)
            {
                if (Display.Text[i] == ',')
                {
                    Display.Check_Decimal_Point = true;
                    break;
                }
            }

            if (Display.Check_Decimal_Point)
            {
                if (Display.Text[Display.Text.Length - 5] == ',')
                {
                    Regex regex = new Regex(",");
                    Display.Text = regex.Replace(Display.Text, string.Empty);
                    Display.Check_Decimal_Point = false;
                }
                return;
            }

            if (Display.Value_Tmp[0] != 0)
            {
                Regex regex = new Regex(" ");
                Display.Text = regex.Replace(Display.Text, string.Empty);
                Display.Text += ",    ";
            }
            else
            {
                Display.Text = "0,    ";
            }
            Display.Check_Decimal_Point = true;
        }
        private bool CheckSolveRepeat(Button btn)
        {
            if (btn.Name == "Addition" || btn.Name == "Subtraction" || 
                btn.Name == "Multiplication" || btn.Name == "Division")
            {
                Display.Check_Solve_Repeat = false;
            }
            return Display.Check_Solve_Repeat;
        }
        private void Addition_Click(Button btn)
        {
            CheckSolveRepeat(btn);
            Display.Value_Result += Display.Value_Tmp[0];
            TmpDisplay.Text = Convert.ToString(Display.Value_Result) + "    ";
            Display.Text = "0    ";
            Display.Check_E_Count = 0;
            Display.Value_Tmp[0] = 0;
        }

        private void Subtraction_Click(Button btn)
        {
            CheckSolveRepeat(btn);
            Display.Value_Result -= Display.Value_Tmp[0];
            TmpDisplay.Text = Convert.ToString(Display.Value_Result) + "    ";         
            Display.Text = "0    ";
            Display.Check_E_Count = 0;
            Display.Value_Tmp[0] = 0;
        }

        private void Multiplication_Click(Button btn)
        {
            CheckSolveRepeat(btn);
            Display.Value_Result *= Display.Value_Tmp[0];
            TmpDisplay.Text = Convert.ToString(Display.Value_Result) + "    ";
            Display.Text = "0    ";
            Display.Check_E_Count = 0;
            Display.Value_Tmp[0] = 0;
        }
        private void Division_Click(Button btn)
        {
            if (Display.Value_Tmp[0] == 0)
            {
                throw new Exception("Нельзя так делать");
            }
            CheckSolveRepeat(btn);
            Display.Value_Result /= Display.Value_Tmp[0];
            TmpDisplay.Text = Convert.ToString(Display.Value_Result) + "    ";
            Display.Text = "0    ";
            Display.Check_E_Count = 0;
            Display.Value_Tmp[0] = 0;
        }
        private void Solve_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Display.Value_Last = Display.Value_Tmp[0];
            switch (btn.Name)
            {
                case "Addition":
                    Addition_Click(btn);
                    break;
                case "Subtraction":
                    Subtraction_Click(btn);
                    break;
                case "Multiplication":
                    Multiplication_Click(btn);
                    break;
                case "Division":
                    Division_Click(btn);
                    break;
                default:
                    break;
            }
            if (!Display.Check_Solve_Repeat && btn.Name == "Solve")
            {
                Display.Check_Solve_Repeat = true;
            }
            else if (Display.Check_Solve_Repeat && btn.Name == "Solve")
            {
                TmpDisplay.Text = "Повторение действия    ";
            }
            Display.FirstAction = true;
            Display.Check_E_Count = 0;
            Display.Value_Tmp[2] = 1;
            Display.Check_Decimal_Point = false;
        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            double tmp = Display.Value_Tmp[0] % 10;
            switch (tmp)
            {
                case 0:
                    tmp = 0;
                    break;
                case 1:
                    tmp = 1;
                    break;
                case 2:
                    tmp = 2;
                    break;
                case 3:
                    tmp = 3;
                    break;
                case 4:
                    tmp = 4;
                    break;
                case 5:
                    tmp = 5;
                    break;
                case 6:
                    tmp = 6;
                    break;
                case 7:
                    tmp = 7;
                    break;
                case 8:
                    tmp = 8;
                    break;
                case 9:
                    tmp = 9;
                    break;
                default:                    
                    break;
            }
            Display.Value_Tmp[0] -= tmp;

            if (Display.Value_Tmp[0] != 0)
            {
                Display.Value_Tmp[0] /= 10;
                Display.Text = Convert.ToString(Display.Value_Tmp) + "    ";
                Display.Check_E_Count--;
            }
            else
            {
                Display.Text = "0    ";
                Display.Check_E_Count = 0;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            TmpDisplay.Text = "";
            TmpDisplay.Value_Result = 0;
            TmpDisplay.Value_Tmp[0] = 0;
            TmpDisplay.Value_Tmp[1] = 0;

            Display.Text = "0    ";
            Display.FirstAction = true;
            Display.Check_E_Count = 0;
            Display.Value_Tmp[0] = 0;
            Display.Value_Tmp[1] = 0;
            Display.Value_Tmp[2] = 1;
            Display.Value_Result = 0;
        }

        private void ClearAction_Click(object sender, EventArgs e)
        {
            Display.Text = "0    ";
            Display.Check_E_Count = 0;
            Display.Value_Tmp[0] = 0;
            Display.Value_Tmp[1] = 0;
            Display.Value_Tmp[2] = 1;
        }
    }    
}
