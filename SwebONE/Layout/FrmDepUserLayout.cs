using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebONE.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmDepUserLayout : Swebui.Controls.SwebUserControl
    {
        public FrmDepUserLayout() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        public string UserPortrait
        {
            set
            {
                image1.ResourceID = value;
            }
            get
            {
                return image1.ResourceID;
            }
        }
        public string UserName
        {
            set
            {
                label1.Text = value;
            }
            get
            {

                return label1.Text;
            }
        }
    }
}