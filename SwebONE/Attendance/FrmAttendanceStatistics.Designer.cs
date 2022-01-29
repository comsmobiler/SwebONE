using Swebui.Controls;
using System;

namespace SwebONE.Attendance
{
    partial class FrmAttendanceStatistics : Swebui.Controls.SwebUserControl
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
            Swebui.Controls.GridViewColumn gridViewColumn1 = new Swebui.Controls.GridViewColumn();
            Swebui.Controls.GridViewColumn gridViewColumn2 = new Swebui.Controls.GridViewColumn();
            Swebui.Controls.GridViewColumn gridViewColumn3 = new Swebui.Controls.GridViewColumn();
            Swebui.Controls.GridViewColumn gridViewColumn4 = new Swebui.Controls.GridViewColumn();
            Swebui.Controls.GridViewColumn gridViewColumn5 = new Swebui.Controls.GridViewColumn();
            Swebui.Controls.GridViewColumn gridViewColumn6 = new Swebui.Controls.GridViewColumn();
            Swebui.Controls.GridViewColumn gridViewColumn7 = new Swebui.Controls.GridViewColumn();
            this.panel1 = new Swebui.Controls.Panel();
            this.label1 = new Swebui.Controls.Label();
            this.panel2 = new Swebui.Controls.Panel();
            this.TabBtn1 = new Swebui.Controls.Button();
            this.TabBtn = new Swebui.Controls.Button();
            this.btnYear = new Swebui.Controls.TreeSelect();
            this.label3 = new Swebui.Controls.Label();
            this.btnMonth = new Swebui.Controls.TreeSelect();
            this.label2 = new Swebui.Controls.Label();
            this.panel3 = new Swebui.Controls.Panel();
            this.gridATdata = new Swebui.Controls.GridView();
            this.panel4 = new Swebui.Controls.Panel();
            this.gridATdata1 = new Swebui.Controls.GridView();
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
            this.label1.Size = new System.Drawing.Size(135, 26);
            this.label1.Text = "考勤统计";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.TabBtn1,
            this.TabBtn,
            this.btnYear,
            this.label3,
            this.btnMonth,
            this.label2});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel2.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 15F);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.panel2.Size = new System.Drawing.Size(0, 46);
            // 
            // TabBtn1
            // 
            this.TabBtn1.BackColor = System.Drawing.Color.White;
            this.TabBtn1.Border = new Swebui.Controls.Border(1F);
            this.TabBtn1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.TabBtn1.ForeColor = System.Drawing.Color.DimGray;
            this.TabBtn1.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.TabBtn1.Name = "TabBtn1";
            this.TabBtn1.NumberOfLines = 0;
            this.TabBtn1.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.TabBtn1.Size = new System.Drawing.Size(0, 35);
            this.TabBtn1.Text = "人员统计";
            this.TabBtn1.Click += new System.EventHandler(this.TabBtn1_Click);
            // 
            // TabBtn
            // 
            this.TabBtn.BackColor = System.Drawing.Color.White;
            this.TabBtn.Border = new Swebui.Controls.Border(1F);
            this.TabBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.TabBtn.ForeColor = System.Drawing.Color.DimGray;
            this.TabBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.TabBtn.Name = "TabBtn";
            this.TabBtn.NumberOfLines = 0;
            this.TabBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.TabBtn.Size = new System.Drawing.Size(0, 35);
            this.TabBtn.Text = "天数统计";
            this.TabBtn.Click += new System.EventHandler(this.TabBtn1_Click);
            // 
            // btnYear
            // 
            this.btnYear.Border = new Swebui.Controls.Border(1F);
            this.btnYear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.btnYear.DefaultValue = new string[0];
            this.btnYear.DropDownHeight = 280;
            this.btnYear.ListBackgroundColor = System.Drawing.Color.White;
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(100, 35);
            this.btnYear.Press += new Swebui.Controls.TreeSelect.TreeSelectOnPressEventHandler(this.btnYear_Press);
            // 
            // label3
            // 
            this.label3.Margin = new Swebui.Controls.Margin(5F, 0F, 0F, 0F);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 28);
            this.label3.Text = "年";
            this.label3.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // btnMonth
            // 
            this.btnMonth.Border = new Swebui.Controls.Border(1F);
            this.btnMonth.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.btnMonth.DefaultValue = new string[0];
            this.btnMonth.DropDownHeight = 280;
            this.btnMonth.ListBackgroundColor = System.Drawing.Color.White;
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(100, 35);
            this.btnMonth.Press += new Swebui.Controls.TreeSelect.TreeSelectOnPressEventHandler(this.btnMonth_Press);
            // 
            // label2
            // 
            this.label2.Margin = new Swebui.Controls.Margin(5F, 0F, 0F, 0F);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 28);
            this.label2.Text = "月";
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.gridATdata});
            this.panel3.Flex = 1;
            this.panel3.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 10F);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 100);
            // 
            // gridATdata
            // 
            this.gridATdata.AllowPaging = true;
            gridViewColumn1.DisplayMember = "Name";
            gridViewColumn1.HeaderText = "姓名";
            gridViewColumn2.DisplayMember = "Total";
            gridViewColumn2.HeaderText = "应签到";
            gridViewColumn3.DisplayMember = "Al";
            gridViewColumn3.HeaderText = "准时";
            gridViewColumn4.DisplayMember = "Late";
            gridViewColumn4.HeaderText = "迟到";
            gridViewColumn5.DisplayMember = "Early";
            gridViewColumn5.HeaderText = "早退";
            gridViewColumn6.DisplayMember = "No";
            gridViewColumn6.HeaderText = "未签";
            this.gridATdata.Columns.AddRange(new Swebui.Controls.GridViewColumn[] {
            gridViewColumn1,
            gridViewColumn2,
            gridViewColumn3,
            gridViewColumn4,
            gridViewColumn5,
            gridViewColumn6});
            this.gridATdata.DataSource = null;
            this.gridATdata.Flex = 1;
            this.gridATdata.Name = "gridATdata";
            this.gridATdata.RowWidth = 0;
            this.gridATdata.Size = new System.Drawing.Size(0, 30);
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.gridATdata1});
            this.panel4.Flex = 1;
            this.panel4.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 10F);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 100);
            // 
            // gridATdata1
            // 
            this.gridATdata1.AllowPaging = true;
            gridViewColumn7.DisplayMember = "Day";
            gridViewColumn7.HeaderText = "日期";
            this.gridATdata1.Columns.AddRange(new Swebui.Controls.GridViewColumn[] {
            gridViewColumn7});
            this.gridATdata1.DataSource = null;
            this.gridATdata1.Flex = 1;
            this.gridATdata1.Name = "gridATdata1";
            this.gridATdata1.RowClickEventRaise = true;
            this.gridATdata1.RowWidth = 0;
            this.gridATdata1.Size = new System.Drawing.Size(0, 30);
            this.gridATdata1.RowClick += new Swebui.Controls.GridViewRowClickEventHandler(this.gridATdata1_RowClick);
            // 
            // FrmAttendanceStatistics
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel2,
            this.panel3,
            this.panel4});
            this.Load += new System.EventHandler(this.FrmAttendanceStatistics_Load);

        }
        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button TabBtn1;
        private Button TabBtn;
        private Panel panel3;
        private GridView gridATdata;
        private Panel panel4;
        private GridView gridATdata1;
        private TreeSelect btnYear;
        private Label label3;
        private TreeSelect btnMonth;
        private Label label2;
    }
}