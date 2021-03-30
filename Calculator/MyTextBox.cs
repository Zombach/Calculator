using System.Windows.Forms;

namespace CalculatorLibrary
{
    public class MyTextBox : TextBox
    {
        public TextBox textBox;
        public bool FirstAction { get; set; }
        public double Value_Result { get; set; }
        public double Value_Tmp { get; set; }

        public MyTextBox()
        {
            textBox = new TextBox();
            Value_Tmp = 0;
            Value_Result = Value_Tmp;
            FirstAction = true;
        }
    }
}