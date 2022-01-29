using Swebui.Controls;
using System;

namespace SwebONE.Department
{
    partial class FrmDepartList : Swebui.Controls.SwebUserControl
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
            this.AddBtn = new Swebui.Controls.Button();
            this.RefreshBtn = new Swebui.Controls.Button();
            this.panel3 = new Swebui.Controls.Panel();
            this.panel4 = new Swebui.Controls.Panel();
            this.treeView1 = new Swebui.Controls.TreeView();
            this.panel5 = new Swebui.Controls.Panel();
            this.depPanel = new Swebui.Controls.Panel();
            this.panel8 = new Swebui.Controls.Panel();
            this.depImg = new Swebui.Controls.Image();
            this.label6 = new Swebui.Controls.Label();
            this.button1 = new Swebui.Controls.Button();
            this.panel9 = new Swebui.Controls.Panel();
            this.label2 = new Swebui.Controls.Label();
            this.depName = new Swebui.Controls.Label();
            this.label4 = new Swebui.Controls.Label();
            this.depLeader = new Swebui.Controls.Label();
            this.label13 = new Swebui.Controls.Label();
            this.memberPanel = new Swebui.Controls.Panel();
            this.userPanel = new Swebui.Controls.Panel();
            this.userImg = new Swebui.Controls.Image();
            this.panel11 = new Swebui.Controls.Panel();
            this.label7 = new Swebui.Controls.Label();
            this.userName = new Swebui.Controls.Label();
            this.label9 = new Swebui.Controls.Label();
            this.userSex = new Swebui.Controls.Label();
            this.panel10 = new Swebui.Controls.Panel();
            this.label3 = new Swebui.Controls.Label();
            this.userTel = new Swebui.Controls.Label();
            this.label8 = new Swebui.Controls.Label();
            this.userMail = new Swebui.Controls.Label();
            this.panel6 = new Swebui.Controls.Panel();
            this.label5 = new Swebui.Controls.Label();
            this.userBrith = new Swebui.Controls.Label();
            this.label11 = new Swebui.Controls.Label();
            this.label12 = new Swebui.Controls.Label();
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
            this.label1.Size = new System.Drawing.Size(100, 26);
            this.label1.Text = "部门列表";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.AddBtn,
            this.RefreshBtn});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel2.Name = "panel2";
            this.panel2.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.panel2.Size = new System.Drawing.Size(0, 46);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.White;
            this.AddBtn.Border = new Swebui.Controls.Border(1F);
            this.AddBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.AddBtn.ForeColor = System.Drawing.Color.DimGray;
            this.AddBtn.IconName = "fa fa-plus";
            this.AddBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.NumberOfLines = 0;
            this.AddBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.AddBtn.Size = new System.Drawing.Size(0, 26);
            this.AddBtn.Text = "新增";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.Color.White;
            this.RefreshBtn.Border = new Swebui.Controls.Border(1F);
            this.RefreshBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.RefreshBtn.ForeColor = System.Drawing.Color.DimGray;
            this.RefreshBtn.IconName = "fa fa-refresh";
            this.RefreshBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.NumberOfLines = 0;
            this.RefreshBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.RefreshBtn.Size = new System.Drawing.Size(0, 26);
            this.RefreshBtn.Text = "刷新";
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel4,
            this.panel5});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.Flex = 1;
            this.panel3.Name = "panel3";
            this.panel3.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.panel3.Size = new System.Drawing.Size(0, 100);
            // 
            // panel4
            // 
            this.panel4.Border = new Swebui.Controls.Border(0F, 0F, 1F, 0F);
            this.panel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.treeView1});
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 0);
            // 
            // treeView1
            // 
            this.treeView1.DefaultValue = new string[0];
            this.treeView1.Flex = 1;
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(137)))), ((int)(((byte)(248)))));
            this.treeView1.Size = new System.Drawing.Size(0, 30);
            this.treeView1.Press += new Swebui.Controls.TreeView.TreeViewOnPressEventHandler(this.treeView1_Press_1);
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.depPanel,
            this.userPanel});
            this.panel5.Flex = 1;
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 0);
            // 
            // depPanel
            // 
            this.depPanel.BackColor = System.Drawing.Color.White;
            this.depPanel.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel8,
            this.panel9,
            this.label13,
            this.memberPanel});
            this.depPanel.Flex = 1;
            this.depPanel.Name = "depPanel";
            this.depPanel.Size = new System.Drawing.Size(0, 100);
            this.depPanel.Visible = false;
            // 
            // panel8
            // 
            this.panel8.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.depImg,
            this.label6,
            this.button1});
            this.panel8.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel8.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel8.Margin = new Swebui.Controls.Margin(10F, 10F, 10F, 0F);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(0, 60);
            // 
            // depImg
            // 
            this.depImg.BorderRadius = 60;
            this.depImg.Name = "depImg";
            this.depImg.ResourceID = "";
            this.depImg.Size = new System.Drawing.Size(60, 60);
            this.depImg.SizeMode = Swebui.Controls.ImageSizeMode.Stretch;
            // 
            // label6
            // 
            this.label6.Flex = 1;
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 0);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Border = new Swebui.Controls.Border(1F);
            this.button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button1.Name = "button1";
            this.button1.NumberOfLines = 0;
            this.button1.Size = new System.Drawing.Size(57, 26);
            this.button1.Text = "编辑";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label2,
            this.depName,
            this.label4,
            this.depLeader});
            this.panel9.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel9.Margin = new Swebui.Controls.Margin(10F);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(0, 35);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 35);
            this.label2.Text = "部门名称";
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // depName
            // 
            this.depName.Flex = 1;
            this.depName.Name = "depName";
            this.depName.Size = new System.Drawing.Size(100, 35);
            this.depName.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 35);
            this.label4.Text = "部门负责人";
            this.label4.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // depLeader
            // 
            this.depLeader.Flex = 1;
            this.depLeader.Name = "depLeader";
            this.depLeader.Size = new System.Drawing.Size(100, 35);
            this.depLeader.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label13
            // 
            this.label13.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.label13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.label13.Name = "label13";
            this.label13.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.label13.Size = new System.Drawing.Size(0, 35);
            this.label13.Text = "部门成员";
            this.label13.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // memberPanel
            // 
            this.memberPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.memberPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.memberPanel.Direction = Swebui.Controls.LayoutDirection.Row;
            this.memberPanel.Flex = 1;
            this.memberPanel.Name = "memberPanel";
            this.memberPanel.Padding = new Swebui.Controls.Padding(10F, 10F, 10F, 0F);
            this.memberPanel.Size = new System.Drawing.Size(0, 92);
            this.memberPanel.Wrap = Swebui.Controls.LayoutWrap.Wrap;
            // 
            // userPanel
            // 
            this.userPanel.BackColor = System.Drawing.Color.White;
            this.userPanel.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.userImg,
            this.panel11,
            this.panel10,
            this.panel6});
            this.userPanel.Flex = 1;
            this.userPanel.Name = "userPanel";
            this.userPanel.Padding = new Swebui.Controls.Padding(10F);
            this.userPanel.Size = new System.Drawing.Size(0, 100);
            this.userPanel.Visible = false;
            // 
            // userImg
            // 
            this.userImg.BorderRadius = 60;
            this.userImg.Name = "userImg";
            this.userImg.ResourceID = "";
            this.userImg.Size = new System.Drawing.Size(60, 60);
            this.userImg.SizeMode = Swebui.Controls.ImageSizeMode.Stretch;
            // 
            // panel11
            // 
            this.panel11.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label7,
            this.userName,
            this.label9,
            this.userSex});
            this.panel11.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel11.Margin = new Swebui.Controls.Margin(0F, 10F, 0F, 10F);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(0, 35);
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 35);
            this.label7.Text = "姓名";
            this.label7.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // userName
            // 
            this.userName.Flex = 1;
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(100, 35);
            this.userName.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 35);
            this.label9.Text = "性别";
            this.label9.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // userSex
            // 
            this.userSex.Flex = 1;
            this.userSex.Name = "userSex";
            this.userSex.Size = new System.Drawing.Size(100, 35);
            this.userSex.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel10
            // 
            this.panel10.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label3,
            this.userTel,
            this.label8,
            this.userMail});
            this.panel10.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel10.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 10F);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(0, 35);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 35);
            this.label3.Text = "电话";
            this.label3.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // userTel
            // 
            this.userTel.Flex = 1;
            this.userTel.Name = "userTel";
            this.userTel.Size = new System.Drawing.Size(100, 35);
            this.userTel.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 35);
            this.label8.Text = "邮箱";
            this.label8.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // userMail
            // 
            this.userMail.Flex = 1;
            this.userMail.Name = "userMail";
            this.userMail.Size = new System.Drawing.Size(100, 35);
            this.userMail.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel6
            // 
            this.panel6.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label5,
            this.userBrith,
            this.label11,
            this.label12});
            this.panel6.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(0, 35);
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 35);
            this.label5.Text = "生日";
            this.label5.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // userBrith
            // 
            this.userBrith.Flex = 1;
            this.userBrith.Name = "userBrith";
            this.userBrith.Size = new System.Drawing.Size(100, 35);
            this.userBrith.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label11
            // 
            this.label11.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 35);
            this.label11.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label12
            // 
            this.label12.Flex = 1;
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 35);
            this.label12.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // FrmDepartList
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel2,
            this.panel3});
            this.Load += new System.EventHandler(this.FrmDepartList_Load);

        }
        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button AddBtn;
        private Button RefreshBtn;
        private Panel panel3;
        private Panel panel4;
        private TreeView treeView1;
        private Panel panel5;
        private Panel depPanel;
        private Panel userPanel;
        private Panel panel8;
        private Image depImg;
        private Label label6;
        private Button button1;
        private Panel panel9;
        private Label label2;
        private Label depName;
        private Label label4;
        private Label depLeader;
        private Image userImg;
        private Panel panel11;
        private Label label7;
        private Label userName;
        private Label label9;
        private Label userSex;
        private Panel panel10;
        private Label label3;
        private Label userTel;
        private Label label8;
        private Label userMail;
        private Panel panel6;
        private Label label5;
        private Label userBrith;
        private Label label11;
        private Label label12;
        private Label label13;
        private Panel memberPanel;
    }
}