using SmoONE.DTOs;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebONE.CostCenter
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmCCTemplateList : Swebui.Controls.SwebUserControl
    {
        public FrmCCTemplateList() : base()
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
        /// <summary>
        /// 新增按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmCCTemplateCreate() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }
        /// <summary>
        /// 编辑按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditBtn_Click(object sender, EventArgs e)
        {
            gridView1.GetSelectedRows((obj, args) =>
            {
                if (args.SelectedRows.Count > 0)
                {
                    Dictionary<string, object> selectrow = args.SelectedRows[0];
                    string ccttid = selectrow["CC_TT_TemplateID"].ToString();
                    FrmCCTemplateCreate frmCCTemplateCreate = new FrmCCTemplateCreate();
                    frmCCTemplateCreate.CTempID = ccttid;
                    frmCCTemplateCreate.Flex = 1;
                    this.Parent.Controls.Add(frmCCTemplateCreate);
                    this.Parent.Controls.RemoveAt(0);
                }
                else { Toast("未选择行！"); }
            });
        }

        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCCTemplateList_Load(object sender, EventArgs e)
        {
            try
            {
                gridView1.DataSource = GetData();
                gridView1.DataBind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }
        /// <summary>
        /// 初始化方法
        /// </summary>
        public List<CC_Type_TemplateDto> GetData()
        {
            //获取所有成本模板
            List<CC_Type_TemplateDto> listCCTemp = AutofacConfig.costCenterService.GetAllCCTTemplate();
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
            };

            return listCCTemp;

        }
        /// <summary>
        /// 刷新按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //获取所有成本模板
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
                    };
                    gridView1.Reload(listCCTemp);
                }
            }
            catch (Exception ex) { Toast(ex.Message); }
        }
    }
}