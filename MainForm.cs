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
            LoadForm(new KeyboardTyping(), scMain.Panel2);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
