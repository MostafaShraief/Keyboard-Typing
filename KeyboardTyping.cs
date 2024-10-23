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

        private void flp1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var item in flp1.Controls)
            {
                if (item.GetType() == b1.GetType())
                {
                    Guna2Button btn = item as Guna2Button;
                    btn.Text = btn.Text.Replace("--", "\n");
                }
            }
        }

    }
}
