using SmoONE.DTOs;
using SwebONE.Leave;
using SwebONE.RB;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebONE.Work
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmCheck : Swebui.Controls.SwebUserControl
    {
        public FrmCheck() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }

        #region "definition"
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
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
                        FrmRBDetail frmRBDetail = new FrmRBDetail(id, false) { Flex = 1, Tag = typeof(FrmCheck) };
                        this.Parent.Controls.Add(frmRBDetail);
                    }
                    else
                    {
                        FrmLeaveDetial frmLeaveDetial = new FrmLeaveDetial(id, false) { Flex = 1, Tag = typeof(FrmCheck) };
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
        /// 返回按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmWork() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
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
                List<DataGridview> listCCTo = new List<DataGridview>();//抄送我的数据
                //获取抄送给当前用户的请假数据
                List<LeaveDto> listLeaveDto = AutofacConfig.leaveService.GetByCCTo(Client.Session["U_ID"].ToString());
                //如果请假数据条数大于0，则添加到抄送我的数据
                if (listLeaveDto.Count > 0)
                {
                    foreach (LeaveDto leave in listLeaveDto)
                    {
                        DataGridview dataGItem = new DataGridview();
                        dataGItem.ID = leave.L_ID;
                        if (string.IsNullOrEmpty(leave.U_Portrait) == true)
                        {
                            UserDetails userDetails = new UserDetails();
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
                                dataGItem.L_StatusDesc = "等待审批";
                                break;
                            case (int)L_Status.已审批:
                                dataGItem.L_StatusDesc = "已审批（完成）";
                                break;
                            case (int)L_Status.已拒绝:
                                dataGItem.L_StatusDesc = "已审批（拒绝）";
                                break;
                        }
                        listCCTo.Add(dataGItem);
                    }
                }
                //绑定gridView数据
                gridView1.Reload(listCCTo);

            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
        }
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCheck_Load(object sender, EventArgs e)
        {
            Bind();
        }
        public void Bind()
        {
            try
            {
                List<DataGridview> listCCTo = new List<DataGridview>();//抄送我的数据
                //获取抄送给当前用户的请假数据
                List<LeaveDto> listLeaveDto = AutofacConfig.leaveService.GetByCCTo(Client.Session["U_ID"].ToString());
                //如果请假数据条数大于0，则添加到抄送我的数据
                if (listLeaveDto.Count > 0)
                {
                    foreach (LeaveDto leave in listLeaveDto)
                    {
                        DataGridview dataGItem = new DataGridview();
                        dataGItem.ID = leave.L_ID;
                        if (string.IsNullOrEmpty(leave.U_Portrait) == true)
                        {
                            UserDetails userDetails = new UserDetails();
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
                                dataGItem.L_StatusDesc = "等待审批";
                                break;
                            case (int)L_Status.已审批:
                                dataGItem.L_StatusDesc = "已审批（完成）";
                                break;
                            case (int)L_Status.已拒绝:
                                dataGItem.L_StatusDesc = "已审批（拒绝）";
                                break;
                        }
                        listCCTo.Add(dataGItem);
                    }
                }
                if (listCCTo.Count > 0)
                {
                    //绑定gridView数据
                    gridView1.DataSource = listCCTo;
                    gridView1.DataBind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
        }
    }
}