using System.Text.RegularExpressions;

namespace Programming_Lab_5
{
    class Data
    {
        public string Text { get; private set; }
        public string FileName { get; private set; }
        public Match Match { get; private set; }
        public void ReadFromFile(string fileName)
        {
            Console.WriteLine(fileName);
            if (!File.Exists(fileName))
            {
                MessageBox.Show($"Не удалось открыть файл {fileName}", "Ошибка открытия файла", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (fileName == null)
            {
                MessageBox.Show($"Пустое имя файла!", "Ошибка открытия файла", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (StreamReader sr = new StreamReader(fileName))
            {
                this.Text = sr.ReadToEnd().Replace("\r", "");
            }
            FileName = fileName;
        }
        public void Find(string re)
        {
            this.Match = Regex.Match(this.Text, re);
        }
        public void Next()
        {
            Match = this.Match.NextMatch();
        }
    }
}
