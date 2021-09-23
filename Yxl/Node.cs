using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yxl
{
    /// <summary>
    /// 节点基类
    /// </summary>
    class Node:TreeNode
    {
        /// <summary>
        /// 设置按钮可用性 虚方法
        /// </summary>
        /// <param name="tsdAdd">增加菜单</param>
        /// <param name="tsbModify">修改按钮</param>
        /// <param name="tsbRemove">移除按钮</param>
        internal virtual void Enable(ToolStripDropDownButton tsdAdd,ToolStripButton tsbModify,ToolStripButton tsbRemove)
        {

        }

        /// <summary>
        /// 生成JSON 虚方法
        /// </summary>
        /// <param name="sb">可变文本</param>
        internal virtual void Json(StringBuilder sb)
        {
            
        }

        /// <summary>
        /// 开始修改 虚方法 什么也不做
        /// </summary>
        internal virtual void Mofify()
        {

        }
    }
}
