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
            this.dateLab = new Swebui.Controls.Label();
            this.weekLab = new Swebui.Controls.Label();
            this.panel6 = new Swebui.Controls.Panel();
            this.timeLab = new Swebui.Controls.Label();
            this.panel2 = new Swebui.Controls.Panel();
            this.panel7 = new Swebui.Controls.Panel();
            this.panel8 = new Swebui.Controls.Panel();
            this.label1 = new Swebui.Controls.Label();
            this.lblInfo = new Swebui.Controls.Label();
            this.listView1 = new Swebui.Controls.ListView();
            this.timer1 = new Swebui.Controls.Timer();
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
            this.panel5,
            this.panel6});
            this.panel4.Flex = 1;
            this.panel4.Margin = new Swebui.Controls.Margin(10F);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new Swebui.Controls.Padding(20F);
            this.panel4.Size = new System.Drawing.Size(300, 0);
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.dateLab,
            this.weekLab});
            this.panel5.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(0, 13);
            // 
            // dateLab
            // 
            this.dateLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.dateLab.Name = "dateLab";
            this.dateLab.Size = new System.Drawing.Size(0, 0);
            this.dateLab.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // weekLab
            // 
            this.weekLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.weekLab.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.weekLab.Name = "weekLab";
            this.weekLab.Size = new System.Drawing.Size(0, 0);
            this.weekLab.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel6
            // 
            this.panel6.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.timeLab});
            this.panel6.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel6.Margin = new Swebui.Controls.Margin(0F, 20F, 0F, 0F);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(0, 30);
            // 
            // timeLab
            // 
            this.timeLab.Flex = 1;
            this.timeLab.FontSize = 30F;
            this.timeLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.timeLab.Name = "timeLab";
            this.timeLab.Size = new System.Drawing.Size(68, 30);
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
            // timer1
            // 
            this.timer1.Name = "timer1";
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmWork
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Components.AddRange(new Swebui.Controls.SwebComponent[] {
            this.timer1});
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
        private Timer timer1;
        private Panel panel5;
        private Label dateLab;
        private Label weekLab;
        private Panel panel6;
        private Label timeLab;
        private Panel panel7;
        private Panel panel8;
        private Label label1;
        private Label lblInfo;
        private ListView listView1;
    }
}