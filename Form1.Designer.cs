namespace FileCompare
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            panel4 = new Panel();
            lvwLeftDir = new ListView();
            name_Left = new ColumnHeader();
            size_Left = new ColumnHeader();
            date_left = new ColumnHeader();
            panel3 = new Panel();
            btnLeftDir = new Button();
            textBox1 = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            btnCopyFromLeft = new Button();
            lblAppName = new Label();
            panel7 = new Panel();
            lvwRightDir = new ListView();
            name_right = new ColumnHeader();
            size_right = new ColumnHeader();
            date_right = new ColumnHeader();
            panel6 = new Panel();
            btnRightDir = new Button();
            txtRightDir = new TextBox();
            panel5 = new Panel();
            btnCopyFromRight = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.FixedSingle;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel4);
            splitContainer1.Panel1.Controls.Add(panel3);
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel7);
            splitContainer1.Panel2.Controls.Add(panel6);
            splitContainer1.Panel2.Controls.Add(panel5);
            splitContainer1.Size = new Size(1072, 626);
            splitContainer1.SplitterDistance = 537;
            splitContainer1.TabIndex = 0;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // panel4
            // 
            panel4.Controls.Add(lvwLeftDir);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 183);
            panel4.Name = "panel4";
            panel4.Size = new Size(535, 441);
            panel4.TabIndex = 7;
            // 
            // lvwLeftDir
            // 
            lvwLeftDir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvwLeftDir.Columns.AddRange(new ColumnHeader[] { name_Left, size_Left, date_left });
            lvwLeftDir.FullRowSelect = true;
            lvwLeftDir.GridLines = true;
            lvwLeftDir.Location = new Point(17, 20);
            lvwLeftDir.Name = "lvwLeftDir";
            lvwLeftDir.Size = new Size(484, 410);
            lvwLeftDir.TabIndex = 0;
            lvwLeftDir.UseCompatibleStateImageBehavior = false;
            lvwLeftDir.View = View.Details;
            // 
            // name_Left
            // 
            name_Left.Text = "이름";
            // 
            // size_Left
            // 
            size_Left.Text = "크기";
            size_Left.Width = 100;
            // 
            // date_left
            // 
            date_left.Text = "수정일";
            date_left.Width = 160;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnLeftDir);
            panel3.Controls.Add(textBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 83);
            panel3.Name = "panel3";
            panel3.Size = new Size(535, 100);
            panel3.TabIndex = 6;
            // 
            // btnLeftDir
            // 
            btnLeftDir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLeftDir.Location = new Point(368, 29);
            btnLeftDir.Name = "btnLeftDir";
            btnLeftDir.Size = new Size(133, 39);
            btnLeftDir.TabIndex = 3;
            btnLeftDir.Text = "폴더선택";
            btnLeftDir.UseVisualStyleBackColor = true;
            btnLeftDir.Click += btnLeftDir_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(22, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(324, 39);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnCopyFromLeft);
            panel1.Controls.Add(lblAppName);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(535, 83);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Location = new Point(265, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 8);
            panel2.TabIndex = 2;
            // 
            // btnCopyFromLeft
            // 
            btnCopyFromLeft.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCopyFromLeft.Location = new Point(366, 14);
            btnCopyFromLeft.Name = "btnCopyFromLeft";
            btnCopyFromLeft.Size = new Size(133, 57);
            btnCopyFromLeft.TabIndex = 1;
            btnCopyFromLeft.Text = ">>>";
            btnCopyFromLeft.UseVisualStyleBackColor = true;
            btnCopyFromLeft.Click += btnCopyFromLeft_Click;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("새굴림", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblAppName.ForeColor = Color.Blue;
            lblAppName.Location = new Point(9, 14);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(297, 43);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "File Compare";
            // 
            // panel7
            // 
            panel7.Controls.Add(lvwRightDir);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 183);
            panel7.Name = "panel7";
            panel7.Size = new Size(529, 441);
            panel7.TabIndex = 8;
            // 
            // lvwRightDir
            // 
            lvwRightDir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvwRightDir.Columns.AddRange(new ColumnHeader[] { name_right, size_right, date_right });
            lvwRightDir.FullRowSelect = true;
            lvwRightDir.GridLines = true;
            lvwRightDir.Location = new Point(22, 20);
            lvwRightDir.Name = "lvwRightDir";
            lvwRightDir.Size = new Size(484, 410);
            lvwRightDir.TabIndex = 1;
            lvwRightDir.UseCompatibleStateImageBehavior = false;
            lvwRightDir.View = View.Details;
            // 
            // name_right
            // 
            name_right.Text = "이름";
            // 
            // size_right
            // 
            size_right.Text = "크기";
            size_right.Width = 100;
            // 
            // date_right
            // 
            date_right.Text = "수정일";
            date_right.Width = 160;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnRightDir);
            panel6.Controls.Add(txtRightDir);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 83);
            panel6.Name = "panel6";
            panel6.Size = new Size(529, 100);
            panel6.TabIndex = 7;
            // 
            // btnRightDir
            // 
            btnRightDir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRightDir.Location = new Point(376, 29);
            btnRightDir.Name = "btnRightDir";
            btnRightDir.Size = new Size(133, 39);
            btnRightDir.TabIndex = 4;
            btnRightDir.Text = "폴더선택";
            btnRightDir.UseVisualStyleBackColor = true;
            btnRightDir.Click += btnRightDir_Click;
            // 
            // txtRightDir
            // 
            txtRightDir.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtRightDir.Location = new Point(22, 29);
            txtRightDir.Name = "txtRightDir";
            txtRightDir.Size = new Size(324, 39);
            txtRightDir.TabIndex = 4;
            txtRightDir.TextChanged += textBox2_TextChanged;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnCopyFromRight);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(529, 83);
            panel5.TabIndex = 6;
            // 
            // btnCopyFromRight
            // 
            btnCopyFromRight.Location = new Point(22, 15);
            btnCopyFromRight.Name = "btnCopyFromRight";
            btnCopyFromRight.Size = new Size(129, 57);
            btnCopyFromRight.TabIndex = 2;
            btnCopyFromRight.Text = "<<<";
            btnCopyFromRight.UseVisualStyleBackColor = true;
            btnCopyFromRight.Click += btnCopyFromRight_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 626);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "File Compare v1.0";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnLeftDir;
        private Label lblAppName;
        private Button btnCopyFromLeft;
        private TextBox textBox1;
        private Button btnRightDir;
        private Button btnCopyFromRight;
        private TextBox txtRightDir;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private ListView lvwLeftDir;
        private ListView lvwRightDir;
        private ColumnHeader name_Left;
        private ColumnHeader size_Left;
        private ColumnHeader date_left;
        private ColumnHeader name_right;
        private ColumnHeader size_right;
        private ColumnHeader date_right;
    }
}
