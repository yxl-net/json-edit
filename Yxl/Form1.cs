using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yxl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tv.Nodes.Add(new RootNode());
        }

        private void tv_AfterSelect(object sender, TreeViewEventArgs e)
        {
            (e.Node as Node).Enable(tsdAdd,tsbModify,tsbRemove);
        }

        private void tsiAddString_Click(object sender, EventArgs e)
        {
            TreeNode tn = new StringNode("字符串");
            tv.SelectedNode.Nodes.Add(tn);
            tv.SelectedNode=tn;
        }

        private void tsbModify_Click(object sender, EventArgs e)
        {
            (tv.SelectedNode as Node).Mofify();
        }

        private void tv_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            (e.Node as Node).Mofify();
        }

        private void tv_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            tv.LabelEdit = false;
        }
    }
}
