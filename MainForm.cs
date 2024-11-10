using Keyboard_Typing.Status_Panel;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadForm(Form form, Panel panel)
        {
            if (panel.Controls.Count > 0)
                panel.Controls.Clear();
                
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            panel.Controls.Add(form);
            form.Show();
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

        private void btnTypingTest_Click(object sender, EventArgs e)
        {
            // Load Keyboard.
            LoadForm(new KeyboardTyping(), scMain.Panel2);
            // Load Mode Settings.
            LoadForm(new TypingSettings(), pnlStatus);
        }
    }
}
