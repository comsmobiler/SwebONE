using SmoONE.CommLib;
using SmoONE.DTOs;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebONE.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmRefuseLayout : Swebui.Controls.SwebUserControl
    {
        public FrmRefuseLayout() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        public FrmRefuseLayout( int type,string ID) : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
            this.Type = type;
            this.ID = ID;
        }
        #region "definition"
        int Type=0;//0 表示 请假拒绝 1 表示报销拒绝
        string ID;//单据ID
        public ReturnInfo Result = new ReturnInfo();
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.ShowResult = ShowResult.Yes;
                if (txtReason.Text.Trim().Length <= 0)
                {
                    throw new Exception("请输入拒绝理由！");
                }
                switch (Type)
                {
                    case 0:
                        //审批人驳回请假
                      Result= AutofacConfig.leaveService.UpdateLeaveStatus(ID, L_Status.已拒绝, Client.Session["U_ID"].ToString(), txtReason.Text.Trim());
                        //如果返回true则审批成功，否则失败并抛出错误
                        this.Close();
                        break;
                    case 1:
                        Result = AutofacConfig.rBService.UpdateRBStatus(ID, RB_Status.已拒绝, Client.Session["U_ID"].ToString(), this.txtReason.Text);
                        this.Close();
                        break;
                }
            }
            catch (Exception ex)
            {
                this.Form.Toast(ex.Message, ToastLength.SHORT);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.ShowResult = ShowResult.No;
            this.Close();
        }
    }
}