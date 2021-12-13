namespace Programming_Lab_5 {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileOpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orOfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.индивидуальныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtbFindString = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lstbRegex = new System.Windows.Forms.ListBox();
            this.rtbFileText = new System.Windows.Forms.RichTextBox();
            this.rtbSearchResult = new System.Windows.Forms.RichTextBox();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.searchMenuItem,
            this.orOfToolStripMenuItem,
            this.toolStripMenuItem1,
            this.статистикаToolStripMenuItem,
            this.индивидуальныеToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(800, 30);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileOpenMenuItem,
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(59, 24);
            this.fileMenuItem.Text = "Файл";
            // 
            // fileOpenMenuItem
            // 
            this.fileOpenMenuItem.Name = "fileOpenMenuItem";
            this.fileOpenMenuItem.Size = new System.Drawing.Size(150, 26);
            this.fileOpenMenuItem.Text = "Открыть";
            this.fileOpenMenuItem.Click += new System.EventHandler(this.OpenFile);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(150, 26);
            this.exitMenuItem.Text = "Выход";
            this.exitMenuItem.Click += new System.EventHandler(this.OpenFile);
            // 
            // searchMenuItem
            // 
            this.searchMenuItem.Name = "searchMenuItem";
            this.searchMenuItem.Size = new System.Drawing.Size(66, 24);
            this.searchMenuItem.Text = "Поиск";
            // 
            // orOfToolStripMenuItem
            // 
            this.orOfToolStripMenuItem.Name = "orOfToolStripMenuItem";
            this.orOfToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.orOfToolStripMenuItem.Text = "Or, Of";
            this.orOfToolStripMenuItem.Click += new System.EventHandler(this.OnOrOfClick);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(51, 24);
            this.toolStripMenuItem1.Text = "????";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.OnQuestionClick);
            // 
            // статистикаToolStripMenuItem
            // 
            this.статистикаToolStripMenuItem.Name = "статистикаToolStripMenuItem";
            this.статистикаToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.статистикаToolStripMenuItem.Text = "Статистика";
            // 
            // индивидуальныеToolStripMenuItem
            // 
            this.индивидуальныеToolStripMenuItem.Name = "индивидуальныеToolStripMenuItem";
            this.индивидуальныеToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.индивидуальныеToolStripMenuItem.Text = "Индивидуальные";
            this.индивидуальныеToolStripMenuItem.Click += new System.EventHandler(this.OnIndividClick);
            // 
            // txtbFindString
            // 
            this.txtbFindString.Location = new System.Drawing.Point(11, 41);
            this.txtbFindString.Name = "txtbFindString";
            this.txtbFindString.Size = new System.Drawing.Size(573, 27);
            this.txtbFindString.TabIndex = 1;
            this.txtbFindString.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DownAnyKey);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(592, 40);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(94, 29);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Найти";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.Find);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(693, 40);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(94, 29);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Еще";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.NextMatch);
            // 
            // lstbRegex
            // 
            this.lstbRegex.FormattingEnabled = true;
            this.lstbRegex.ItemHeight = 20;
            this.lstbRegex.Items.AddRange(new object[] {
            "\\sк..а\\s",
            "\\b\\d{4}\\b ",
            "\\bо[а-я]+ ",
            "\\bо[а-я]{5,} ",
            "\\bо\\S+",
            "\\b\\S*ша\\b ",
            "\\b[а-я]*(ить|ать)\\b ",
            "[А-Я].*[.!?]+  ",
            "\\b[ф-я].*?\\b  ",
            "\\b(\\S)\\S+(\\S)\\b",
            "([LMXIV]+)\\n",
            "\\b(\\S)\\S*\\1\\b "});
            this.lstbRegex.Location = new System.Drawing.Point(11, 75);
            this.lstbRegex.Name = "lstbRegex";
            this.lstbRegex.Size = new System.Drawing.Size(276, 464);
            this.lstbRegex.TabIndex = 4;
            // 
            // rtbFileText
            // 
            this.rtbFileText.Location = new System.Drawing.Point(294, 75);
            this.rtbFileText.Name = "rtbFileText";
            this.rtbFileText.Size = new System.Drawing.Size(494, 313);
            this.rtbFileText.TabIndex = 5;
            this.rtbFileText.Text = "";
            // 
            // rtbSearchResult
            // 
            this.rtbSearchResult.Location = new System.Drawing.Point(294, 395);
            this.rtbSearchResult.Name = "rtbSearchResult";
            this.rtbSearchResult.ReadOnly = true;
            this.rtbSearchResult.Size = new System.Drawing.Size(494, 144);
            this.rtbSearchResult.TabIndex = 6;
            this.rtbSearchResult.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 555);
            this.Controls.Add(this.rtbSearchResult);
            this.Controls.Add(this.rtbFileText);
            this.Controls.Add(this.lstbRegex);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtbFindString);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Лабочка № 5";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem fileMenuItem;
        private ToolStripMenuItem searchMenuItem;
        private ToolStripMenuItem exitMenuItem;
        private ToolStripMenuItem fileOpenMenuItem;
        private TextBox txtbFindString;
        private Button btnFind;
        private Button btnNext;
        private ListBox lstbRegex;
        private RichTextBox rtbFileText;
        private RichTextBox rtbSearchResult;
        private ToolStripMenuItem orOfToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem статистикаToolStripMenuItem;
        private ToolStripMenuItem индивидуальныеToolStripMenuItem;
    }
}