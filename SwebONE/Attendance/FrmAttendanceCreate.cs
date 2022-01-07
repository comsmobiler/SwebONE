using SmoONE.CommLib;
using SmoONE.DTOs;
using SwebONE.Layout;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SwebONE.Attendance
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmAttendanceCreate : Swebui.Controls.SwebUserControl
    {
        public FrmAttendanceCreate() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        public string ATNo;//考勤模板编号
        private WorkTimeType ATMode;//考勤类型
        private ATInputDto ATemplate = new ATInputDto();//考勤
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类 
        #endregion
      

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmAttendanceList() { Flex=1});
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
                if (txtName.Text.Trim().Length <= 0)
                {
                    throw new Exception("请输入考勤名称！");
                }
                if (Convert.IsDBNull(ATMode) == true)
                {
                    throw new Exception("请输入考勤类型！");
                }
                if (string.IsNullOrEmpty(ATemplate.AT_WeeklyWorkingDay) == true)
                {
                    throw new Exception("请输入考勤每周上班时间！");
                }

                if (ATemplate.AT_Latitude <= 0 & ATemplate.AT_Longitude <= 0 & (string.IsNullOrEmpty(ATemplate.AT_Positions) == true || string.IsNullOrWhiteSpace(ATemplate.AT_Positions) == true))
                {
                    throw new Exception("请输入考勤地点！");
                }
                if (txtADeviation.Text.Trim().Length <= 0)
                {
                    throw new Exception("请输入考勤地点允许偏差值！");
                }
                ATemplate.AT_Name = txtName.Text.Trim();
                //允许考勤地址偏差
                ATemplate.AT_AllowableDeviation = Convert.ToInt32(txtADeviation.Text);
                ReturnInfo result;
                if (string.IsNullOrEmpty(ATNo) == false)
                {
                    ATemplate.AT_UpdateUser = Client.Session["U_ID"].ToString();
                    //更新考勤
                    result = AutofacConfig.attendanceService.UpdateAttendanceTemplate(ATemplate);
                }
                else
                {
                    //创建考勤
                    ATemplate.AT_CreateUser = Client.Session["U_ID"].ToString();
                    result = AutofacConfig.attendanceService.AddAttendanceTemplate(ATemplate);
                }
                //如果返回值true表示考勤创建或更新成功，否则失败并抛出错误
                if (result.IsSuccess == true)
                {
                    ShowResult = ShowResult.Yes;
                    Toast("您的考勤已成功提交！", ToastLength.SHORT);
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

        private void FrmAttendanceCreate_Load(object sender, EventArgs e)
        {
            
            GetAT();
        }

        /// <summary>
        /// 定位
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mapTrimView1_LocationChanged(object sender, MapTrimViewLocationChangedEventArgs e)
        {
            ATemplate.AT_Longitude = (decimal)e.Longitude;
            ATemplate.AT_Latitude = (decimal)e.Latitude;
            ATemplate.AT_Positions = e.Description;
            lblAddress.Text = ATemplate.AT_Positions;
        }
        /// <summary>
        /// 获取考勤信息
        /// </summary>
        private void GetAT()
        {
            try
            {
                if (string.IsNullOrEmpty(ATNo) == false)
                {
                    DeleteBtn.Visible = true;
                    ATDetailDto At = AutofacConfig.attendanceService.GetATByID(ATNo);
                    if (At != null)
                    {
                        ATemplate.AT_ID = At.AT_ID;
                        ATemplate.AT_Name = At.AT_Name;
                        txtName.Text = ATemplate.AT_Name;
                        //工作日考勤时间
                        if (string.IsNullOrEmpty(At.AT_CommutingType) == false)
                        {
                            ATMode = (WorkTimeType)Enum.Parse(typeof(WorkTimeType), At.AT_CommutingType);
                            ATemplate.AT_CommutingType = ATMode;
                            switch (ATMode)
                            {
                                case WorkTimeType.一天一上下班:
                                    if (At.AT_StartTime != null)
                                    {
                                        ATemplate.AT_AMStartTime = At.AT_StartTime;
                                        dpStartWork.Value = Convert.ToDateTime(At.AT_StartTime);
                                    }
                                    if (At.AT_EndTime != null)
                                    {
                                        ATemplate.AT_EndTime = At.AT_EndTime;
                                        dpEndWork.Value = Convert.ToDateTime(At.AT_EndTime);
                                    }
                                    break;
                                case WorkTimeType.一天二上下班:
                                    if (At.AT_AMStartTime != null)
                                    {
                                        ATemplate.AT_AMStartTime = At.AT_AMStartTime;
                                        dpAMStartWork.Value = Convert.ToDateTime(At.AT_AMStartTime);
                                    }

                                    if (At.AT_AMEndTime != null)
                                    {
                                        ATemplate.AT_AMEndTime = At.AT_AMEndTime;
                                        dpAMEndWork.Value = Convert.ToDateTime(At.AT_AMEndTime);
                                    }

                                    if (At.AT_PMStartTime != null)
                                    {
                                        ATemplate.AT_PMStartTime = At.AT_PMStartTime;
                                        dpPMStartWork.Value = Convert.ToDateTime(At.AT_PMStartTime);
                                    }

                                    if (At.AT_PMEndTime != null)
                                    {
                                        ATemplate.AT_PMEndTime = At.AT_PMEndTime;
                                        dpPMEndWork.Value = Convert.ToDateTime(At.AT_PMEndTime);
                                    }

                                    break;
                            }
                        }
                        //考勤工作日
                        if (string.IsNullOrEmpty(At.AT_WeeklyWorkingDay) == false)
                        {
                            ATemplate.AT_WeeklyWorkingDay = At.AT_WeeklyWorkingDay;
                        }
                        else
                        {
                            ATemplate.AT_WeeklyWorkingDay = ((int)Week.Monday).ToString() + "," + ((int)Week.Tuesday).ToString() + "," + ((int)Week.Wednesday).ToString() + "," + ((int)Week.Thursday).ToString() + "," + ((int)Week.Friday).ToString();
                        }

                        int nATUser = 0; //考勤人数
                        if (string.IsNullOrEmpty(At.AT_Users) == false)
                        {
                            string[] atUser = At.AT_Users.Split(',');
                            nATUser = atUser.Length;
                            ATemplate.AT_Users = At.AT_Users;

                        }
                        btnUser.Text = nATUser.ToString() + "人" + "   > ";
                        //考勤位置
                        ATemplate.AT_Longitude = At.AT_Longitude;
                        ATemplate.AT_Latitude = At.AT_Latitude;
                        if (string.IsNullOrEmpty(At.AT_Positions) == false)
                        {
                            ATemplate.AT_Positions = At.AT_Positions;
                        }
                        ATemplate.AT_AllowableDeviation = At.AT_AllowableDeviation;
                        lblAddress.Text = At.AT_Positions;
                        txtADeviation.Text = At.AT_AllowableDeviation.ToString();

                    }
                }
                else
                {
                 
                    ATMode = (int)WorkTimeType.一天一上下班;
                    ATemplate.AT_WeeklyWorkingDay = ((int)Week.Monday).ToString() + "," + ((int)Week.Tuesday).ToString() + "," + ((int)Week.Wednesday).ToString() + "," + ((int)Week.Thursday).ToString() + "," + ((int)Week.Friday).ToString();
                    ATemplate.AT_CommutingType = ATMode;
                }
                if (Convert.IsDBNull(ATMode) == false)
                {
                    upATMode();//更新考勤模式
                }
                upATweeklyWorkingDay();//更新日期
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 考勤模式更新
        /// </summary>
        private void upATMode()
        {
            if (Convert.IsDBNull(ATMode) == false)
            {
                switch (ATMode)//考勤模式 0-一天一次上下班模式，1-一天两次上下班模式
                {
                    case WorkTimeType.一天一上下班:

                        if (ATemplate.AT_StartTime != null)
                        {

                            dpStartWork.Value = Convert.ToDateTime(ATemplate.AT_StartTime);
                        }
                        else
                        {
                            DateTime starttime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 9, 0, 0);
                            dpStartWork.Value = starttime;
                            ATemplate.AT_StartTime = starttime;
                        }
                        if (ATemplate.AT_EndTime != null)
                        {

                            dpEndWork.Value = Convert.ToDateTime(ATemplate.AT_EndTime);
                        }
                        else
                        {
                            DateTime endtime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 17, 30, 0);
                            dpEndWork.Value = endtime;
                            ATemplate.AT_EndTime = endtime;
                        }
                        panel15.Visible = panel16.Visible = true;
                        timePanel.Visible = false;
                        btnATMode.Text = "切换到一天两次上下班";
                        break;
                    case WorkTimeType.一天二上下班:
                        if (ATemplate.AT_AMStartTime != null)
                        {
                            dpAMStartWork.Value = Convert.ToDateTime(ATemplate.AT_AMStartTime);
                        }
                        else
                        {
                            DateTime amstarttime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 9, 0, 0);
                            dpAMStartWork.Value = amstarttime;
                            ATemplate.AT_AMStartTime = amstarttime;
                        }

                        if (ATemplate.AT_AMEndTime != null)
                        {
                            dpAMEndWork.Value = Convert.ToDateTime(ATemplate.AT_AMEndTime);
                        }
                        else
                        {
                            DateTime amendtime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 0, 0);
                            dpAMEndWork.Value = amendtime;
                            ATemplate.AT_AMEndTime = amendtime;
                        }
                        if (ATemplate.AT_PMStartTime != null)
                        {
                            dpPMStartWork.Value = Convert.ToDateTime(ATemplate.AT_PMStartTime);
                        }
                        else
                        {
                            DateTime pmstarttime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 13, 0, 0);
                            dpPMStartWork.Value = pmstarttime;
                            ATemplate.AT_PMStartTime = pmstarttime;
                        }
                        if (ATemplate.AT_PMEndTime != null)
                        {
                            dpPMEndWork.Value = Convert.ToDateTime(ATemplate.AT_PMEndTime);
                        }
                        else
                        {
                            DateTime pmsendtime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 17, 30, 0);
                            dpPMEndWork.Value = pmsendtime;
                            ATemplate.AT_PMEndTime = pmsendtime;
                        }
                        panel5.Visible = panel6.Visible = false;
                        timePanel.Visible = true;
                        btnATMode.Text = "切换到一天一次上下班";
                        break;
                }
       
                //btnSave.Top = lblADeviation.Top + lblADeviation.Height  + 10;
                if (string.IsNullOrEmpty(ATNo) == false)
                {
                  
                }
            }
        }
        /// <summary>
        /// 更新工作日期
        /// </summary>
        private void upATweeklyWorkingDay()
        {
            AttendanceManager atManager = new AttendanceManager();
            btnDate.Text = atManager.getWeekDesc(ATemplate.AT_WeeklyWorkingDay);
        }
        /// <summary>
        /// 切换上班模式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnATMode_Click(object sender, EventArgs e)
        {
            MessageBox.Show("切换后，需重新设置考勤时间，你确定么？", MessageBoxButtons.YesNo, (object o, MessageBoxHandlerArgs args) =>
            {
                try
                {
                    if (args.Result == ShowResult.Yes)
                    {
                        switch (ATMode)
                        {
                            case WorkTimeType.一天一上下班:
                                ATMode = WorkTimeType.一天二上下班;
                                break;
                            case WorkTimeType.一天二上下班:
                                ATMode = WorkTimeType.一天一上下班;
                                break;
                        }
                        ATemplate.AT_CommutingType = ATMode;
                        ATemplate.CustomDates.Clear();
                        upATMode();
                    }
                }
                catch (Exception ex)
                {
                    Toast(ex.Message, ToastLength.SHORT);
                }
            });

        }
        /// <summary>
        /// 选择考勤成员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUser_Click(object sender, EventArgs e)
        {
            ATUserChooseLayot aTUserChooseLayot = new ATUserChooseLayot();
            if (string.IsNullOrEmpty(ATNo) == false)
            {
                aTUserChooseLayot.ATNo = ATNo;
            }
            if (string.IsNullOrEmpty(ATemplate.AT_Users) == false)
            {
                aTUserChooseLayot.selectUser = ATemplate.AT_Users;
            }

            ShowDialog(aTUserChooseLayot, ( obj,  args) =>
            {
                if (aTUserChooseLayot.ShowResult == ShowResult.Yes)
                {
                    ATemplate.AT_Users = aTUserChooseLayot.selectUser;
                    if (string.IsNullOrEmpty(ATemplate.AT_Users) == false)
                    {
                        btnUser.Text = "已选择"+(ATemplate.AT_Users.Split(',').Length).ToString() + "人";
                    }

                }
            });
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("是否确定删除考勤？", "删除", MessageBoxButtons.YesNo, (Object s1, MessageBoxHandlerArgs args1) =>
                {
                    if (args1.Result == ShowResult.Yes)
                    {
                        ReturnInfo r = AutofacConfig.attendanceService.DeleteAttendanceTemplate(ATNo);
                        if (r.IsSuccess == true)
                        {
                            this.ShowResult =ShowResult.Yes;
                            Toast("考勤模板已删除!");
                            BackBtn_Click(null, null);
                        }
                        else
                        {
                            throw new Exception(r.ErrorInfo);
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
        }

        
        private void txtADeviation_TouchLeave(object sender, EventArgs e)
        {
            if(txtADeviation.Text!=null && txtADeviation.Text.Trim().Length > 0)
            {
                Regex regex = new Regex("^[0-9]*$");
                if (regex.IsMatch(txtADeviation.Text))
                {
                    decimal value = decimal.Parse(txtADeviation.Text.Trim());
                    if (value < 300 || value > 5000)
                    {
                        txtADeviation.Text = "";
                        Toast("请输入300-5000之间的数值");
                    }
                }
                else
                {
                    txtADeviation.Text = "";
                    Toast("请输入300-5000之间的数值");
                }
            }
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            AttendanceWorkDate atWorkDate = new AttendanceWorkDate();
            atWorkDate.AT_Type = ATMode;
            switch (ATMode)
            {
                case WorkTimeType.一天一上下班:


                    if (Convert.IsDBNull(ATemplate.AT_StartTime) == false || Convert.IsDBNull(ATemplate.AT_EndTime) == false)
                    {
                        atWorkDate.AT_StartTime = ATemplate.AT_StartTime;

                    }
                    if (Convert.IsDBNull(ATemplate.AT_EndTime) == false)
                    {
                        atWorkDate.AT_EndTime = ATemplate.AT_EndTime;

                    }
                    break;
                case WorkTimeType.一天二上下班:
                    if (Convert.IsDBNull(ATemplate.AT_AMStartTime) == false)
                    {
                        atWorkDate.AT_AMStartTime = ATemplate.AT_AMStartTime;
                    }
                    if (Convert.IsDBNull(ATemplate.AT_AMEndTime) == false)
                    {
                        atWorkDate.AT_AMEndTime = ATemplate.AT_AMEndTime;
                    }
                    if (Convert.IsDBNull(ATemplate.AT_PMStartTime) == false)
                    {
                        atWorkDate.AT_PMStartTime = ATemplate.AT_PMStartTime;
                    }
                    if (Convert.IsDBNull(ATemplate.AT_PMEndTime) == false)
                    {
                        atWorkDate.AT_PMEndTime = ATemplate.AT_PMEndTime;
                    }
                    break;
            }
            ATDateChoose aTDateChoose = new ATDateChoose();
            aTDateChoose.weekdays = ATemplate.AT_WeeklyWorkingDay;
            aTDateChoose.atWorkDate = atWorkDate;
            aTDateChoose.listatcdInput = ATemplate.CustomDates;
            if (string.IsNullOrEmpty(ATNo) == false)
            {
                aTDateChoose.ATNo = ATNo;
            }
            ShowDialog(aTDateChoose, (obj, args) =>
            {
                if (aTDateChoose.ShowResult == ShowResult.Yes)
                {
                    ATemplate.AT_WeeklyWorkingDay = aTDateChoose.weekdays;
                    upATweeklyWorkingDay();
                    ATemplate.CustomDates = aTDateChoose.listatcdInput;
                }
            });
        }
    }
}