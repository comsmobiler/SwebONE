using Swebui.Controls;
using System;

namespace SwebONE.Leave
{
    partial class FrmLeaveCreate : Swebui.Controls.SwebUserControl
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
            this.panel3 = new Swebui.Controls.Panel();
            this.label2 = new Swebui.Controls.Label();
            this.label3 = new Swebui.Controls.Label();
            this.label4 = new Swebui.Controls.Label();
            this.panel4 = new Swebui.Controls.Panel();
            this.btnType = new Swebui.Controls.TreeSelect();
            this.dpkStartDate = new Swebui.Controls.DatePicker();
            this.dpkEndDate = new Swebui.Controls.DatePicker();
            this.panel5 = new Swebui.Controls.Panel();
            this.label5 = new Swebui.Controls.Label();
            this.label6 = new Swebui.Controls.Label();
            this.label11 = new Swebui.Controls.Label();
            this.panel6 = new Swebui.Controls.Panel();
            this.txtLday = new Swebui.Controls.TextBox();
            this.txtReason = new Swebui.Controls.TextBox();
            this.comboBox2 = new Swebui.Controls.TreeSelect();
            this.panel9 = new Swebui.Controls.Panel();
            this.label12 = new Swebui.Controls.Label();
            this.label7 = new Swebui.Controls.Label();
            this.label13 = new Swebui.Controls.Label();
            this.panel10 = new Swebui.Controls.Panel();
            this.comboBox3 = new Swebui.Controls.TreeSelect();
            this.label14 = new Swebui.Controls.Panel();
            this.imgL = new Swebui.Controls.Image();
            this.panel11 = new Swebui.Controls.Panel();
            this.button1 = new Swebui.Controls.Button();
            this.button2 = new Swebui.Controls.Button();
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
            this.panel1.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.panel1.Size = new System.Drawing.Size(0, 46);
            // 
            // label1
            // 
            this.label1.Flex = 1;
            this.label1.FontSize = 24F;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 26);
            this.label1.Text = "请假新增";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.BackBtn,
            this.SaveBtn});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel2.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 15F);
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
            this.label2.Text = "请假类型";
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Flex = 1;
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 0);
            this.label3.Text = "开始时间";
            this.label3.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Flex = 1;
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 0);
            this.label4.Text = "结束时间";
            this.label4.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.btnType,
            this.dpkStartDate,
            this.dpkEndDate});
            this.panel4.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel4.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel4.Name = "panel4";
            this.panel4.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel4.Size = new System.Drawing.Size(0, 35);
            // 
            // btnType
            // 
            this.btnType.Border = new Swebui.Controls.Border(1F);
            this.btnType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnType.DefaultValue = new string[0];
            this.btnType.DropDownHeight = 280;
            this.btnType.Flex = 1;
            this.btnType.ListBackgroundColor = System.Drawing.Color.White;
            this.btnType.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(100, 0);
            this.btnType.Press += new Swebui.Controls.TreeSelect.TreeSelectOnPressEventHandler(this.btnType_Press);
            // 
            // dpkStartDate
            // 
            this.dpkStartDate.Border = new Swebui.Controls.Border(1F);
            this.dpkStartDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.dpkStartDate.Flex = 1;
            this.dpkStartDate.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.dpkStartDate.MaxDate = new System.DateTime(9997, 12, 31, 23, 59, 59, 999);
            this.dpkStartDate.Name = "dpkStartDate";
            this.dpkStartDate.Size = new System.Drawing.Size(100, 0);
            this.dpkStartDate.Value = new System.DateTime(2021, 10, 25, 10, 39, 36, 17);
            // 
            // dpkEndDate
            // 
            this.dpkEndDate.Border = new Swebui.Controls.Border(1F);
            this.dpkEndDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.dpkEndDate.Flex = 1;
            this.dpkEndDate.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.dpkEndDate.MaxDate = new System.DateTime(9997, 12, 31, 23, 59, 59, 999);
            this.dpkEndDate.Name = "dpkEndDate";
            this.dpkEndDate.Size = new System.Drawing.Size(100, 0);
            this.dpkEndDate.Value = new System.DateTime(2021, 10, 25, 10, 39, 37, 706);
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label5,
            this.label6,
            this.label11});
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
            this.label5.Text = "请假天数";
            this.label5.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Flex = 1;
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 0);
            this.label6.Text = "请假事由";
            this.label6.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label11
            // 
            this.label11.Flex = 1;
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 0);
            this.label11.Text = "审核人";
            this.label11.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel6
            // 
            this.panel6.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtLday,
            this.txtReason,
            this.comboBox2});
            this.panel6.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel6.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel6.Name = "panel6";
            this.panel6.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel6.Size = new System.Drawing.Size(0, 35);
            // 
            // txtLday
            // 
            this.txtLday.Border = new Swebui.Controls.Border(1F);
            this.txtLday.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtLday.Flex = 1;
            this.txtLday.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.txtLday.Name = "txtLday";
            this.txtLday.Size = new System.Drawing.Size(100, 0);
            // 
            // txtReason
            // 
            this.txtReason.Border = new Swebui.Controls.Border(1F);
            this.txtReason.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtReason.Flex = 1;
            this.txtReason.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(100, 0);
            // 
            // comboBox2
            // 
            this.comboBox2.Border = new Swebui.Controls.Border(1F);
            this.comboBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.comboBox2.DefaultValue = new string[0];
            this.comboBox2.DropDownHeight = 280;
            this.comboBox2.Flex = 1;
            this.comboBox2.ListBackgroundColor = System.Drawing.Color.White;
            this.comboBox2.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.comboBox2.Multiple = true;
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Placeholder = "请选择1-4审核人";
            this.comboBox2.Size = new System.Drawing.Size(100, 0);
            this.comboBox2.TagBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(137)))), ((int)(((byte)(248)))));
            this.comboBox2.TagColor = System.Drawing.Color.White;
            this.comboBox2.Press += new Swebui.Controls.TreeSelect.TreeSelectOnPressEventHandler(this.comboBox2_Press);
            // 
            // panel9
            // 
            this.panel9.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label12,
            this.label7,
            this.label13});
            this.panel9.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel9.Margin = new Swebui.Controls.Margin(10F, 10F, 10F, 0F);
            this.panel9.Name = "panel9";
            this.panel9.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel9.Size = new System.Drawing.Size(0, 30);
            // 
            // label12
            // 
            this.label12.Flex = 1;
            this.label12.ForeColor = System.Drawing.Color.Silver;
            this.label12.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 0);
            this.label12.Text = "抄送人";
            this.label12.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Flex = 1;
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 0);
            this.label7.Text = "图片";
            this.label7.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label13
            // 
            this.label13.Flex = 1;
            this.label13.ForeColor = System.Drawing.Color.Silver;
            this.label13.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 0);
            // 
            // panel10
            // 
            this.panel10.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.comboBox3,
            this.label14});
            this.panel10.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel10.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel10.Name = "panel10";
            this.panel10.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel10.Size = new System.Drawing.Size(0, 130);
            // 
            // comboBox3
            // 
            this.comboBox3.Border = new Swebui.Controls.Border(1F);
            this.comboBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.comboBox3.DefaultValue = new string[0];
            this.comboBox3.DropDownHeight = 280;
            this.comboBox3.Flex = 1;
            this.comboBox3.ListBackgroundColor = System.Drawing.Color.White;
            this.comboBox3.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.comboBox3.Multiple = true;
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Placeholder = "请选择0-4个抄送人";
            this.comboBox3.Size = new System.Drawing.Size(100, 35);
            this.comboBox3.TagBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(137)))), ((int)(((byte)(248)))));
            this.comboBox3.TagColor = System.Drawing.Color.White;
            this.comboBox3.Press += new Swebui.Controls.TreeSelect.TreeSelectOnPressEventHandler(this.comboBox3_Press);
            // 
            // label14
            // 
            this.label14.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.imgL,
            this.panel11});
            this.label14.Direction = Swebui.Controls.LayoutDirection.Row;
            this.label14.Flex = 2;
            this.label14.Margin = new Swebui.Controls.Margin(5F, 0F, 15F, 0F);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 0);
            // 
            // imgL
            // 
            this.imgL.Border = new Swebui.Controls.Border(1F);
            this.imgL.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.imgL.Name = "imgL";
            this.imgL.ResourceID = "";
            this.imgL.Size = new System.Drawing.Size(212, 100);
            this.imgL.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // panel11
            // 
            this.panel11.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.button1,
            this.button2});
            this.panel11.ItemAlign = Swebui.Controls.LayoutItemAlign.FlexStart;
            this.panel11.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.SpaceAround;
            this.panel11.Margin = new Swebui.Controls.Margin(0F, 10F, 0F, 0F);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(92, 80);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Border = new Swebui.Controls.Border(1F);
            this.button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button1.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.button1.Name = "button1";
            this.button1.NumberOfLines = 0;
            this.button1.Size = new System.Drawing.Size(60, 26);
            this.button1.Text = "上传";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Border = new Swebui.Controls.Border(1F);
            this.button2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.button2.Name = "button2";
            this.button2.NumberOfLines = 0;
            this.button2.Size = new System.Drawing.Size(60, 26);
            this.button2.Text = "删除";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmLeaveCreate
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel2,
            this.panel3,
            this.panel4,
            this.panel5,
            this.panel6,
            this.panel9,
            this.panel10});
            this.Load += new System.EventHandler(this.FrmLeaveCreate_Load);

        }
        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button BackBtn;
        private Button SaveBtn;
        private Panel panel3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel4;
        private TreeSelect btnType;
        private DatePicker dpkStartDate;
        private DatePicker dpkEndDate;
        private Panel panel5;
        private Label label5;
        private Label label6;
        private Panel panel6;
        private Panel panel9;
        private Label label11;
        private Label label12;
        private Label label13;
        private Panel panel10;
        private TextBox txtLday;
        private TextBox txtReason;
        private TreeSelect comboBox2;
        private TreeSelect comboBox3;
        private Label label7;
        private Panel label14;
        private Image imgL;
        private Panel panel11;
        private Button button1;
        private Button button2;
    }
}