using SwebONE.Department;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebONE.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmDepAssignUserLayout : Swebui.Controls.SwebUserControl
    {
        public FrmDepAssignUserLayout() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }

        private void Check_CheckedChanged(object sender, EventArgs e)
        {
            if (Check.Checked)
            {
                ((FrmDepartCreate)this.Owner.Tag).AddSelectUserQty();
                ((FrmDepartCreate)this.Owner.Tag).UpdateState();
            }
            else
            {
                ((FrmDepartCreate)this.Owner.Tag).SubtractSelectUserQty();
                ((FrmDepartCreate)this.Owner.Tag).UpdateState();
            }
        }
    }
}