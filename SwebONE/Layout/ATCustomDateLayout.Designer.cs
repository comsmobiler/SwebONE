using Swebui.Controls;
using System;

namespace SwebONE.Layout
{
    partial class ATCustomDateLayout : Swebui.Controls.SwebUserControl
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
            this.gridView1 = new Swebui.Controls.GridView();
            this.lblinfo = new Swebui.Controls.Label();
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
            this.titleLab.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.titleLab.Name = "titleLab";
            this.titleLab.Size = new System.Drawing.Size(100, 26);
            this.titleLab.Text = "自定义日期列表";
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.gridView1});
            this.panel2.Flex = 1;
            this.panel2.Margin = new Swebui.Controls.Margin(10F, 10F, 10F, 0F);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 100);
            // 
            // gridView1
            // 
            this.gridView1.AllowPaging = true;
            this.gridView1.DataSource = null;
            this.gridView1.Flex = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowWidth = 0;
            this.gridView1.Size = new System.Drawing.Size(0, 30);
            // 
            // lblinfo
            // 
            this.lblinfo.Flex = 1;
            this.lblinfo.ForeColor = System.Drawing.Color.Silver;
            this.lblinfo.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.lblinfo.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 10F);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(0, 35);
            this.lblinfo.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            this.lblinfo.Visible = false;
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
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Border = new Swebui.Controls.Border(1F);
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.btnSave.Name = "btnSave";
            this.btnSave.NumberOfLines = 0;
            this.btnSave.Size = new System.Drawing.Size(71, 30);
            this.btnSave.Text = "关闭";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ATCustomDateLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel2,
            this.lblinfo,
            this.panel5});
            this.Size = new System.Drawing.Size(600, 400);
            this.Load += new System.EventHandler(this.ATCoustomDateLayout_Load);

        }
        #endregion

        private Panel panel1;
        private Label titleLab;
        private Panel panel2;
        private GridView gridView1;
        private Label lblinfo;
        private Panel panel5;
        private Label lblDesc;
        private Button btnSave;
    }
}