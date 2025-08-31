using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DreamLens
{
    public partial class FormHistory : Form
    {
        public FormHistory()
        {
            InitializeComponent();
            this.Load += FormHistory_Load;
        }

        private void FormHistory_Load(object sender, EventArgs e)
        {
            LoadHistory();
        }

        private void LoadHistory()
        {
            string filePath = "history.csv";
            if (File.Exists(filePath))
            {
                lbresult.Items.Clear();
                var lines = File.ReadAllLines(filePath, Encoding.UTF8)
                                .Select(l => l.Replace("|", " "))
                                .ToArray();
                lbresult.Items.AddRange(lines);
            }
            else
            {
                lbresult.Items.Clear();
                lbresult.Items.Add("history.csv 없음");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadHistory();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
