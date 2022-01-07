using Swebui.Controls;
using System;

namespace SwebONE.CostCenter
{
    partial class FrmCCAnalyseDetail : Swebui.Controls.SwebUserControl
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
            this.label1 = new Swebui.Controls.Label();
            this.panel2 = new Swebui.Controls.Panel();
            this.panel3 = new Swebui.Controls.Panel();
            this.label2 = new Swebui.Controls.Label();
            this.idLab = new Swebui.Controls.Label();
            this.label4 = new Swebui.Controls.Label();
            this.nameLab = new Swebui.Controls.Label();
            this.label6 = new Swebui.Controls.Label();
            this.manLab = new Swebui.Controls.Label();
            this.eCharts1 = new Swebui.Controls.ECharts();
            this.panel5 = new Swebui.Controls.Panel();
            this.panel6 = new Swebui.Controls.Panel();
            this.label3 = new Swebui.Controls.Label();
            this.label5 = new Swebui.Controls.Label();
            this.label7 = new Swebui.Controls.Label();
            this.label8 = new Swebui.Controls.Label();
            this.label9 = new Swebui.Controls.Label();
            this.itemPanel = new Swebui.Controls.Panel();
            this.panel4 = new Swebui.Controls.Panel();
            this.BackBtn = new Swebui.Controls.Button();
            this.itemTitle = new Swebui.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1});
            this.panel1.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel1.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel1.Name = "panel1";
            this.panel1.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel1.Size = new System.Drawing.Size(0, 46);
            // 
            // label1
            // 
            this.label1.Flex = 1;
            this.label1.FontSize = 24F;
            this.label1.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 26);
            this.label1.Text = "成本分析";
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel3,
            this.panel5});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.Flex = 1;
            this.panel2.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 10F);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 216);
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label2,
            this.idLab,
            this.label4,
            this.nameLab,
            this.label6,
            this.manLab,
            this.eCharts1});
            this.panel3.Flex = 1;
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 0);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 35);
            this.label2.Text = "成本中心编号";
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // idLab
            // 
            this.idLab.Name = "idLab";
            this.idLab.Size = new System.Drawing.Size(0, 35);
            this.idLab.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 35);
            this.label4.Text = "成本中心名称";
            this.label4.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // nameLab
            // 
            this.nameLab.Name = "nameLab";
            this.nameLab.Size = new System.Drawing.Size(0, 35);
            this.nameLab.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 35);
            this.label6.Text = "责任人";
            this.label6.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // manLab
            // 
            this.manLab.Name = "manLab";
            this.manLab.Size = new System.Drawing.Size(0, 35);
            this.manLab.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // eCharts1
            // 
            this.eCharts1.Flex = 1;
            this.eCharts1.Margin = new Swebui.Controls.Margin(0F, 10F, 0F, 0F);
            this.eCharts1.Name = "eCharts1";
            this.eCharts1.Size = new System.Drawing.Size(0, 30);
            this.eCharts1.EChartsPress += new Swebui.Controls.EChartsPressEventHandler(this.eCharts1_EChartsPress);
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.itemTitle,
            this.panel6,
            this.itemPanel
           });
            this.panel5.Flex = 3;
            this.panel5.Name = "panel5";
            this.panel5.Padding = new Swebui.Controls.Padding(10F);
            this.panel5.Size = new System.Drawing.Size(300, 0);
            // 
            // panel6
            // 
            this.panel6.Border = new Swebui.Controls.Border(1F);
            this.panel6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel6.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label3,
            this.label5,
            this.label7,
            this.label8,
            this.label9});
            this.panel6.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(0, 35);
            // 
            // label3
            // 
            this.label3.Border = new Swebui.Controls.Border(0F, 0F, 1F, 0F);
            this.label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label3.Flex = 1;
            this.label3.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 35);
            this.label3.Text = "报销编号";
            this.label3.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Border = new Swebui.Controls.Border(0F, 0F, 1F, 0F);
            this.label5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label5.Flex = 1;
            this.label5.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 35);
            this.label5.Text = "报销日期";
            this.label5.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Border = new Swebui.Controls.Border(0F, 0F, 1F, 0F);
            this.label7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label7.Flex = 1;
            this.label7.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 35);
            this.label7.Text = "报销类型";
            this.label7.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Border = new Swebui.Controls.Border(0F, 0F, 1F, 0F);
            this.label8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label8.Flex = 1;
            this.label8.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 35);
            this.label8.Text = "金额";
            this.label8.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label9
            // 
            this.label9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label9.Flex = 1;
            this.label9.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 35);
            this.label9.Text = "用户";
            this.label9.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // itemPanel
            // 
            this.itemPanel.Border = new Swebui.Controls.Border(1F, 0F, 1F, 1F);
            this.itemPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.itemPanel.Flex = 1;
            this.itemPanel.Name = "itemPanel";
            this.itemPanel.Size = new System.Drawing.Size(0, 100);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.panel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.BackBtn});
            this.panel4.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel4.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel4.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 15F);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.panel4.Size = new System.Drawing.Size(0, 46);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.White;
            this.BackBtn.Border = new Swebui.Controls.Border(1F);
            this.BackBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.BackBtn.ForeColor = System.Drawing.Color.DimGray;
            this.BackBtn.IconName = "fa fa-angle-left";
            this.BackBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.NumberOfLines = 0;
            this.BackBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.BackBtn.Size = new System.Drawing.Size(0, 26);
            this.BackBtn.Text = "返回";
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // itemTitle
            // 
            this.itemTitle.ForeColor = System.Drawing.Color.Silver;
            this.itemTitle.Name = "itemTitle";
            this.itemTitle.Size = new System.Drawing.Size(0, 35);
            this.itemTitle.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // FrmCCAnalyseDetail
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel4,
            this.panel2});
            this.Load += new System.EventHandler(this.FrmCCAnalyseDetail_Load);

        }
        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel4;
        private Button BackBtn;
        private Panel panel3;
        private Label label2;
        private Label idLab;
        private Label label4;
        private Label nameLab;
        private Label label6;
        private Label manLab;
        private Panel panel5;
        private ECharts eCharts1;
        private Panel panel6;
        private Label label3;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private Panel itemPanel;
        private Label itemTitle;
    }
}