using Keyboard_Typing.Right_Panel;
using Keyboard_Typing.Status_Panel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Keyboard_Typing.MainForm;

namespace Keyboard_Typing
{
    public partial class MainForm : Form
    {
        internal int TotalMinutes;
        // If the user click finish before the round is end, then we want this to calculate WPM.
        internal int MinutesOfTyping;

        public MainForm()
        {
            InitializeComponent();
        }

        internal struct stRoundStatus
        {
            public int WPM;
            public int cntWrongChars;
            public int cntTotalChars;
            public float Accuracy;
        }

        internal stRoundStatus RoundStatus;

        private void LoadForm(Form form, Panel panel)
        {
            if (panel.Controls.Count > 0)
            {
                panel.Controls[0].Dispose();
                panel.Controls.Clear();
            }

            panel.Enabled = true;
            if (form != null)
            {
                form.Dock = DockStyle.Fill;
                form.TopLevel = false;
                panel.Controls.Add(form);
                form.Show();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Click "TypingTest" Button.
            btnTypingTest.PerformClick();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close Application.
            this.Close();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            // Change Visible Of Top And Bottom Panel To False.
            pnlBottomRibbon.Visible = false;
            pnlRibbon.Visible = false;
            // Minimize Main Form.
            this.WindowState = FormWindowState.Minimized;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            // Check If Form Is Minimize And Change Visible Of Top And Bottom Panel To True.
            if (this.WindowState == FormWindowState.Normal)
            {
                pnlBottomRibbon.Visible = true;
                pnlRibbon.Visible = true;
            }
        }

        internal void TakeTypingTest()
        {
            // Load Mode Settings.
            LoadForm(new TypingSettings(), pnlStatus);
            // Clear right panel controls.
            LoadForm(new MainMenuScreen(), scMain.Panel2);
        }

        internal void TypingTestButton(object sender, EventArgs e)
        {
            TakeTypingTest();
        }
        
        internal void StartKeyboardTyping(int minutes)
        {
            TotalMinutes = minutes;
            MinutesOfTyping = 1;
            // Reset data in 'RoundStatus'.
            RoundStatus = new stRoundStatus();
            // Load 'KeyboardTyping' form.
            LoadForm(new KeyboardTyping(), scMain.Panel2);
            // Load 'TypingRoundStatus' form.
            LoadForm(new TypingRoundStatus(), pnlStatus);
            scMain.Panel2.Controls[0].Focus();
        }

        internal void ShowKeyboardTypingResult()
        {
            // Stop typing by disable the right panel.
            scMain.Panel2.Enabled = false;

            CalculateWPMandAccuracy();
            // Load 'TypingRounfResult' form.
            LoadForm(new TypingRounfResult(), pnlStatus);
        }

        void CalculateWPMandAccuracy()
        {
            // Calculate WPM.
            RoundStatus.WPM /= MinutesOfTyping;

            int cntCorrectChars = RoundStatus.cntTotalChars - RoundStatus.cntWrongChars;

            // Calculate accuracy.
            if (RoundStatus.cntTotalChars > 0)
                RoundStatus.Accuracy = (float)(cntCorrectChars * 100) / RoundStatus.cntTotalChars;
            else
                RoundStatus.Accuracy = 0;
        }
    }
}
