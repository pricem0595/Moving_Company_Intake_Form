using System.Drawing;
using System.Windows.Forms;

namespace MovingIntake
{
    public class TextBoxLogic
    {

        private static readonly Font leavingFont = new Font("Mongolian Baiti", 12F, FontStyle.Italic);
        private static readonly Font enteringFont = new Font("Mongolian Baiti", 12F);

        public static void EnterTextBox(object sender, string defaultText)
        {
            TextBox passedBox = (TextBox)sender;

            if (passedBox.Text == defaultText)
            {
                passedBox.Clear();
                passedBox.ForeColor = Color.Black;
                passedBox.Font = enteringFont;
            }
        }
        public static void LeaveTextBox(object sender, string defaultText)
        {
            TextBox passedBox = (TextBox)sender;

            if (passedBox.Text == "")
            {
                passedBox.Font = leavingFont;
                passedBox.ForeColor = SystemColors.ControlDark;
                passedBox.Text = defaultText;
            }
        }
        public static void ResetTextBox(TextBox passedBox, string defaultText)
        {
            passedBox.Clear();
            passedBox.ForeColor = SystemColors.ControlDark;
            passedBox.Text = defaultText;
        }

    }
}
