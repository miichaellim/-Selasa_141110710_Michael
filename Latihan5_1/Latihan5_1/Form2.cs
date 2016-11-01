using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan5_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            TreeNode ParentNode1;

            ParentNode1 = treeView.Nodes.Add("Color");
            ParentNode1.Nodes.Add("Background Color");
            ParentNode1.Nodes.Add("Font Color");
            ParentNode1.Collapse();
        }

        private void treeView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TreeNode node = treeView.SelectedNode;
            colorDialog1.Color = treeView.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                treeView.BackColor = colorDialog1.Color;
            }
        }
    }
}
