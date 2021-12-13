using System.Text.RegularExpressions;

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
            }
        }

        private void Find(object sender, EventArgs e) {
            data.Find(this.txtbFindString.Text);
            this.ShowMatch();
        }

        private void ShowMatch() {
            Match m = null;
            if (m != null && m.Success) {
                this.rtbFileText.SelectionBackColor = Color.White;
                this.rtbFileText.SelectionStart = m.Index;
                this.rtbFileText.SelectionLength = m.Value.Length;
                this.rtbFileText.ScrollToCaret();
                this.rtbFileText.SelectionBackColor = Color.Yellow;

                rtbSearchResult.Text = $"Найдено[{m.Index}]: ##{m.Value}##\n";

            }
        }
    }
}