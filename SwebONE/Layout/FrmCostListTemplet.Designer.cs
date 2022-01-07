using Swebui.Controls;
using System;

namespace SwebONE.Layout
{
    partial class FrmCostListTemplet : Swebui.Controls.SwebUserControl
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
            this.panel1 = new Swebui.Controls.Panel();
            this.panel2 = new Swebui.Controls.Panel();
            this.label1 = new Swebui.Controls.Label();
            this.label2 = new Swebui.Controls.Label();
            this.label3 = new Swebui.Controls.Label();
            this.panel3 = new Swebui.Controls.Panel();
            this.panel4 = new Swebui.Controls.Panel();
            this.label4 = new Swebui.Controls.Label();
            this.label5 = new Swebui.Controls.Label();
            this.fontIcon1 = new Swebui.Controls.FontIcon();
            this.panel5 = new Swebui.Controls.Panel();
            this.label6 = new Swebui.Controls.Label();
            this.label7 = new Swebui.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel2,
            this.label3,
            this.panel3});
            this.panel1.Name = "panel1";
            this.panel1.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel1.Size = new System.Drawing.Size(0, 82);
            this.panel1.Touchable = true;
            this.panel1.Press += new System.EventHandler(this.panel1_Press);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.label2});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 20);
            // 
            // label1
            // 
            this.label1.DataMember = "CC_TT_TemplateID";
            this.label1.DisplayMember = "CC_TT_TemplateID";
            this.label1.Flex = 1;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 0);
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label2
            // 
            this.label2.DataMember = "CC_TT_TypeName";
            this.label2.DisplayMember = "CC_TT_TypeName";
            this.label2.Flex = 1;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 0);
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 20);
            this.label3.Text = "审批流程：";
            this.label3.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel4,
            this.fontIcon1,
            this.panel5});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 40);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.panel4.BorderRadius = 2;
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label4,
            this.label5});
            this.panel4.Flex = 1;
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(219, 40);
            // 
            // label4
            // 
            this.label4.Flex = 1;
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 35);
            this.label4.Text = "行政审批人";
            this.label4.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label5
            // 
            this.label5.DataMember = "CC_TT_AEACheckers";
            this.label5.DisplayMember = "CC_TT_AEACheckers";
            this.label5.Flex = 1;
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 35);
            this.label5.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // fontIcon1
            // 
            this.fontIcon1.Name = "fontIcon1";
            this.fontIcon1.ResourceID = "angle-double-right";
            this.fontIcon1.Size = new System.Drawing.Size(35, 35);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.panel5.BorderRadius = 2;
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label6,
            this.label7});
            this.panel5.Flex = 1;
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(219, 40);
            // 
            // label6
            // 
            this.label6.Flex = 1;
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 35);
            this.label6.Text = "财务审批人";
            this.label6.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label7
            // 
            this.label7.DataMember = "CC_TT_FinancialCheckers";
            this.label7.DisplayMember = "CC_TT_FinancialCheckers";
            this.label7.Flex = 1;
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 35);
            this.label7.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // FrmCostListTemplet
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1});
            this.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.Padding = new Swebui.Controls.Padding(0F, 5F, 0F, 0F);
            this.Size = new System.Drawing.Size(580, 90);

        }
        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel3;
        private Panel panel4;
        private Label label4;
        private Label label5;
        private FontIcon fontIcon1;
        private Panel panel5;
        private Label label6;
        private Label label7;
    }
}