using Swebui.Controls;
using System;

namespace SwebONE.Layout
{
    partial class WorkButton : Swebui.Controls.SwebUserControl
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
            this.image1 = new Swebui.Controls.Image();
            this.label1 = new Swebui.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.image1,
            this.label1});
            this.panel1.Flex = 1;
            this.panel1.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 120);
            this.panel1.Touchable = true;
            this.panel1.Press += new System.EventHandler(this.panel1_Press);
            // 
            // image1
            // 
            this.image1.Margin = new Swebui.Controls.Margin(0F, 15F, 0F, 0F);
            this.image1.Name = "image1";
            this.image1.ResourceID = "";
            this.image1.Size = new System.Drawing.Size(60, 50);
            this.image1.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // label1
            // 
            this.label1.Margin = new Swebui.Controls.Margin(0F, 10F, 0F, 0F);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 35);
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // WorkButton
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1});
            this.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.Center;
            this.Size = new System.Drawing.Size(120, 120);

        }
        #endregion

        private Panel panel1;
        private Image image1;
        private Label label1;
    }
}