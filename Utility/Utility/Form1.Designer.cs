namespace Utility
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.noteBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddDate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddTime = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDownload = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpConverter = new System.Windows.Forms.TabPage();
            this.lbMeasure = new System.Windows.Forms.Label();
            this.cbMetric = new System.Windows.Forms.ComboBox();
            this.btnSwap = new System.Windows.Forms.Button();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.tpNotebook = new System.Windows.Forms.TabPage();
            this.rtbNotebook = new System.Windows.Forms.RichTextBox();
            this.tpCounter = new System.Windows.Forms.TabPage();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.tpRandom = new System.Windows.Forms.TabPage();
            this.cbRandom = new System.Windows.Forms.CheckBox();
            this.btnRandomCopy = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.txtRandom = new System.Windows.Forms.TextBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblRandom = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnRandom = new System.Windows.Forms.Button();
            this.tpGeneratePass = new System.Windows.Forms.TabPage();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnCreatePassword = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudPassLength = new System.Windows.Forms.NumericUpDown();
            this.clbPassword = new System.Windows.Forms.CheckedListBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpConverter.SuspendLayout();
            this.tpNotebook.SuspendLayout();
            this.tpCounter.SuspendLayout();
            this.tpRandom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tpGeneratePass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPassLength)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.noteBookToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(619, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(116, 26);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // noteBookToolStripMenuItem
            // 
            this.noteBookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddDate,
            this.tsmiAddTime,
            this.toolStripMenuItem1,
            this.tsmiSave,
            this.tsmiDownload});
            this.noteBookToolStripMenuItem.Name = "noteBookToolStripMenuItem";
            this.noteBookToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.noteBookToolStripMenuItem.Text = "NoteBook";
            // 
            // tsmiAddDate
            // 
            this.tsmiAddDate.Name = "tsmiAddDate";
            this.tsmiAddDate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.tsmiAddDate.Size = new System.Drawing.Size(211, 26);
            this.tsmiAddDate.Text = "Add Date";
            this.tsmiAddDate.Click += new System.EventHandler(this.tsmiAddDate_Click);
            // 
            // tsmiAddTime
            // 
            this.tsmiAddTime.Name = "tsmiAddTime";
            this.tsmiAddTime.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.tsmiAddTime.Size = new System.Drawing.Size(211, 26);
            this.tsmiAddTime.Text = "Add Time";
            this.tsmiAddTime.Click += new System.EventHandler(this.tsmiAddTime_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(208, 6);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmiSave.Size = new System.Drawing.Size(211, 26);
            this.tsmiSave.Text = "Save";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // tsmiDownload
            // 
            this.tsmiDownload.Name = "tsmiDownload";
            this.tsmiDownload.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.tsmiDownload.Size = new System.Drawing.Size(211, 26);
            this.tsmiDownload.Text = "Download";
            this.tsmiDownload.Click += new System.EventHandler(this.tsmiDownload_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(133, 26);
            this.tsmiAbout.Text = "About";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpNotebook);
            this.tabControl1.Controls.Add(this.tpCounter);
            this.tabControl1.Controls.Add(this.tpRandom);
            this.tabControl1.Controls.Add(this.tpGeneratePass);
            this.tabControl1.Controls.Add(this.tpConverter);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(619, 422);
            this.tabControl1.TabIndex = 1;
            // 
            // tpConverter
            // 
            this.tpConverter.Controls.Add(this.lbMeasure);
            this.tpConverter.Controls.Add(this.cbMetric);
            this.tpConverter.Controls.Add(this.btnSwap);
            this.tpConverter.Controls.Add(this.tbTo);
            this.tpConverter.Controls.Add(this.tbFrom);
            this.tpConverter.Controls.Add(this.btnConvert);
            this.tpConverter.Controls.Add(this.cbTo);
            this.tpConverter.Controls.Add(this.cbFrom);
            this.tpConverter.Location = new System.Drawing.Point(4, 29);
            this.tpConverter.Name = "tpConverter";
            this.tpConverter.Size = new System.Drawing.Size(611, 389);
            this.tpConverter.TabIndex = 4;
            this.tpConverter.Text = "Converter";
            this.tpConverter.UseVisualStyleBackColor = true;
            // 
            // lbMeasure
            // 
            this.lbMeasure.AutoSize = true;
            this.lbMeasure.Location = new System.Drawing.Point(26, 26);
            this.lbMeasure.Name = "lbMeasure";
            this.lbMeasure.Size = new System.Drawing.Size(68, 20);
            this.lbMeasure.TabIndex = 7;
            this.lbMeasure.Text = "Measure:";
            // 
            // cbMetric
            // 
            this.cbMetric.FormattingEnabled = true;
            this.cbMetric.Items.AddRange(new object[] {
            "Length",
            "Weight"});
            this.cbMetric.Location = new System.Drawing.Point(26, 49);
            this.cbMetric.Name = "cbMetric";
            this.cbMetric.Size = new System.Drawing.Size(151, 28);
            this.cbMetric.TabIndex = 6;
            this.cbMetric.Text = "Length";
            this.cbMetric.SelectedIndexChanged += new System.EventHandler(this.cbMetric_SelectedIndexChanged);
            // 
            // btnSwap
            // 
            this.btnSwap.Location = new System.Drawing.Point(252, 136);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(121, 49);
            this.btnSwap.TabIndex = 5;
            this.btnSwap.Text = "<-->";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(456, 270);
            this.tbTo.Name = "tbTo";
            this.tbTo.ReadOnly = true;
            this.tbTo.Size = new System.Drawing.Size(125, 27);
            this.tbTo.TabIndex = 4;
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(26, 270);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(125, 27);
            this.tbFrom.TabIndex = 3;
            this.tbFrom.Text = "0";
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnConvert.Location = new System.Drawing.Point(252, 248);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(121, 49);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // cbTo
            // 
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Items.AddRange(new object[] {
            "mm",
            "cm",
            "dm",
            "m",
            "km",
            "mile"});
            this.cbTo.Location = new System.Drawing.Point(430, 147);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(151, 28);
            this.cbTo.TabIndex = 1;
            this.cbTo.Text = "m";
            // 
            // cbFrom
            // 
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Items.AddRange(new object[] {
            "mm",
            "cm",
            "dm",
            "m",
            "km",
            "mile"});
            this.cbFrom.Location = new System.Drawing.Point(26, 147);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(151, 28);
            this.cbFrom.TabIndex = 0;
            this.cbFrom.Text = "mm";
            // 
            // tpNotebook
            // 
            this.tpNotebook.Controls.Add(this.rtbNotebook);
            this.tpNotebook.Location = new System.Drawing.Point(4, 29);
            this.tpNotebook.Name = "tpNotebook";
            this.tpNotebook.Size = new System.Drawing.Size(611, 389);
            this.tpNotebook.TabIndex = 2;
            this.tpNotebook.Text = "Notebook";
            this.tpNotebook.UseVisualStyleBackColor = true;
            // 
            // rtbNotebook
            // 
            this.rtbNotebook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbNotebook.Location = new System.Drawing.Point(0, 0);
            this.rtbNotebook.Name = "rtbNotebook";
            this.rtbNotebook.Size = new System.Drawing.Size(611, 389);
            this.rtbNotebook.TabIndex = 0;
            this.rtbNotebook.Text = "";
            // 
            // tpCounter
            // 
            this.tpCounter.Controls.Add(this.lblCount);
            this.tpCounter.Controls.Add(this.btnMinus);
            this.tpCounter.Controls.Add(this.btnReset);
            this.tpCounter.Controls.Add(this.btnPlus);
            this.tpCounter.Location = new System.Drawing.Point(4, 29);
            this.tpCounter.Name = "tpCounter";
            this.tpCounter.Padding = new System.Windows.Forms.Padding(3);
            this.tpCounter.Size = new System.Drawing.Size(611, 389);
            this.tpCounter.TabIndex = 0;
            this.tpCounter.Text = "Counter";
            this.tpCounter.UseVisualStyleBackColor = true;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblCount.Location = new System.Drawing.Point(285, 216);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(24, 28);
            this.lblCount.TabIndex = 3;
            this.lblCount.Text = "0";
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnMinus.Location = new System.Drawing.Point(413, 68);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(152, 55);
            this.btnMinus.TabIndex = 2;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(222, 68);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(152, 55);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnPlus.Location = new System.Drawing.Point(33, 68);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(152, 55);
            this.btnPlus.TabIndex = 0;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // tpRandom
            // 
            this.tpRandom.Controls.Add(this.cbRandom);
            this.tpRandom.Controls.Add(this.btnRandomCopy);
            this.tpRandom.Controls.Add(this.btnClean);
            this.tpRandom.Controls.Add(this.txtRandom);
            this.tpRandom.Controls.Add(this.lblTo);
            this.tpRandom.Controls.Add(this.lblFrom);
            this.tpRandom.Controls.Add(this.lblRandom);
            this.tpRandom.Controls.Add(this.numericUpDown2);
            this.tpRandom.Controls.Add(this.numericUpDown1);
            this.tpRandom.Controls.Add(this.btnRandom);
            this.tpRandom.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.tpRandom.Location = new System.Drawing.Point(4, 29);
            this.tpRandom.Name = "tpRandom";
            this.tpRandom.Padding = new System.Windows.Forms.Padding(3);
            this.tpRandom.Size = new System.Drawing.Size(611, 389);
            this.tpRandom.TabIndex = 1;
            this.tpRandom.Text = "Random";
            this.tpRandom.UseVisualStyleBackColor = true;
            // 
            // cbRandom
            // 
            this.cbRandom.AutoSize = true;
            this.cbRandom.Location = new System.Drawing.Point(226, 267);
            this.cbRandom.Name = "cbRandom";
            this.cbRandom.Size = new System.Drawing.Size(107, 50);
            this.cbRandom.TabIndex = 9;
            this.cbRandom.Text = "without \r\nrepetition";
            this.cbRandom.UseVisualStyleBackColor = true;
            // 
            // btnRandomCopy
            // 
            this.btnRandomCopy.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnRandomCopy.Location = new System.Drawing.Point(55, 326);
            this.btnRandomCopy.Name = "btnRandomCopy";
            this.btnRandomCopy.Size = new System.Drawing.Size(113, 40);
            this.btnRandomCopy.TabIndex = 8;
            this.btnRandomCopy.Text = "Copy";
            this.btnRandomCopy.UseVisualStyleBackColor = true;
            this.btnRandomCopy.Click += new System.EventHandler(this.btnRandomCopy_Click);
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnClean.Location = new System.Drawing.Point(226, 326);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(109, 40);
            this.btnClean.TabIndex = 7;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // txtRandom
            // 
            this.txtRandom.Location = new System.Drawing.Point(355, 169);
            this.txtRandom.Multiline = true;
            this.txtRandom.Name = "txtRandom";
            this.txtRandom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRandom.Size = new System.Drawing.Size(128, 197);
            this.txtRandom.TabIndex = 6;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTo.Location = new System.Drawing.Point(55, 125);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(28, 23);
            this.lblTo.TabIndex = 5;
            this.lblTo.Text = "To";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblFrom.Location = new System.Drawing.Point(55, 60);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(49, 23);
            this.lblFrom.TabIndex = 4;
            this.lblFrom.Text = "From";
            // 
            // lblRandom
            // 
            this.lblRandom.AutoSize = true;
            this.lblRandom.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblRandom.Location = new System.Drawing.Point(355, 130);
            this.lblRandom.Name = "lblRandom";
            this.lblRandom.Size = new System.Drawing.Size(43, 23);
            this.lblRandom.TabIndex = 3;
            this.lblRandom.Text = "Null";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.numericUpDown2.Location = new System.Drawing.Point(132, 123);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(81, 30);
            this.numericUpDown2.TabIndex = 2;
            this.numericUpDown2.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.numericUpDown1.Location = new System.Drawing.Point(132, 58);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(81, 30);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnRandom
            // 
            this.btnRandom.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnRandom.Location = new System.Drawing.Point(355, 58);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(128, 41);
            this.btnRandom.TabIndex = 0;
            this.btnRandom.Text = "Generate";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // tpGeneratePass
            // 
            this.tpGeneratePass.Controls.Add(this.tbPassword);
            this.tpGeneratePass.Controls.Add(this.btnCreatePassword);
            this.tpGeneratePass.Controls.Add(this.label1);
            this.tpGeneratePass.Controls.Add(this.nudPassLength);
            this.tpGeneratePass.Controls.Add(this.clbPassword);
            this.tpGeneratePass.Location = new System.Drawing.Point(4, 29);
            this.tpGeneratePass.Name = "tpGeneratePass";
            this.tpGeneratePass.Size = new System.Drawing.Size(611, 389);
            this.tpGeneratePass.TabIndex = 3;
            this.tpGeneratePass.Text = "GeneratePass";
            this.tpGeneratePass.UseVisualStyleBackColor = true;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(392, 142);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(170, 27);
            this.tbPassword.TabIndex = 4;
            // 
            // btnCreatePassword
            // 
            this.btnCreatePassword.Font = new System.Drawing.Font("Nirmala UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnCreatePassword.Location = new System.Drawing.Point(392, 18);
            this.btnCreatePassword.Name = "btnCreatePassword";
            this.btnCreatePassword.Size = new System.Drawing.Size(170, 53);
            this.btnCreatePassword.TabIndex = 3;
            this.btnCreatePassword.Text = "Create a password";
            this.btnCreatePassword.UseVisualStyleBackColor = true;
            this.btnCreatePassword.Click += new System.EventHandler(this.btnCreatePassword_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password length";
            // 
            // nudPassLength
            // 
            this.nudPassLength.Location = new System.Drawing.Point(22, 155);
            this.nudPassLength.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudPassLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPassLength.Name = "nudPassLength";
            this.nudPassLength.Size = new System.Drawing.Size(150, 27);
            this.nudPassLength.TabIndex = 1;
            this.nudPassLength.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // clbPassword
            // 
            this.clbPassword.CheckOnClick = true;
            this.clbPassword.FormattingEnabled = true;
            this.clbPassword.Items.AddRange(new object[] {
            "Numbers",
            "Uppercase",
            "lower case",
            "Special symbols"});
            this.clbPassword.Location = new System.Drawing.Point(22, 18);
            this.clbPassword.Name = "clbPassword";
            this.clbPassword.Size = new System.Drawing.Size(150, 92);
            this.clbPassword.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "My Utility";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpConverter.ResumeLayout(false);
            this.tpConverter.PerformLayout();
            this.tpNotebook.ResumeLayout(false);
            this.tpCounter.ResumeLayout(false);
            this.tpCounter.PerformLayout();
            this.tpRandom.ResumeLayout(false);
            this.tpRandom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tpGeneratePass.ResumeLayout(false);
            this.tpGeneratePass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPassLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem tsmiExit;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem tsmiAbout;
        private TabControl tabControl1;
        private TabPage tpCounter;
        private TabPage tpRandom;
        private Button btnPlus;
        private Label lblCount;
        private Button btnMinus;
        private Button btnReset;
        private Label lblTo;
        private Label lblFrom;
        private Label lblRandom;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private Button btnRandom;
        private TextBox txtRandom;
        private Button btnClean;
        private Button btnRandomCopy;
        private CheckBox cbRandom;
        private ToolStripMenuItem noteBookToolStripMenuItem;
        private ToolStripMenuItem tsmiAddDate;
        private ToolStripMenuItem tsmiAddTime;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem tsmiSave;
        private ToolStripMenuItem tsmiDownload;
        private TabPage tpNotebook;
        private RichTextBox rtbNotebook;
        private TabPage tpGeneratePass;
        private CheckedListBox clbPassword;
        private TextBox tbPassword;
        private Button btnCreatePassword;
        private Label label1;
        private NumericUpDown nudPassLength;
        private TabPage tpConverter;
        private TextBox tbTo;
        private TextBox tbFrom;
        private Button btnConvert;
        private ComboBox cbTo;
        private ComboBox cbFrom;
        private Button btnSwap;
        private ComboBox cbMetric;
        private Label lbMeasure;
    }
}