namespace Programming_Lab_5 {
    partial class Form1 {
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
            this.txtbFindString = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lstbRegex = new System.Windows.Forms.ListBox();
            this.rtbFileText = new System.Windows.Forms.RichTextBox();
            this.rtbSearchResult = new System.Windows.Forms.RichTextBox();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // topMenu
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.searchMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "topMenu";
            this.menuStrip.Size = new System.Drawing.Size(800, 28);
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
            this.fileOpenMenuItem.Size = new System.Drawing.Size(224, 26);
            this.fileOpenMenuItem.Text = "Открыть";
            this.fileOpenMenuItem.Click += new System.EventHandler(this.OpenFile);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitMenuItem.Text = "Выход";
            this.exitMenuItem.Click += new System.EventHandler(this.OpenFile);
            // 
            // searchMenuItem
            // 
            this.searchMenuItem.Name = "searchMenuItem";
            this.searchMenuItem.Size = new System.Drawing.Size(66, 24);
            this.searchMenuItem.Text = "Поиск";
            // 
            // searchTextBox
            // 
            this.txtbFindString.Location = new System.Drawing.Point(11, 41);
            this.txtbFindString.Name = "searchTextBox";
            this.txtbFindString.Size = new System.Drawing.Size(513, 27);
            this.txtbFindString.TabIndex = 1;
            // 
            // searchButton
            // 
            this.btnFind.Location = new System.Drawing.Point(546, 41);
            this.btnFind.Name = "searchButton";
            this.btnFind.Size = new System.Drawing.Size(94, 29);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Найти";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.Find);
            // 
            // moreButton
            // 
            this.btnNext.Location = new System.Drawing.Point(666, 40);
            this.btnNext.Name = "moreButton";
            this.btnNext.Size = new System.Drawing.Size(94, 29);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Еще";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.lstbRegex.FormattingEnabled = true;
            this.lstbRegex.ItemHeight = 20;
            this.lstbRegex.Location = new System.Drawing.Point(12, 74);
            this.lstbRegex.Name = "listBox1";
            this.lstbRegex.Size = new System.Drawing.Size(276, 464);
            this.lstbRegex.TabIndex = 4;
            // 
            // richTextBox1
            // 
            this.rtbFileText.Location = new System.Drawing.Point(294, 74);
            this.rtbFileText.Name = "richTextBox1";
            this.rtbFileText.Size = new System.Drawing.Size(494, 314);
            this.rtbFileText.TabIndex = 5;
            this.rtbFileText.Text = "";
            // 
            // richTextBox2
            // 
            this.rtbSearchResult.Location = new System.Drawing.Point(294, 394);
            this.rtbSearchResult.Name = "richTextBox2";
            this.rtbSearchResult.Size = new System.Drawing.Size(494, 144);
            this.rtbSearchResult.TabIndex = 6;
            this.rtbSearchResult.Text = "";
            // 
            // Form1
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
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}