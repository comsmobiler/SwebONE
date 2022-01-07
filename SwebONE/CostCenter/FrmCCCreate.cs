using SmoONE.CommLib;
using SmoONE.Domain;
using SmoONE.DTOs;
using SwebONE.Layout;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebONE.CostCenter
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmCCCreate : Swebui.Controls.SwebUserControl
    {
        public FrmCCCreate() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        public string ATNO;//考勤模板编号
        public string CCID;//成本中心编号
        string type = "";//类型
        string CTempID = "";//类型模板编号
        string liableMan = "";//责任人
        string D_ID = "";//部门编号
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        private void FrmCCCreate_Load(object sender, EventArgs e)
        {
            Bind();
        }
        /// <summary>
        /// 初始化方法
        /// </summary>
        private void Bind()
        {
            try
            {
                //成本中心编号不为空时，成本中心数据
                if (CCID != null)
                {
                    //根据成本中心编号获取成本中心信息
                    CCDetailDto cc = AutofacConfig.costCenterService.GetCCByID(CCID);
                    txtCC_Name.Text = cc.CC_Name;
                    type = cc.CC_TypeID;
                    btnType.Text = cc.CC_TypeName;
                    dpkStartDate.Value = cc.CC_StartDate;
                    dpkEndDate.Value = cc.CC_EndDate;
                    txtAmount.Text = cc.CC_Amount.ToString();
                    liableMan = cc.CC_LiableMan;
                    UserDetailDto user = AutofacConfig.userService.GetUserByUserID(cc.CC_LiableMan);
                    btnLiableMan.Text = user.U_Name;
                    D_ID = cc.CC_DepartmentID;
                    lblDep.Text = cc.CC_DepName;
                    CTempID = cc.CC_TemplateID;
                    btnTemplate.Text = cc.CC_TemplateID;
                }
                else
                {
                    DateTime t = DateTime.Now;
                    dpkEndDate.Value = t.AddYears(1);
                }
                // 获取成本中心类型
                GetCCType();
                /// 获取责任人数据
                GetLeader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 获取成本中心类型
        /// </summary>
        private void GetCCType()
        {
            List<CostCenter_Type> listCCType = AutofacConfig.costCenterService.GetAllCCType();
            foreach (CostCenter_Type ccType in listCCType)
            {
                btnType.Items.Add(new ComboBoxItem(ccType.CC_T_TypeID, ccType.CC_T_Description));
                if (type.Trim().Length > 0)
                {
                    if (type.Trim().Equals(ccType.CC_T_TypeID))
                    {
                        btnType.Text = ccType.CC_T_Description;
                    }
                }
            }
        }
        /// <summary>
        /// 获取责任人数据
        /// </summary>
        private void GetLeader()
        {
            List<UserDto> listuser = AutofacConfig.userService.GetAllUsers();
            foreach (UserDto user in listuser)
            {
                btnLiableMan.Items.Add(new ComboBoxItem(user.U_ID, user.U_Name));
                if (liableMan.Trim().Length > 0)
                {
                    if (liableMan.Trim().Equals(user.U_ID))
                    {
                        btnLiableMan.Text = user.U_Name;
                    }
                }
            }
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmCCList() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCC_Name.Text.Trim().Length <= 0)
                {
                    throw new Exception("请输入成本中心名称！");
                }
                if (string.IsNullOrEmpty(type) == true)
                {
                    throw new Exception("请输入类型！");
                }
                if (txtAmount.Text.Trim().Length <= 0)
                {
                    throw new Exception("金额必须大于0！");
                }
                else
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(txtAmount.Text.Trim(), @"^(?!0+(?:\.0+)?$)(?:[1-9]\d*|0)(?:\.\d{1,2})?$") == false)
                    {
                        throw new Exception("金额必须为大于0的数字！");
                    }

                }
                if (string.IsNullOrWhiteSpace(liableMan) == true)
                {
                    throw new Exception("请输入责任人！");
                }
                if (string.IsNullOrWhiteSpace(CTempID) == true)
                {
                    throw new Exception("请输入成本中心类型模板！");
                }
                if (string.IsNullOrEmpty(D_ID) == true)
                {
                    throw new Exception("该责任人未分配部门，请去分配部门！");
                }
                //更新成本中心数据赋值
                CCInputDto cc = new CCInputDto();
                cc.CC_Name = txtCC_Name.Text.Trim();
                cc.CC_TypeID = type;
                cc.CC_StartDate = dpkStartDate.Value;
                cc.CC_EndDate = dpkEndDate.Value;
                cc.CC_Amount = Convert.ToDecimal(txtAmount.Text.Trim());
                cc.CC_LiableMan = liableMan;
                cc.CC_DepartmentID = D_ID;
                cc.CC_TemplateID = CTempID;
                ReturnInfo result;
                if (string.IsNullOrEmpty(CCID) == false)
                {
                    cc.CC_ID = CCID;
                    cc.CC_UpdateUser = Client.Session["U_ID"].ToString();
                    //更新成本中心
                    result = AutofacConfig.costCenterService.UpdateCostCenter(cc);
                }
                else
                {
                    cc.CC_CreateUser = Client.Session["U_ID"].ToString();
                    //创建成本中心
                    result = AutofacConfig.costCenterService.AddCostCenter(cc);
                }
                //如果返回true，则创建或更新成本中心成功，否则失败并抛出错误
                if (result.IsSuccess == false)
                {
                    throw new Exception(result.ErrorInfo);
                }
                else
                {
                    ShowResult = ShowResult.Yes;
                    Toast("成本中心提交成功！", ToastLength.SHORT);
                    BackBtn_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 责任人选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLiableMan_ValueChanged(object sender, EventArgs e)
        {
            if (btnLiableMan.SelectKey != null)
            {
                liableMan = btnLiableMan.SelectKey;
                UserDepDto user = AutofacConfig.userService.GetUseDepByUserID(liableMan);
                D_ID = user.Dep_ID;
                lblDep.Text = user.Dep_Name;

            }

        }
        /// <summary>
        /// 模板选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTemplate_Click(object sender, EventArgs e)
        {
            FrmCostTemplet frmCostTemplet = new FrmCostTemplet();
            ShowDialog(frmCostTemplet, (obj, args) =>
             {
                 if (frmCostTemplet.ShowResult == ShowResult.Yes)
                 {
                     btnTemplate.Text = frmCostTemplet.CTempID;
                     this.CTempID = frmCostTemplet.CTempID;
                 }

             });
        }
        /// <summary>
        /// 类型选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnType_ValueChanged(object sender, EventArgs e)
        {
            if (btnType.SelectKey != null)
            {
                type = btnType.SelectKey;
            }
        }
    }
}