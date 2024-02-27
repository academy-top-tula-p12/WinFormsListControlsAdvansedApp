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

            TreeNode root = new("������");
            treeRegs.Nodes.Add(root);

            TreeNode moscow = new("������");
            TreeNode tula = new("����");
            TreeNode irkutsk = new("�������");

            root.Nodes.AddRange(new[] { moscow, tula, irkutsk });

            TreeNode aleksin = new("�������");
            TreeNode belev = new("�����");

            tula.Nodes.AddRange(new[] { aleksin, belev });


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
    }
}
