using Swebui.Controls;
using System;

namespace SwebONE.RB
{
    partial class FrmRBCreate : Swebui.Controls.SwebUserControl
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
            this.lblRBNO = new Swebui.Controls.Label();
            this.panel2 = new Swebui.Controls.Panel();
            this.BackBtn = new Swebui.Controls.Button();
            this.SaveBtn = new Swebui.Controls.Button();
            this.panel3 = new Swebui.Controls.Panel();
            this.label2 = new Swebui.Controls.Label();
            this.label3 = new Swebui.Controls.Label();
            this.label4 = new Swebui.Controls.Label();
            this.panel4 = new Swebui.Controls.Panel();
            this.comboBox1 = new Swebui.Controls.TreeSelect();
            this.TxtNote = new Swebui.Controls.TextBox();
            this.label5 = new Swebui.Controls.Label();
            this.panel5 = new Swebui.Controls.Panel();
            this.label6 = new Swebui.Controls.Label();
            this.label7 = new Swebui.Controls.Label();
            this.label8 = new Swebui.Controls.Label();
            this.panel6 = new Swebui.Controls.Panel();
            this.AddRow = new Swebui.Controls.Button();
            this.panel7 = new Swebui.Controls.Panel();
            this.label9 = new Swebui.Controls.Label();
            this.label10 = new Swebui.Controls.Label();
            this.label11 = new Swebui.Controls.Label();
            this.label12 = new Swebui.Controls.Label();
            this.label13 = new Swebui.Controls.Label();
            this.ItemPanels = new Swebui.Controls.Panel();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.titleLab,
            this.lblRBNO});
            this.panel1.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel1.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel1.Name = "panel1";
            this.panel1.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel1.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.panel1.Size = new System.Drawing.Size(0, 46);
            // 
            // titleLab
            // 
            this.titleLab.FontSize = 24F;
            this.titleLab.Name = "titleLab";
            this.titleLab.Size = new System.Drawing.Size(0, 26);
            this.titleLab.Text = "报销新增";
            this.titleLab.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
            // 
            // lblRBNO
            // 
            this.lblRBNO.FontSize = 18F;
            this.lblRBNO.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.lblRBNO.Name = "lblRBNO";
            this.lblRBNO.Size = new System.Drawing.Size(0, 26);
            this.lblRBNO.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
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
            this.label2.Text = "成本中心";
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Flex = 1;
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 0);
            this.label3.Text = "报销备注";
            this.label3.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Flex = 1;
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 0);
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.comboBox1,
            this.TxtNote,
            this.label5});
            this.panel4.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel4.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel4.Name = "panel4";
            this.panel4.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel4.Size = new System.Drawing.Size(0, 35);
            // 
            // comboBox1
            // 
            this.comboBox1.Border = new Swebui.Controls.Border(1F);
            this.comboBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.comboBox1.DefaultValue = new string[0];
            this.comboBox1.DropDownHeight = 280;
            this.comboBox1.Flex = 1;
            this.comboBox1.ListBackgroundColor = System.Drawing.Color.White;
            this.comboBox1.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 35);
            this.comboBox1.Press += new Swebui.Controls.TreeSelect.TreeSelectOnPressEventHandler(this.comboBox1_Press);
            // 
            // TxtNote
            // 
            this.TxtNote.Border = new Swebui.Controls.Border(1F);
            this.TxtNote.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.TxtNote.Flex = 1;
            this.TxtNote.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.TxtNote.Name = "TxtNote";
            this.TxtNote.Size = new System.Drawing.Size(100, 0);
            // 
            // label5
            // 
            this.label5.Flex = 1;
            this.label5.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 0);
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label6,
            this.label7,
            this.label8});
            this.panel5.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel5.Margin = new Swebui.Controls.Margin(10F, 10F, 10F, 0F);
            this.panel5.Name = "panel5";
            this.panel5.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel5.Size = new System.Drawing.Size(0, 30);
            // 
            // label6
            // 
            this.label6.Flex = 1;
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 0);
            this.label6.Text = "报销明细";
            this.label6.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Flex = 1;
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 0);
            // 
            // label8
            // 
            this.label8.Flex = 1;
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 0);
            // 
            // panel6
            // 
            this.panel6.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.AddRow});
            this.panel6.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel6.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel6.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel6.Name = "panel6";
            this.panel6.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel6.Size = new System.Drawing.Size(0, 35);
            // 
            // AddRow
            // 
            this.AddRow.BackColor = System.Drawing.Color.White;
            this.AddRow.Border = new Swebui.Controls.Border(1F);
            this.AddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.AddRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.AddRow.Name = "AddRow";
            this.AddRow.NumberOfLines = 0;
            this.AddRow.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.AddRow.Size = new System.Drawing.Size(0, 26);
            this.AddRow.Text = "增加一行";
            this.AddRow.Click += new System.EventHandler(this.AddRow_Click);
            // 
            // panel7
            // 
            this.panel7.Border = new Swebui.Controls.Border(1F);
            this.panel7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel7.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label9,
            this.label10,
            this.label11,
            this.label12,
            this.label13});
            this.panel7.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel7.Margin = new Swebui.Controls.Margin(10F, 10F, 10F, 0F);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(0, 35);
            // 
            // label9
            // 
            this.label9.Border = new Swebui.Controls.Border(0F, 0F, 1F, 0F);
            this.label9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label9.Flex = 1;
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 35);
            this.label9.Text = "状态列";
            this.label9.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Border = new Swebui.Controls.Border(0F, 0F, 1F, 0F);
            this.label10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label10.Flex = 1;
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 35);
            this.label10.Text = "消费类型";
            this.label10.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label11
            // 
            this.label11.Border = new Swebui.Controls.Border(0F, 0F, 1F, 0F);
            this.label11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label11.Flex = 1;
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 35);
            this.label11.Text = "消费金额";
            this.label11.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label12
            // 
            this.label12.Border = new Swebui.Controls.Border(0F, 0F, 1F, 0F);
            this.label12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label12.Flex = 1;
            this.label12.ForeColor = System.Drawing.Color.Silver;
            this.label12.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 35);
            this.label12.Text = "消费日期";
            this.label12.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label13
            // 
            this.label13.Flex = 1;
            this.label13.ForeColor = System.Drawing.Color.Silver;
            this.label13.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 35);
            this.label13.Text = "备注";
            this.label13.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // ItemPanels
            // 
            this.ItemPanels.Border = new Swebui.Controls.Border(1F, 0F, 1F, 1F);
            this.ItemPanels.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ItemPanels.Flex = 1;
            this.ItemPanels.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 10F);
            this.ItemPanels.Name = "ItemPanels";
            this.ItemPanels.Size = new System.Drawing.Size(0, 35);
            // 
            // FrmRBCreate
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel2,
            this.panel3,
            this.panel4,
            this.panel5,
            this.panel6,
            this.panel7,
            this.ItemPanels});
            this.Load += new System.EventHandler(this.FrmRBCreate_Load);

        }
        #endregion

        private Panel panel1;
        private Label titleLab;
        private Panel panel2;
        private Button BackBtn;
        private Button SaveBtn;
        private Panel panel3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel4;
        private TreeSelect comboBox1;
        private Panel panel5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Panel panel6;
        private Button AddRow;
        private Panel panel7;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Panel ItemPanels;
        private TextBox TxtNote;
        private Label label5;
        private Label lblRBNO;
    }
}