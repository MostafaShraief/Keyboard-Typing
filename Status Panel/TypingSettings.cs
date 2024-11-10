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
    public partial class TypingSettings : Form
    {
        public TypingSettings()
        {
            InitializeComponent();
        }

        private void tbTime_ValueChanged(object sender, EventArgs e)
        {
            lblTimeValue.Text = tbTime.Value.ToString();
        }
    }
}
