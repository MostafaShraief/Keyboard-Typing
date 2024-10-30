using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keyboard_Typing
{
    public partial class KeyboardTyping : Form
    {
        public KeyboardTyping()
        {
            InitializeComponent();
        }

        private struct stText
        {
            public string Input;
            public string Output;
        }

        private stText text;

        Dictionary<Keys, List <Guna2Button>> DicButtons = new Dictionary<Keys, List<Guna2Button>>();

        private struct stSettings
        {
            public Color DefaulttxtColor;
            public Color WrongtxtColor;
            public Color CorrecttxtColor;
            public Color BackgroundtxtColor;
            public Color ClickedButtonColor;
        }

        private stSettings Settings;

        void GetKeyboardButtons()
        {

            foreach (var item in flp1.Controls)
            {
                // Check if 'item' is a keyboard button and its tag is not null.
                if (item is Guna2Button button && button.Tag != null)
                {
                    // Convert the Tag to a Keys value if it matches
                    if (Enum.TryParse(button.Tag.ToString(), true, out Keys key))
                    {

                        if (!DicButtons.ContainsKey(key))
                            DicButtons[key] = new List<Guna2Button>();

                        DicButtons[key].Add(button);

                    }
                }
            }

        }

        void EditTextKeyboardButtons()
        {
            // each keyboard button replace its text characters that
            // contains "--" by new line and change its hover state color too.
            foreach (var item in DicButtons)
            {
                item.Value.ForEach(btn =>
                {
                    btn.Text = btn.Text.Replace("--", "\n");
                    btn.HoverState.FillColor = btn.FillColor;
                });
            }

        }

        void InitializeKeyboard()
        {
            GetKeyboardButtons();
            EditTextKeyboardButtons();
        }

        void PreventClick(KeyEventArgs e)
        {
            // Block Ctrl-based shortcuts (Ctrl + A, C, X, V, etc.)
            if (e.Control)
            {
                e.SuppressKeyPress = true;
            }

            // Block arrow keys, home, end, and tab keys for navigation
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right ||
                e.KeyCode == Keys.Up || e.KeyCode == Keys.Down ||
                e.KeyCode == Keys.Home || e.KeyCode == Keys.End ||
                e.KeyCode == Keys.Tab ||
                e.KeyCode == Keys.PageUp)
            {
                e.SuppressKeyPress = true;
            }
        }

        void ProcessKeyDown(Guna2Button btn)
        {
            // get color of button before changing it, and save it in tag property
            if (!(btn.Tag is Color))
                btn.Tag = btn.FillColor;

            // apply key down status settings
            btn.FillColor = Settings.ClickedButtonColor;
            btn.HoverState.FillColor = Settings.ClickedButtonColor;

        }

        void ProcessKeyUp(Guna2Button btn)
        {
            // check if tag contains color or not
            if ((btn.Tag is Color))
            {
                // apply original button color settings
                btn.FillColor = (Color)btn.Tag;
                btn.HoverState.FillColor = (Color)btn.Tag;
            }
        }

        void KeyboardPress(KeyEventArgs Key, bool IsKeyDown)
        {
            // Apply settings on the pressed button,
            // according to key down or key up status.
            foreach (var item in DicButtons)
            {
                // find keyboard button pressed
                if (Key.KeyCode == item.Key)
                {
                    foreach (var btn in item.Value)
                    {
                        if (IsKeyDown)
                            ProcessKeyDown(btn); // apply key down status
                        else
                            ProcessKeyUp(btn);  // apply key up status
                    }
                    break; // stop searching after apply settings.
                }
            }

        }

        void RestoreKeyboardButtonsStatus()
        {

            // Restore default settings for all buttons.
            foreach (var item in DicButtons)
            {
                foreach (var btn in item.Value)
                    ProcessKeyUp(btn);
            }

        }

        private void StopTyping()
        {
            RestoreKeyboardButtonsStatus(); // Restore default settings for all buttons.
            rtxtInput.Enabled = false; // stop enter more characters.
            rtxtOutput.Enabled = false; // to ignore typing in 'rtxtoutput'.
        }

        void ChangeCharProperties(int ind, int range, Color color, FontStyle fontStyle = FontStyle.Regular)
        {

            // select correspond character
            rtxtOutput.Select(ind, range);
            // change its color
            rtxtOutput.SelectionColor = color;
            // change background color
            if (color != Settings.DefaulttxtColor)
                rtxtOutput.SelectionBackColor = Settings.BackgroundtxtColor;
            else
                rtxtOutput.SelectionBackColor = Color.Transparent;
            // change font style
            rtxtOutput.SelectionFont = new Font(rtxtOutput.SelectionFont, fontStyle);

        }

        bool CheckingText()
        {
            // Check the entered character if match and change its color.

            text.Input = rtxtInput.Text;
            text.Output = rtxtOutput.Text;

            // iterate each character from end to start, and leave if there are new line.
            if (text.Input.Length <= text.Output.Length)
            {
                for (int i = text.Input.Length - 1; i >= 0; --i)
                {

                    if (text.Input[i] == text.Output[i])
                    {
                        ChangeCharProperties(i, 1, Settings.CorrecttxtColor);
                    }
                    else
                    {
                        ChangeCharProperties(i, 1, Settings.WrongtxtColor);
                    }

                    if (text.Output[i] == '\n')
                        break;

                }
            }

            // This important if the key pressed is delete key.
            if (text.Input.Length < text.Output.Length)
            ChangeCharProperties(text.Input.Length, 1, Settings.DefaulttxtColor, FontStyle.Underline);

            // This to disable underline style to ignore remove characters.
            if (text.Input.Length < text.Output.Length - 1)
                ChangeCharProperties(text.Input.Length + 1, 1, Settings.DefaulttxtColor);

            return (text.Input.Length == text.Output.Length);

        }

        private void rtxtInput_TextChanged(object sender, EventArgs e)
        {
            // Check Completed text length and stop if true.
            if (CheckingText())
                StopTyping();
        }

        private void KeyboardTyping_Load(object sender, EventArgs e)
        {
            Settings.DefaulttxtColor = Color.Black;
            Settings.WrongtxtColor = Color.Red;
            Settings.CorrecttxtColor = Color.Green;
            Settings.BackgroundtxtColor = Color.Yellow;
            Settings.ClickedButtonColor = Color.Blue;
            InitializeKeyboard();
        }

        private void rtxtInput_KeyDown(object sender, KeyEventArgs e)
        {
            PreventClick(e);
            KeyboardPress(e, true);
        }
        private void rtxtInput_KeyUp(object sender, KeyEventArgs e)
        {
            KeyboardPress(e, false);
        }

        private void rtxtOutput_Click(object sender, EventArgs e)
        {
            rtxtInput.Focus();
        }

    }
}
