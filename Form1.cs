using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DreamLens
{
    public partial class Form1 : Form
    {
        List<string> results;
        private Dictionary<string, string> _dreamDictionary;

        public Form1()
        {
            InitializeComponent();
            _dreamDictionary = new Dictionary<string, string>(40000);
            LoadResults();
        }
        private void LoadResults()
        {
            try
            {
                foreach (var line in File.ReadLines("./dream_data.csv"))
                {
                    var firstCommaIndex = line.IndexOf(',');
                    if (firstCommaIndex < 0) continue;

                    var secondCommaIndex = line.IndexOf(',', firstCommaIndex + 1);
                    if (secondCommaIndex < 0) continue;

                    var thirdCommaIndex = line.IndexOf(',', secondCommaIndex + 1);
                    if (thirdCommaIndex < 0) continue;

                    string key = line.Substring(0, thirdCommaIndex);
                    string value = line.Substring(thirdCommaIndex + 1);

                    _dreamDictionary[key] = value;
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"파일이 없어요.\n{ex.Message}", "파일 오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"권환이 없어요.\n{ex.Message}", "권한 오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"알 수 없는 오류가 발생했어요.\n{ex.Message}", "알 수 없는 오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string obj = tbObject.Text;
                string act = tbAct.Text;
                string emt = tbEmotion.Text;
                string key = $"{obj},{act},{emt}";

                if (_dreamDictionary.TryGetValue(key, out string interpretation))
                {
                    resultBox.Text = interpretation;
                }
                else
                {
                    resultBox.Text = "해석을 찾을 수 없습니다.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"알 수 없는 오류가 발생했어요.\n{ex.Message}", "알 수 없는 오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void 내역불러오기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistory form = Application.OpenForms["FormHistory"] as FormHistory;
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                form = new FormHistory();
                form.Show();
            }
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dreamLens정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
            form.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

    }
}
