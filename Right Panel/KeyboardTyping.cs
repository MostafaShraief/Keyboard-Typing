using Guna.UI2.WinForms;
using Keyboard_Typing.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
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

        Dictionary<Keys, List <Guna2Button>> DicButtons;

        Dictionary<string,  List <Guna2Button>> KeyboardButtonsColorGroups;

        private struct stSettings
        {
            public Color DefaulttxtColor;
            public Color WrongtxtColor;
            public Color CorrecttxtColor;
            public Color DefaultBackgroundtxtColor;
            public Color CorrectBackgroundtxtColor;
            public Color WrongBackgroundtxtColor;
            public Color ClickedButtonColor;
        }

        private stSettings Settings;

        void ChooseRandomStory()
        {

            // Retrieve all stories from resources.
            List<string> stories = new List<string>
            {
                Resources.The_Black_Cat,
                Resources.The_Chapel,
                Resources.Haircut,
                Resources.A_Coward,
                Resources.The_Metro
            };

            Random rdm = new Random();

            rtxtOutput.Text = stories[rdm.Next(stories.Count)];

            stories.Clear();

        }

        void GetKeyboardButtons()
        {

            DicButtons = new Dictionary<Keys, List<Guna2Button>>();

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
            Program.mainformobject.ShowKeyboardTypingResult();
        }

        void ChangeCharProperties(int ind, int range, Color forecolor, Color backgroundcolor, FontStyle fontStyle = FontStyle.Regular)
        {
            // select correspond character
            rtxtOutput.Select(ind, range);
            // change its color
            rtxtOutput.SelectionColor = forecolor;
            // change background color
            rtxtOutput.SelectionBackColor = backgroundcolor;
            // change font style
            rtxtOutput.SelectionFont = new Font(rtxtOutput.SelectionFont, fontStyle);
        }

        void HighlightCharacters()
        {
            // check last character.
            if (text.Input.Length <= text.Output.Length && text.Input.Length > 0)
            {
                int pos = text.Input.Length - 1;

                if (text.Input[pos] == text.Output[pos])
                {
                    ChangeCharProperties(pos, 1, Settings.CorrecttxtColor, Settings.CorrectBackgroundtxtColor);
                }
                else
                {
                    ChangeCharProperties(pos, 1, Settings.WrongtxtColor, Settings.WrongBackgroundtxtColor);
                    Program.mainformobject.RoundStatus.cntWrongChars++;
                }
            }
        }

        void UnderlineNext()
        {
            // Underline where to type.
            if (text.Input.Length < text.Output.Length)
            {
                ChangeCharProperties(text.Input.Length, 1, Settings.DefaulttxtColor, Settings.DefaultBackgroundtxtColor, FontStyle.Underline);
            }
        }

        void RemoveUnderline()
        {
            // This to disable underline style to ignore remove characters.
            if (text.Input.Length < text.Output.Length - 1)
            {
                ChangeCharProperties(text.Input.Length + 1, 1, Settings.DefaulttxtColor, Settings.DefaultBackgroundtxtColor);
            }
        }

        bool CheckingText()
        {
            // Check Completed text length.
            return (text.Input.Length == text.Output.Length);
        }

        void Updatetext()
        {
            // Get Input and output text.
            text.Input = rtxtInput.Text;
            text.Output = rtxtOutput.Text;
        }

        void UpdateCharactersFormatting()
        {
            Updatetext();

            // Formatting.
            HighlightCharacters();
            UnderlineNext();
            RemoveUnderline();
        }

        void UpdateScroll()
        {
            if (text.Input.Length > 1)
            {
                char underlinedchar = text.Output[text.Input.Length - 2];
                // Scroll 'rtxtOutput' to current underlined character.
                if (underlinedchar == '\n' || underlinedchar == ' ')
                {
                    rtxtOutput.SelectionStart = text.Input.Length;
                    rtxtOutput.ScrollToCaret();
                }
            }
        }

        private void rtxtInput_TextChanged(object sender, EventArgs e)
        {
            // Format shown text (1.Correct & Uncorrect Chraracters, 2.UnderLine Next, 3.Remove Previous UnderLine).
            UpdateCharactersFormatting();
            // Scroll 'rtxtOutput' to current line
            UpdateScroll();

            if (CheckingText()) // Check Completed text length and stop if true.
                StopTyping();
        }

        private void DefaultSettings()
        {
            Settings.DefaulttxtColor = Color.Black;
            Settings.WrongtxtColor = Color.Red;
            Settings.CorrecttxtColor = Color.Green;
            Settings.DefaultBackgroundtxtColor = Color.Transparent;
            Settings.CorrectBackgroundtxtColor = Color.Yellow;
            Settings.WrongBackgroundtxtColor = Color.Orange;
            Settings.ClickedButtonColor = Color.Blue;
        }

        void AssignFocusRedirect()
        {
            foreach (Control control in this.Controls)
            {
                if (control != rtxtInput)
                {
                    control.Enter += RedirectFocus;
                }
            }
            foreach (Control control in flp1.Controls)
            {
                if (control != rtxtInput)
                {
                    control.Enter += RedirectFocus;
                }
            }
        }

        private void KeyboardTyping_Load(object sender, EventArgs e)
        {
            DefaultSettings();
            InitializeKeyboard();
            ChooseRandomStory();
            AssignFocusRedirect();
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

        private void RedirectFocus(object sender, EventArgs e)
        {
            rtxtInput.Focus();
        }

        private void rtxtOutput_TextChanged(object sender, EventArgs e)
        {
            // Get Output text.
            text.Output = rtxtOutput.Text;
        }

        void CalculateWPM()
        {
            bool Skip = false;

            // Count all spaces and new lines that exists in output textbox according to
            // text length in input textbox.
            for (int i = 0; i < text.Input.Length; i++)
            {
                char incrntch = text.Input[i];
                char outcrntch = text.Output[i];

                if (incrntch != outcrntch)
                    Skip = true;

                if (outcrntch == '\n' || outcrntch == ' ')
                {
                    if (Skip)
                        Skip = false;
                    else
                        ++Program.mainformobject.RoundStatus.WPM;
                }
            }
        }

        void GetRoundResult()
        {
            Updatetext();
            // Total character typed in input textbox.
            Program.mainformobject.RoundStatus.cntTotalChars = text.Input.Length;
            // Calculate WPM result.
            CalculateWPM();
        }

        private void KeyboardTyping_EnabledChanged(object sender, EventArgs e)
        {
            FocusNotification.Visible = this.Enabled;
            GetRoundResult();
        }

        private void FocusNotification_Click(object sender, EventArgs e)
        {
            rtxtInput.Focus();
        }

        private void rtxtInput_Leave(object sender, EventArgs e)
        {
            FocusNotification.Visible = true;
        }

        private void rtxtInput_Enter(object sender, EventArgs e)
        {
            FocusNotification.Visible = false;
        }
    }
}
