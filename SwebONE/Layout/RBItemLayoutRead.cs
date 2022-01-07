using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebONE.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class RBItemLayoutRead : Swebui.Controls.SwebUserControl
    {
        public RBItemLayoutRead() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        public RBItemLayoutRead(string typeName,string amount,DateTime rbdate,string note) : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
            typeCom.Text = typeName;
            amountTxt.Text = amount;
            rbDate.Text = rbdate.ToString();
            noteTxt.Text = note;
        }
        private void RBItemLayout_Load(object sender, EventArgs e)
        {
        }

     
    }
}