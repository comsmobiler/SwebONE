using Swebui.Controls;
using System;

namespace SwebONE.Layout
{
    partial class RBItemLayout : Swebui.Controls.SwebUserControl
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
            this.deleteBtn = new Swebui.Controls.Button();
            this.typeCom = new Swebui.Controls.ComboBox();
            this.amountTxt = new Swebui.Controls.TextBox();
            this.rbDate = new Swebui.Controls.DatePicker();
            this.noteTxt = new Swebui.Controls.TextBox();
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.Border = new Swebui.Controls.Border(0F, 0F, 1F, 0F);
            this.deleteBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.deleteBtn.Flex = 1;
            this.deleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteBtn.IconName = "fa fa-times-circle-o";
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.NumberOfLines = 0;
            this.deleteBtn.Size = new System.Drawing.Size(100, 35);
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // typeCom
            // 
            this.typeCom.Border = new Swebui.Controls.Border(0F, 0F, 1F, 0F);
            this.typeCom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.typeCom.Flex = 1;
            this.typeCom.Name = "typeCom";
            this.typeCom.Placeholder = "";
            this.typeCom.PopupHeight = 0;
            this.typeCom.Size = new System.Drawing.Size(100, 35);
            this.typeCom.Text = "";
            this.typeCom.ValueChanged += new System.EventHandler(this.typeCom_ValueChanged_1);
            // 
            // amountTxt
            // 
            this.amountTxt.Border = new Swebui.Controls.Border(0F, 0F, 1F, 0F);
            this.amountTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.amountTxt.Flex = 1;
            this.amountTxt.Name = "amountTxt";
            this.amountTxt.Size = new System.Drawing.Size(100, 35);
            // 
            // rbDate
            // 
            this.rbDate.Border = new Swebui.Controls.Border(0F, 0F, 1F, 0F);
            this.rbDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.rbDate.Flex = 1;
            this.rbDate.MaxDate = new System.DateTime(9997, 12, 31, 23, 59, 59, 999);
            this.rbDate.MinDate = new System.DateTime(((long)(0)));
            this.rbDate.Name = "rbDate";
            this.rbDate.Size = new System.Drawing.Size(100, 35);
            this.rbDate.Value = new System.DateTime(2021, 11, 9, 16, 43, 24, 58);
            // 
            // noteTxt
            // 
            this.noteTxt.Flex = 1;
            this.noteTxt.Name = "noteTxt";
            this.noteTxt.Size = new System.Drawing.Size(100, 35);
            // 
            // RBItemLayout
            // 
            this.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.deleteBtn,
            this.typeCom,
            this.amountTxt,
            this.rbDate,
            this.noteTxt});
            this.Direction = Swebui.Controls.LayoutDirection.Row;
            this.Size = new System.Drawing.Size(0, 35);
            this.Load += new System.EventHandler(this.RBItemLayout_Load);

        }
        #endregion

        private Button deleteBtn;
        private ComboBox typeCom;
        private TextBox amountTxt;
        private DatePicker rbDate;
        private TextBox noteTxt;
    }
}