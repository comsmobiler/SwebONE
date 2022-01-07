using Swebui.Controls;
using System;

namespace SwebONE.Attendance
{
    partial class FrmAttendanceView : Swebui.Controls.SwebUserControl
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
            this.BackBtn = new Swebui.Controls.Button();
            this.panel3 = new Swebui.Controls.Panel();
            this.label2 = new Swebui.Controls.Label();
            this.label3 = new Swebui.Controls.Label();
            this.label4 = new Swebui.Controls.Label();
            this.panel4 = new Swebui.Controls.Panel();
            this.txtName = new Swebui.Controls.Label();
            this.panel13 = new Swebui.Controls.Panel();
            this.btnDate = new Swebui.Controls.Label();
            this.button1 = new Swebui.Controls.Button();
            this.btnATMode = new Swebui.Controls.Label();
            this.panel5 = new Swebui.Controls.Panel();
            this.label5 = new Swebui.Controls.Label();
            this.label6 = new Swebui.Controls.Label();
            this.label29 = new Swebui.Controls.Label();
            this.panel6 = new Swebui.Controls.Panel();
            this.dpStartWork = new Swebui.Controls.Label();
            this.dpEndWork = new Swebui.Controls.Label();
            this.label7 = new Swebui.Controls.Label();
            this.timePanel = new Swebui.Controls.Panel();
            this.panel7 = new Swebui.Controls.Panel();
            this.label8 = new Swebui.Controls.Label();
            this.label9 = new Swebui.Controls.Label();
            this.label27 = new Swebui.Controls.Label();
            this.panel8 = new Swebui.Controls.Panel();
            this.dpAMStartWork = new Swebui.Controls.Label();
            this.dpAMEndWork = new Swebui.Controls.Label();
            this.label10 = new Swebui.Controls.Label();
            this.panel9 = new Swebui.Controls.Panel();
            this.label11 = new Swebui.Controls.Label();
            this.label12 = new Swebui.Controls.Label();
            this.label30 = new Swebui.Controls.Label();
            this.panel10 = new Swebui.Controls.Panel();
            this.dpPMStartWork = new Swebui.Controls.Label();
            this.dpPMEndWork = new Swebui.Controls.Label();
            this.label14 = new Swebui.Controls.Label();
            this.panel15 = new Swebui.Controls.Panel();
            this.label21 = new Swebui.Controls.Label();
            this.label22 = new Swebui.Controls.Label();
            this.label24 = new Swebui.Controls.Label();
            this.panel16 = new Swebui.Controls.Panel();
            this.btnUser = new Swebui.Controls.Label();
            this.txtADeviation = new Swebui.Controls.Label();
            this.label16 = new Swebui.Controls.Label();
            this.panel11 = new Swebui.Controls.Panel();
            this.label15 = new Swebui.Controls.Label();
            this.panel12 = new Swebui.Controls.Panel();
            this.lblAddress = new Swebui.Controls.Label();
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
            this.label1.Text = "考勤查看";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.BackBtn});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel2.Margin = new Swebui.Controls.Margin(0F, 10F, 0F, 15F);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.panel2.Size = new System.Drawing.Size(0, 46);
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
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label2,
            this.label3,
            this.label4});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel3.Name = "panel3";
            this.panel3.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel3.Size = new System.Drawing.Size(0, 30);
            // 
            // label2
            // 
            this.label2.Flex = 1;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 0);
            this.label2.Text = "名称";
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Flex = 1;
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 0);
            this.label3.Text = "日期";
            this.label3.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Flex = 1;
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 0);
            this.label4.Text = "考勤模式";
            this.label4.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtName,
            this.panel13,
            this.btnATMode});
            this.panel4.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel4.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel4.Name = "panel4";
            this.panel4.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel4.Size = new System.Drawing.Size(0, 35);
            // 
            // txtName
            // 
            this.txtName.Flex = 1;
            this.txtName.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 0);
            this.txtName.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel13
            // 
            this.panel13.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.btnDate,
            this.button1});
            this.panel13.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel13.Flex = 1;
            this.panel13.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel13.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(300, 0);
            // 
            // btnDate
            // 
            this.btnDate.BackColor = System.Drawing.Color.White;
            this.btnDate.Flex = 1;
            this.btnDate.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(0, 35);
            this.btnDate.Text = "点击选择";
            this.btnDate.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Border = new Swebui.Controls.Border(1F);
            this.button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button1.Name = "button1";
            this.button1.NumberOfLines = 0;
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.Text = "查看自定义日期";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnATMode
            // 
            this.btnATMode.Flex = 1;
            this.btnATMode.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.btnATMode.Name = "btnATMode";
            this.btnATMode.Size = new System.Drawing.Size(100, 0);
            this.btnATMode.Text = "一天一次上下班";
            this.btnATMode.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label5,
            this.label6,
            this.label29});
            this.panel5.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel5.Margin = new Swebui.Controls.Margin(10F, 10F, 10F, 0F);
            this.panel5.Name = "panel5";
            this.panel5.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel5.Size = new System.Drawing.Size(0, 30);
            // 
            // label5
            // 
            this.label5.Flex = 1;
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 0);
            this.label5.Text = "上班时间";
            this.label5.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Flex = 1;
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 0);
            this.label6.Text = "下班时间";
            this.label6.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label29
            // 
            this.label29.Flex = 1;
            this.label29.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(100, 0);
            this.label29.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel6
            // 
            this.panel6.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.dpStartWork,
            this.dpEndWork,
            this.label7});
            this.panel6.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel6.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel6.Name = "panel6";
            this.panel6.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel6.Size = new System.Drawing.Size(0, 35);
            // 
            // dpStartWork
            // 
            this.dpStartWork.Flex = 1;
            this.dpStartWork.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.dpStartWork.Name = "dpStartWork";
            this.dpStartWork.Size = new System.Drawing.Size(100, 0);
            this.dpStartWork.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // dpEndWork
            // 
            this.dpEndWork.Flex = 1;
            this.dpEndWork.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.dpEndWork.Name = "dpEndWork";
            this.dpEndWork.Size = new System.Drawing.Size(100, 0);
            this.dpEndWork.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Flex = 1;
            this.label7.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 0);
            this.label7.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // timePanel
            // 
            this.timePanel.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel7,
            this.panel8,
            this.panel9,
            this.panel10});
            this.timePanel.Name = "timePanel";
            this.timePanel.Size = new System.Drawing.Size(0, 150);
            this.timePanel.Visible = false;
            // 
            // panel7
            // 
            this.panel7.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label8,
            this.label9,
            this.label27});
            this.panel7.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel7.Margin = new Swebui.Controls.Margin(10F, 10F, 10F, 0F);
            this.panel7.Name = "panel7";
            this.panel7.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel7.Size = new System.Drawing.Size(0, 30);
            // 
            // label8
            // 
            this.label8.Flex = 1;
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 0);
            this.label8.Text = "上午上班时间";
            this.label8.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Flex = 1;
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 0);
            this.label9.Text = "上午下班时间";
            this.label9.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label27
            // 
            this.label27.Flex = 1;
            this.label27.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(100, 0);
            this.label27.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel8
            // 
            this.panel8.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.dpAMStartWork,
            this.dpAMEndWork,
            this.label10});
            this.panel8.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel8.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel8.Name = "panel8";
            this.panel8.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel8.Size = new System.Drawing.Size(0, 35);
            // 
            // dpAMStartWork
            // 
            this.dpAMStartWork.Flex = 1;
            this.dpAMStartWork.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.dpAMStartWork.Name = "dpAMStartWork";
            this.dpAMStartWork.Size = new System.Drawing.Size(100, 0);
            this.dpAMStartWork.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // dpAMEndWork
            // 
            this.dpAMEndWork.Flex = 1;
            this.dpAMEndWork.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.dpAMEndWork.Name = "dpAMEndWork";
            this.dpAMEndWork.Size = new System.Drawing.Size(100, 0);
            this.dpAMEndWork.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Flex = 1;
            this.label10.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 0);
            this.label10.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel9
            // 
            this.panel9.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label11,
            this.label12,
            this.label30});
            this.panel9.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel9.Margin = new Swebui.Controls.Margin(10F, 10F, 10F, 0F);
            this.panel9.Name = "panel9";
            this.panel9.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel9.Size = new System.Drawing.Size(0, 30);
            // 
            // label11
            // 
            this.label11.Flex = 1;
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 0);
            this.label11.Text = "下午上班时间";
            this.label11.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label12
            // 
            this.label12.Flex = 1;
            this.label12.ForeColor = System.Drawing.Color.Silver;
            this.label12.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 0);
            this.label12.Text = "下午下班时间";
            this.label12.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label30
            // 
            this.label30.Flex = 1;
            this.label30.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(100, 0);
            this.label30.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel10
            // 
            this.panel10.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.dpPMStartWork,
            this.dpPMEndWork,
            this.label14});
            this.panel10.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel10.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel10.Name = "panel10";
            this.panel10.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel10.Size = new System.Drawing.Size(0, 35);
            // 
            // dpPMStartWork
            // 
            this.dpPMStartWork.Flex = 1;
            this.dpPMStartWork.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.dpPMStartWork.Name = "dpPMStartWork";
            this.dpPMStartWork.Size = new System.Drawing.Size(100, 0);
            this.dpPMStartWork.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // dpPMEndWork
            // 
            this.dpPMEndWork.Flex = 1;
            this.dpPMEndWork.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.dpPMEndWork.Name = "dpPMEndWork";
            this.dpPMEndWork.Size = new System.Drawing.Size(100, 0);
            this.dpPMEndWork.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label14
            // 
            this.label14.Flex = 1;
            this.label14.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 0);
            this.label14.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel15
            // 
            this.panel15.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label21,
            this.label22,
            this.label24});
            this.panel15.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel15.Margin = new Swebui.Controls.Margin(10F, 10F, 10F, 0F);
            this.panel15.Name = "panel15";
            this.panel15.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel15.Size = new System.Drawing.Size(0, 30);
            // 
            // label21
            // 
            this.label21.Flex = 1;
            this.label21.ForeColor = System.Drawing.Color.Silver;
            this.label21.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(100, 0);
            this.label21.Text = "考勤成员";
            this.label21.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label22
            // 
            this.label22.Flex = 1;
            this.label22.ForeColor = System.Drawing.Color.Silver;
            this.label22.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(100, 0);
            this.label22.Text = "允许误差（在300-5000米）";
            this.label22.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label24
            // 
            this.label24.Flex = 1;
            this.label24.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(100, 0);
            this.label24.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel16
            // 
            this.panel16.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.btnUser,
            this.txtADeviation,
            this.label16});
            this.panel16.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel16.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel16.Name = "panel16";
            this.panel16.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel16.Size = new System.Drawing.Size(0, 35);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.White;
            this.btnUser.Flex = 1;
            this.btnUser.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.btnUser.Name = "btnUser";
            this.btnUser.NumberOfLines = 1;
            this.btnUser.Size = new System.Drawing.Size(100, 0);
            this.btnUser.Text = "点击选择";
            this.btnUser.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtADeviation
            // 
            this.txtADeviation.Flex = 1;
            this.txtADeviation.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.txtADeviation.Name = "txtADeviation";
            this.txtADeviation.Size = new System.Drawing.Size(100, 0);
            this.txtADeviation.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label16
            // 
            this.label16.Flex = 1;
            this.label16.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 0);
            // 
            // panel11
            // 
            this.panel11.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label15});
            this.panel11.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel11.Margin = new Swebui.Controls.Margin(10F, 10F, 10F, 0F);
            this.panel11.Name = "panel11";
            this.panel11.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel11.Size = new System.Drawing.Size(0, 30);
            // 
            // label15
            // 
            this.label15.Flex = 1;
            this.label15.ForeColor = System.Drawing.Color.Silver;
            this.label15.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 30);
            this.label15.Text = "考勤地点";
            this.label15.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel12
            // 
            this.panel12.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.lblAddress});
            this.panel12.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(0, 35);
            // 
            // lblAddress
            // 
            this.lblAddress.Flex = 1;
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(0, 30);
            this.lblAddress.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // FrmAttendanceView
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel2,
            this.panel3,
            this.panel4,
            this.panel5,
            this.panel6,
            this.timePanel,
            this.panel15,
            this.panel16,
            this.panel11,
            this.panel12});
            this.Load += new System.EventHandler(this.FrmAttendanceView_Load);

        }
        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button BackBtn;
        private Panel panel3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel4;
        private Label txtName;
        private Panel panel5;
        private Label label5;
        private Label label6;
        private Label label29;
        private Panel panel6;
        private Label dpStartWork;
        private Label dpEndWork;
        private Label label7;
        private Panel timePanel;
        private Panel panel7;
        private Label label8;
        private Label label9;
        private Label label27;
        private Panel panel8;
        private Label dpAMStartWork;
        private Label dpAMEndWork;
        private Label label10;
        private Panel panel9;
        private Label label11;
        private Label label12;
        private Label label30;
        private Panel panel10;
        private Label dpPMStartWork;
        private Label dpPMEndWork;
        private Label label14;
        private Panel panel15;
        private Label label21;
        private Label label22;
        private Label label24;
        private Panel panel16;
        private Label btnUser;
        private Label txtADeviation;
        private Label label16;
        private Panel panel11;
        private Label label15;
        private Panel panel12;
        private Label lblAddress;
        private Panel panel13;
        private Label btnDate;
        private Button button1;
        private Label btnATMode;
    }
}