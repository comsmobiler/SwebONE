using Swebui.Controls;
using System;

namespace SwebONE.Attendance
{
    partial class FrmAttendanceCreate : Swebui.Controls.SwebUserControl
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
            this.SaveBtn = new Swebui.Controls.Button();
            this.DeleteBtn = new Swebui.Controls.Button();
            this.panel3 = new Swebui.Controls.Panel();
            this.label2 = new Swebui.Controls.Label();
            this.label3 = new Swebui.Controls.Label();
            this.label4 = new Swebui.Controls.Label();
            this.btnATMode = new Swebui.Controls.Button();
            this.panel4 = new Swebui.Controls.Panel();
            this.txtName = new Swebui.Controls.TextBox();
            this.btnDate = new Swebui.Controls.Button();
            this.panel5 = new Swebui.Controls.Panel();
            this.label5 = new Swebui.Controls.Label();
            this.label6 = new Swebui.Controls.Label();
            this.label29 = new Swebui.Controls.Label();
            this.panel6 = new Swebui.Controls.Panel();
            this.dpStartWork = new Swebui.Controls.DatePicker();
            this.dpEndWork = new Swebui.Controls.DatePicker();
            this.label7 = new Swebui.Controls.Label();
            this.panel15 = new Swebui.Controls.Panel();
            this.label21 = new Swebui.Controls.Label();
            this.label22 = new Swebui.Controls.Label();
            this.label24 = new Swebui.Controls.Label();
            this.label30 = new Swebui.Controls.Label();
            this.panel16 = new Swebui.Controls.Panel();
            this.btnUser = new Swebui.Controls.Button();
            this.txtADeviation = new Swebui.Controls.TextBox();
            this.label16 = new Swebui.Controls.Label();
            this.label14 = new Swebui.Controls.Label();
            this.timePanel = new Swebui.Controls.Panel();
            this.panel7 = new Swebui.Controls.Panel();
            this.label8 = new Swebui.Controls.Label();
            this.label9 = new Swebui.Controls.Label();
            this.label27 = new Swebui.Controls.Label();
            this.panel8 = new Swebui.Controls.Panel();
            this.dpAMStartWork = new Swebui.Controls.DatePicker();
            this.dpAMEndWork = new Swebui.Controls.DatePicker();
            this.label10 = new Swebui.Controls.Label();
            this.panel9 = new Swebui.Controls.Panel();
            this.label11 = new Swebui.Controls.Label();
            this.label12 = new Swebui.Controls.Label();
            this.panel10 = new Swebui.Controls.Panel();
            this.dpPMStartWork = new Swebui.Controls.DatePicker();
            this.dpPMEndWork = new Swebui.Controls.DatePicker();
            this.panel11 = new Swebui.Controls.Panel();
            this.label15 = new Swebui.Controls.Label();
            this.panel12 = new Swebui.Controls.Panel();
            this.lblAddress = new Swebui.Controls.Label();
            this.mapTrimView1 = new Swebui.Controls.MapTrimView();
            this.eventLog1 = new System.Diagnostics.EventLog();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
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
            this.label1.Text = "考勤新增";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.BackBtn,
            this.SaveBtn,
            this.DeleteBtn});
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
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.White;
            this.SaveBtn.Border = new Swebui.Controls.Border(1F);
            this.SaveBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.SaveBtn.ForeColor = System.Drawing.Color.DimGray;
            this.SaveBtn.IconName = "fa fa-floppy-o";
            this.SaveBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.NumberOfLines = 0;
            this.SaveBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.SaveBtn.Size = new System.Drawing.Size(0, 26);
            this.SaveBtn.Text = "保存";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.White;
            this.DeleteBtn.Border = new Swebui.Controls.Border(1F);
            this.DeleteBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.DeleteBtn.ForeColor = System.Drawing.Color.DimGray;
            this.DeleteBtn.IconName = "fa fa-trash-o";
            this.DeleteBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.NumberOfLines = 0;
            this.DeleteBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.DeleteBtn.Size = new System.Drawing.Size(0, 26);
            this.DeleteBtn.Text = "删除";
            this.DeleteBtn.Visible = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
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
            // btnATMode
            // 
            this.btnATMode.BackColor = System.Drawing.Color.Transparent;
            this.btnATMode.Border = new Swebui.Controls.Border(1F);
            this.btnATMode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.btnATMode.Flex = 1;
            this.btnATMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.btnATMode.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.btnATMode.Name = "btnATMode";
            this.btnATMode.NumberOfLines = 0;
            this.btnATMode.Size = new System.Drawing.Size(100, 0);
            this.btnATMode.Text = "切换到一天两次上下班";
            this.btnATMode.Click += new System.EventHandler(this.btnATMode_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtName,
            this.btnDate,
            this.btnATMode});
            this.panel4.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel4.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel4.Name = "panel4";
            this.panel4.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel4.Size = new System.Drawing.Size(0, 35);
            // 
            // txtName
            // 
            this.txtName.Border = new Swebui.Controls.Border(1F);
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtName.Flex = 1;
            this.txtName.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 0);
            // 
            // btnDate
            // 
            this.btnDate.BackColor = System.Drawing.Color.White;
            this.btnDate.Border = new Swebui.Controls.Border(1F);
            this.btnDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.btnDate.Flex = 1;
            this.btnDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.btnDate.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.btnDate.Name = "btnDate";
            this.btnDate.NumberOfLines = 0;
            this.btnDate.Size = new System.Drawing.Size(100, 0);
            this.btnDate.Text = "点击选择";
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
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
            this.dpStartWork.Border = new Swebui.Controls.Border(1F);
            this.dpStartWork.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.dpStartWork.Flex = 1;
            this.dpStartWork.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.dpStartWork.MaxDate = new System.DateTime(9997, 12, 31, 23, 59, 59, 999);
            this.dpStartWork.Mode = Swebui.Controls.DatePickerMode.Time;
            this.dpStartWork.Name = "dpStartWork";
            this.dpStartWork.Size = new System.Drawing.Size(100, 0);
            this.dpStartWork.Value = new System.DateTime(2021, 11, 18, 14, 23, 54, 0);
            // 
            // dpEndWork
            // 
            this.dpEndWork.Border = new Swebui.Controls.Border(1F);
            this.dpEndWork.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.dpEndWork.Flex = 1;
            this.dpEndWork.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.dpEndWork.MaxDate = new System.DateTime(9997, 12, 31, 23, 59, 59, 999);
            this.dpEndWork.Mode = Swebui.Controls.DatePickerMode.Time;
            this.dpEndWork.Name = "dpEndWork";
            this.dpEndWork.Size = new System.Drawing.Size(100, 0);
            this.dpEndWork.Value = new System.DateTime(2021, 11, 2, 11, 51, 22, 342);
            // 
            // label7
            // 
            this.label7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label7.Flex = 1;
            this.label7.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 0);
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
            // label30
            // 
            this.label30.Flex = 1;
            this.label30.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(100, 0);
            this.label30.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
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
            this.btnUser.Border = new Swebui.Controls.Border(1F);
            this.btnUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.btnUser.Flex = 1;
            this.btnUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.btnUser.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.btnUser.Name = "btnUser";
            this.btnUser.NumberOfLines = 0;
            this.btnUser.Size = new System.Drawing.Size(100, 0);
            this.btnUser.Text = "点击选择";
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // txtADeviation
            // 
            this.txtADeviation.Border = new Swebui.Controls.Border(1F);
            this.txtADeviation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtADeviation.Flex = 1;
            this.txtADeviation.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.txtADeviation.Name = "txtADeviation";
            this.txtADeviation.Size = new System.Drawing.Size(100, 0);
            this.txtADeviation.ValueType = Swebui.Controls.TextBoxValueType.Number;
            this.txtADeviation.TouchLeave += new System.EventHandler(this.txtADeviation_TouchLeave);
            // 
            // label16
            // 
            this.label16.Flex = 1;
            this.label16.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 0);
            // 
            // label14
            // 
            this.label14.Flex = 1;
            this.label14.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 0);
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
            this.dpAMStartWork.Border = new Swebui.Controls.Border(1F);
            this.dpAMStartWork.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.dpAMStartWork.Flex = 1;
            this.dpAMStartWork.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.dpAMStartWork.MaxDate = new System.DateTime(9997, 12, 31, 23, 59, 59, 999);
            this.dpAMStartWork.Mode = Swebui.Controls.DatePickerMode.Time;
            this.dpAMStartWork.Name = "dpAMStartWork";
            this.dpAMStartWork.Size = new System.Drawing.Size(100, 0);
            this.dpAMStartWork.Value = new System.DateTime(2021, 11, 2, 11, 51, 19, 943);
            // 
            // dpAMEndWork
            // 
            this.dpAMEndWork.Border = new Swebui.Controls.Border(1F);
            this.dpAMEndWork.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.dpAMEndWork.Flex = 1;
            this.dpAMEndWork.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.dpAMEndWork.MaxDate = new System.DateTime(9997, 12, 31, 23, 59, 59, 999);
            this.dpAMEndWork.Mode = Swebui.Controls.DatePickerMode.Time;
            this.dpAMEndWork.Name = "dpAMEndWork";
            this.dpAMEndWork.Size = new System.Drawing.Size(100, 0);
            this.dpAMEndWork.Value = new System.DateTime(2021, 11, 2, 11, 51, 22, 342);
            // 
            // label10
            // 
            this.label10.Flex = 1;
            this.label10.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 0);
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
            this.dpPMStartWork.Border = new Swebui.Controls.Border(1F);
            this.dpPMStartWork.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.dpPMStartWork.Flex = 1;
            this.dpPMStartWork.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.dpPMStartWork.MaxDate = new System.DateTime(9997, 12, 31, 23, 59, 59, 999);
            this.dpPMStartWork.Mode = Swebui.Controls.DatePickerMode.Time;
            this.dpPMStartWork.Name = "dpPMStartWork";
            this.dpPMStartWork.Size = new System.Drawing.Size(100, 0);
            this.dpPMStartWork.Value = new System.DateTime(2021, 11, 2, 11, 51, 19, 943);
            // 
            // dpPMEndWork
            // 
            this.dpPMEndWork.Border = new Swebui.Controls.Border(1F);
            this.dpPMEndWork.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.dpPMEndWork.Flex = 1;
            this.dpPMEndWork.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.dpPMEndWork.MaxDate = new System.DateTime(9997, 12, 31, 23, 59, 59, 999);
            this.dpPMEndWork.Mode = Swebui.Controls.DatePickerMode.Time;
            this.dpPMEndWork.Name = "dpPMEndWork";
            this.dpPMEndWork.Size = new System.Drawing.Size(100, 0);
            this.dpPMEndWork.Value = new System.DateTime(2021, 11, 2, 11, 51, 22, 342);
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
            this.label15.Text = "考勤地点(移动下方地图更换考勤地点)";
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
            // mapTrimView1
            // 
            this.mapTrimView1.Flex = 1;
            this.mapTrimView1.Margin = new Swebui.Controls.Margin(10F, 10F, 0F, 0F);
            this.mapTrimView1.Name = "mapTrimView1";
            this.mapTrimView1.Size = new System.Drawing.Size(0, 0);
            this.mapTrimView1.LocationChanged += new Swebui.Controls.MapTrimViewLocationChanged(this.mapTrimView1_LocationChanged);
            // 
            // FrmAttendanceCreate
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
            this.panel12,
            this.mapTrimView1});
            this.Load += new System.EventHandler(this.FrmAttendanceCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();

        }
        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Label label3;
        private Panel panel4;
        private TextBox txtName;
        private Button btnDate;
        private Label label4;
        private Panel panel5;
        private Label label5;
        private Label label6;
        private Panel panel6;
        private DatePicker dpStartWork;
        private DatePicker dpEndWork;
        private Label label7;
        private Panel panel15;
        private Label label21;
        private Label label22;
        private Label label24;
        private Panel panel16;
        private Label label29;
        private Button btnUser;
        private Button btnATMode;
        private Panel timePanel;
        private Panel panel7;
        private Label label8;
        private Label label9;
        private Label label27;
        private Panel panel8;
        private DatePicker dpAMStartWork;
        private DatePicker dpAMEndWork;
        private Label label10;
        private Panel panel9;
        private Label label11;
        private Label label12;
        private Label label30;
        private Panel panel10;
        private DatePicker dpPMStartWork;
        private DatePicker dpPMEndWork;
        private Label label14;
        private Panel panel11;
        private Label label15;
        private TextBox txtADeviation;
        private Label label16;
        private Button BackBtn;
        private Button SaveBtn;
        private Button DeleteBtn;
        private Panel panel12;
        private Label lblAddress;
        private MapTrimView mapTrimView1;
        private System.Diagnostics.EventLog eventLog1;
    }
}