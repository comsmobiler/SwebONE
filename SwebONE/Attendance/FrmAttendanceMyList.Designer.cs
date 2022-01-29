using Swebui.Controls;
using System;

namespace SwebONE.Attendance
{
    partial class FrmAttendanceMyList : Swebui.Controls.SwebUserControl
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
            this.panel1 = new Swebui.Controls.Panel();
            this.label1 = new Swebui.Controls.Label();
            this.panel2 = new Swebui.Controls.Panel();
            this.btnYear = new Swebui.Controls.TreeSelect();
            this.label3 = new Swebui.Controls.Label();
            this.btnMonth = new Swebui.Controls.TreeSelect();
            this.label2 = new Swebui.Controls.Label();
            this.gridView1 = new Swebui.Controls.GridView();
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
            this.label1.Text = "我的考勤";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
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
            // gridView1
            // 
            this.gridView1.AllowPaging = true;
            gridViewColumn1.DisplayMember = "Day";
            gridViewColumn1.HeaderText = "日期";
            gridViewColumn2.DisplayMember = "Description";
            gridViewColumn2.HeaderText = "签到描述";
            gridViewColumn3.DisplayMember = "OnTime";
            gridViewColumn3.HeaderText = "应签到时间";
            gridViewColumn4.DisplayMember = "Action";
            gridViewColumn4.HeaderText = "签到或签退";
            gridViewColumn5.DisplayMember = "Time";
            gridViewColumn5.HeaderText = "签到时间";
            gridViewColumn6.DisplayMember = "Info";
            gridViewColumn6.HeaderText = "迟到/早退理由";
            this.gridView1.Columns.AddRange(new Swebui.Controls.GridViewColumn[] {
            gridViewColumn1,
            gridViewColumn2,
            gridViewColumn3,
            gridViewColumn4,
            gridViewColumn5,
            gridViewColumn6});
            this.gridView1.DataSource = null;
            this.gridView1.Flex = 1;
            this.gridView1.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.gridView1.Name = "gridView1";
            this.gridView1.RowWidth = 0;
            this.gridView1.Size = new System.Drawing.Size(0, 30);
            // 
            // FrmAttendanceMyList
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel2,
            this.gridView1});
            this.Load += new System.EventHandler(this.FrmAttendanceMyList_Load);

        }
        #endregion
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private GridView gridView1;
        private TreeSelect btnYear;
        private Label label3;
        private TreeSelect btnMonth;
        private Label label2;
    }
}