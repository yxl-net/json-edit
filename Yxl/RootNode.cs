using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yxl
{
    /// <summary>
    /// 根节点
    /// </summary>
    class RootNode:Node
    {
        /// <summary>
        /// Null节点 构造方法
        /// </summary>
        /// <param name="text">文本</param>
        internal RootNode()
        {
            Text = "JSON";
            ImageIndex = 0;
        }

        /// <summary>
        /// 设置按钮可用性 覆盖方法
        /// </summary>
        /// <param name="tsdAdd">增加菜单</param>
        /// <param name="tsbModify">修改按钮</param>
        /// <param name="tsbRemove">移除按钮</param>
        internal override void Enable(ToolStripDropDownButton tsdAdd, ToolStripButton tsbModify, ToolStripButton tsbRemove)
        {
            tsdAdd.Enabled = true;
            tsbModify.Enabled = false;
            tsbRemove.Enabled = false;
        }

        /// <summary>
        /// 生成JSON 覆盖方法
        /// </summary>
        /// <param name="sb">可变文本</param>
        internal override void Json(StringBuilder sb)
        {
            foreach (Node tn in Nodes)
            {
                tn.Json(sb);
            }
        }
    }
}
