namespace WinFormsListControlsAdvansedApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            chkListLangs.Items.AddRange(new object[]
            {
                "C++", "C#", "Java", "Python", "JavaScript", "Php", "Kotlin"
            });
            chkListLangs.CheckOnClick = true;
            chkListLangs.MultiColumn = false;

            lblLangs.Text = "";

            TreeNode root = new("Россия");
            treeRegs.Nodes.Add(root);

            TreeNode moscow = new("Москва");
            TreeNode tula = new("Тула");
            TreeNode irkutsk = new("Иркутск");

            root.Nodes.AddRange(new[] { moscow, tula, irkutsk });

            TreeNode aleksin = new("Алексин");
            TreeNode belev = new("Белев");

            tula.Nodes.AddRange(new[] { aleksin, belev });


            CheckBox chkBrasil = new CheckBox();
            chkBrasil.Text = "";
            chkBrasil.ImageList = imgList;
            chkBrasil.ImageIndex = 2;

            chkBrasil.Location = new Point(142, 492);
            chkBrasil.Size = new Size(79, 64);

            this.Controls.Add(chkBrasil);


        }

        private void chkListLangs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //chkListLangs.SetItemCheckState(
            //    chkListLangs.SelectedIndex,
            //    CheckState.Indeterminate
            //    );

            string str = "";
            foreach (var item in chkListLangs.CheckedItems)
            {
                str += item.ToString() + " ";
            }
            lblLangs.Text = str;
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            var selectNode = treeRegs.SelectedNode;
            if (selectNode.IsExpanded)
                selectNode.Collapse();
            else
                selectNode.Expand();
        }

        private void btnLargeIcons_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void btnSmallIcons_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }
    }
}
