using Swebui.Controls;
using System;

namespace SwebONE.Layout
{
    partial class CCDetialLayout : Swebui.Controls.SwebUserControl
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
            this.idLab = new Swebui.Controls.Label();
            this.dateLab = new Swebui.Controls.Label();
            this.typeLab = new Swebui.Controls.Label();
            this.amoutLab = new Swebui.Controls.Label();
            this.userLab = new Swebui.Controls.Label();
            // 
            // idLab
            // 
            this.idLab.Border = new Swebui.Controls.Border(0F, 0F, 1F, 0F);
            this.idLab.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.idLab.Flex = 1;
            this.idLab.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.idLab.Name = "idLab";
            this.idLab.Size = new System.Drawing.Size(100, 35);
            this.idLab.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // dateLab
            // 
            this.dateLab.Border = new Swebui.Controls.Border(0F, 0F, 1F, 0F);
            this.dateLab.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.dateLab.Flex = 1;
            this.dateLab.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.dateLab.Name = "dateLab";
            this.dateLab.Size = new System.Drawing.Size(100, 35);
            this.dateLab.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // typeLab
            // 
            this.typeLab.Border = new Swebui.Controls.Border(0F, 0F, 1F, 0F);
            this.typeLab.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.typeLab.Flex = 1;
            this.typeLab.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.typeLab.Name = "typeLab";
            this.typeLab.Size = new System.Drawing.Size(100, 35);
            this.typeLab.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // amoutLab
            // 
            this.amoutLab.Border = new Swebui.Controls.Border(0F, 0F, 1F, 0F);
            this.amoutLab.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.amoutLab.Flex = 1;
            this.amoutLab.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.amoutLab.Name = "amoutLab";
            this.amoutLab.Size = new System.Drawing.Size(100, 35);
            this.amoutLab.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // userLab
            // 
            this.userLab.Flex = 1;
            this.userLab.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.userLab.Name = "userLab";
            this.userLab.Size = new System.Drawing.Size(100, 35);
            this.userLab.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // CCDetialLayout
            // 
            this.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.idLab,
            this.dateLab,
            this.typeLab,
            this.amoutLab,
            this.userLab});
            this.Direction = Swebui.Controls.LayoutDirection.Row;
            this.Size = new System.Drawing.Size(0, 35);
            this.Load += new System.EventHandler(this.CCDetialLayout_Load);

        }
        #endregion

        private Label idLab;
        private Label dateLab;
        private Label typeLab;
        private Label amoutLab;
        private Label userLab;
    }
}