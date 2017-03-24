
using System.Windows.Forms;

namespace Engine_Brute
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnSource = new System.Windows.Forms.Button();
            this.btnProxy = new System.Windows.Forms.Button();
            this.txtDelimiter = new System.Windows.Forms.TextBox();
            this.CbProxyType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nThreads = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tabLists = new System.Windows.Forms.GroupBox();
            this.tabSettings = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimeOut = new System.Windows.Forms.TextBox();
            this.Tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trayShowStatistic = new System.Windows.Forms.ToolStripMenuItem();
            this.trayShowProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.trayExitApp = new System.Windows.Forms.ToolStripMenuItem();
            this.Gui = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.picTray = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblCountBad = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.picSound = new System.Windows.Forms.PictureBox();
            this.lblCountLeft = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCountPPS = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCountGood = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCountProxy = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCountSource = new System.Windows.Forms.Label();
            this.lblSource = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.Images = new System.Windows.Forms.ImageList(this.components);
            this.btnAbout = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nThreads)).BeginInit();
            this.tabLists.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.TrayMenu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSound)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(6, 15);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(110, 25);
            this.btnSource.TabIndex = 0;
            this.btnSource.Text = "Source";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.BtnSourceClick);
            // 
            // btnProxy
            // 
            this.btnProxy.Location = new System.Drawing.Point(6, 46);
            this.btnProxy.Name = "btnProxy";
            this.btnProxy.Size = new System.Drawing.Size(110, 25);
            this.btnProxy.TabIndex = 1;
            this.btnProxy.Text = "Proxy";
            this.btnProxy.UseVisualStyleBackColor = true;
            this.btnProxy.Click += new System.EventHandler(this.BtnProxyClick);
            // 
            // txtDelimiter
            // 
            this.txtDelimiter.Location = new System.Drawing.Point(58, 14);
            this.txtDelimiter.MaxLength = 1;
            this.txtDelimiter.Name = "txtDelimiter";
            this.txtDelimiter.Size = new System.Drawing.Size(58, 21);
            this.txtDelimiter.TabIndex = 2;
            this.txtDelimiter.Text = ";";
            this.txtDelimiter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDelimiter.Click += new System.EventHandler(this.txtDelimiter_Click);
            this.txtDelimiter.TextChanged += new System.EventHandler(this.txtDelimiter_TextChanged);
            // 
            // CbProxyType
            // 
            this.CbProxyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbProxyType.Enabled = false;
            this.CbProxyType.FormattingEnabled = true;
            this.CbProxyType.Items.AddRange(new object[] {
            "HTTP",
            "Socks4",
            "Socks5"});
            this.CbProxyType.Location = new System.Drawing.Point(58, 41);
            this.CbProxyType.Name = "CbProxyType";
            this.CbProxyType.Size = new System.Drawing.Size(58, 21);
            this.CbProxyType.TabIndex = 4;
            this.CbProxyType.TextChanged += new System.EventHandler(this.CbProxyTypeSelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Delimiter:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Type: ";
            // 
            // nThreads
            // 
            this.nThreads.Location = new System.Drawing.Point(58, 68);
            this.nThreads.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nThreads.Name = "nThreads";
            this.nThreads.Size = new System.Drawing.Size(58, 21);
            this.nThreads.TabIndex = 9;
            this.nThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nThreads.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nThreads.ValueChanged += new System.EventHandler(this.nThreads_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Threads:";
            // 
            // tabLists
            // 
            this.tabLists.Controls.Add(this.btnSource);
            this.tabLists.Controls.Add(this.btnProxy);
            this.tabLists.Location = new System.Drawing.Point(8, 2);
            this.tabLists.Name = "tabLists";
            this.tabLists.Size = new System.Drawing.Size(123, 82);
            this.tabLists.TabIndex = 11;
            this.tabLists.TabStop = false;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.checkBox1);
            this.tabSettings.Controls.Add(this.label3);
            this.tabSettings.Controls.Add(this.txtTimeOut);
            this.tabSettings.Controls.Add(this.label1);
            this.tabSettings.Controls.Add(this.txtDelimiter);
            this.tabSettings.Controls.Add(this.label4);
            this.tabSettings.Controls.Add(this.label2);
            this.tabSettings.Controls.Add(this.nThreads);
            this.tabSettings.Controls.Add(this.CbProxyType);
            this.tabSettings.Location = new System.Drawing.Point(8, 90);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(123, 146);
            this.tabSettings.TabIndex = 12;
            this.tabSettings.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(14, 122);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(97, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "ReBrute Errors";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "TimeOut:";
            // 
            // txtTimeOut
            // 
            this.txtTimeOut.Location = new System.Drawing.Point(58, 95);
            this.txtTimeOut.MaxLength = 4;
            this.txtTimeOut.Name = "txtTimeOut";
            this.txtTimeOut.Size = new System.Drawing.Size(58, 21);
            this.txtTimeOut.TabIndex = 11;
            this.txtTimeOut.Text = "5000";
            this.txtTimeOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Tray
            // 
            this.Tray.ContextMenuStrip = this.TrayMenu;
            this.Tray.Icon = ((System.Drawing.Icon)(resources.GetObject("Tray.Icon")));
            this.Tray.Text = "Engine Brute";
            this.Tray.Visible = true;
            this.Tray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Tray_MouseDoubleClick);
            // 
            // TrayMenu
            // 
            this.TrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trayShowStatistic,
            this.trayShowProgram,
            this.trayExitApp});
            this.TrayMenu.Name = "TrayMenu";
            this.TrayMenu.Size = new System.Drawing.Size(153, 70);
            // 
            // trayShowStatistic
            // 
            this.trayShowStatistic.Image = ((System.Drawing.Image)(resources.GetObject("trayShowStatistic.Image")));
            this.trayShowStatistic.Name = "trayShowStatistic";
            this.trayShowStatistic.Size = new System.Drawing.Size(152, 22);
            this.trayShowStatistic.Text = "Show Statistic";
            this.trayShowStatistic.Click += new System.EventHandler(this.trayShowStatistic_Click);
            // 
            // trayShowProgram
            // 
            this.trayShowProgram.Image = ((System.Drawing.Image)(resources.GetObject("trayShowProgram.Image")));
            this.trayShowProgram.Name = "trayShowProgram";
            this.trayShowProgram.Size = new System.Drawing.Size(152, 22);
            this.trayShowProgram.Text = "Show Program";
            this.trayShowProgram.Click += new System.EventHandler(this.trayShowProgram_Click);
            // 
            // trayExitApp
            // 
            this.trayExitApp.Image = ((System.Drawing.Image)(resources.GetObject("trayExitApp.Image")));
            this.trayExitApp.Name = "trayExitApp";
            this.trayExitApp.Size = new System.Drawing.Size(152, 22);
            this.trayExitApp.Text = "Exit";
            this.trayExitApp.Click += new System.EventHandler(this.trayExitApp_Click);
            // 
            // Gui
            // 
            this.Gui.Enabled = true;
            this.Gui.Interval = 1000;
            this.Gui.Tick += new System.EventHandler(this.Gui_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ImageList = this.Images;
            this.tabControl1.Location = new System.Drawing.Point(137, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(186, 189);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.picTray);
            this.tabPage1.Controls.Add(this.pictureBox3);
            this.tabPage1.Controls.Add(this.lblCountBad);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.picSound);
            this.tabPage1.Controls.Add(this.lblCountLeft);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.lblCountPPS);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.lblCountGood);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.lblCountProxy);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.lblCountSource);
            this.tabPage1.Controls.Add(this.lblSource);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(178, 162);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Statistic ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(77, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "0";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "Errors: ";
            // 
            // picTray
            // 
            this.picTray.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picTray.Image = global::Engine_Brute.Properties.Resources.tray;
            this.picTray.Location = new System.Drawing.Point(159, 136);
            this.picTray.Name = "picTray";
            this.picTray.Size = new System.Drawing.Size(16, 16);
            this.picTray.TabIndex = 41;
            this.picTray.TabStop = false;
            this.picTray.Click += new System.EventHandler(this.picTray_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Engine_Brute.Properties.Resources.line;
            this.pictureBox3.Location = new System.Drawing.Point(143, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 162);
            this.pictureBox3.TabIndex = 42;
            this.pictureBox3.TabStop = false;
            // 
            // lblCountBad
            // 
            this.lblCountBad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCountBad.AutoSize = true;
            this.lblCountBad.Location = new System.Drawing.Point(77, 74);
            this.lblCountBad.Name = "lblCountBad";
            this.lblCountBad.Size = new System.Drawing.Size(13, 13);
            this.lblCountBad.TabIndex = 40;
            this.lblCountBad.Text = "0";
            this.lblCountBad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Bad: ";
            // 
            // picSound
            // 
            this.picSound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSound.Image = global::Engine_Brute.Properties.Resources.sound_on;
            this.picSound.Location = new System.Drawing.Point(159, 3);
            this.picSound.Name = "picSound";
            this.picSound.Size = new System.Drawing.Size(16, 16);
            this.picSound.TabIndex = 18;
            this.picSound.TabStop = false;
            this.picSound.Click += new System.EventHandler(this.picSound_Click);
            // 
            // lblCountLeft
            // 
            this.lblCountLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCountLeft.AutoSize = true;
            this.lblCountLeft.Location = new System.Drawing.Point(77, 139);
            this.lblCountLeft.Name = "lblCountLeft";
            this.lblCountLeft.Size = new System.Drawing.Size(13, 13);
            this.lblCountLeft.TabIndex = 38;
            this.lblCountLeft.Text = "0";
            this.lblCountLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Left: ";
            // 
            // lblCountPPS
            // 
            this.lblCountPPS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCountPPS.AutoSize = true;
            this.lblCountPPS.Location = new System.Drawing.Point(77, 118);
            this.lblCountPPS.Name = "lblCountPPS";
            this.lblCountPPS.Size = new System.Drawing.Size(13, 13);
            this.lblCountPPS.TabIndex = 36;
            this.lblCountPPS.Text = "0";
            this.lblCountPPS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "PPS: ";
            // 
            // lblCountGood
            // 
            this.lblCountGood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCountGood.AutoSize = true;
            this.lblCountGood.Location = new System.Drawing.Point(77, 50);
            this.lblCountGood.Name = "lblCountGood";
            this.lblCountGood.Size = new System.Drawing.Size(13, 13);
            this.lblCountGood.TabIndex = 34;
            this.lblCountGood.Text = "0";
            this.lblCountGood.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Good: ";
            // 
            // lblCountProxy
            // 
            this.lblCountProxy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCountProxy.AutoSize = true;
            this.lblCountProxy.Location = new System.Drawing.Point(77, 27);
            this.lblCountProxy.Name = "lblCountProxy";
            this.lblCountProxy.Size = new System.Drawing.Size(13, 13);
            this.lblCountProxy.TabIndex = 32;
            this.lblCountProxy.Text = "0";
            this.lblCountProxy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Proxy: ";
            // 
            // lblCountSource
            // 
            this.lblCountSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCountSource.AutoSize = true;
            this.lblCountSource.Location = new System.Drawing.Point(77, 4);
            this.lblCountSource.Name = "lblCountSource";
            this.lblCountSource.Size = new System.Drawing.Size(13, 13);
            this.lblCountSource.TabIndex = 30;
            this.lblCountSource.Text = "0";
            this.lblCountSource.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(6, 4);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(47, 13);
            this.lblSource.TabIndex = 29;
            this.lblSource.Text = "Source: ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtLog);
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(178, 162);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Log   ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.White;
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLog.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtLog.Location = new System.Drawing.Point(3, 7);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(172, 147);
            this.txtLog.TabIndex = 0;
            this.txtLog.Click += new System.EventHandler(this.txtLog_Clicked);
            // 
            // Images
            // 
            this.Images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Images.ImageStream")));
            this.Images.TransparentColor = System.Drawing.Color.Transparent;
            this.Images.Images.SetKeyName(0, "1371312641_statistics.png");
            this.Images.Images.SetKeyName(1, "log.png");
            this.Images.Images.SetKeyName(2, "1371494365_dialog-close.png");
            this.Images.Images.SetKeyName(3, "fav.ico");
            // 
            // btnAbout
            // 
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(137, 197);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(25, 25);
            this.btnAbout.TabIndex = 16;
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 90);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Image = global::Engine_Brute.Properties.Resources.start;
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.Location = new System.Drawing.Point(248, 197);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 25);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start   ";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStartClick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 243);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabSettings);
            this.Controls.Add(this.tabLists);
            this.Controls.Add(this.btnStart);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Program Name | By BruteForce Engine";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nThreads)).EndInit();
            this.tabLists.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.TrayMenu.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSound)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.Button btnProxy;
        private System.Windows.Forms.TextBox txtDelimiter;
        private System.Windows.Forms.ComboBox CbProxyType;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nThreads;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox tabLists;
        private System.Windows.Forms.GroupBox tabSettings;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.NotifyIcon Tray;
        private System.Windows.Forms.Timer Gui;
        private System.Windows.Forms.PictureBox picSound;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblCountBad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCountLeft;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCountPPS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCountGood;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCountProxy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCountSource;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList Images;
        private System.Windows.Forms.ContextMenuStrip TrayMenu;
        private System.Windows.Forms.ToolStripMenuItem trayShowStatistic;
        private System.Windows.Forms.ToolStripMenuItem trayShowProgram;
        private System.Windows.Forms.ToolStripMenuItem trayExitApp;
        public  System.Windows.Forms.TextBox txtLog;
        private Label label3;
        private TextBox txtTimeOut;
        private PictureBox picTray;
        private CheckBox checkBox1;
        private PictureBox pictureBox3;
        private Label label10;
        private Label label11;
    }
}

