using Swebui.Controls;
using System;

namespace SwebONE.Layout
{
    partial class FrmDepAssignUserLayout : Swebui.Controls.SwebUserControl
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
            this.lblDep = new Swebui.Controls.Label();
            this.Check = new Swebui.Controls.CheckBox();
            // 
            // image1
            // 
            this.image1.BorderRadius = 45;
            this.image1.DataMember = "U_Portrait";
            this.image1.DisplayMember = "U_Portrait";
            this.image1.Margin = new Swebui.Controls.Margin(5F, 0F, 0F, 0F);
            this.image1.Name = "image1";
            this.image1.ResourceID = "";
            this.image1.Size = new System.Drawing.Size(45, 45);
            this.image1.SizeMode = Swebui.Controls.ImageSizeMode.Stretch;
            // 
            // lblUser
            // 
            this.lblUser.DataMember = "U_ID";
            this.lblUser.DisplayMember = "U_Name";
            this.lblUser.Flex = 1;
            this.lblUser.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(100, 45);
            this.lblUser.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // lblDep
            // 
            this.lblDep.DataMember = "U_DepID";
            this.lblDep.DisplayMember = "U_DepName";
            this.lblDep.Flex = 1;
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(100, 45);
            this.lblDep.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // Check
            // 
            this.Check.BackColor = System.Drawing.Color.Transparent;
            this.Check.BorderColor = System.Drawing.Color.Black;
            this.Check.BorderRadius = 0;
            this.Check.DataMember = "SelectCheck";
            this.Check.DisplayMember = "SelectCheck";
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(36, 35);
            this.Check.CheckedChanged += new System.EventHandler(this.Check_CheckedChanged);
            // 
            // FrmDepAssignUserLayout
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.image1,
            this.lblUser,
            this.lblDep,
            this.Check});
            this.Direction = Swebui.Controls.LayoutDirection.Row;
            this.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.Size = new System.Drawing.Size(0, 54);

        }
        #endregion

        private Image image1;
        public CheckBox Check;
        public Label lblUser;
        public Label lblDep;
    }
}