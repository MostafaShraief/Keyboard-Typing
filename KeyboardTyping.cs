using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private struct stSettings
        {
            public Color DefaulttxtColor;
            public Color WrongtxtColor;
            public Color CorrecttxtColor;
            public Color BackgroundtxtColor;
        }

        private stSettings Settings;

        void InitializeKeyboard()
        {
            // each keyboard buttob replace its text characters that
            // contains "--" by new line and change its hover state color too.
            foreach (var item in flp1.Controls)
            {
                if (item.GetType() == b1.GetType())
                {
                    Guna2Button btn = item as Guna2Button;
                    btn.Text = btn.Text.Replace("--", "\n");
                    btn.HoverState.FillColor = btn.FillColor;
                }
            }
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

        void KeyboardPress()
        {

        }

        private void StopTyping()
        {
            rtxtInput.Enabled = false;
            rtxtOutput.Enabled = false;
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
            InitializeKeyboard();
        }

        private void rtxtInput_KeyDown(object sender, KeyEventArgs e)
        {
            PreventClick(e);
        }

        private void rtxtOutput_Click(object sender, EventArgs e)
        {
            rtxtInput.Focus();
        }
    }
}
