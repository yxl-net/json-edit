using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yxl
{
    /// <summary>
    /// Null节点
    /// </summary>
    class NullNode:Node
    {
        /// <summary>
        /// Null节点 构造方法
        /// </summary>
        internal NullNode()
        {
            Text = "null";
            ImageIndex = 1;
        }

        /// <summary>
        /// 设置按钮可用性 覆盖方法
        /// </summary>
        /// <param name="tsdAdd">增加菜单</param>
        /// <param name="tsbModify">修改按钮</param>
        /// <param name="tsbRemove">移除按钮</param>
        internal override void Enable(ToolStripDropDownButton tsdAdd, ToolStripButton tsbModify, ToolStripButton tsbRemove)
        {
            tsdAdd.Enabled = false;
            tsbModify.Enabled = false;
            tsbRemove.Enabled = true;
        }

        /// <summary>
        /// 生成JSON 覆盖方法
        /// </summary>
        /// <param name="sb">可变文本</param>
        internal override void Json(StringBuilder sb)
        {
            sb.Append("null");
        }
    }
}
