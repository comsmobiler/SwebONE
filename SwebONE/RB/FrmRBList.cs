using SmoONE.DTOs;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebONE.RB
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmRBList : Swebui.Controls.SwebUserControl
    {
        public FrmRBList() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        private void FrmRBList_Load(object sender, EventArgs e)
        {
            try
            {
                //获取当前用户创建的报销数据
                List<ReimbursementDto> listRBDto = AutofacConfig.rBService.GetByCreateUsers(Client.Session["U_ID"].ToString());
                List<DataGridview> listCreated = new List<DataGridview>();//我发起的数据
                UserDetails userDetails = new UserDetails();

                //如果报销数据条数大于0，则添加到我发起的数据
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
                            case (int)RB_Status.新建:
                                dataGItem.L_StatusDesc = "等待责任人审批";
                                break;
                            case (int)RB_Status.责任人审批:
                                dataGItem.L_StatusDesc = "等待行政审批";
                                break;
                            case (int)RB_Status.行政审批:
                                dataGItem.L_StatusDesc = "等待财务审批";
                                break;
                            case (int)RB_Status.财务审批:
                                dataGItem.L_StatusDesc = "财务已审批";
                                break;
                            case (int)RB_Status.已拒绝:
                                dataGItem.L_StatusDesc = "已审批（拒绝）";
                                break;
                        }
                        listCreated.Add(dataGItem);
                    }
                }
                if (listCreated.Count > 0)
                {
                    gridView1.DataSource = listCreated;//绑定gridView数据
                    gridView1.DataBind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmRBCreate() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            gridView1.GetSelectedRows((obj, args) =>
            {
                if (args.SelectedRows.Count > 0)
                {
                    Dictionary<string, object> selectrow = args.SelectedRows[0];
                    if (selectrow["L_StatusDesc"].ToString() != "财务已审批")
                    {
                        string id = selectrow["ID"].ToString();
                        FrmRBCreate frmRBCreate = new FrmRBCreate();
                        frmRBCreate.RBID = selectrow["ID"].ToString();
                        frmRBCreate.Flex = 1;
                        this.Parent.Controls.Add(frmRBCreate);
                        this.Parent.Controls.RemoveAt(0);
                    }
                    else
                    {
                        Toast("该请假条已审批，无法编辑！");
                    }
                }
                else
                {
                    Toast("未选择行！");
                }
            });
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            gridView1.GetSelectedRows((obj, args) =>
            {
                if (args.SelectedRows.Count > 0)
                {
                    Dictionary<string, object> selectrow = args.SelectedRows[0];

                    string id = selectrow["ID"].ToString();
                    FrmRBDetail frmRBDetail = new FrmRBDetail(id);
                    frmRBDetail.Flex = 1;
                    this.Parent.Controls.Add(frmRBDetail);
                    this.Parent.Controls.RemoveAt(0);

                }
                else
                {
                    Toast("未选择行！");
                }
            });
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmRBList() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }


    }
}