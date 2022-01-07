using Swebui.Controls;
using System;

namespace SwebONE.Layout
{
    partial class ATMainLayout : Swebui.Controls.SwebUserControl
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
            this.lblType = new Swebui.Controls.Label();
            this.lblTime = new Swebui.Controls.Label();
            this.lblInfo = new Swebui.Controls.Label();
            this.panel1 = new Swebui.Controls.Panel();
            this.btnCheck = new Swebui.Controls.Button();
            // 
            // image1
            // 
            this.image1.DisplayMember = "Picture";
            this.image1.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.image1.Name = "image1";
            this.image1.ResourceID = "";
            this.image1.Size = new System.Drawing.Size(50, 50);
            this.image1.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // lblType
            // 
            this.lblType.DataMember = "ID";
            this.lblType.DisplayMember = "Description";
            this.lblType.Flex = 1;
            this.lblType.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(100, 34);
            // 
            // lblTime
            // 
            this.lblTime.DisplayMember = "Time";
            this.lblTime.Flex = 1;
            this.lblTime.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(100, 34);
            // 
            // lblInfo
            // 
            this.lblInfo.BindDisplayValueGone = true;
            this.lblInfo.DisplayMember = "Info";
            this.lblInfo.Flex = 1;
            this.lblInfo.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(100, 34);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.btnCheck});
            this.panel1.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.Center;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 36);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.White;
            this.btnCheck.BindDisplayValueGone = true;
            this.btnCheck.Border = new Swebui.Controls.Border(1F);
            this.btnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.btnCheck.BorderRadius = 4;
            this.btnCheck.DisplayMember = "Action";
            this.btnCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.NumberOfLines = 0;
            this.btnCheck.Size = new System.Drawing.Size(100, 34);
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // ATMainLayout
            // 
            this.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.image1,
            this.lblType,
            this.lblTime,
            this.lblInfo,
            this.panel1});
            this.Direction = Swebui.Controls.LayoutDirection.Row;
            this.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.Size = new System.Drawing.Size(0, 60);

        }
        #endregion

        private Image image1;
        private Label lblType;
        private Label lblTime;
        private Label lblInfo;
        private Panel panel1;
        private Button btnCheck;
    }
}