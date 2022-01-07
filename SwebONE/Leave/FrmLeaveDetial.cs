using SmoONE.CommLib;
using SmoONE.DTOs;
using SwebONE.Layout;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebONE.Leave
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmLeaveDetial : Swebui.Controls.SwebUserControl
    {
        public FrmLeaveDetial() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }

        #region "definition"
        string LID;//请假编号
        bool IsEA;//是否审核
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        public FrmLeaveDetial(string LID) : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
            this.LID = LID;
        }
        public FrmLeaveDetial(string LID, bool isEA) : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
            this.LID = LID;
            this.IsEA = isEA;
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            if (this.Tag == null)
            {
                this.Parent.Controls.Add(new FrmLeaveList() { Flex = 1 });
            }
            else
            {
                Type userType = this.Tag as Type;
                SwebControl swebControl = Activator.CreateInstance(userType) as SwebControl;
                swebControl.Flex = 1;
                this.Parent.Controls.Add(swebControl);
            }
            this.Parent.Controls.RemoveAt(0);
        }

        private void FrmLeaveDetial_Load(object sender, EventArgs e)
        {
            //获取请假信息
            lblRBNO.Text = LID;
            LeaveDetailDto leave = AutofacConfig.leaveService.GetByID(LID);
            string type = leave.L_TypeID;
            btnType.Text = AutofacConfig.leaveService.GetTypeNameByID(leave.L_TypeID);
            dpkStartDate.Text = leave.L_StartDate.ToString("yyyy-MM-dd");
            dpkEndDate.Text = leave.L_EndDate.ToString("yyyy-MM-dd");
            txtLday.Text = leave.L_LDay.ToString();
            txtReason.Text = leave.L_Reason;
            imgL.ResourceID = leave.L_Img1;
            //获取审批人
            if (leave.L_CheckUsers != null)
            {
                string[] CheckUsers = leave.L_CheckUsers.Split(',');
                foreach (string checkUser in CheckUsers)
                {
                    UserDetailDto user = AutofacConfig.userService.GetUserByUserID(checkUser);
                    txtCheck.Text = user.U_Name + ",";
                }
            }
            //获取抄送人
            if (string.IsNullOrEmpty(leave.L_CCTo) == false)
            {
                string[] CCToUsers = leave.L_CCTo.Split(',');
                foreach (string ccToUser in CCToUsers)
                {
                    UserDetailDto user = AutofacConfig.userService.GetUserByUserID(ccToUser);
                    txtCC.Text = user.U_Name + ",";
                }
            }
            //获取审批状态
            if (leave.L_Status == 0)
            {
                statusLab.Text = "等待审批";
                statusLab.ForeColor = System.Drawing.Color.Orange;
            }
            else if(leave.L_Status==1)
            {
                statusLab.Text = "已审批(同意)";
                statusLab.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                statusLab.Text = "已审批(拒绝)";
                statusLab.ForeColor = System.Drawing.Color.Red;

            }
            getNodeItemDate(leave);

            if (IsEA == true)
            {
                yesBtn.Visible = true;
                noBtn.Visible = true;
            }
        }
        /// <summary>
        /// 添加节点数据
        /// </summary>
        /// <param name="leave"></param>
        private void getNodeItemDate(LeaveDetailDto leave)
        {

            //清除所有节点
            nodePanel.Controls.Clear();
            //添加节点数据
            NodeLayout nodeItem = new NodeLayout() { Flex = 1 };
            UserDetails userDetails = new UserDetails();
            UserDetailDto createUser = userDetails.getUser(leave.L_CreateUser);
            if (createUser != null)
            {
                if (Client.Session["U_ID"].Equals(leave.L_CreateUser))
                {
                    nodeItem.Text = "我 " + "发起申请";
                }
                else
                {
                    nodeItem.Text = createUser.U_Name + "发起申请";
                }
                nodeItem.SubText = leave.L_CreateDate.ToString();
                nodePanel.Controls.Add(nodeItem);//动态添加节点
            }
            switch (leave.L_Status)
            {
                case (int)L_Status.新建:
                    if (string.IsNullOrEmpty(leave.L_CheckUsers) == false)
                    {
                        string[] CheckUsers = leave.L_CheckUsers.Split(',');
                        foreach (string cUser in CheckUsers)
                        {
                            NodeLayout nodeItem2 = new NodeLayout() { Flex = 1 };
                            UserDetailDto checkUser = userDetails.getUser(cUser);
                            if (checkUser != null)
                            {
                                if (Client.Session["U_ID"].Equals(cUser))
                                {
                                    nodeItem2.Text = "我 " + "审批中";
                                }
                                else
                                {
                                    nodeItem2.Text = checkUser.U_Name + "审批中";
                                }
                                nodeItem2.SubText = leave.L_UpdateDate.ToString();
                                nodeItem2.NodeColor = System.Drawing.Color.Silver;
                                nodePanel.Controls.Add(nodeItem2);
                            }
                        }
                    }
                    break;
                case (int)L_Status.已审批:
                    NodeLayout nodeItem3 = new NodeLayout() { Flex = 1 };
                    UserDetailDto checkUser1 = userDetails.getUser(leave.L_CurrantCheck);
                    if (checkUser1 != null)
                    {
                        if (Client.Session["U_ID"].Equals(leave.L_CurrantCheck))
                        {
                            nodeItem3.Text = "我" + "已同意";
                        }
                        else
                        {
                            nodeItem3.Text = checkUser1.U_Name + "已同意";
                        }
                        nodeItem3.SubText = leave.L_UpdateDate.ToString();

                        nodePanel.Controls.Add(nodeItem3);
                    }


                    break;
                case (int)L_Status.已拒绝:
                    NodeLayout nodeItem4 = new NodeLayout() { Flex = 1 };
                    UserDetailDto checkUser2 = userDetails.getUser(leave.L_CurrantCheck);
                    if (checkUser2 != null)
                    {
                        if (Client.Session["U_ID"].Equals(leave.L_CurrantCheck))
                        {
                            nodeItem4.Text = "我" + "已拒绝";
                        }
                        else
                        {
                            nodeItem4.Text = checkUser2.U_Name + "已拒绝";
                        }
                        nodeItem4.SubText = leave.L_UpdateDate.ToString();

                        nodePanel.Controls.Add(nodeItem4);
                    }
                    break;
            }
        }
        /// <summary>
        /// 审批拒绝
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void noBtn_Click(object sender, EventArgs e)
        {
            FrmRefuseLayout refuseLayout = new FrmRefuseLayout(0,LID);
            this.Form.ShowDialog(refuseLayout,(obj,args)=> {
                if (refuseLayout.ShowResult == ShowResult.Yes)
                {
                    if (refuseLayout.Result.IsSuccess == true)
                    {
                        Toast("已拒绝请假！", ToastLength.SHORT);
                        BackBtn_Click(null, null);
                    }
                    else
                    {
                        throw new Exception(refuseLayout.Result.ErrorInfo);
                    }
                }
            });
        }
        /// <summary>
        /// 审批同意
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void yesBtn_Click(object sender, EventArgs e)
        {
            try
            { //审批人同意请假
                ReturnInfo result = AutofacConfig.leaveService.UpdateLeaveStatus(LID, L_Status.已审批, Client.Session["U_ID"].ToString(), "");
                //如果返回true则审批成功，否则失败并抛出错误
                if (result.IsSuccess == true)
                {
                    this.Form.Toast("已同意请假审批！", ToastLength.SHORT);
                    BackBtn_Click(null, null);
                }
                else
                {
                    throw new Exception(result.ErrorInfo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}