using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Keyboard_Typing.Status_Panel
{
    public partial class TypingRoundStatus : Form
    {
        int remainingtime;

        public TypingRoundStatus()
        {
            InitializeComponent();
        }
        void TimeChanging()
        {
            TimeSpan timeSpan = TimeSpan.FromSeconds(remainingtime);
            lblTimeLeft.Text = timeSpan.ToString("m\\:ss");
            tbTime.Value = remainingtime;
        }

        void StartTimer()
        {
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Start();
        }

        void Stop()
        {
            timer.Enabled = false;
            Program.mainformobject.ShowKeyboardTypingResult();
        }

        private void TypingRoundStatus_Load(object sender, EventArgs e)
        {
            remainingtime = Program.mainformobject.TotalMinutes * 60;
            tbTime.Maximum = remainingtime;
            StartTimer();
            TimeChanging();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            remainingtime--;

            TimeChanging();

            if (remainingtime == 0)
            {
                Stop();
                return;
            }

            if (remainingtime % 60 == 0)
                Program.mainformobject.MinutesOfTyping++;
        }

        private void tbTime_Scroll(object sender, ScrollEventArgs e)
        {
            TimeChanging();
        }

        private void btnFinsihTyping_Click(object sender, EventArgs e)
        {
            Stop();
        }
    }
}
