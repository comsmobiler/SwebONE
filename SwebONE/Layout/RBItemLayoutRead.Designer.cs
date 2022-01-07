using Swebui.Controls;
using System;

namespace SwebONE.Layout
{
    partial class RBItemLayoutRead : Swebui.Controls.SwebUserControl
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
            this.typeCom = new Swebui.Controls.Label();
            this.amountTxt = new Swebui.Controls.Label();
            this.rbDate = new Swebui.Controls.Label();
            this.noteTxt = new Swebui.Controls.Label();
            // 
            // typeCom
            // 
            this.typeCom.Border = new Swebui.Controls.Border(0F, 0F, 1F, 0F);
            this.typeCom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.typeCom.Flex = 1;
            this.typeCom.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.typeCom.Name = "typeCom";
            this.typeCom.Size = new System.Drawing.Size(100, 35);
            this.typeCom.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // amountTxt
            // 
            this.amountTxt.Border = new Swebui.Controls.Border(0F, 0F, 1F, 0F);
            this.amountTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.amountTxt.Flex = 1;
            this.amountTxt.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.amountTxt.Name = "amountTxt";
            this.amountTxt.Size = new System.Drawing.Size(100, 35);
            this.amountTxt.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // rbDate
            // 
            this.rbDate.Border = new Swebui.Controls.Border(0F, 0F, 1F, 0F);
            this.rbDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.rbDate.Flex = 1;
            this.rbDate.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.rbDate.Name = "rbDate";
            this.rbDate.Size = new System.Drawing.Size(100, 35);
            this.rbDate.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // noteTxt
            // 
            this.noteTxt.Flex = 1;
            this.noteTxt.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.noteTxt.Name = "noteTxt";
            this.noteTxt.Size = new System.Drawing.Size(100, 35);
            this.noteTxt.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // RBItemLayoutRead
            // 
            this.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.typeCom,
            this.amountTxt,
            this.rbDate,
            this.noteTxt});
            this.Direction = Swebui.Controls.LayoutDirection.Row;
            this.Size = new System.Drawing.Size(0, 35);
            this.Load += new System.EventHandler(this.RBItemLayout_Load);

        }
        #endregion

        private Label typeCom;
        private Label amountTxt;
        private Label rbDate;
        private Label noteTxt;
    }
}