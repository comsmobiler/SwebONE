using SmoONE.CommLib;
using SmoONE.Domain;
using SmoONE.DTOs;
using Swebui;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SwebONE.Leave
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmLeaveCreate : Swebui.Controls.SwebUserControl
    {
        public FrmLeaveCreate() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        public string LID;//请假编号
        private string type = ""; //请假类别

        //private int checkTop = 0;//审阅人top
        private int imgCheckLeft = 0;
        private string addCheckUser = "";//添加审批人
        private List<string> listCheckUsers = new List<string>(); //审阅人

        private int ccTop = 0;//抄送人top
        private int imgCCLeft = 0;
        private string addCCUser = "";//添加抄送人
        private List<string> listCCToUsers = new List<string>(); //抄送人
        private string leaveImg = "";//请假图片
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        private void FrmLeaveCreate_Load(object sender, EventArgs e)
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
                GetDate();
                //当请假编号不为空时，获取请假信息
                if (LID != null)
                {
                    label1.Text = "请假编辑";
                       //获取请假信息
                       LeaveDetailDto leave = AutofacConfig.leaveService.GetByID(LID);
                    type = leave.L_TypeID;
                    btnType.Text = AutofacConfig.leaveService.GetTypeNameByID(leave.L_TypeID);
                    dpkStartDate.Value = leave.L_StartDate;
                    dpkEndDate.Value = leave.L_EndDate;
                    txtLday.Text = leave.L_LDay.ToString();
                    txtReason.Text = leave.L_Reason;
                    //获取图片
                    if (string.IsNullOrEmpty(leave.L_Img1) == false)
                    {
                        imgL.ResourceID = leave.L_Img1;
                        leaveImg = leave.L_Img1;
                    }
                    //获取审批人
                    if (leave.L_CheckUsers != null)
                    {
                        string[] CheckUsers = leave.L_CheckUsers.Split(',');
                        foreach (string checkUser in CheckUsers)
                        {
                            UserDetailDto user = AutofacConfig.userService.GetUserByUserID(checkUser);
                            addCheckUser = checkUser + "," + user.U_Name + "," + user.U_Portrait;
                            comboBox2.Text = user.U_Name;
                            listCheckUsers.Add(checkUser);
                        }
                    }
                    //获取抄送人
                    if (string.IsNullOrEmpty(leave.L_CCTo) == false)
                    {
                        string[] CCToUsers = leave.L_CCTo.Split(',');
                        foreach (string ccToUser in CCToUsers)
                        {
                            UserDetailDto user = AutofacConfig.userService.GetUserByUserID(ccToUser);
                            addCCUser = ccToUser + "," + user.U_Name + "," + user.U_Portrait;
                            comboBox3.Text = user.U_Name;
                            listCCToUsers.Add(ccToUser);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 获取获取类型、审批人、抄送人数据
        /// </summary>
        private void GetDate()
        {
            List<UserDto> listUser = new List<UserDto>();//审批人或抄送人数据
            List<UserDto> listUser1 = new List<UserDto>();//抄送人数据

            //获取审批人数据或成本中心模板审批人数据
            listUser = AutofacConfig.userService.QueryCheckUsers("");

            //获取抄送人数据
            listUser1 = AutofacConfig.userService.QueryCCUsers("");


            //如果审批人或抄送人数据大于0，则绑定数据
            if (listUser.Count() > 0)
            {
                foreach (UserDto user in listUser)
                {
                    comboBox2.Items.Add(new ComboBoxItem(user.U_ID, user.U_Name));
                }
            }
            //如果审批人或抄送人数据大于0，则绑定数据
            if (listUser1.Count() > 0)
            {
                foreach (UserDto user in listUser)
                {
                    comboBox3.Items.Add(new ComboBoxItem(user.U_ID, user.U_Name));
                }
            }
            //获取类别
            List<LeaveType> listLType = AutofacConfig.leaveService.GetAllType();
            foreach (LeaveType leaveType in listLType)
            {
                btnType.Items.Add(new ComboBoxItem(leaveType.L_T_ID, leaveType.L_T_Name));
            }

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

                if (type.Trim().Length <= 0)
                {
                    throw new Exception("请输入请假类别！");
                }
                if (dpkStartDate.Value > dpkEndDate.Value)
                {
                    throw new Exception("开始时间必须小于结束时间！");
                }
                if (txtLday.Text.Trim().Length <= 0)
                {
                    throw new Exception("请输入请假天数！");
                }
                else
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(txtLday.Text.Trim(), @"^(?!0+(?:\.0+)?$)(?:[1-9]\d*|0)(?:\.\d{1,2})?$") == false)
                    {
                        throw new Exception("请假天数必须为大于0的数字！");
                    }
                }
                if (txtReason.Text.Trim().Length <= 0)
                {
                    throw new Exception("请输入请假事由！");
                }
                if (listCheckUsers.Count <= 0)
                {
                    throw new Exception("请输入审批人！");
                }

                //赋值请假信息
                LeaveInputDto leave = new LeaveInputDto();
                leave.L_TypeID = type;
                leave.L_StartDate = dpkStartDate.Value;
                leave.L_EndDate = dpkEndDate.Value;
                leave.L_LDay = Convert.ToDecimal(txtLday.Text.Trim());
                leave.L_Reason = txtReason.Text.Trim();
                if (imgL.ResourceID.Trim().Length > 0)
                {
                    leave.L_Img1 = imgL.ResourceID.Trim();
                }
                else
                {
                    leave.L_Img1 = "";
                }
                if (listCheckUsers.Count > 0)
                {
                    string CheckUsers = "";
                    foreach (string checkuser in listCheckUsers)
                    {
                        if (string.IsNullOrWhiteSpace(CheckUsers) == true)
                        {
                            CheckUsers = checkuser;
                        }
                        else
                        {
                            CheckUsers += "," + checkuser;
                        }
                    }
                    leave.L_CheckUsers = CheckUsers;
                }
                string CCToUsers = "";
                if (listCCToUsers.Count > 0)
                {

                    foreach (string user in listCCToUsers)
                    {
                        if (string.IsNullOrWhiteSpace(CCToUsers) == true)
                        {
                            CCToUsers = user;
                        }
                        else
                        {
                            CCToUsers += "," + user;
                        }
                    }
                }
                leave.L_CCTo = CCToUsers;
                ReturnInfo result;
                if (string.IsNullOrEmpty(LID) == false)
                {
                    leave.L_ID = LID;
                    leave.L_UpdateUser = Client.Session["U_ID"].ToString();
                    //更新请假信息
                    result = AutofacConfig.leaveService.UpdateLeave(leave);
                }
                else
                {
                    //创建请假
                    leave.L_CreateUser = Client.Session["U_ID"].ToString();
                    result = AutofacConfig.leaveService.AddLeave(leave);
                }
                //如果返回值true表示请假信息创建或更新成功，否则失败并抛出错误
                if (result.IsSuccess == true)
                {
                    ShowResult = ShowResult.Yes;
                    Toast("您的请假条已成功提交！", ToastLength.SHORT);
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
         
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(LID) && string.IsNullOrEmpty(leaveImg) == false)
            {
                File.Delete(SwebResourceManager.DefaultImagePath + "\\" + leaveImg);
            }
            this.Parent.Controls.Add(new FrmLeaveList() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }
        /// <summary>
        /// 图片上传
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button1_Click(object sender, EventArgs e)
        {
            Client.FileUpload((obj, args) =>
            {
                if (string.IsNullOrEmpty(args.error))
                {

                    if (leaveImg.Trim().Length <= 0)
                    {
                        string[] suffixs = args.ResourceID.Split('.');
                        string imgName = "leave" + DateTime.Now.ToString("yyyyMMddhhmm") + "." + suffixs[1];
                        args.SaveFile(imgName, SwebResourceManager.DefaultImagePath);
                        leaveImg = imgName;
                        args.SaveFile(leaveImg, SwebResourceManager.DefaultImagePath);
                        imgL.ResourceID = imgName;
                        imgL.Refresh();//当图片上传文件名相同时，刷新界面图片内容
                    }
                    else
                    {
                        string[] suffixs = args.ResourceID.Split('.');
                        string[] suffixs1 = leaveImg.Split('.');
                        string imgName = "";
                        if (suffixs1.Length > 1)
                            imgName = suffixs1[0] + "." + suffixs[1];
                        args.SaveFile(imgName, SwebResourceManager.DefaultImagePath);
                        leaveImg = imgName;
                        imgL.Refresh();//当图片上传文件名相同时，刷新界面图片内容
                    }
                }
            });

        }
        /// <summary>
        /// 图片删除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(LID) && string.IsNullOrEmpty(leaveImg) == false)
            {
                File.Delete(SwebResourceManager.DefaultImagePath + "\\" + leaveImg);
                leaveImg = "";
                imgL.ResourceID = "";
            }
        }
        /// <summary>
        /// 请假类型选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnType_ValueChanged(object sender, EventArgs e)
        {
            type = btnType.SelectKey;
        }
        /// <summary>
        /// 审批人选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox2_ValueChanged(object sender, EventArgs e)
        {
            listCheckUsers.Clear();
            listCheckUsers.Add(comboBox2.SelectKey);
        }
        /// <summary>
        /// 抄送人选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox3_ValueChanged(object sender, EventArgs e)
        {
            listCCToUsers.Clear();
            listCCToUsers.Add(comboBox3.SelectKey);
        }

    }
}