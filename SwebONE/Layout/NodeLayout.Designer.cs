using Swebui.Controls;
using System;

namespace SwebONE.Layout
{
    partial class NodeLayout : Swebui.Controls.SwebUserControl
    {
        #region "SwebUserControl generated code "

        //SwebUserControl overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        //NOTE: The following procedure is required by the SwebUserControl
        //It can be modified using the SwebUserControl.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.label1 = new Swebui.Controls.Label();
            this.panel1 = new Swebui.Controls.Panel();
            this.leftLine = new Swebui.Controls.Label();
            this.label4 = new Swebui.Controls.Label();
            this.rightLine = new Swebui.Controls.Label();
            this.label2 = new Swebui.Controls.Label();

            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 30);
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.leftLine,
            this.label4,
            this.rightLine});
            this.panel1.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel1.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 30);
            // 
            // leftLine
            // 
            this.leftLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(137)))), ((int)(((byte)(248)))));
            this.leftLine.Flex = 1;
            this.leftLine.Name = "leftLine";
            this.leftLine.Size = new System.Drawing.Size(100, 8);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(137)))), ((int)(((byte)(248)))));
            this.label4.BorderRadius = 26;
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 26);
            // 
            // rightLine
            // 
            this.rightLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(137)))), ((int)(((byte)(248)))));
            this.rightLine.Flex = 1;
            this.rightLine.Name = "rightLine";
            this.rightLine.Size = new System.Drawing.Size(100, 8);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 30);
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // NodeLayout
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.panel1,
            this.label2});
            this.Size = new System.Drawing.Size(0, 90);

        }
        #endregion

       
        private Label label1;
        private Panel panel1;
        private Label leftLine;
        private Label label4;
        private Label rightLine;
        private Label label2;
    }
}