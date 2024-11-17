using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keyboard_Typing.Status_Panel
{
    public partial class TypingRounfResult : Form
    {
        public TypingRounfResult()
        {
            InitializeComponent();
        }

        void EnableButtons()
        {
            btnChangeMode.Enabled = true;
            btnStartAgain.Enabled = true;
        }

        void UpdateStatus()
        {
            lblWPMValue.Text = Program.mainformobject.RoundStatus.WPM.ToString();
            lblAccuracy.Text = Program.mainformobject.RoundStatus.Accuracy.ToString();
            if (lblAccuracy.Text.Length > 5)
                lblAccuracy.Text = lblAccuracy.Text.Substring(0, 5);
            lblTotalTimeValue.Text = Program.mainformobject.TotalMinutes.ToString();
        }

        private void TypingRounfResult_Load(object sender, EventArgs e)
        {
            UpdateStatus();
            // This important to ignore skipping result when
            // user enter a space on keyboard mistakenly (by changing focus to 'this').
            EnableButtons();
            this.Focus();
        }

        private void btnDownWords_Click(object sender, EventArgs e)
        {
            Program.mainformobject.StartKeyboardTyping(Program.mainformobject.TotalMinutes);
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            Program.mainformobject.TakeTypingTest();
        }
    }
}
