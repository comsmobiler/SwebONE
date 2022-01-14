using SmoONE.CommLib;
using SmoONE.Domain;
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
    partial class FrmCCTemplateCreate : Swebui.Controls.SwebUserControl
    {
        public FrmCCTemplateCreate() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        public string CTempID;//模板编号
        string type = "";//类型
        private int AEACheckTop;//行政审批人top
        private int imgCheckLeft = 0;
        private string addAEACheck = "";
        private List<string> listAEAChecks = new List<string>(); //行政审批人
        private List<Button> listbtnAEAChecks = new List<Button>();//行政审批人名称控件

        private int FCheckTop;//财务审批人top
        private int imgFCheckLeft = 0;
        private string addFCheck = "";
        private List<string> listFCheckers = new List<string>(); //财务审批人
        private List<Button> listbtnFCheckers = new List<Button>();//财务审批人名称控件
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmCCTemplateList() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(type) == true)
                {
                    throw new Exception("请输入类型！");
                }
                if (listAEAChecks.Count <= 0)
                {
                    throw new Exception("请输入行政审批人！");
                }
                if (listFCheckers.Count <= 0)
                {
                    throw new Exception("请输入财务审批人！");
                }

                CCTTInputDto ccTemplate = new CCTTInputDto();
                ccTemplate.CC_TT_TypeID = type;
                //行政审批人
                string AEAChecks = "";
                foreach (string checkuser in listAEAChecks)
                {
                    if (string.IsNullOrWhiteSpace(AEAChecks) == true)
                    {
                        AEAChecks = checkuser;
                    }
                    else
                    {
                        AEAChecks += "," + checkuser;
                    }
                }
                ccTemplate.CC_TT_AEACheckers = AEAChecks;
                //财务审批人
                string FCheckers = "";
                foreach (string checkuser in listFCheckers)
                {
                    if (string.IsNullOrWhiteSpace(FCheckers) == true)
                    {
                        FCheckers = checkuser;
                    }
                    else
                    {
                        FCheckers += "," + checkuser;
                    }
                }
                ccTemplate.CC_TT_FinancialCheckers = FCheckers;
                ccTemplate.CC_TT_UpdateUser = Client.Session["U_ID"].ToString();
                ReturnInfo result;
                if (string.IsNullOrEmpty(CTempID) == false)
                {
                    ccTemplate.CC_TT_TemplateID = CTempID;
                    //更新成本中心模板信息
                    result = AutofacConfig.costCenterService.UpdateCC_Type_Template(ccTemplate);
                }
                else
                {
                    //创建成本中心模板
                    result = AutofacConfig.costCenterService.AddCC_Type_Template(ccTemplate);
                }
                //如果返回true，则创建或更新成本中心成功，否则失败并抛出错误
                if (result.IsSuccess == true)
                {
                    ShowResult = ShowResult.Yes;
                    Toast("成本中心类型模板提交成功！", ToastLength.LONG);
                    //回到列表页
                    BackBtn_Click(null, null);
                }
                else
                {
                    throw new Exception(result.ErrorInfo);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
        }

        private void ReSetBtn_Click(object sender, EventArgs e)
        {
            comboBox1.DefaultValue = comboBox2.DefaultValue = comboBox3.DefaultValue = new string[] { };
        }

        private void FrmCCTemplateCreate_Load(object sender, EventArgs e)
        {
            try
            {  //获取类型，并赋值combobox1数据
                List<CostCenter_Type> listCCType = AutofacConfig.costCenterService.GetAllCCType();
                foreach (CostCenter_Type ccType in listCCType)
                {
                    comboBox1.Nodes.Add(new TreeSelectNode(ccType.CC_T_TypeID, ccType.CC_T_Description));

                }
                if (type.Trim().Length > 0)
                {
                    comboBox1.DefaultValue = new string[] { type };
                }
                //获取审批人
                GetDate();

                //判断是新增还是编辑
                if (string.IsNullOrEmpty(CTempID) == false)
                {
                    //根据成本中心模板编号获取成本中心模板数据
                    CC_Type_TemplateDto ccTemplate = AutofacConfig.costCenterService.GetTemplateByID(CTempID);
                    type = ccTemplate.CC_TT_TypeID;
                    comboBox1.DefaultValue = new string[] { ccTemplate.CC_TT_TemplateID };
                    if (string.IsNullOrEmpty(ccTemplate.CC_TT_AEACheckers) == false)
                    {
                        UserDetailDto user = AutofacConfig.userService.GetUserByUserID(ccTemplate.CC_TT_AEACheckers);
                        listAEAChecks.Add(user.U_ID);
                        comboBox2.DefaultValue = new string[] { ccTemplate.CC_TT_AEACheckers };
                    }
                    if (string.IsNullOrEmpty(ccTemplate.CC_TT_FinancialCheckers) == false)
                    {
                        UserDetailDto user = AutofacConfig.userService.GetUserByUserID(ccTemplate.CC_TT_AEACheckers);
                        listFCheckers.Add(user.U_ID);
                          comboBox3.DefaultValue=new string[] { ccTemplate.CC_TT_FinancialCheckers };
                    }
                    titleLab.Text = "模板编辑";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 类型选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_ValueChanged(object sender, EventArgs e)
        {
            //  type = comboBox1.SelectKey;
        }

        /// <summary>
        /// 获取审批人或抄送人数据数据
        /// </summary>
        private void GetDate()
        {
            List<UserDto> listUser = new List<UserDto>();//审批人或抄送人数据
                                                         //获取审批人数据或成本中心模板审批人数据
            listUser = AutofacConfig.userService.QueryCheckUsers("");

            //如果审批人或抄送人数据大于0，则绑定数据
            if (listUser.Count() > 0)
            {
                foreach (UserDto user in listUser)
                {
                    comboBox2.Nodes.Add(new TreeSelectNode(user.U_ID, user.U_Name));
                    comboBox3.Nodes.Add(new TreeSelectNode(user.U_ID, user.U_Name));
                }
            }
        }

        private void comboBox2_ValueChanged(object sender, EventArgs e)
        {
            //if (comboBox2.Text != "")
            //{
            //    listAEAChecks.Clear();
            //    listAEAChecks.Add(comboBox2.SelectKey);
            //}

        }

        private void comboBox3_ValueChanged(object sender, EventArgs e)
        {
            //if (comboBox3.Text != "")
            //{
            //    listFCheckers.Clear();
            //    listFCheckers.Add(comboBox3.SelectKey);
            //}
        }
    }
}