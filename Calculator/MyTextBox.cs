using System.Windows.Forms;

namespace CalculatorLibrary
{
    public class MyTextBox : TextBox
    {
        public TextBox textBox;
        public bool FirstAction { get; set; }
        public bool Check_Decimal_Point { get; set; }
        public bool Check_Solve_Repeat { get; set; }
        public int Check_E_Count { get; set; }
        public double Value_Result { get; set; }
        public double[] Value_Tmp { get; set; }
        public double Value_Last { get; set; }


        public MyTextBox()
        {
            textBox = new TextBox();
            FirstAction = true;
            Check_Decimal_Point = false;
            Check_Solve_Repeat = false;
            Check_E_Count = 0;
            Value_Tmp = new double[3] { 0D, 0D, 1D };
            Value_Result = 0D;
            Value_Last = 0D;
        }
    }
}