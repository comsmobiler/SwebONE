using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebONE.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class RBItemLayout : Swebui.Controls.SwebUserControl
    {
        public RBItemLayout() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        public RBItemLayout(int rid,string rbRowID,string type,string amount,DateTime rbdate,string note) : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
            this.RID = rid;
            this.RBRowID = rbRowID;
            TypeID= type;
            amountTxt.Text = amount;
            rbDate.Value = rbdate;
            noteTxt.Text = note;
        }
        #region "definition"
        public int RID=-1;
        public string RBRowID;
        public string TypeID;                //消费类型编号
        public string Amount { get { return amountTxt.Text; } }
        public DateTime RBDate { get { return rbDate.Value; } }
        public string RBNote { get { return noteTxt.Text; } }
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        private void RBItemLayout_Load(object sender, EventArgs e)
        {
            try
            {
                //显示数据报销类型
                List<SmoONE.Domain.RB_RType> Types = AutofacConfig.rBService.GetAllType();
                foreach (SmoONE.Domain.RB_RType row in Types)
                {
                   typeCom.Items.Add(new ComboBoxItem(row.RB_RT_ID, row.RB_RT_Name));
                    if (string.IsNullOrEmpty(TypeID) == false&& TypeID==row.RB_RT_ID)
                    {
                        typeCom.Text = row.RB_RT_Name;
                    }
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void typeCom_ValueChanged_1(object sender, EventArgs e)
        {
            if (typeCom.SelectKey != null)
            {
                TypeID = typeCom.SelectKey;
            }
        }
    }
}