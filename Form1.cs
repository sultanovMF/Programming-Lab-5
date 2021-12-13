﻿using System.Text.RegularExpressions;

namespace Programming_Lab_5 {
    public partial class Form1 : Form {
        Data data = new Data();
        public Form1() {
            InitializeComponent();
        }

        private void OpenFile(object sender, EventArgs e) {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "txt files (*.txt|*.txt|All files (*.*)|*.*";
            dlg.FilterIndex = 1;
            DialogResult res = dlg.ShowDialog();

            if (res == DialogResult.OK) {
                data.ReadFromFile(dlg.FileName);
                Console.WriteLine(dlg.FileName);
                this.rtbFileText.Text = data.Text;
            }
        }

        private void Find(object sender, EventArgs e) {
            data.Find(this.txtbFindString.Text);
            this.ShowMatch();
        }

        private void ShowMatch() {
            Match m = data.Match;
            if (m != null && m.Success) {
                this.rtbFileText.SelectionBackColor = Color.White;
                this.rtbFileText.SelectionStart = m.Index;
                this.rtbFileText.SelectionLength = m.Value.Length;
                this.rtbFileText.ScrollToCaret();
                this.rtbFileText.SelectionBackColor = Color.Yellow;

                this.rtbSearchResult.Text = $"Найдено[{m.Index}]: ##{m.Value}##\n";

            }
        }

        private void NextMatch(object sender, EventArgs e) {
            data.Next();
            this.ShowMatch();
        }

        private void DownAnyKey(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                Find(sender, e);
                e.SuppressKeyPress = true;
            }
        }
    }
}