using SmoONE.DTOs;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebONE.Leave
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmLeaveList : Swebui.Controls.SwebUserControl
    {
        public FrmLeaveList() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        private void AddBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmLeaveCreate() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }
        /// <summary>
        /// 编辑按钮
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
                    if (selectrow["L_StatusDesc"].ToString() != "已审批（完成）")
                    {
                        string id = selectrow["ID"].ToString();
                        FrmLeaveCreate frmLeaveCreate = new FrmLeaveCreate();
                        frmLeaveCreate.Flex = 1;
                        frmLeaveCreate.LID = id;
                        this.Parent.Controls.Add(frmLeaveCreate);
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

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmLeaveList() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }

        private void FrmLeaveList_Load(object sender, EventArgs e)
        {
            try
            {
                //获取当前用户创建的请假数据
                List<LeaveDto> listLeaveDto = AutofacConfig.leaveService.GetByCreateUsers(Client.Session["U_ID"].ToString());
                List<DataGridview> listCreated = new List<DataGridview>();//我发起的数据
                UserDetails userDetails = new UserDetails();
                //如果请假数据条数大于0，则添加到我发起的数据
                if (listLeaveDto.Count > 0)
                {
                    foreach (LeaveDto leave in listLeaveDto)
                    {
                        DataGridview dataGItem = new DataGridview();
                        dataGItem.ID = leave.L_ID;
                        dataGItem.Name = leave.U_Name + "的" + DataGridviewType.请假;
                        dataGItem.Type = ((int)Enum.Parse(typeof(DataGridviewType), DataGridviewType.请假.ToString())).ToString();
                        dataGItem.CreateDate = leave.L_CreateDate.ToString("yyyy/MM/dd");
                        switch (leave.L_Status)
                        {
                            case (int)L_Status.新建:
                                dataGItem.L_StatusDesc = "等待审批";
                                break;
                            case (int)L_Status.已审批:
                                dataGItem.L_StatusDesc = "已审批（完成）";
                                break;
                            case (int)L_Status.已拒绝:
                                dataGItem.L_StatusDesc = "已审批（拒绝）";
                                break;
                        }
                        listCreated.Add(dataGItem);
                    }
                    gridView1.DataSource = listCreated;
                    gridView1.DataBind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }

        }
        /// <summary>
        /// 查看按钮
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
                    FrmLeaveDetial frmLeaveDetial = new FrmLeaveDetial(id) { Flex = 1 };
                    this.Parent.Controls.Add(frmLeaveDetial);
                    this.Parent.Controls.RemoveAt(0);
                }
                else
                {
                    Toast("未选择行！");
                }

            });
        }
    }
}