using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebONE.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class ATUserLayout : Swebui.Controls.SwebUserControl
    {
        public ATUserLayout() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        private void Check_CheckedChanged(object sender, EventArgs e)
        {
         
            ((ATUserChooseLayot)this.Owner.Owner).upCheckState();
        }
    }
}