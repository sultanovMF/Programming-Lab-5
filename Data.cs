using System.Text.RegularExpressions;

namespace Programming_Lab_5 {
    class Data {
        public string Text { get; private set; }
        public string FileName { get; private set; }
        public Match Match;
        public void ReadFromFile(string filename) {
            using (StreamReader sr = new StreamReader(filename)) {
                this.Text = sr.ReadToEnd().Replace("\r", "");
            }
        }
        public void Find(string re) {
            this.Match = Regex.Match(this.Text, re);
        }
        public Data() {
            
        }
    }
}
