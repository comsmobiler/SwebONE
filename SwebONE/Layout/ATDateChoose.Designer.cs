using Swebui.Controls;
using System;

namespace SwebONE.Layout
{
    partial class ATDateChoose : Swebui.Controls.SwebUserControl
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
            this.titleLab = new Swebui.Controls.Label();
            this.button1 = new Swebui.Controls.Button();
            this.label1 = new Swebui.Controls.Label();
            this.panel2 = new Swebui.Controls.Panel();
            this.checkDate1 = new Swebui.Controls.CheckBox();
            this.label2 = new Swebui.Controls.Label();
            this.checkDate2 = new Swebui.Controls.CheckBox();
            this.label3 = new Swebui.Controls.Label();
            this.checkDate3 = new Swebui.Controls.CheckBox();
            this.label4 = new Swebui.Controls.Label();
            this.checkDate4 = new Swebui.Controls.CheckBox();
            this.label5 = new Swebui.Controls.Label();
            this.checkDate5 = new Swebui.Controls.CheckBox();
            this.label6 = new Swebui.Controls.Label();
            this.checkDate6 = new Swebui.Controls.CheckBox();
            this.label7 = new Swebui.Controls.Label();
            this.checkDate7 = new Swebui.Controls.CheckBox();
            this.label8 = new Swebui.Controls.Label();
            this.panel3 = new Swebui.Controls.Panel();
            this.fontIcon1 = new Swebui.Controls.FontIcon();
            this.label9 = new Swebui.Controls.Label();
            this.panel4 = new Swebui.Controls.Panel();
            this.calendar1 = new Swebui.Controls.Calendar();
            this.panel6 = new Swebui.Controls.Panel();
            this.panel7 = new Swebui.Controls.Panel();
            this.lblRest = new Swebui.Controls.Label();
            this.panel8 = new Swebui.Controls.Panel();
            this.lblStartWork = new Swebui.Controls.Label();
            this.dpStartWork = new Swebui.Controls.DatePicker();
            this.dpAMStartWork = new Swebui.Controls.DatePicker();
            this.panel9 = new Swebui.Controls.Panel();
            this.lblEndWork = new Swebui.Controls.Label();
            this.dpEndWork = new Swebui.Controls.DatePicker();
            this.dpAMEndWork = new Swebui.Controls.DatePicker();
            this.panel10 = new Swebui.Controls.Panel();
            this.lblPMStartWork = new Swebui.Controls.Label();
            this.dpPMStartWork = new Swebui.Controls.DatePicker();
            this.panel11 = new Swebui.Controls.Panel();
            this.lblPMEndWork = new Swebui.Controls.Label();
            this.dpPMEndWork = new Swebui.Controls.DatePicker();
            this.btnCDType = new Swebui.Controls.Button();
            this.panel5 = new Swebui.Controls.Panel();
            this.lblDesc = new Swebui.Controls.Label();
            this.btnSave = new Swebui.Controls.Button();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.titleLab,
            this.button1});
            this.panel1.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel1.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel1.Name = "panel1";
            this.panel1.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel1.Size = new System.Drawing.Size(0, 46);
            // 
            // titleLab
            // 
            this.titleLab.Flex = 1;
            this.titleLab.FontSize = 24F;
            this.titleLab.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.titleLab.Name = "titleLab";
            this.titleLab.Size = new System.Drawing.Size(100, 26);
            this.titleLab.Text = "工作日选择";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.Color.Gray;
            this.button1.IconName = "fa fa-times-circle";
            this.button1.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.button1.Name = "button1";
            this.button1.NumberOfLines = 0;
            this.button1.Size = new System.Drawing.Size(39, 41);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 30);
            this.label1.Text = "常规工作日选择";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.checkDate1,
            this.label2,
            this.checkDate2,
            this.label3,
            this.checkDate3,
            this.label4,
            this.checkDate4,
            this.label5,
            this.checkDate5,
            this.label6,
            this.checkDate6,
            this.label7,
            this.checkDate7,
            this.label8});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel2.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 30);
            // 
            // checkDate1
            // 
            this.checkDate1.BackColor = System.Drawing.Color.Transparent;
            this.checkDate1.BorderColor = System.Drawing.Color.Black;
            this.checkDate1.BorderRadius = 0;
            this.checkDate1.Margin = new Swebui.Controls.Margin(0F, 0F, 5F, 0F);
            this.checkDate1.Name = "checkDate1";
            this.checkDate1.Size = new System.Drawing.Size(25, 25);
            this.checkDate1.CheckedChanged += new System.EventHandler(this.checkDate7_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Margin = new Swebui.Controls.Margin(0F, 0F, 5F, 0F);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 30);
            this.label2.Text = "星期一";
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // checkDate2
            // 
            this.checkDate2.BackColor = System.Drawing.Color.Transparent;
            this.checkDate2.BorderColor = System.Drawing.Color.Black;
            this.checkDate2.BorderRadius = 0;
            this.checkDate2.Margin = new Swebui.Controls.Margin(0F, 0F, 5F, 0F);
            this.checkDate2.Name = "checkDate2";
            this.checkDate2.Size = new System.Drawing.Size(25, 25);
            this.checkDate2.CheckedChanged += new System.EventHandler(this.checkDate7_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Margin = new Swebui.Controls.Margin(0F, 0F, 5F, 0F);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 30);
            this.label3.Text = "星期二";
            this.label3.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // checkDate3
            // 
            this.checkDate3.BackColor = System.Drawing.Color.Transparent;
            this.checkDate3.BorderColor = System.Drawing.Color.Black;
            this.checkDate3.BorderRadius = 0;
            this.checkDate3.Margin = new Swebui.Controls.Margin(0F, 0F, 5F, 0F);
            this.checkDate3.Name = "checkDate3";
            this.checkDate3.Size = new System.Drawing.Size(25, 25);
            this.checkDate3.CheckedChanged += new System.EventHandler(this.checkDate7_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Margin = new Swebui.Controls.Margin(0F, 0F, 5F, 0F);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 30);
            this.label4.Text = "星期三";
            this.label4.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // checkDate4
            // 
            this.checkDate4.BackColor = System.Drawing.Color.Transparent;
            this.checkDate4.BorderColor = System.Drawing.Color.Black;
            this.checkDate4.BorderRadius = 0;
            this.checkDate4.Margin = new Swebui.Controls.Margin(0F, 0F, 5F, 0F);
            this.checkDate4.Name = "checkDate4";
            this.checkDate4.Size = new System.Drawing.Size(25, 25);
            this.checkDate4.CheckedChanged += new System.EventHandler(this.checkDate7_CheckedChanged);
            // 
            // label5
            // 
            this.label5.Margin = new Swebui.Controls.Margin(0F, 0F, 5F, 0F);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 30);
            this.label5.Text = "星期四";
            this.label5.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // checkDate5
            // 
            this.checkDate5.BackColor = System.Drawing.Color.Transparent;
            this.checkDate5.BorderColor = System.Drawing.Color.Black;
            this.checkDate5.BorderRadius = 0;
            this.checkDate5.Margin = new Swebui.Controls.Margin(0F, 0F, 5F, 0F);
            this.checkDate5.Name = "checkDate5";
            this.checkDate5.Size = new System.Drawing.Size(25, 25);
            this.checkDate5.CheckedChanged += new System.EventHandler(this.checkDate7_CheckedChanged);
            // 
            // label6
            // 
            this.label6.Margin = new Swebui.Controls.Margin(0F, 0F, 5F, 0F);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 30);
            this.label6.Text = "星期五";
            this.label6.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // checkDate6
            // 
            this.checkDate6.BackColor = System.Drawing.Color.Transparent;
            this.checkDate6.BorderColor = System.Drawing.Color.Black;
            this.checkDate6.BorderRadius = 0;
            this.checkDate6.Margin = new Swebui.Controls.Margin(0F, 0F, 5F, 0F);
            this.checkDate6.Name = "checkDate6";
            this.checkDate6.Size = new System.Drawing.Size(25, 25);
            this.checkDate6.CheckedChanged += new System.EventHandler(this.checkDate7_CheckedChanged);
            // 
            // label7
            // 
            this.label7.Margin = new Swebui.Controls.Margin(0F, 0F, 5F, 0F);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 30);
            this.label7.Text = "星期六";
            this.label7.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // checkDate7
            // 
            this.checkDate7.BackColor = System.Drawing.Color.Transparent;
            this.checkDate7.BorderColor = System.Drawing.Color.Black;
            this.checkDate7.BorderRadius = 0;
            this.checkDate7.Margin = new Swebui.Controls.Margin(0F, 0F, 5F, 0F);
            this.checkDate7.Name = "checkDate7";
            this.checkDate7.Size = new System.Drawing.Size(25, 25);
            this.checkDate7.CheckedChanged += new System.EventHandler(this.checkDate7_CheckedChanged);
            // 
            // label8
            // 
            this.label8.Margin = new Swebui.Controls.Margin(0F, 0F, 5F, 0F);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 30);
            this.label8.Text = "星期七";
            this.label8.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.fontIcon1,
            this.label9});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel3.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 30);
            // 
            // fontIcon1
            // 
            this.fontIcon1.Name = "fontIcon1";
            this.fontIcon1.ResourceID = "calendar-o";
            this.fontIcon1.Size = new System.Drawing.Size(20, 20);
            // 
            // label9
            // 
            this.label9.Flex = 1;
            this.label9.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 30);
            this.label9.Text = "自定义日期";
            this.label9.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.calendar1,
            this.panel6});
            this.panel4.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel4.Flex = 1;
            this.panel4.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 2F);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 100);
            // 
            // calendar1
            // 
            this.calendar1.Name = "calendar1";
            this.calendar1.Size = new System.Drawing.Size(282, 0);
            this.calendar1.DateChanged += new System.EventHandler(this.calendar1_DateChanged);
            // 
            // panel6
            // 
            this.panel6.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel7,
            this.panel8,
            this.panel9,
            this.panel10,
            this.panel11,
            this.btnCDType});
            this.panel6.Flex = 1;
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(276, 0);
            // 
            // panel7
            // 
            this.panel7.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.lblRest});
            this.panel7.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(0, 30);
            // 
            // lblRest
            // 
            this.lblRest.Flex = 1;
            this.lblRest.ForeColor = System.Drawing.Color.Silver;
            this.lblRest.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.lblRest.Name = "lblRest";
            this.lblRest.Size = new System.Drawing.Size(100, 30);
            this.lblRest.Text = "休息";
            this.lblRest.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel8
            // 
            this.panel8.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.lblStartWork,
            this.dpStartWork,
            this.dpAMStartWork});
            this.panel8.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(0, 30);
            // 
            // lblStartWork
            // 
            this.lblStartWork.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.lblStartWork.Name = "lblStartWork";
            this.lblStartWork.Size = new System.Drawing.Size(100, 30);
            this.lblStartWork.Text = "上班时间";
            this.lblStartWork.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // dpStartWork
            // 
            this.dpStartWork.Border = new Swebui.Controls.Border(1F);
            this.dpStartWork.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.dpStartWork.Flex = 1;
            this.dpStartWork.MaxDate = new System.DateTime(9997, 12, 31, 23, 59, 59, 999);
            this.dpStartWork.MinDate = new System.DateTime(((long)(0)));
            this.dpStartWork.Mode = Swebui.Controls.DatePickerMode.Time;
            this.dpStartWork.Name = "dpStartWork";
            this.dpStartWork.Size = new System.Drawing.Size(100, 30);
            this.dpStartWork.Value = new System.DateTime(2021, 11, 18, 11, 30, 18, 737);
            this.dpStartWork.ValueChanged += new System.EventHandler(this.dpStartWork_ValueChanged);
            // 
            // dpAMStartWork
            // 
            this.dpAMStartWork.Border = new Swebui.Controls.Border(1F);
            this.dpAMStartWork.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.dpAMStartWork.Flex = 1;
            this.dpAMStartWork.MaxDate = new System.DateTime(9997, 12, 31, 23, 59, 59, 999);
            this.dpAMStartWork.MinDate = new System.DateTime(((long)(0)));
            this.dpAMStartWork.Mode = Swebui.Controls.DatePickerMode.Time;
            this.dpAMStartWork.Name = "dpAMStartWork";
            this.dpAMStartWork.Size = new System.Drawing.Size(100, 30);
            this.dpAMStartWork.Value = new System.DateTime(2021, 11, 18, 11, 30, 18, 737);
            // 
            // panel9
            // 
            this.panel9.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.lblEndWork,
            this.dpEndWork,
            this.dpAMEndWork});
            this.panel9.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(0, 30);
            // 
            // lblEndWork
            // 
            this.lblEndWork.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.lblEndWork.Name = "lblEndWork";
            this.lblEndWork.Size = new System.Drawing.Size(100, 30);
            this.lblEndWork.Text = "下班时间";
            this.lblEndWork.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // dpEndWork
            // 
            this.dpEndWork.Border = new Swebui.Controls.Border(1F);
            this.dpEndWork.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.dpEndWork.Flex = 1;
            this.dpEndWork.MaxDate = new System.DateTime(9997, 12, 31, 23, 59, 59, 999);
            this.dpEndWork.MinDate = new System.DateTime(((long)(0)));
            this.dpEndWork.Mode = Swebui.Controls.DatePickerMode.Time;
            this.dpEndWork.Name = "dpEndWork";
            this.dpEndWork.Size = new System.Drawing.Size(100, 0);
            this.dpEndWork.Value = new System.DateTime(2021, 11, 18, 11, 30, 20, 849);
            this.dpEndWork.ValueChanged += new System.EventHandler(this.dpEndWork_ValueChanged);
            // 
            // dpAMEndWork
            // 
            this.dpAMEndWork.Border = new Swebui.Controls.Border(1F);
            this.dpAMEndWork.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.dpAMEndWork.Flex = 1;
            this.dpAMEndWork.MaxDate = new System.DateTime(9997, 12, 31, 23, 59, 59, 999);
            this.dpAMEndWork.MinDate = new System.DateTime(((long)(0)));
            this.dpAMEndWork.Mode = Swebui.Controls.DatePickerMode.Time;
            this.dpAMEndWork.Name = "dpAMEndWork";
            this.dpAMEndWork.Size = new System.Drawing.Size(100, 0);
            this.dpAMEndWork.Value = new System.DateTime(2021, 11, 18, 11, 30, 20, 849);
            // 
            // panel10
            // 
            this.panel10.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.lblPMStartWork,
            this.dpPMStartWork});
            this.panel10.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(0, 30);
            // 
            // lblPMStartWork
            // 
            this.lblPMStartWork.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.lblPMStartWork.Name = "lblPMStartWork";
            this.lblPMStartWork.Size = new System.Drawing.Size(100, 30);
            this.lblPMStartWork.Text = "下午上班";
            this.lblPMStartWork.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // dpPMStartWork
            // 
            this.dpPMStartWork.Border = new Swebui.Controls.Border(1F);
            this.dpPMStartWork.Flex = 1;
            this.dpPMStartWork.MaxDate = new System.DateTime(9997, 12, 31, 23, 59, 59, 999);
            this.dpPMStartWork.MinDate = new System.DateTime(((long)(0)));
            this.dpPMStartWork.Mode = Swebui.Controls.DatePickerMode.Time;
            this.dpPMStartWork.Name = "dpPMStartWork";
            this.dpPMStartWork.Size = new System.Drawing.Size(100, 0);
            this.dpPMStartWork.Value = new System.DateTime(2021, 11, 18, 11, 30, 23, 486);
            this.dpPMStartWork.ValueChanged += new System.EventHandler(this.dpPMStartWork_ValueChanged);
            // 
            // panel11
            // 
            this.panel11.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.lblPMEndWork,
            this.dpPMEndWork});
            this.panel11.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(0, 30);
            // 
            // lblPMEndWork
            // 
            this.lblPMEndWork.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.lblPMEndWork.Name = "lblPMEndWork";
            this.lblPMEndWork.Size = new System.Drawing.Size(100, 30);
            this.lblPMEndWork.Text = "下午下班";
            this.lblPMEndWork.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // dpPMEndWork
            // 
            this.dpPMEndWork.Border = new Swebui.Controls.Border(1F);
            this.dpPMEndWork.Flex = 1;
            this.dpPMEndWork.MaxDate = new System.DateTime(9997, 12, 31, 23, 59, 59, 999);
            this.dpPMEndWork.MinDate = new System.DateTime(((long)(0)));
            this.dpPMEndWork.Mode = Swebui.Controls.DatePickerMode.Time;
            this.dpPMEndWork.Name = "dpPMEndWork";
            this.dpPMEndWork.Size = new System.Drawing.Size(100, 0);
            this.dpPMEndWork.Value = new System.DateTime(2021, 11, 18, 11, 30, 25, 477);
            this.dpPMEndWork.ValueChanged += new System.EventHandler(this.dpPMEndWork_ValueChanged);
            // 
            // btnCDType
            // 
            this.btnCDType.BackColor = System.Drawing.Color.White;
            this.btnCDType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.btnCDType.Name = "btnCDType";
            this.btnCDType.NumberOfLines = 0;
            this.btnCDType.Size = new System.Drawing.Size(0, 35);
            this.btnCDType.Text = "设置为休息";
            this.btnCDType.Click += new System.EventHandler(this.btnCDType_Click);
            // 
            // panel5
            // 
            this.panel5.Border = new Swebui.Controls.Border(0F, 1F, 0F, 0F);
            this.panel5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.lblDesc,
            this.btnSave});
            this.panel5.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel5.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel5.Name = "panel5";
            this.panel5.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.panel5.Size = new System.Drawing.Size(0, 45);
            // 
            // lblDesc
            // 
            this.lblDesc.Flex = 1;
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(100, 30);
            this.lblDesc.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // btnSave
            // 
            this.btnSave.Name = "btnSave";
            this.btnSave.NumberOfLines = 0;
            this.btnSave.Size = new System.Drawing.Size(71, 30);
            this.btnSave.Text = "确定";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ATDateChoose
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.label1,
            this.panel2,
            this.panel3,
            this.panel4,
            this.panel5});
            this.Size = new System.Drawing.Size(600, 400);
            this.Load += new System.EventHandler(this.ATDateChoose_Load);

        }
        #endregion

        private Panel panel1;
        private Label titleLab;
        private Button button1;
        private Label label1;
        private Panel panel2;
        private CheckBox checkDate1;
        private Label label2;
        private CheckBox checkDate2;
        private Label label3;
        private CheckBox checkDate3;
        private Label label4;
        private CheckBox checkDate4;
        private Label label5;
        private CheckBox checkDate5;
        private Label label6;
        private CheckBox checkDate6;
        private Label label7;
        private CheckBox checkDate7;
        private Label label8;
        private Panel panel3;
        private FontIcon fontIcon1;
        private Label label9;
        private Panel panel4;
        private Calendar calendar1;
        private Panel panel6;
        private Panel panel5;
        private Label lblDesc;
        private Button btnSave;
        private Panel panel7;
        private Label lblRest;
        private Panel panel8;
        private Label lblStartWork;
        private Panel panel9;
        private Label lblEndWork;
        private Panel panel10;
        private Label lblPMStartWork;
        private Panel panel11;
        private Label lblPMEndWork;
        private Button btnCDType;
        private DatePicker dpStartWork;
        private DatePicker dpEndWork;
        private DatePicker dpPMStartWork;
        private DatePicker dpPMEndWork;
        private DatePicker dpAMStartWork;
        private DatePicker dpAMEndWork;
    }
}