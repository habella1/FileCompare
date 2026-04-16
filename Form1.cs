using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace FileCompare
{
    public partial class Form1 : Form
    {
        Dictionary<string, FileInfo> leftDict = new Dictionary<string, FileInfo>();
        Dictionary<string, FileInfo> rightDict = new Dictionary<string, FileInfo>();
        
        //과제2: ListView에 파일 목록 표시하는 함수
        void PopulateListView(ListView lv, string folderPath, bool isLeft)
        {

            // prepare
            lv.BeginUpdate();
            lv.Items.Clear();
            // ensure details view and columns exist
            lv.View = View.Details;

            // ✔ [추가] 기존 데이터 초기화
            if (isLeft)
                leftDict.Clear();
            else
                rightDict.Clear();

            // if designer didn't create columns, add defaults
            if (lv.Columns.Count == 0)
            {
                lv.Columns.Add("이름", 250);
                lv.Columns.Add("크기", 100);
                lv.Columns.Add("수정일", 160);
            }

            var files = Directory.EnumerateFiles(folderPath)
                .Select(p => new FileInfo(p))
                .OrderBy(f => f.Name);

            foreach (var f in files)
            {
                var item = new ListViewItem(f.Name);

                item.SubItems.Add(f.Length.ToString("N0") + " bytes");
                item.SubItems.Add(f.LastWriteTime.ToString("g"));

                lv.Items.Add(item);

                // ✔ [핵심] Dictionary 저장
                if (isLeft)
                    leftDict[f.Name] = f;
                else
                    rightDict[f.Name] = f;
            }

            // finish update
            lv.EndUpdate();
            lv.Invalidate(); // 다시 그리기

            // 컬럼 너비 자동 조정하여 크기/수정일이 보이도록 함
            for (int i = 0; i < lv.Columns.Count; i++)
                lv.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.ColumnContent);
            // 최소 너비 보장(자동조정 후에도 가려지면 보이도록 함)
            if (lv.Columns.Count >= 3)
            {
                lv.Columns[0].Width = Math.Max(lv.Columns[0].Width, 200);
                lv.Columns[1].Width = Math.Max(lv.Columns[1].Width, 100);
                lv.Columns[2].Width = Math.Max(lv.Columns[2].Width, 140);
            }
        }

        public Form1()
        {
            InitializeComponent();

            // Use default drawing and set ForeColor per item for simplicity
        }

        private void lvw_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            // We handle drawing of the full row (background) here; text is drawn in DrawSubItem.
            e.DrawDefault = false;

            // draw background (respect selection)
            var bounds = e.Bounds;
            if ((e.State & ListViewItemStates.Selected) != 0)
            {
                e.Graphics.FillRectangle(SystemBrushes.Highlight, bounds);
            }
            else
            {
                e.Graphics.FillRectangle(SystemBrushes.Window, bounds);
            }
        }

        private void lvw_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            string fileName = e.Item.Text;

            bool inLeft = leftDict.ContainsKey(fileName);
            bool inRight = rightDict.ContainsKey(fileName);

            Color color = Color.Purple;

            // ✔ 둘 다 존재하는 경우
            if (inLeft && inRight)
            {
                var lf = leftDict[fileName];
                var rf = rightDict[fileName];

                // ✔ 완전히 동일
                if (lf.Length == rf.Length)
                    color = Color.Black;

                // ✔ 다름 → 변경됨
                else
                    color = Color.Purple;
            }
            else if (!inLeft && inRight)
                color = Color.Red;   // 오른쪽만

            else if (inLeft && !inRight)
                color = Color.Gray;  // 왼쪽만

            // 출력
            TextRenderer.DrawText(
                e.Graphics,
                e.SubItem.Text,
                e.SubItem.Font,
                e.Bounds,
                (e.ItemState & ListViewItemStates.Selected) != 0
                    ? SystemColors.HighlightText
                    : color
            );
        }

     


        private void lvw_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }

        // Update item ForeColor based on presence in left/right dictionaries.
        void UpdateListViewColors()
        {
            Action<ListView, Dictionary<string, FileInfo>, Dictionary<string, FileInfo>> update = (lv, myDict, otherDict) =>
            {
                foreach (ListViewItem it in lv.Items)
                {
                    string name = it.Text;
                    bool inLeft = leftDict.ContainsKey(name);
                    bool inRight = rightDict.ContainsKey(name);
                    Color color = Color.Purple;
                    if (inLeft && inRight) color = Color.Black;
                    else if (!inLeft && inRight) color = Color.Red;
                    else if (inLeft && !inRight) color = Color.Gray;
                    it.ForeColor = color;
                }
            };

            update(lvwLeftDir, leftDict, rightDict);
            update(lvwRightDir, rightDict, leftDict);
        }

        private void CopyFileWithConfirmation(string srcPath, string destPath)
        {
            // ✔ 대상 파일 존재 여부 확인
            if (File.Exists(destPath))
            {
                DateTime srcTime = File.GetLastWriteTime(srcPath);
                DateTime destTime = File.GetLastWriteTime(destPath);

                // ✔ 대상이 더 최신이면 경고
                if (destTime > srcTime)
                {
                    var result = MessageBox.Show(
                        "대상 파일이 더 최신입니다. 그래도 덮어쓰시겠습니까?",
                        "확인",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (result != DialogResult.Yes)
                        return;
                }
            }

            // ✔ 폴더 없으면 생성 (중요)
            string dir = Path.GetDirectoryName(destPath);
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            // ✔ 실제 복사
            File.Copy(srcPath, destPath, true);
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

        private void btnRightDir_Click(object sender, EventArgs e)
        {
            using (var dlg = new FolderBrowserDialog())
            {
                dlg.Description = "폴더를 선택하세요.";
                if (!string.IsNullOrWhiteSpace(txtRightDir.Text) && Directory.Exists(txtRightDir.Text))
                {
                    dlg.SelectedPath = txtRightDir.Text;
                }

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtRightDir.Text = dlg.SelectedPath;

                    // **과제2 - 추가
                    PopulateListView(lvwRightDir, dlg.SelectedPath, false);
                    lvwLeftDir.Invalidate();
                    lvwRightDir.Invalidate(); 
                    UpdateListViewColors();
                }
            }
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

                    // **과제2 - 추가
                    PopulateListView(lvwLeftDir, dlg.SelectedPath, true);
                    lvwLeftDir.Invalidate();
                    lvwRightDir.Invalidate();
                    UpdateListViewColors();
                }
            }
        }

        private void btnCopyFromLeft_Click(object sender, EventArgs e)
        {
            if (lvwLeftDir.SelectedItems.Count == 0)
                return;

            foreach (ListViewItem item in lvwLeftDir.SelectedItems)
            {
                string name = item.Text;

                if (!leftDict.TryGetValue(name, out var src))
                    continue;

                string destPath = Path.Combine(txtRightDir.Text, src.Name);

                CopyFileWithConfirmation(src.FullName, destPath);
            }

            PopulateListView(lvwRightDir, txtRightDir.Text, false);
            lvwRightDir.Invalidate();
        }
    }
}
