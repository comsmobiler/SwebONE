using Swebui.Controls;
using System;

namespace SwebONE.Layout
{
    partial class ATUserLayout : Swebui.Controls.SwebUserControl
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
            this.lblUser = new Swebui.Controls.Label();
            this.label2 = new Swebui.Controls.Label();
            this.Check = new Swebui.Controls.CheckBox();
            // 
            // image1
            // 
            this.image1.BorderRadius = 45;
            this.image1.DataMember = "U_Portrait";
            this.image1.DisplayMember = "U_Portrait";
            this.image1.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.image1.Name = "image1";
            this.image1.ResourceID = "";
            this.image1.Size = new System.Drawing.Size(45, 45);
            this.image1.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // lblUser
            // 
            this.lblUser.DataMember = "U_ID";
            this.lblUser.DisplayMember = "U_Name";
            this.lblUser.Flex = 1;
            this.lblUser.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(100, 45);
            // 
            // label2
            // 
            this.label2.DataMember = "U_DepID";
            this.label2.DisplayMember = "U_DepName";
            this.label2.Flex = 1;
            this.label2.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 45);
            // 
            // Check
            // 
            this.Check.BackColor = System.Drawing.Color.Transparent;
            this.Check.BorderColor = System.Drawing.Color.Black;
            this.Check.BorderRadius = 0;
            this.Check.DataMember = "SelectCheck";
            this.Check.DisplayMember = "SelectCheck";
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(35, 35);
            this.Check.CheckedChanged += new System.EventHandler(this.Check_CheckedChanged);
            // 
            // ATUserLayout
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.image1,
            this.lblUser,
            this.label2,
            this.Check});
            this.Direction = Swebui.Controls.LayoutDirection.Row;
            this.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.Size = new System.Drawing.Size(0, 54);

        }
        #endregion

        private Image image1;
        private Label label2;
        public CheckBox Check;
        public Label lblUser;
    }
}