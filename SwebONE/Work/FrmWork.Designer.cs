using Swebui.Controls;
using System;

namespace SwebONE.Work
{
    partial class FrmWork : Swebui.Controls.SwebUserControl
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
            this.panel3 = new Swebui.Controls.Panel();
            this.button1 = new Swebui.Controls.Button();
            this.button3 = new Swebui.Controls.Button();
            this.panel4 = new Swebui.Controls.Panel();
            this.panel5 = new Swebui.Controls.Panel();
            this.weekLab = new Swebui.Controls.Label();
            this.dateLab = new Swebui.Controls.Label();
            this.panel2 = new Swebui.Controls.Panel();
            this.panel7 = new Swebui.Controls.Panel();
            this.panel8 = new Swebui.Controls.Panel();
            this.label1 = new Swebui.Controls.Label();
            this.lblInfo = new Swebui.Controls.Label();
            this.listView1 = new Swebui.Controls.ListView();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel3,
            this.panel4});
            this.panel1.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 125);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Border = new Swebui.Controls.Border(1F);
            this.panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(1)))));
            this.panel3.BorderRadius = 8;
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.button1,
            this.button3});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.Flex = 1;
            this.panel3.Margin = new Swebui.Controls.Margin(10F);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 0);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Flex = 1;
            this.button1.FontSize = 16F;
            this.button1.Margin = new Swebui.Controls.Margin(30F);
            this.button1.Name = "button1";
            this.button1.NumberOfLines = 0;
            this.button1.Size = new System.Drawing.Size(100, 0);
            this.button1.Text = "待我审批";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button3.Flex = 1;
            this.button3.FontSize = 16F;
            this.button3.Margin = new Swebui.Controls.Margin(0F, 30F, 30F, 30F);
            this.button3.Name = "button3";
            this.button3.NumberOfLines = 0;
            this.button3.Size = new System.Drawing.Size(100, 0);
            this.button3.Text = "抄送我的";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Border = new Swebui.Controls.Border(1F);
            this.panel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(1)))));
            this.panel4.BorderRadius = 8;
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel5});
            this.panel4.Flex = 1;
            this.panel4.ItemAlign = Swebui.Controls.LayoutItemAlign.FlexStart;
            this.panel4.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.Center;
            this.panel4.Margin = new Swebui.Controls.Margin(10F);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new Swebui.Controls.Padding(20F);
            this.panel4.Size = new System.Drawing.Size(300, 0);
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.weekLab,
            this.dateLab});
            this.panel5.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel5.Flex = 1;
            this.panel5.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(337, 20);
            // 
            // weekLab
            // 
            this.weekLab.FontSize = 24F;
            this.weekLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.weekLab.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.weekLab.Name = "weekLab";
            this.weekLab.Size = new System.Drawing.Size(0, 30);
            this.weekLab.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
            // 
            // dateLab
            // 
            this.dateLab.FontSize = 20F;
            this.dateLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.dateLab.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.dateLab.Name = "dateLab";
            this.dateLab.Size = new System.Drawing.Size(0, 30);
            this.dateLab.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Border = new Swebui.Controls.Border(1F);
            this.panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(1)))));
            this.panel2.BorderRadius = 8;
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel7,
            this.panel8});
            this.panel2.Flex = 1;
            this.panel2.Margin = new Swebui.Controls.Margin(10F);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 285);
            // 
            // panel7
            // 
            this.panel7.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(0, 120);
            // 
            // panel8
            // 
            this.panel8.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.lblInfo,
            this.listView1});
            this.panel8.Flex = 2;
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(0, 200);
            // 
            // label1
            // 
            this.label1.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.label1.FontSize = 20F;
            this.label1.Name = "label1";
            this.label1.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(0, 35);
            this.label1.Text = "签到打卡";
            // 
            // lblInfo
            // 
            this.lblInfo.ForeColor = System.Drawing.Color.Silver;
            this.lblInfo.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.lblInfo.Margin = new Swebui.Controls.Margin(0F, 10F, 0F, 0F);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Padding = new Swebui.Controls.Padding(20F, 0F, 0F, 0F);
            this.lblInfo.Size = new System.Drawing.Size(0, 35);
            this.lblInfo.Text = "今日无排版";
            this.lblInfo.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // listView1
            // 
            this.listView1.Flex = 1;
            this.listView1.Margin = new Swebui.Controls.Margin(20F, 10F, 20F, 10F);
            this.listView1.Name = "listView1";
            this.listView1.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listView1.Size = new System.Drawing.Size(0, 300);
            this.listView1.TemplateControlName = "ATMainLayout";
            // 
            // FrmWork
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel2});
            this.Load += new System.EventHandler(this.FrmWork_Load);

        }
        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button button1;
        private Button button3;
        private Panel panel4;
        private Panel panel5;
        private Label weekLab;
        private Panel panel7;
        private Panel panel8;
        private Label label1;
        private Label lblInfo;
        private ListView listView1;
        private Label dateLab;
    }
}