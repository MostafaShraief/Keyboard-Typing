﻿namespace Keyboard_Typing
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.scSubLeft = new System.Windows.Forms.SplitContainer();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.flpOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTypingTest = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnDownWords = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnSettings = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlBottomRibbon = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pnlRibbon = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnlStatus = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnClose = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scSubLeft)).BeginInit();
            this.scSubLeft.Panel1.SuspendLayout();
            this.scSubLeft.Panel2.SuspendLayout();
            this.scSubLeft.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.flpOptions.SuspendLayout();
            this.pnlRibbon.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.IsSplitterFixed = true;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.scSubLeft);
            this.scMain.Size = new System.Drawing.Size(1374, 658);
            this.scMain.SplitterDistance = 315;
            this.scMain.TabIndex = 0;
            // 
            // scSubLeft
            // 
            this.scSubLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scSubLeft.IsSplitterFixed = true;
            this.scSubLeft.Location = new System.Drawing.Point(0, 0);
            this.scSubLeft.Name = "scSubLeft";
            this.scSubLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scSubLeft.Panel1
            // 
            this.scSubLeft.Panel1.Controls.Add(this.guna2CustomGradientPanel1);
            // 
            // scSubLeft.Panel2
            // 
            this.scSubLeft.Panel2.Controls.Add(this.pnlStatus);
            this.scSubLeft.Size = new System.Drawing.Size(315, 658);
            this.scSubLeft.SplitterDistance = 105;
            this.scSubLeft.TabIndex = 0;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.MediumBlue;
            this.guna2CustomGradientPanel1.Controls.Add(this.flpOptions);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Quality = 1;
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(315, 105);
            this.guna2CustomGradientPanel1.TabIndex = 4;
            // 
            // flpOptions
            // 
            this.flpOptions.BackColor = System.Drawing.Color.Transparent;
            this.flpOptions.Controls.Add(this.btnTypingTest);
            this.flpOptions.Controls.Add(this.btnDownWords);
            this.flpOptions.Controls.Add(this.btnSettings);
            this.flpOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpOptions.Location = new System.Drawing.Point(0, 0);
            this.flpOptions.Name = "flpOptions";
            this.flpOptions.Size = new System.Drawing.Size(315, 105);
            this.flpOptions.TabIndex = 0;
            // 
            // btnTypingTest
            // 
            this.btnTypingTest.Animated = true;
            this.btnTypingTest.BorderRadius = 5;
            this.btnTypingTest.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTypingTest.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTypingTest.CheckedState.Parent = this.btnTypingTest;
            this.btnTypingTest.CustomImages.Parent = this.btnTypingTest;
            this.btnTypingTest.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTypingTest.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTypingTest.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTypingTest.ForeColor = System.Drawing.Color.White;
            this.btnTypingTest.HoverState.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnTypingTest.HoverState.Parent = this.btnTypingTest;
            this.btnTypingTest.Location = new System.Drawing.Point(3, 3);
            this.btnTypingTest.Name = "btnTypingTest";
            this.btnTypingTest.ShadowDecoration.Parent = this.btnTypingTest;
            this.btnTypingTest.Size = new System.Drawing.Size(99, 99);
            this.btnTypingTest.TabIndex = 0;
            this.btnTypingTest.Text = "Typing Test";
            // 
            // btnDownWords
            // 
            this.btnDownWords.Animated = true;
            this.btnDownWords.BorderRadius = 5;
            this.btnDownWords.CheckedState.Parent = this.btnDownWords;
            this.btnDownWords.CustomImages.Parent = this.btnDownWords;
            this.btnDownWords.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDownWords.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDownWords.ForeColor = System.Drawing.Color.White;
            this.btnDownWords.HoverState.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDownWords.HoverState.Parent = this.btnDownWords;
            this.btnDownWords.Location = new System.Drawing.Point(108, 3);
            this.btnDownWords.Name = "btnDownWords";
            this.btnDownWords.ShadowDecoration.Parent = this.btnDownWords;
            this.btnDownWords.Size = new System.Drawing.Size(99, 99);
            this.btnDownWords.TabIndex = 1;
            this.btnDownWords.Text = "Down Words";
            // 
            // btnSettings
            // 
            this.btnSettings.Animated = true;
            this.btnSettings.BorderRadius = 5;
            this.btnSettings.CheckedState.Parent = this.btnSettings;
            this.btnSettings.CustomImages.Parent = this.btnSettings;
            this.btnSettings.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.btnSettings.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.HoverState.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSettings.HoverState.Parent = this.btnSettings;
            this.btnSettings.Location = new System.Drawing.Point(213, 3);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.ShadowDecoration.Parent = this.btnSettings;
            this.btnSettings.Size = new System.Drawing.Size(99, 99);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "Settings";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // pnlBottomRibbon
            // 
            this.pnlBottomRibbon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottomRibbon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlBottomRibbon.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlBottomRibbon.FillColor3 = System.Drawing.Color.MediumBlue;
            this.pnlBottomRibbon.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlBottomRibbon.Location = new System.Drawing.Point(0, 690);
            this.pnlBottomRibbon.Name = "pnlBottomRibbon";
            this.pnlBottomRibbon.Quality = 100;
            this.pnlBottomRibbon.ShadowDecoration.Parent = this.pnlBottomRibbon;
            this.pnlBottomRibbon.Size = new System.Drawing.Size(1374, 17);
            this.pnlBottomRibbon.TabIndex = 2;
            // 
            // pnlRibbon
            // 
            this.pnlRibbon.Controls.Add(this.btnClose);
            this.pnlRibbon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRibbon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlRibbon.FillColor2 = System.Drawing.Color.MediumBlue;
            this.pnlRibbon.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlRibbon.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlRibbon.Location = new System.Drawing.Point(0, 0);
            this.pnlRibbon.Name = "pnlRibbon";
            this.pnlRibbon.Quality = 100;
            this.pnlRibbon.ShadowDecoration.Parent = this.pnlRibbon;
            this.pnlRibbon.Size = new System.Drawing.Size(1374, 37);
            this.pnlRibbon.TabIndex = 3;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.scMain);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.Location = new System.Drawing.Point(0, 37);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.ShadowDecoration.Parent = this.pnlMain;
            this.pnlMain.Size = new System.Drawing.Size(1374, 658);
            this.pnlMain.TabIndex = 4;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = null;
            // 
            // pnlStatus
            // 
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStatus.Location = new System.Drawing.Point(0, 0);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.ShadowDecoration.Parent = this.pnlStatus;
            this.pnlStatus.Size = new System.Drawing.Size(315, 549);
            this.pnlStatus.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Animated = true;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.FillColor2 = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnClose.HoverState.FillColor2 = System.Drawing.Color.Red;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Location = new System.Drawing.Point(1310, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(64, 37);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 707);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlRibbon);
            this.Controls.Add(this.pnlBottomRibbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.scMain.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.scSubLeft.Panel1.ResumeLayout(false);
            this.scSubLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scSubLeft)).EndInit();
            this.scSubLeft.ResumeLayout(false);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.flpOptions.ResumeLayout(false);
            this.pnlRibbon.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scMain;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlBottomRibbon;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlRibbon;
        private System.Windows.Forms.SplitContainer scSubLeft;
        private System.Windows.Forms.FlowLayoutPanel flpOptions;
        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnTypingTest;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnDownWords;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnSettings;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlStatus;
        private Guna.UI2.WinForms.Guna2GradientButton btnClose;
    }
}