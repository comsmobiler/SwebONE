using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebONE.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmCostListTemplet : Swebui.Controls.SwebUserControl
    {
        public FrmCostListTemplet() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }

        private void panel1_Press(object sender, EventArgs e)
        {
            ((FrmCostTemplet)this.Owner.Tag).CTempID = label1.BindDataValue.ToString();
            ((FrmCostTemplet)this.Owner.Tag).ShowResult = ShowResult.Yes;
           ((FrmCostTemplet)this.Owner.Tag).Close();
        }
    }
}