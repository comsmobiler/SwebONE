using Swebui.Controls;
using System;

namespace SwebONE.Layout
{
    partial class FrmDepUserLayout : Swebui.Controls.SwebUserControl
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
            this.image1 = new Swebui.Controls.Image();
            this.label1 = new Swebui.Controls.Label();
            // 
            // image1
            // 
            this.image1.BorderRadius = 60;
            this.image1.Name = "image1";
            this.image1.ResourceID = "";
            this.image1.Size = new System.Drawing.Size(60, 60);
            this.image1.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // label1
            // 
            this.label1.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 40);
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // FrmDepUserLayout
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.image1,
            this.label1});
            this.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.Center;
            this.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.Size = new System.Drawing.Size(100, 100);

        }
        #endregion

        private Image image1;
        private Label label1;
    }
}