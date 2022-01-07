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
    partial class FrmCostTemplet : Swebui.Controls.SwebUserControl
    {
        public FrmCostTemplet() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        /// <summary>
        /// 是否选择成本中心类型模板
        /// </summary>
        public bool IsSelectCTemPlet;
        /// <summary>
        /// 模板编号
        /// </summary>
        public string CTempID;
        /// <summary>
        /// 模板编号
        /// </summary>
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion

        private void FrmCostTemplet_Load(object sender, EventArgs e)
        {
            listView1.Tag = this;
            List<CC_Type_TemplateDto> listCCTemp = AutofacConfig.costCenterService.GetAllCCTTemplate();


            if (listCCTemp.Count > 0)
            {
                foreach (CC_Type_TemplateDto ccTemp in listCCTemp)
                {
                    string AEACheckers = "";
                    string[] AEAChecks = ccTemp.CC_TT_AEACheckers.Split(',');
                    foreach (string AEACheck in AEAChecks)
                    {
                        UserDetailDto user = AutofacConfig.userService.GetUserByUserID(AEACheck);
                        if (string.IsNullOrWhiteSpace(AEACheckers) == true)
                        {
                            AEACheckers = user.U_Name;
                        }
                        else
                        {
                            AEACheckers += "," + user.U_Name;
                        }
                    }
                    ccTemp.CC_TT_AEACheckers = AEACheckers;
                    string FCheckers = "";
                    string[] FChecks = ccTemp.CC_TT_FinancialCheckers.Split(',');
                    foreach (string FCheck in FChecks)
                    {
                        UserDetailDto user = AutofacConfig.userService.GetUserByUserID(FCheck);
                        if (string.IsNullOrWhiteSpace(FCheckers) == true)
                        {
                            FCheckers = user.U_Name;
                        }
                        else
                        {
                            FCheckers += "," + user.U_Name;
                        }
                    }
                    ccTemp.CC_TT_FinancialCheckers = FCheckers;
                }
                lblInfor.Visible = false;
                listView1.DataSource = listCCTemp;
                listView1.DataBind();
            }
            else
            {
                lblInfor.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ShowResult = ShowResult.No;
            this.Close();
        }
    }
}