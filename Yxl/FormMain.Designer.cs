
namespace Yxl
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ts = new System.Windows.Forms.ToolStrip();
            this.tv = new System.Windows.Forms.TreeView();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbSaveAs = new System.Windows.Forms.ToolStripButton();
            this.tsbCopy = new System.Windows.Forms.ToolStripButton();
            this.tsbPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsdAdd = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsbModify = new System.Windows.Forms.ToolStripButton();
            this.tsbRemove = new System.Windows.Forms.ToolStripButton();
            this.tsiAddNull = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiAddNumber = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiAddString = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiAddBoolean = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiAddArray = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiAddObject = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiAddProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.ts.SuspendLayout();
            this.SuspendLayout();
            // 
            // ts
            // 
            this.ts.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen,
            this.tsbSave,
            this.tsbSaveAs,
            this.toolStripSeparator1,
            this.tsbPaste,
            this.tsbCopy,
            this.toolStripSeparator2,
            this.tsdAdd,
            this.tsbModify,
            this.tsbRemove});
            this.ts.Location = new System.Drawing.Point(0, 0);
            this.ts.Name = "ts";
            this.ts.Size = new System.Drawing.Size(800, 27);
            this.ts.TabIndex = 0;
            this.ts.Text = "toolStrip1";
            // 
            // tv
            // 
            this.tv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv.HideSelection = false;
            this.tv.Location = new System.Drawing.Point(0, 27);
            this.tv.Name = "tv";
            this.tv.ShowNodeToolTips = true;
            this.tv.Size = new System.Drawing.Size(800, 423);
            this.tv.TabIndex = 1;
            this.tv.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.tv_AfterLabelEdit);
            this.tv.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_AfterSelect);
            this.tv.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_NodeMouseDoubleClick);
            // 
            // tsbOpen
            // 
            this.tsbOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpen.Image")));
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(63, 24);
            this.tsbOpen.Text = "打开";
            this.tsbOpen.ToolTipText = "打开...";
            // 
            // tsbSave
            // 
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(63, 24);
            this.tsbSave.Text = "保存";
            // 
            // tsbSaveAs
            // 
            this.tsbSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("tsbSaveAs.Image")));
            this.tsbSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveAs.Name = "tsbSaveAs";
            this.tsbSaveAs.Size = new System.Drawing.Size(78, 24);
            this.tsbSaveAs.Text = "另存为";
            this.tsbSaveAs.ToolTipText = "另存为...";
            // 
            // tsbCopy
            // 
            this.tsbCopy.Image = ((System.Drawing.Image)(resources.GetObject("tsbCopy.Image")));
            this.tsbCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCopy.Name = "tsbCopy";
            this.tsbCopy.Size = new System.Drawing.Size(63, 24);
            this.tsbCopy.Text = "复制";
            // 
            // tsbPaste
            // 
            this.tsbPaste.Image = ((System.Drawing.Image)(resources.GetObject("tsbPaste.Image")));
            this.tsbPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPaste.Name = "tsbPaste";
            this.tsbPaste.Size = new System.Drawing.Size(63, 24);
            this.tsbPaste.Text = "粘贴";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tsdAdd
            // 
            this.tsdAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiAddNull,
            this.tsiAddNumber,
            this.tsiAddString,
            this.tsiAddBoolean,
            this.tsiAddArray,
            this.tsiAddObject,
            this.tsiAddProperty});
            this.tsdAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsdAdd.Image")));
            this.tsdAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdAdd.Name = "tsdAdd";
            this.tsdAdd.Size = new System.Drawing.Size(73, 24);
            this.tsdAdd.Text = "增加";
            // 
            // tsbModify
            // 
            this.tsbModify.Image = ((System.Drawing.Image)(resources.GetObject("tsbModify.Image")));
            this.tsbModify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModify.Name = "tsbModify";
            this.tsbModify.Size = new System.Drawing.Size(63, 24);
            this.tsbModify.Text = "修改";
            this.tsbModify.Click += new System.EventHandler(this.tsbModify_Click);
            // 
            // tsbRemove
            // 
            this.tsbRemove.Image = ((System.Drawing.Image)(resources.GetObject("tsbRemove.Image")));
            this.tsbRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemove.Name = "tsbRemove";
            this.tsbRemove.Size = new System.Drawing.Size(63, 24);
            this.tsbRemove.Text = "移除";
            // 
            // tsiAddNull
            // 
            this.tsiAddNull.Name = "tsiAddNull";
            this.tsiAddNull.Size = new System.Drawing.Size(224, 26);
            this.tsiAddNull.Text = "NULL";
            // 
            // tsiAddNumber
            // 
            this.tsiAddNumber.Name = "tsiAddNumber";
            this.tsiAddNumber.Size = new System.Drawing.Size(224, 26);
            this.tsiAddNumber.Text = "数值";
            // 
            // tsiAddString
            // 
            this.tsiAddString.Name = "tsiAddString";
            this.tsiAddString.Size = new System.Drawing.Size(224, 26);
            this.tsiAddString.Text = "字符串";
            this.tsiAddString.Click += new System.EventHandler(this.tsiAddString_Click);
            // 
            // tsiAddBoolean
            // 
            this.tsiAddBoolean.Name = "tsiAddBoolean";
            this.tsiAddBoolean.Size = new System.Drawing.Size(224, 26);
            this.tsiAddBoolean.Text = "布尔值";
            // 
            // tsiAddArray
            // 
            this.tsiAddArray.Name = "tsiAddArray";
            this.tsiAddArray.Size = new System.Drawing.Size(224, 26);
            this.tsiAddArray.Text = "数组";
            // 
            // tsiAddObject
            // 
            this.tsiAddObject.Name = "tsiAddObject";
            this.tsiAddObject.Size = new System.Drawing.Size(224, 26);
            this.tsiAddObject.Text = "对象";
            // 
            // tsiAddProperty
            // 
            this.tsiAddProperty.Name = "tsiAddProperty";
            this.tsiAddProperty.Size = new System.Drawing.Size(224, 26);
            this.tsiAddProperty.Text = "属性";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tv);
            this.Controls.Add(this.ts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ts.ResumeLayout(false);
            this.ts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ts;
        private System.Windows.Forms.TreeView tv;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbPaste;
        private System.Windows.Forms.ToolStripButton tsbCopy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton tsdAdd;
        private System.Windows.Forms.ToolStripMenuItem tsiAddNull;
        private System.Windows.Forms.ToolStripMenuItem tsiAddNumber;
        private System.Windows.Forms.ToolStripMenuItem tsiAddString;
        private System.Windows.Forms.ToolStripMenuItem tsiAddBoolean;
        private System.Windows.Forms.ToolStripMenuItem tsiAddArray;
        private System.Windows.Forms.ToolStripMenuItem tsiAddObject;
        private System.Windows.Forms.ToolStripMenuItem tsiAddProperty;
        private System.Windows.Forms.ToolStripButton tsbModify;
        private System.Windows.Forms.ToolStripButton tsbRemove;
    }
}

