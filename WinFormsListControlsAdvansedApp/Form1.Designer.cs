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
            TreeNode treeNode1 = new TreeNode("Холодильники");
            TreeNode treeNode2 = new TreeNode("Бытовая техника", new TreeNode[] { treeNode1 });
            TreeNode treeNode3 = new TreeNode("Ноутбуки");
            TreeNode treeNode4 = new TreeNode("Компьтерная техника", new TreeNode[] { treeNode3 });
            TreeNode treeNode5 = new TreeNode("Гаджеты");
            TreeNode treeNode6 = new TreeNode("Товары", new TreeNode[] { treeNode2, treeNode4, treeNode5 });
            chkListLangs = new CheckedListBox();
            lblLangs = new Label();
            treeView1 = new TreeView();
            treeRegs = new TreeView();
            btnExpand = new Button();
            btnCollapse = new Button();
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
            treeView1.Location = new Point(406, 12);
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
            treeRegs.Location = new Point(406, 175);
            treeRegs.Name = "treeRegs";
            treeRegs.Size = new Size(356, 183);
            treeRegs.TabIndex = 3;
            // 
            // btnExpand
            // 
            btnExpand.Font = new Font("Segoe UI", 20F);
            btnExpand.Location = new Point(406, 389);
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
            btnCollapse.Location = new Point(609, 389);
            btnCollapse.Name = "btnCollapse";
            btnCollapse.Size = new Size(153, 58);
            btnCollapse.TabIndex = 4;
            btnCollapse.Text = "Collapse";
            btnCollapse.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 577);
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
    }
}
