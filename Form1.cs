using System.IO;

namespace FileCompare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btnCopyFromRight_Click(object sender, EventArgs e)
        {

        }

        private void lvwLeftDir_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLeftDir_Click(object sender, EventArgs e)
        {
            using (var dlg = new FolderBrowserDialog())
            {
                dlg.Description = "폴더를 선택하세요.";
                // 현재 텍스트박스에 있는 경로를 초기 선택 폴더로 설정
                if (!string.IsNullOrWhiteSpace(textBox1.Text) && Directory.Exists(textBox1.Text))
                {
                    dlg.SelectedPath = textBox1.Text;
                }

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = dlg.SelectedPath;
                }
            }
        }

        private void btnCopyFromLeft_Click(object sender, EventArgs e)
        {

        }
    }
}
