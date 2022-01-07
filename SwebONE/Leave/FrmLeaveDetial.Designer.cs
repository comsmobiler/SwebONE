using Swebui.Controls;
using System;

namespace SwebONE.Leave
{
    partial class FrmLeaveDetial : Swebui.Controls.SwebUserControl
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
            this.lblRBNO = new Swebui.Controls.Label();
            this.statusLab = new Swebui.Controls.Label();
            this.panel2 = new Swebui.Controls.Panel();
            this.BackBtn = new Swebui.Controls.Button();
            this.yesBtn = new Swebui.Controls.Button();
            this.noBtn = new Swebui.Controls.Button();
            this.panel3 = new Swebui.Controls.Panel();
            this.panel11 = new Swebui.Controls.Panel();
            this.label9 = new Swebui.Controls.Label();
            this.nodePanel = new Swebui.Controls.Panel();
            this.label10 = new Swebui.Controls.Label();
            this.panel4 = new Swebui.Controls.Panel();
            this.label2 = new Swebui.Controls.Label();
            this.label3 = new Swebui.Controls.Label();
            this.label4 = new Swebui.Controls.Label();
            this.panel5 = new Swebui.Controls.Panel();
            this.btnType = new Swebui.Controls.Label();
            this.dpkStartDate = new Swebui.Controls.Label();
            this.dpkEndDate = new Swebui.Controls.Label();
            this.panel6 = new Swebui.Controls.Panel();
            this.label5 = new Swebui.Controls.Label();
            this.label6 = new Swebui.Controls.Label();
            this.label7 = new Swebui.Controls.Label();
            this.panel7 = new Swebui.Controls.Panel();
            this.txtLday = new Swebui.Controls.Label();
            this.txtReason = new Swebui.Controls.Label();
            this.label16 = new Swebui.Controls.Label();
            this.panel9 = new Swebui.Controls.Panel();
            this.label11 = new Swebui.Controls.Label();
            this.label12 = new Swebui.Controls.Label();
            this.label13 = new Swebui.Controls.Label();
            this.panel10 = new Swebui.Controls.Panel();
            this.txtCheck = new Swebui.Controls.Label();
            this.txtCC = new Swebui.Controls.Label();
            this.label19 = new Swebui.Controls.Label();
            this.panel8 = new Swebui.Controls.Panel();
            this.label8 = new Swebui.Controls.Label();
            this.panel12 = new Swebui.Controls.Panel();
            this.imgL = new Swebui.Controls.Image();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.lblRBNO,
            this.statusLab});
            this.panel1.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel1.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel1.Name = "panel1";
            this.panel1.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel1.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.panel1.Size = new System.Drawing.Size(0, 46);
            // 
            // label1
            // 
            this.label1.FontSize = 24F;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 26);
            this.label1.Text = "请假详情";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
            // 
            // lblRBNO
            // 
            this.lblRBNO.FontSize = 18F;
            this.lblRBNO.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.lblRBNO.Name = "lblRBNO";
            this.lblRBNO.Size = new System.Drawing.Size(0, 26);
            this.lblRBNO.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
            // 
            // statusLab
            // 
            this.statusLab.FontSize = 18F;
            this.statusLab.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.statusLab.Name = "statusLab";
            this.statusLab.Size = new System.Drawing.Size(0, 26);
            this.statusLab.Text = "请假新增";
            this.statusLab.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.BackBtn,
            this.yesBtn,
            this.noBtn});
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
            // yesBtn
            // 
            this.yesBtn.BackColor = System.Drawing.Color.White;
            this.yesBtn.Border = new Swebui.Controls.Border(1F);
            this.yesBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.yesBtn.ForeColor = System.Drawing.Color.DimGray;
            this.yesBtn.IconName = "fa fa-check-circle-o";
            this.yesBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.NumberOfLines = 0;
            this.yesBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.yesBtn.Size = new System.Drawing.Size(0, 26);
            this.yesBtn.Text = "同意";
            this.yesBtn.Visible = false;
            this.yesBtn.Click += new System.EventHandler(this.yesBtn_Click);
            // 
            // noBtn
            // 
            this.noBtn.BackColor = System.Drawing.Color.White;
            this.noBtn.Border = new Swebui.Controls.Border(1F);
            this.noBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.noBtn.ForeColor = System.Drawing.Color.DimGray;
            this.noBtn.IconName = "fa fa-times-circle-o";
            this.noBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.noBtn.Name = "noBtn";
            this.noBtn.NumberOfLines = 0;
            this.noBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.noBtn.Size = new System.Drawing.Size(0, 26);
            this.noBtn.Text = "拒绝";
            this.noBtn.Visible = false;
            this.noBtn.Click += new System.EventHandler(this.noBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel11,
            this.panel4,
            this.panel5,
            this.panel6,
            this.panel7,
            this.panel9,
            this.panel10,
            this.panel8,
            this.panel12});
            this.panel3.Flex = 1;
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 100);
            // 
            // panel11
            // 
            this.panel11.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label9,
            this.nodePanel,
            this.label10});
            this.panel11.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel11.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 20F);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(0, 100);
            // 
            // label9
            // 
            this.label9.Flex = 1;
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 0);
            // 
            // nodePanel
            // 
            this.nodePanel.Direction = Swebui.Controls.LayoutDirection.Row;
            this.nodePanel.Flex = 4;
            this.nodePanel.Name = "nodePanel";
            this.nodePanel.Size = new System.Drawing.Size(25, 100);
            // 
            // label10
            // 
            this.label10.Flex = 1;
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 0);
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label2,
            this.label3,
            this.label4});
            this.panel4.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel4.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel4.Name = "panel4";
            this.panel4.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel4.Size = new System.Drawing.Size(0, 30);
            // 
            // label2
            // 
            this.label2.Flex = 1;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 30);
            this.label2.Text = "请假类型";
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Flex = 1;
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 30);
            this.label3.Text = "开始时间";
            this.label3.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Flex = 1;
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 30);
            this.label4.Text = "结束时间";
            this.label4.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.btnType,
            this.dpkStartDate,
            this.dpkEndDate});
            this.panel5.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel5.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel5.Name = "panel5";
            this.panel5.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel5.Size = new System.Drawing.Size(0, 35);
            // 
            // btnType
            // 
            this.btnType.Flex = 1;
            this.btnType.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(100, 35);
            this.btnType.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // dpkStartDate
            // 
            this.dpkStartDate.Flex = 1;
            this.dpkStartDate.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.dpkStartDate.Name = "dpkStartDate";
            this.dpkStartDate.Size = new System.Drawing.Size(100, 35);
            this.dpkStartDate.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // dpkEndDate
            // 
            this.dpkEndDate.Flex = 1;
            this.dpkEndDate.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.dpkEndDate.Name = "dpkEndDate";
            this.dpkEndDate.Size = new System.Drawing.Size(100, 35);
            this.dpkEndDate.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel6
            // 
            this.panel6.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label5,
            this.label6,
            this.label7});
            this.panel6.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel6.Margin = new Swebui.Controls.Margin(10F, 10F, 10F, 0F);
            this.panel6.Name = "panel6";
            this.panel6.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel6.Size = new System.Drawing.Size(0, 30);
            // 
            // label5
            // 
            this.label5.Flex = 1;
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 30);
            this.label5.Text = "请假天数";
            this.label5.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Flex = 1;
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 30);
            this.label6.Text = "请假事由";
            this.label6.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Flex = 1;
            this.label7.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 30);
            this.label7.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtLday,
            this.txtReason,
            this.label16});
            this.panel7.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel7.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel7.Name = "panel7";
            this.panel7.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel7.Size = new System.Drawing.Size(0, 35);
            // 
            // txtLday
            // 
            this.txtLday.Flex = 1;
            this.txtLday.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.txtLday.Name = "txtLday";
            this.txtLday.Size = new System.Drawing.Size(100, 35);
            this.txtLday.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtReason
            // 
            this.txtReason.Flex = 1;
            this.txtReason.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(100, 35);
            this.txtReason.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label16
            // 
            this.label16.Flex = 1;
            this.label16.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 35);
            this.label16.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel9
            // 
            this.panel9.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label11,
            this.label12,
            this.label13});
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
            this.label11.Text = "审核人";
            this.label11.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label12
            // 
            this.label12.Flex = 1;
            this.label12.ForeColor = System.Drawing.Color.Silver;
            this.label12.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 0);
            this.label12.Text = "抄送人";
            this.label12.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label13
            // 
            this.label13.Flex = 1;
            this.label13.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 0);
            // 
            // panel10
            // 
            this.panel10.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtCheck,
            this.txtCC,
            this.label19});
            this.panel10.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel10.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel10.Name = "panel10";
            this.panel10.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel10.Size = new System.Drawing.Size(0, 35);
            // 
            // txtCheck
            // 
            this.txtCheck.Flex = 1;
            this.txtCheck.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.txtCheck.Name = "txtCheck";
            this.txtCheck.Size = new System.Drawing.Size(100, 35);
            this.txtCheck.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtCC
            // 
            this.txtCC.Flex = 1;
            this.txtCC.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(100, 35);
            this.txtCC.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label19
            // 
            this.label19.Flex = 1;
            this.label19.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 0);
            // 
            // panel8
            // 
            this.panel8.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label8});
            this.panel8.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel8.Margin = new Swebui.Controls.Margin(10F, 10F, 10F, 0F);
            this.panel8.Name = "panel8";
            this.panel8.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel8.Size = new System.Drawing.Size(0, 30);
            // 
            // label8
            // 
            this.label8.Flex = 1;
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 30);
            this.label8.Text = "图片";
            this.label8.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.White;
            this.panel12.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.imgL});
            this.panel12.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel12.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel12.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel12.Name = "panel12";
            this.panel12.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel12.Size = new System.Drawing.Size(0, 110);
            // 
            // imgL
            // 
            this.imgL.Name = "imgL";
            this.imgL.ResourceID = "";
            this.imgL.Size = new System.Drawing.Size(212, 90);
            this.imgL.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // FrmLeaveDetial
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel2,
            this.panel3});
            this.Load += new System.EventHandler(this.FrmLeaveDetial_Load);

        }
        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button BackBtn;
        private Label lblRBNO;
        private Label statusLab;
        private Button yesBtn;
        private Button noBtn;
        private Panel panel3;
        private Panel panel11;
        private Label label9;
        private Panel nodePanel;
        private Label label10;
        private Panel panel4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel5;
        private Label btnType;
        private Label dpkStartDate;
        private Label dpkEndDate;
        private Panel panel6;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel7;
        private Label txtLday;
        private Label txtReason;
        private Label label16;
        private Panel panel9;
        private Label label11;
        private Label label12;
        private Label label13;
        private Panel panel10;
        private Label txtCheck;
        private Label txtCC;
        private Label label19;
        private Panel panel8;
        private Label label8;
        private Panel panel12;
        private Image imgL;
    }
}