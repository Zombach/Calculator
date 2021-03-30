using System.Windows.Forms;

namespace CalculatorLibrary
{
    public class MyButton : Button
    {
        public Button Button;
        public double Value { get; set; }

        public MyButton()
        {
            Button = new Button();
            Value = 0;
        }
    }
}
