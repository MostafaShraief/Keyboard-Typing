﻿using System;
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

        private void btnDownWords_Click(object sender, EventArgs e)
        {
            Program.mainformobject.StartKeyboardTyping(Program.mainformobject.Minutes);
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            Program.mainformobject.TakeTypingTest();
        }
    }
}