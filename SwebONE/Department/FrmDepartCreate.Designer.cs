using Swebui.Controls;
using System;

namespace SwebONE.Department
{
    partial class FrmDepartCreate : Swebui.Controls.SwebUserControl
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
            this.panel2 = new Swebui.Controls.Panel();
            this.BackBtn = new Swebui.Controls.Button();
            this.SaveBtn = new Swebui.Controls.Button();
            this.DeleteBtn = new Swebui.Controls.Button();
            this.panel3 = new Swebui.Controls.Panel();
            this.label5 = new Swebui.Controls.Label();
            this.label2 = new Swebui.Controls.Label();
            this.label3 = new Swebui.Controls.Label();
            this.panel4 = new Swebui.Controls.Panel();
            this.panel7 = new Swebui.Controls.Panel();
            this.image1 = new Swebui.Controls.Image();
            this.button1 = new Swebui.Controls.Button();
            this.txtDep_Name = new Swebui.Controls.TextBox();
            this.comboBox1 = new Swebui.Controls.TreeSelect();
            this.panel5 = new Swebui.Controls.Panel();
            this.panel10 = new Swebui.Controls.Panel();
            this.label8 = new Swebui.Controls.Label();
            this.label14 = new Swebui.Controls.Label();
            this.checkAll1 = new Swebui.Controls.CheckBox();
            this.label1 = new Swebui.Controls.Label();
            this.label4 = new Swebui.Controls.Label();
            this.panel6 = new Swebui.Controls.Panel();
            this.panel8 = new Swebui.Controls.Panel();
            this.listView1 = new Swebui.Controls.ListView();
            this.info = new Swebui.Controls.Label();
            this.label6 = new Swebui.Controls.Label();
            this.label7 = new Swebui.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.titleLab});
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
            this.titleLab.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.titleLab.Name = "titleLab";
            this.titleLab.Size = new System.Drawing.Size(100, 26);
            this.titleLab.Text = "部门新增";
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
            this.label5,
            this.label2,
            this.label3});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel3.Name = "panel3";
            this.panel3.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel3.Size = new System.Drawing.Size(0, 30);
            // 
            // label5
            // 
            this.label5.Flex = 1;
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 0);
            this.label5.Text = "部门头像";
            this.label5.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Flex = 1;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 0);
            this.label2.Text = "部门名称";
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Flex = 1;
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 0);
            this.label3.Text = "部门负责人";
            this.label3.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel7,
            this.txtDep_Name,
            this.comboBox1});
            this.panel4.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel4.ItemAlign = Swebui.Controls.LayoutItemAlign.FlexStart;
            this.panel4.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel4.Name = "panel4";
            this.panel4.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel4.Size = new System.Drawing.Size(0, 110);
            // 
            // panel7
            // 
            this.panel7.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.image1,
            this.button1});
            this.panel7.Flex = 1;
            this.panel7.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(0, 110);
            // 
            // image1
            // 
            this.image1.BorderRadius = 60;
            this.image1.Margin = new Swebui.Controls.Margin(0F, 10F, 0F, 10F);
            this.image1.Name = "image1";
            this.image1.ResourceID = "bumenicon.png";
            this.image1.Size = new System.Drawing.Size(60, 60);
            this.image1.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Border = new Swebui.Controls.Border(1F);
            this.button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button1.Margin = new Swebui.Controls.Margin(5F, 0F, 0F, 0F);
            this.button1.Name = "button1";
            this.button1.NumberOfLines = 0;
            this.button1.Size = new System.Drawing.Size(55, 26);
            this.button1.Text = "上传";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDep_Name
            // 
            this.txtDep_Name.Border = new Swebui.Controls.Border(1F);
            this.txtDep_Name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtDep_Name.Flex = 1;
            this.txtDep_Name.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.txtDep_Name.Name = "txtDep_Name";
            this.txtDep_Name.Size = new System.Drawing.Size(100, 35);
            // 
            // comboBox1
            // 
            this.comboBox1.Border = new Swebui.Controls.Border(1F);
            this.comboBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.comboBox1.DefaultValue = new string[0];
            this.comboBox1.DropDownHeight = 280;
            this.comboBox1.Flex = 1;
            this.comboBox1.ListBackgroundColor = System.Drawing.Color.White;
            this.comboBox1.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 35);
            this.comboBox1.Press += new Swebui.Controls.TreeSelect.TreeSelectOnPressEventHandler(this.comboBox1_Press);
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel10,
            this.label1,
            this.label4});
            this.panel5.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel5.Margin = new Swebui.Controls.Margin(10F, 10F, 10F, 0F);
            this.panel5.Name = "panel5";
            this.panel5.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel5.Size = new System.Drawing.Size(0, 30);
            // 
            // panel10
            // 
            this.panel10.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label8,
            this.label14,
            this.checkAll1});
            this.panel10.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel10.Flex = 1;
            this.panel10.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(300, 30);
            // 
            // label8
            // 
            this.label8.Flex = 1;
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 35);
            this.label8.Text = "部门成员";
            this.label8.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label14
            // 
            this.label14.ForeColor = System.Drawing.Color.Silver;
            this.label14.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Right;
            this.label14.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 35);
            this.label14.Text = "全选";
            this.label14.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // checkAll1
            // 
            this.checkAll1.BackColor = System.Drawing.Color.Transparent;
            this.checkAll1.BorderColor = System.Drawing.Color.Black;
            this.checkAll1.BorderRadius = 0;
            this.checkAll1.Name = "checkAll1";
            this.checkAll1.Size = new System.Drawing.Size(22, 0);
            // 
            // label1
            // 
            this.label1.Flex = 1;
            this.label1.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 0);
            // 
            // label4
            // 
            this.label4.Flex = 1;
            this.label4.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 0);
            // 
            // panel6
            // 
            this.panel6.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel8,
            this.label6,
            this.label7});
            this.panel6.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel6.Flex = 1;
            this.panel6.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel6.Name = "panel6";
            this.panel6.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel6.Size = new System.Drawing.Size(0, 0);
            // 
            // panel8
            // 
            this.panel8.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.listView1,
            this.info});
            this.panel8.Flex = 1;
            this.panel8.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(300, 0);
            // 
            // listView1
            // 
            this.listView1.Border = new Swebui.Controls.Border(1F);
            this.listView1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.listView1.Flex = 1;
            this.listView1.Name = "listView1";
            this.listView1.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listView1.Size = new System.Drawing.Size(0, 0);
            this.listView1.TemplateControlName = "FrmDepAssignUserLayout";
            // 
            // info
            // 
            this.info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(0, 35);
            this.info.Text = "注：请先选择部门负责人";
            this.info.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Flex = 1;
            this.label6.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 0);
            // 
            // label7
            // 
            this.label7.Flex = 1;
            this.label7.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 0);
            // 
            // FrmDepartCreate
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel2,
            this.panel3,
            this.panel4,
            this.panel5,
            this.panel6});
            this.Load += new System.EventHandler(this.FrmDepartCreate_Load);

        }
        #endregion

        private Panel panel1;
        private Label titleLab;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Label label3;
        private Panel panel4;
        private Panel panel5;
        private Label label5;
        private Panel panel6;
        private TextBox txtDep_Name;
        private TreeSelect comboBox1;
        private Button BackBtn;
        private Button SaveBtn;
        private Button DeleteBtn;
        private Panel panel10;
        private Label label8;
        private Label label14;
        private Panel panel7;
        private Image image1;
        private Button button1;
        private Panel panel8;
        private ListView listView1;
        private Label info;
        private CheckBox checkAll1;
        private Label label1;
        private Label label4;
        private Label label6;
        private Label label7;
    }
}