using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Lab_5
{
    public partial class StatisticsForm : Form
    {
        public IDictionary<string, int> Stats { get; set; }
        public StatisticsForm(IDictionary<string, int> stats)
        {
            this.Stats = stats;


            InitializeComponent();

            foreach (KeyValuePair<string, int> p in stats)
            {
                this.dataGridView.Rows.Add(new object[] { p.Key, p.Value });
            }

            this.dataGridView.Sort(this.dataGridView.Columns[1], ListSortDirection.Descending);

        }
    }
}
