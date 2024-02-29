namespace WinFormsListControlsAdvansedApp
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
            components = new System.ComponentModel.Container();
            TreeNode treeNode1 = new TreeNode("Холодильники");
            TreeNode treeNode2 = new TreeNode("Бытовая техника", new TreeNode[] { treeNode1 });
            TreeNode treeNode3 = new TreeNode("Ноутбуки");
            TreeNode treeNode4 = new TreeNode("Компьтерная техника", new TreeNode[] { treeNode3 });
            TreeNode treeNode5 = new TreeNode("Гаджеты");
            TreeNode treeNode6 = new TreeNode("Товары", new TreeNode[] { treeNode2, treeNode4, treeNode5 });
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ListViewItem listViewItem1 = new ListViewItem("Россия", 0);
            ListViewItem listViewItem2 = new ListViewItem("Китай", 1);
            ListViewItem listViewItem3 = new ListViewItem("Бразилия", 2);
            chkListLangs = new CheckedListBox();
            lblLangs = new Label();
            treeView1 = new TreeView();
            treeRegs = new TreeView();
            btnExpand = new Button();
            btnCollapse = new Button();
            imgList = new ImageList(components);
            chkRussia = new CheckBox();
            checkBox1 = new CheckBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            btnLargeIcons = new Button();
            btnSmallIcons = new Button();
            btnTable = new Button();
            SuspendLayout();
            // 
            // chkListLangs
            // 
            chkListLangs.Font = new Font("Segoe UI", 20F);
            chkListLangs.FormattingEnabled = true;
            chkListLangs.Location = new Point(12, 12);
            chkListLangs.Name = "chkListLangs";
            chkListLangs.Size = new Size(338, 346);
            chkListLangs.TabIndex = 0;
            chkListLangs.SelectedIndexChanged += chkListLangs_SelectedIndexChanged;
            // 
            // lblLangs
            // 
            lblLangs.AutoSize = true;
            lblLangs.Font = new Font("Segoe UI", 20F);
            lblLangs.Location = new Point(12, 373);
            lblLangs.Name = "lblLangs";
            lblLangs.Size = new Size(90, 37);
            lblLangs.TabIndex = 1;
            lblLangs.Text = "label1";
            // 
            // treeView1
            // 
            treeView1.CheckBoxes = true;
            treeView1.Font = new Font("Segoe UI", 16F);
            treeView1.Location = new Point(365, 12);
            treeView1.Name = "treeView1";
            treeNode1.Name = "Узел4";
            treeNode1.Text = "Холодильники";
            treeNode2.Name = "Узел1";
            treeNode2.Text = "Бытовая техника";
            treeNode3.BackColor = Color.Red;
            treeNode3.Name = "Узел5";
            treeNode3.Text = "Ноутбуки";
            treeNode4.Name = "Узел2";
            treeNode4.Text = "Компьтерная техника";
            treeNode5.Checked = true;
            treeNode5.Name = "Узел3";
            treeNode5.Text = "Гаджеты";
            treeNode6.Name = "Узел0";
            treeNode6.Text = "Товары";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode6 });
            treeView1.Size = new Size(356, 142);
            treeView1.TabIndex = 2;
            // 
            // treeRegs
            // 
            treeRegs.Font = new Font("Segoe UI", 16F);
            treeRegs.Location = new Point(365, 175);
            treeRegs.Name = "treeRegs";
            treeRegs.Size = new Size(356, 135);
            treeRegs.TabIndex = 3;
            // 
            // btnExpand
            // 
            btnExpand.Font = new Font("Segoe UI", 20F);
            btnExpand.Location = new Point(365, 352);
            btnExpand.Name = "btnExpand";
            btnExpand.Size = new Size(153, 58);
            btnExpand.TabIndex = 4;
            btnExpand.Text = "Expand";
            btnExpand.UseVisualStyleBackColor = true;
            btnExpand.Click += btnExpand_Click;
            // 
            // btnCollapse
            // 
            btnCollapse.Font = new Font("Segoe UI", 20F);
            btnCollapse.Location = new Point(568, 352);
            btnCollapse.Name = "btnCollapse";
            btnCollapse.Size = new Size(153, 58);
            btnCollapse.TabIndex = 4;
            btnCollapse.Text = "Collapse";
            btnCollapse.UseVisualStyleBackColor = true;
            // 
            // imgList
            // 
            imgList.ColorDepth = ColorDepth.Depth32Bit;
            imgList.ImageStream = (ImageListStreamer)resources.GetObject("imgList.ImageStream");
            imgList.TransparentColor = Color.Transparent;
            imgList.Images.SetKeyName(0, "russia.jpg");
            imgList.Images.SetKeyName(1, "china.png");
            imgList.Images.SetKeyName(2, "brasil.jpg");
            // 
            // chkRussia
            // 
            chkRussia.AutoSize = true;
            chkRussia.Font = new Font("Segoe UI", 18F);
            chkRussia.ImageIndex = 0;
            chkRussia.ImageList = imgList;
            chkRussia.Location = new Point(142, 362);
            chkRussia.Name = "chkRussia";
            chkRussia.Size = new Size(79, 64);
            chkRussia.TabIndex = 5;
            chkRussia.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 18F);
            checkBox1.ImageIndex = 1;
            checkBox1.ImageList = imgList;
            checkBox1.Location = new Point(142, 432);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(79, 64);
            checkBox1.TabIndex = 5;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            listView1.Font = new Font("Segoe UI", 18F);
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
            listView1.LargeImageList = imgList;
            listView1.Location = new Point(752, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(389, 298);
            listView1.SmallImageList = imgList;
            listView1.StateImageList = imgList;
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Страна";
            columnHeader1.Width = 250;
            // 
            // btnLargeIcons
            // 
            btnLargeIcons.Location = new Point(752, 352);
            btnLargeIcons.Name = "btnLargeIcons";
            btnLargeIcons.Size = new Size(103, 58);
            btnLargeIcons.TabIndex = 7;
            btnLargeIcons.Text = "Large Icons";
            btnLargeIcons.UseVisualStyleBackColor = true;
            btnLargeIcons.Click += btnLargeIcons_Click;
            // 
            // btnSmallIcons
            // 
            btnSmallIcons.Location = new Point(876, 352);
            btnSmallIcons.Name = "btnSmallIcons";
            btnSmallIcons.Size = new Size(104, 58);
            btnSmallIcons.TabIndex = 7;
            btnSmallIcons.Text = "Small Icons";
            btnSmallIcons.UseVisualStyleBackColor = true;
            btnSmallIcons.Click += btnSmallIcons_Click;
            // 
            // btnTable
            // 
            btnTable.Location = new Point(1007, 352);
            btnTable.Name = "btnTable";
            btnTable.Size = new Size(104, 58);
            btnTable.TabIndex = 7;
            btnTable.Text = "Table";
            btnTable.UseVisualStyleBackColor = true;
            btnTable.Click += btnTable_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 577);
            Controls.Add(btnTable);
            Controls.Add(btnSmallIcons);
            Controls.Add(btnLargeIcons);
            Controls.Add(listView1);
            Controls.Add(checkBox1);
            Controls.Add(chkRussia);
            Controls.Add(btnCollapse);
            Controls.Add(btnExpand);
            Controls.Add(treeRegs);
            Controls.Add(treeView1);
            Controls.Add(lblLangs);
            Controls.Add(chkListLangs);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox chkListLangs;
        private Label lblLangs;
        private TreeView treeView1;
        private TreeView treeRegs;
        private Button btnExpand;
        private Button btnCollapse;
        private ImageList imgList;
        private CheckBox chkRussia;
        private CheckBox checkBox1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private Button btnLargeIcons;
        private Button btnSmallIcons;
        private Button btnTable;
    }
}
