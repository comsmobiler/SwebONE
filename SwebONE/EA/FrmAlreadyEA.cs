using SmoONE.DTOs;
using SwebONE.Leave;
using SwebONE.RB;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebONE.EA
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmAlreadyEA : Swebui.Controls.SwebUserControl
    {
        public FrmAlreadyEA() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        internal string type = "";//类型
        internal string state = "";//状态
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAlreadyEA_Load(object sender, EventArgs e)
        {
            try
            {
                gridView1.DataSource = GetData();//绑定gridview数据
                gridView1.DataBind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
        }   /// <summary>
            /// 获取初始化数据
            /// </summary>
        public List<DataGridview> GetData()
        {
            List<LeaveDto> listLeaveDto = new List<LeaveDto>();
            List<ReimbursementDto> listRBDto = new List<ReimbursementDto>();

            //获取当前用户已审批的请假数据
            listLeaveDto = AutofacConfig.leaveService.GetCheckedByCheckUsers(Client.Session["U_ID"].ToString());
            //获取当前用户已审批的报销数据
            listRBDto = AutofacConfig.rBService.GetCheckedByCheckUsers(Client.Session["U_ID"].ToString());
            List<DataGridview> listCheck = new List<DataGridview>();//审批数据
            UserDetails userDetails = new UserDetails();
            //如果待我审批或我审批的请假数据条数大于0，则添加到审批数据                
            if (listLeaveDto.Count > 0)
            {
                foreach (LeaveDto leave in listLeaveDto)
                {
                    DataGridview dataGItem = new DataGridview();
                    dataGItem.ID = leave.L_ID;
                    if (string.IsNullOrEmpty(leave.U_Portrait) == true)
                    {
                        UserDetailDto user = userDetails.getUser(leave.U_ID);
                        if (user != null)
                        {
                            dataGItem.U_Portrait = user.U_Portrait;
                        }
                    }
                    else
                    {
                        dataGItem.U_Portrait = leave.U_Portrait;
                    }
                    dataGItem.Name = leave.U_Name + "的" + DataGridviewType.请假;
                    dataGItem.Type = ((int)Enum.Parse(typeof(DataGridviewType), DataGridviewType.请假.ToString())).ToString();
                    dataGItem.CreateDate = leave.L_CreateDate.ToString("yyyy/MM/dd");
                    switch (leave.L_Status)
                    {
                        case (int)L_Status.新建:
                            if (string.IsNullOrEmpty(leave.L_CheckUsers) == false)
                            {
                                dataGItem.L_StatusDesc = "等待我审批";
                            }
                            else
                            {
                                dataGItem.L_StatusDesc = "等待我审批";
                            }
                            break;
                        case (int)L_Status.已审批:
                            dataGItem.L_StatusDesc = "已审批（完成）";
                            break;
                        case (int)L_Status.已拒绝:
                            dataGItem.L_StatusDesc = "已审批（拒绝）";
                            break;
                    }
                    listCheck.Add(dataGItem);
                }
            }

            //如果待我审批或我审批的报销数据条数大于0，则添加到审批数据     
            if (listRBDto.Count > 0)
            {
                foreach (ReimbursementDto reimbursement in listRBDto)
                {
                    DataGridview dataGItem = new DataGridview();
                    dataGItem.ID = reimbursement.RB_ID;
                    if (string.IsNullOrEmpty(reimbursement.U_Portrait) == true)
                    {
                        UserDetailDto user = userDetails.getUser(reimbursement.U_ID);
                        if (user != null)
                        {
                            dataGItem.U_Portrait = user.U_Portrait;
                        }
                    }
                    else
                    {
                        dataGItem.U_Portrait = reimbursement.U_Portrait;
                    }
                    dataGItem.Name = reimbursement.U_Name + "的" + DataGridviewType.报销;
                    dataGItem.Type = ((int)Enum.Parse(typeof(DataGridviewType), DataGridviewType.报销.ToString())).ToString();
                    dataGItem.CreateDate = reimbursement.RB_CreateDate.ToString("yyyy/MM/dd");
                    switch (reimbursement.RB_Status)
                    {

                        case (int)RB_Status.责任人审批:
                            dataGItem.L_StatusDesc = "责任人已审批";
                            break;
                        case (int)RB_Status.行政审批:
                            dataGItem.L_StatusDesc = "行政已审批";

                            break;
                        case (int)RB_Status.财务审批:
                            dataGItem.L_StatusDesc = "财务已审批";
                            break;
                        case (int)RB_Status.已拒绝:
                            dataGItem.L_StatusDesc = "已审批（拒绝）";
                            break;
                    }
                    listCheck.Add(dataGItem);
                }
            }
            return listCheck;

        }
        /// <summary>
        /// 查看按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewBtn_Click(object sender, EventArgs e)
        {
            gridView1.GetSelectedRows((obj, args) =>
            {
                if (args.SelectedRows.Count > 0)
                {
                    Dictionary<string, object> selectrow = args.SelectedRows[0];
                    string id = selectrow["ID"].ToString();
                    if (id.Contains("RB"))
                    {
                        FrmRBDetail frmRBDetail = new FrmRBDetail(id) { Flex = 1, Tag = typeof(FrmAlreadyEA) };
                        this.Parent.Controls.Add(frmRBDetail);
                    }
                    else
                    {
                        FrmLeaveDetial frmLeaveDetial = new FrmLeaveDetial(id) { Flex = 1, Tag = typeof(FrmAlreadyEA) };
                        this.Parent.Controls.Add(frmLeaveDetial);
                    }

                    this.Parent.Controls.RemoveAt(0);
                }
                else
                {
                    Toast("未选择行！");
                }

            });
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
                gridView1.Reload(GetData());
            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
        }


    }
}