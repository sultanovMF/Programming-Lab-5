using Programming_Lab_5.Properties;
using System.Text.RegularExpressions;

namespace Programming_Lab_5 {
    public partial class MainForm : Form {
        Data data = new Data();
        public MainForm() {
            InitializeComponent();
            this.lstbRegex.Click += (s, e) =>
            {
                this.txtbFindString.Text = this.lstbRegex.Text;
                data.Find(this.rtbFileText.Text);
                ShowMatch();
            };
            if (Settings.Default.DefaultFileName != null)
            {
                data.ReadFromFile(Settings.Default.DefaultFileName);
                this.rtbFileText.Text = data.Text;
            }



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

                this.rtbSearchResult.Text = $"Найдено[{m.Index}]: {m.Value}\n";

            }
            if (m != null && !m.Success) {
                this.rtbSearchResult.Text = $"По запросу ничего не найдено!";
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

        private void OnClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.DefaultFileName = data.FileName;
            Settings.Default.Save();

        }
    }
}