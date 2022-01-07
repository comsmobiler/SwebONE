using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebONE.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class CCDetialLayout : Swebui.Controls.SwebUserControl
    {
        public CCDetialLayout() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        public CCDetialLayout( string rbid ,string rbdate,string rbtype,string amount,string user) : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
            idLab.Text = rbid;
            dateLab.Text = rbdate;
            typeLab.Text = rbtype;
            amoutLab.Text = amount;
            userLab.Text = user;
        }


        private void CCDetialLayout_Load(object sender, EventArgs e)
        {

        }
    }
}