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

namespace Keyboard_Typing.Right_Panel
{
    public partial class MainMenuScreen : Form
    {
        public MainMenuScreen()
        {
            InitializeComponent();
        }

        void OpenURL(string URL)
        {
            System.Diagnostics.Process.Start(URL);
        }

        private void btnOpenURL_Click(object sender, EventArgs e)
        {
            OpenURL((sender as Guna2GradientButton).Tag.ToString());
        }
    }
}
