namespace WinFormsApp1
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
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            tsmiExit = new ToolStripMenuItem();
            помощьToolStripMenuItem = new ToolStripMenuItem();
            tsmiAbout = new ToolStripMenuItem();
            notebookToolStripMenuItem = new ToolStripMenuItem();
            tsmPasteDate = new ToolStripMenuItem();
            tsmPasteTime = new ToolStripMenuItem();
            tsmPasteTimedate = new ToolStripMenuItem();
            tsmSave = new ToolStripMenuItem();
            tsmLoad = new ToolStripMenuItem();
            tsmExit = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnExit = new Button();
            lblCount = new Label();
            btnReset = new Button();
            btnMinus = new Button();
            btnPlus = new Button();
            tabPage2 = new TabPage();
            chkboxNotRepeat = new CheckBox();
            btnRandomCopy = new Button();
            btnClear = new Button();
            txtboxRandom = new TextBox();
            btnExit2 = new Button();
            lblBefore = new Label();
            lblFrom = new Label();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            lblRandom = new Label();
            btnAsk = new Button();
            tabPage3 = new TabPage();
            RTBNotepad = new RichTextBox();
            tabPage4 = new TabPage();
            tbPassword = new TextBox();
            btnCreatePass = new Button();
            lblLenghtPass = new Label();
            nudLenghtPass = new NumericUpDown();
            clbPassword = new CheckedListBox();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudLenghtPass).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, помощьToolStripMenuItem, notebookToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(546, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmiExit });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(57, 29);
            файлToolStripMenuItem.Text = "File";
            // 
            // tsmiExit
            // 
            tsmiExit.Name = "tsmiExit";
            tsmiExit.Size = new Size(146, 34);
            tsmiExit.Text = "Exit";
            tsmiExit.Click += tsmiExit_Click;
            // 
            // помощьToolStripMenuItem
            // 
            помощьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmiAbout });
            помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            помощьToolStripMenuItem.Size = new Size(68, 29);
            помощьToolStripMenuItem.Text = "Help";
            // 
            // tsmiAbout
            // 
            tsmiAbout.Name = "tsmiAbout";
            tsmiAbout.Size = new Size(167, 34);
            tsmiAbout.Text = "About";
            tsmiAbout.Click += tsmiAbout_Click;
            // 
            // notebookToolStripMenuItem
            // 
            notebookToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmPasteDate, tsmPasteTime, tsmPasteTimedate, tsmSave, tsmLoad, tsmExit });
            notebookToolStripMenuItem.Name = "notebookToolStripMenuItem";
            notebookToolStripMenuItem.Size = new Size(113, 29);
            notebookToolStripMenuItem.Text = "Notebook";
            // 
            // tsmPasteDate
            // 
            tsmPasteDate.Name = "tsmPasteDate";
            tsmPasteDate.ShortcutKeys = Keys.Control | Keys.D1;
            tsmPasteDate.Size = new Size(319, 34);
            tsmPasteDate.Text = "Paste date";
            tsmPasteDate.Click += tsmPasteDate_Click;
            // 
            // tsmPasteTime
            // 
            tsmPasteTime.Name = "tsmPasteTime";
            tsmPasteTime.ShortcutKeys = Keys.Control | Keys.D2;
            tsmPasteTime.Size = new Size(319, 34);
            tsmPasteTime.Text = "Paste time";
            tsmPasteTime.Click += tsmPasteTime_Click;
            // 
            // tsmPasteTimedate
            // 
            tsmPasteTimedate.Name = "tsmPasteTimedate";
            tsmPasteTimedate.ShortcutKeys = Keys.Control | Keys.D3;
            tsmPasteTimedate.Size = new Size(319, 34);
            tsmPasteTimedate.Text = "Paste time+date";
            tsmPasteTimedate.Click += pasteTimedateToolStripMenuItem_Click;
            // 
            // tsmSave
            // 
            tsmSave.Name = "tsmSave";
            tsmSave.Size = new Size(319, 34);
            tsmSave.Text = "Save";
            tsmSave.Click += tsmSave_Click;
            // 
            // tsmLoad
            // 
            tsmLoad.Name = "tsmLoad";
            tsmLoad.Size = new Size(319, 34);
            tsmLoad.Text = "Load";
            tsmLoad.Click += tsmLoad_Click;
            // 
            // tsmExit
            // 
            tsmExit.Name = "tsmExit";
            tsmExit.Size = new Size(319, 34);
            tsmExit.Text = "Exit";
            tsmExit.Click += exitToolStripMenuItem_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 33);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(546, 500);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnExit);
            tabPage1.Controls.Add(lblCount);
            tabPage1.Controls.Add(btnReset);
            tabPage1.Controls.Add(btnMinus);
            tabPage1.Controls.Add(btnPlus);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(538, 462);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Counter";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(376, 323);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(80, 128);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(22, 25);
            lblCount.TabIndex = 3;
            lblCount.Text = "0";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(245, 128);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(112, 34);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(59, 211);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(112, 34);
            btnMinus.TabIndex = 1;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(59, 45);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(112, 34);
            btnPlus.TabIndex = 0;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(chkboxNotRepeat);
            tabPage2.Controls.Add(btnRandomCopy);
            tabPage2.Controls.Add(btnClear);
            tabPage2.Controls.Add(txtboxRandom);
            tabPage2.Controls.Add(btnExit2);
            tabPage2.Controls.Add(lblBefore);
            tabPage2.Controls.Add(lblFrom);
            tabPage2.Controls.Add(numericUpDown2);
            tabPage2.Controls.Add(numericUpDown1);
            tabPage2.Controls.Add(lblRandom);
            tabPage2.Controls.Add(btnAsk);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(538, 462);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Generator";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // chkboxNotRepeat
            // 
            chkboxNotRepeat.AutoSize = true;
            chkboxNotRepeat.Location = new Point(247, 321);
            chkboxNotRepeat.Name = "chkboxNotRepeat";
            chkboxNotRepeat.Size = new Size(161, 29);
            chkboxNotRepeat.TabIndex = 10;
            chkboxNotRepeat.Text = "Do not Repeat";
            chkboxNotRepeat.UseVisualStyleBackColor = true;
            chkboxNotRepeat.CheckedChanged += chkboxNotRepeat_CheckedChanged;
            // 
            // btnRandomCopy
            // 
            btnRandomCopy.ForeColor = Color.Black;
            btnRandomCopy.Location = new Point(247, 258);
            btnRandomCopy.Name = "btnRandomCopy";
            btnRandomCopy.Size = new Size(112, 34);
            btnRandomCopy.TabIndex = 9;
            btnRandomCopy.Text = "Copy";
            btnRandomCopy.UseVisualStyleBackColor = true;
            btnRandomCopy.Click += btnRandomCopy_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(247, 193);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtboxRandom
            // 
            txtboxRandom.Location = new Point(45, 193);
            txtboxRandom.Multiline = true;
            txtboxRandom.Name = "txtboxRandom";
            txtboxRandom.ScrollBars = ScrollBars.Vertical;
            txtboxRandom.Size = new Size(187, 134);
            txtboxRandom.TabIndex = 7;
            // 
            // btnExit2
            // 
            btnExit2.Location = new Point(412, 387);
            btnExit2.Name = "btnExit2";
            btnExit2.Size = new Size(112, 34);
            btnExit2.TabIndex = 6;
            btnExit2.Text = "Exit";
            btnExit2.UseVisualStyleBackColor = true;
            btnExit2.Click += btnExit2_Click;
            // 
            // lblBefore
            // 
            lblBefore.AutoSize = true;
            lblBefore.Location = new Point(8, 97);
            lblBefore.Name = "lblBefore";
            lblBefore.Size = new Size(68, 25);
            lblBefore.TabIndex = 5;
            lblBefore.Text = "before";
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Location = new Point(8, 34);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(53, 25);
            lblFrom.TabIndex = 4;
            lblFrom.Text = "from";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(110, 97);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(105, 31);
            numericUpDown2.TabIndex = 3;
            numericUpDown2.Value = new decimal(new int[] { 11, 0, 0, 0 });
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(110, 34);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(105, 31);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblRandom
            // 
            lblRandom.AutoSize = true;
            lblRandom.Location = new Point(258, 103);
            lblRandom.Name = "lblRandom";
            lblRandom.Size = new Size(83, 25);
            lblRandom.TabIndex = 1;
            lblRandom.Text = "Random";
            // 
            // btnAsk
            // 
            btnAsk.Location = new Point(258, 34);
            btnAsk.Name = "btnAsk";
            btnAsk.Size = new Size(112, 34);
            btnAsk.TabIndex = 0;
            btnAsk.Text = "Ask";
            btnAsk.UseVisualStyleBackColor = true;
            btnAsk.Click += btnRandom_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(RTBNotepad);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(538, 462);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Notebook";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // RTBNotepad
            // 
            RTBNotepad.Dock = DockStyle.Fill;
            RTBNotepad.Location = new Point(0, 0);
            RTBNotepad.Name = "RTBNotepad";
            RTBNotepad.Size = new Size(538, 462);
            RTBNotepad.TabIndex = 0;
            RTBNotepad.Text = "";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(tbPassword);
            tabPage4.Controls.Add(btnCreatePass);
            tabPage4.Controls.Add(lblLenghtPass);
            tabPage4.Controls.Add(nudLenghtPass);
            tabPage4.Controls.Add(clbPassword);
            tabPage4.Location = new Point(4, 34);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(538, 462);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Pass Generator";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(244, 203);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(239, 31);
            tbPassword.TabIndex = 4;
            // 
            // btnCreatePass
            // 
            btnCreatePass.Location = new Point(8, 203);
            btnCreatePass.Name = "btnCreatePass";
            btnCreatePass.Size = new Size(202, 34);
            btnCreatePass.TabIndex = 3;
            btnCreatePass.Text = "Create Password";
            btnCreatePass.UseVisualStyleBackColor = true;
            btnCreatePass.Click += btnCreatePass_Click;
            // 
            // lblLenghtPass
            // 
            lblLenghtPass.AutoSize = true;
            lblLenghtPass.Location = new Point(105, 155);
            lblLenghtPass.Name = "lblLenghtPass";
            lblLenghtPass.Size = new Size(156, 25);
            lblLenghtPass.TabIndex = 2;
            lblLenghtPass.Text = "Lenght Password";
            // 
            // nudLenghtPass
            // 
            nudLenghtPass.Location = new Point(8, 153);
            nudLenghtPass.Maximum = new decimal(new int[] { 22, 0, 0, 0 });
            nudLenghtPass.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            nudLenghtPass.Name = "nudLenghtPass";
            nudLenghtPass.Size = new Size(81, 31);
            nudLenghtPass.TabIndex = 1;
            nudLenghtPass.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // clbPassword
            // 
            clbPassword.CheckOnClick = true;
            clbPassword.FormattingEnabled = true;
            clbPassword.Items.AddRange(new object[] { "Numbers", "Capital letters", "Lower case", "Special symbols !@#$%^&*()`{}" });
            clbPassword.Location = new Point(8, 3);
            clbPassword.Name = "clbPassword";
            clbPassword.Size = new Size(323, 144);
            clbPassword.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 533);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Utilit";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudLenghtPass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem tsmiExit;
        private ToolStripMenuItem помощьToolStripMenuItem;
        private ToolStripMenuItem tsmiAbout;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label lblCount;
        private Button btnReset;
        private Button btnMinus;
        private Button btnPlus;
        private TabPage tabPage2;
        private Button btnExit;
        private Label lblBefore;
        private Label lblFrom;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private Label lblRandom;
        private Button btnAsk;
        private Button btnExit2;
        private TextBox txtboxRandom;
        private Button btnClear;
        private Button btnRandomCopy;
        private CheckBox chkboxNotRepeat;
        private TabPage tabPage3;
        private RichTextBox RTBNotepad;
        private ToolStripMenuItem notebookToolStripMenuItem;
        private ToolStripMenuItem tsmPasteDate;
        private ToolStripMenuItem tsmPasteTime;
        private ToolStripMenuItem tsmExit;
        private ToolStripMenuItem tsmPasteTimedate;
        private ToolStripMenuItem tsmSave;
        private ToolStripMenuItem tsmLoad;
        private TabPage tabPage4;
        private CheckedListBox clbPassword;
        private Label lblLenghtPass;
        private NumericUpDown nudLenghtPass;
        private Button btnCreatePass;
        private TextBox tbPassword;
    }
}