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
        public void GetOfOrStatistics(out int ofc, out int orc)
        {
            ofc = 0;
            orc = 0;
            foreach (Match m in Regex.Matches(this.Text, @"\b(or|of)\b")) {
                if (m.Value == "of") ofc++; else orc++;
            }
        }
        public ISet<string> FindSentencesFirstWords()
        {
            ISet<string> words = new HashSet<string>();
            foreach (Match m in Regex.Matches(this.Text, @"[?.!]\s*([A-Z][a-z]*)[^.!]*\?"))
            {
                words.Add(m.Groups[1].Value);
            }
            return words;
        }
        public IDictionary<string, int> FirstLetterCounts()
        {
            Dictionary<string, int> counts = new Dictionary<string, int>();
            Regex r = new Regex(@"[a-zA]\s(\S)");
            foreach (Match m in r.Matches(this.Text))
            {
                string b = m.Groups[1].Value;
                if (counts.ContainsKey(b))
                {
                    counts[b]++;
                }
                else
                {
                    counts[b] = 1;
                }
            }
            return counts;
        }
        //9.	Найдите все различные слова.Отсортируйте все начальные фрагменты слов из трех
        //    букв по популярности (одно слово считать один раз, а не учитывать каждое вхождение в тексте)
        public IDictionary<string, int> ThreeWordPopularity()
        {
            Dictionary<string, int> counts = new Dictionary<string, int>();
            Dictionary<string, bool> isRepeated = new Dictionary<string, bool>();

            foreach (Match m in Regex.Matches(this.Text, @"[a-zA]*\b\w{3,}\b"))
            {
                string word = m.ToString();
                if (isRepeated.ContainsKey(word)) {
                    continue;
                } else {
                    isRepeated[word] = true;
                }
                string firstLetters = Regex.Match(word, @".{0,3}$").ToString();
                firstLetters = firstLetters.ToLower();
                if (counts.ContainsKey(firstLetters)) {
                    counts[firstLetters]++;
                } else {
                    counts[firstLetters] = 1;
                }
            }

            return counts;
        }
    }
}
