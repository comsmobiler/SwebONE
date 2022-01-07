using Swebui.Controls;
using System;

namespace SwebONE.Layout
{
    partial class FrmCostTemplet : Swebui.Controls.SwebUserControl
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
            this.lblInfor = new Swebui.Controls.Label();
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
            this.titleLab.Text = "模板选择";
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
            this.listView1.TemplateControlName = "FrmCostListTemplet";
            // 
            // lblInfor
            // 
            this.lblInfor.ForeColor = System.Drawing.Color.Silver;
            this.lblInfor.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 10F);
            this.lblInfor.Name = "lblInfor";
            this.lblInfor.Size = new System.Drawing.Size(0, 30);
            this.lblInfor.Text = "当前暂无成本中心模板，请创建！";
            this.lblInfor.Visible = false;
            // 
            // FrmCostTemplet
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.listView1,
            this.lblInfor});
            this.Size = new System.Drawing.Size(600, 400);
            this.Load += new System.EventHandler(this.FrmCostTemplet_Load);

        }
        #endregion

        private Panel panel1;
        private Label titleLab;
        private Button button1;
        private ListView listView1;
        private Label lblInfor;
    }
}