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
            this.searchMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(700, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileOpenMenuItem,
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileMenuItem.Text = "Файл";
            // 
            // fileOpenMenuItem
            // 
            this.fileOpenMenuItem.Name = "fileOpenMenuItem";
            this.fileOpenMenuItem.Size = new System.Drawing.Size(121, 22);
            this.fileOpenMenuItem.Text = "Открыть";
            this.fileOpenMenuItem.Click += new System.EventHandler(this.OpenFile);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(121, 22);
            this.exitMenuItem.Text = "Выход";
            this.exitMenuItem.Click += new System.EventHandler(this.OpenFile);
            // 
            // searchMenuItem
            // 
            this.searchMenuItem.Name = "searchMenuItem";
            this.searchMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchMenuItem.Text = "Поиск";
            // 
            // txtbFindString
            // 
            this.txtbFindString.Location = new System.Drawing.Point(10, 31);
            this.txtbFindString.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbFindString.Name = "txtbFindString";
            this.txtbFindString.Size = new System.Drawing.Size(502, 23);
            this.txtbFindString.TabIndex = 1;
            this.txtbFindString.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DownAnyKey);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(518, 30);
            this.btnFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(82, 22);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Найти";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.Find);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(606, 30);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(82, 22);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Еще";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.NextMatch);
            // 
            // lstbRegex
            // 
            this.lstbRegex.FormattingEnabled = true;
            this.lstbRegex.ItemHeight = 15;
            this.lstbRegex.Location = new System.Drawing.Point(10, 56);
            this.lstbRegex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstbRegex.Name = "lstbRegex";
            this.lstbRegex.Size = new System.Drawing.Size(242, 349);
            this.lstbRegex.TabIndex = 4;
            // 
            // rtbFileText
            // 
            this.rtbFileText.Location = new System.Drawing.Point(257, 56);
            this.rtbFileText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbFileText.Name = "rtbFileText";
            this.rtbFileText.Size = new System.Drawing.Size(433, 236);
            this.rtbFileText.TabIndex = 5;
            this.rtbFileText.Text = "";
            // 
            // rtbSearchResult
            // 
            this.rtbSearchResult.Location = new System.Drawing.Point(257, 296);
            this.rtbSearchResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbSearchResult.Name = "rtbSearchResult";
            this.rtbSearchResult.Size = new System.Drawing.Size(433, 109);
            this.rtbSearchResult.TabIndex = 6;
            this.rtbSearchResult.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 416);
            this.Controls.Add(this.rtbSearchResult);
            this.Controls.Add(this.rtbFileText);
            this.Controls.Add(this.lstbRegex);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtbFindString);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
    }
}