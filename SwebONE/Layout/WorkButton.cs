using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebONE.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class WorkButton : Swebui.Controls.SwebUserControl
    {
        public WorkButton() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        public string ResourceID
        {
            set => image1.ResourceID = value;
            get => image1.ResourceID;
        }
        public string Text
        {
            set => label1.Text = value;
            get => label1.Text;
        }
        public event EventHandler Press;
        private void panel1_Press(object sender, EventArgs e)
        {
            if (Press != null) this.Press.Invoke(this, new EventArgs());
        }
    }
}