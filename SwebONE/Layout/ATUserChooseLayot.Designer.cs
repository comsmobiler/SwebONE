using Swebui.Controls;
using System;

namespace SwebONE.Layout
{
    partial class ATUserChooseLayot : Swebui.Controls.SwebUserControl
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
            this.listView1 = new Swebui.Controls.ListView();
            this.panel2 = new Swebui.Controls.Panel();
            this.label1 = new Swebui.Controls.Label();
            this.checkAll1 = new Swebui.Controls.CheckBox();
            this.panel3 = new Swebui.Controls.Panel();
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
            this.titleLab.Text = "考勤成员选择";
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
            // listView1
            // 
            this.listView1.Flex = 1;
            this.listView1.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 10F);
            this.listView1.Name = "listView1";
            this.listView1.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listView1.Size = new System.Drawing.Size(0, 300);
            this.listView1.TemplateControlName = "ATUserLayout";
            // 
            // panel2
            // 
            this.panel2.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.checkAll1});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.Name = "panel2";
            this.panel2.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.panel2.Size = new System.Drawing.Size(0, 35);
            // 
            // label1
            // 
            this.label1.Flex = 1;
            this.label1.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Right;
            this.label1.Margin = new Swebui.Controls.Margin(20F, 0F, 10F, 0F);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 0);
            this.label1.Text = "全选";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // checkAll1
            // 
            this.checkAll1.BackColor = System.Drawing.Color.Transparent;
            this.checkAll1.BorderColor = System.Drawing.Color.Black;
            this.checkAll1.BorderRadius = 0;
            this.checkAll1.DataMember = "SelectCheck";
            this.checkAll1.DisplayMember = "SelectCheck";
            this.checkAll1.Name = "checkAll1";
            this.checkAll1.Size = new System.Drawing.Size(35, 35);
            this.checkAll1.CheckedChanged += new System.EventHandler(this.checkAll1_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Border = new Swebui.Controls.Border(0F, 1F, 0F, 0F);
            this.panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.lblDesc,
            this.btnSave});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel3.Name = "panel3";
            this.panel3.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.panel3.Size = new System.Drawing.Size(0, 45);
            // 
            // lblDesc
            // 
            this.lblDesc.Flex = 1;
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(100, 30);
            this.lblDesc.Text = "已选中 0 人";
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
            // ATUserChooseLayot
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel2,
            this.listView1,
            this.panel3});
            this.Size = new System.Drawing.Size(600, 400);
            this.Load += new System.EventHandler(this.ATUserChooseLayot_Load);

        }
        #endregion

        private Panel panel1;
        private Label titleLab;
        private Button button1;
        private ListView listView1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private CheckBox checkAll1;
        private Label lblDesc;
        private Button btnSave;
    }
}