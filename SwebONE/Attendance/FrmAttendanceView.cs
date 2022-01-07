using SmoONE.DTOs;
using SwebONE.Layout;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebONE.Attendance
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmAttendanceView : Swebui.Controls.SwebUserControl
    {
        public FrmAttendanceView() : base()
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
            this.Parent.Controls.Add(new FrmAttendanceList() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }

        private void FrmAttendanceView_Load(object sender, EventArgs e)
        {
            try
            {
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
                        btnATMode.Text = ATMode.ToString();
                        ATemplate.AT_CommutingType = ATMode;
                        switch (ATMode)
                        {
                            case WorkTimeType.一天一上下班:
                                if (At.AT_StartTime != null)
                                {
                                    ATemplate.AT_StartTime = At.AT_StartTime;
                                    dpStartWork.Text = Convert.ToDateTime(At.AT_StartTime).ToString("HH:mm");
                                }
                                if (At.AT_EndTime != null)
                                {
                                    ATemplate.AT_EndTime = At.AT_EndTime;
                                    dpEndWork.Text = Convert.ToDateTime(At.AT_EndTime).ToString("HH:mm");
                                }
                                break;
                            case WorkTimeType.一天二上下班:
                                if (At.AT_AMStartTime != null)
                                {
                                    ATemplate.AT_AMStartTime = At.AT_AMStartTime;
                                    dpAMEndWork.Text = Convert.ToDateTime(At.AT_AMStartTime).ToString("HH:mm");
                                }

                                if (At.AT_AMEndTime != null)
                                {
                                    ATemplate.AT_AMEndTime = At.AT_AMEndTime;
                                    dpAMEndWork.Text = Convert.ToDateTime(At.AT_AMEndTime).ToString("HH:mm");
                                }

                                if (At.AT_PMStartTime != null)
                                {
                                    ATemplate.AT_PMStartTime = At.AT_PMStartTime;
                                    dpPMStartWork.Text = Convert.ToDateTime(At.AT_PMStartTime).ToString("HH:mm");
                                }

                                if (At.AT_PMEndTime != null)
                                {
                                    ATemplate.AT_PMEndTime = At.AT_PMEndTime;
                                    dpPMEndWork.Text = Convert.ToDateTime(At.AT_PMEndTime).ToString("HH:mm");
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

                    string nATUser = ""; //考勤成员
                    if (string.IsNullOrEmpty(At.AT_Users) == false)
                    {
                        string[] atUser = At.AT_Users.Split(',');

                        ATemplate.AT_Users = At.AT_Users;
                        foreach (string userid in atUser)
                        {
                            UserDetailDto userDetails = AutofacConfig.userService.GetUserByUserID(userid);
                            nATUser += userDetails.U_Name+" , ";
                        }
                    }

                    btnUser.Text = nATUser;
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
                    upATweeklyWorkingDay();//更新日期
                }

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
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

        private void button1_Click(object sender, EventArgs e)
        {
            ATCustomDateLayout aTCustomDateLayout = new ATCustomDateLayout();
            aTCustomDateLayout.ATNo = ATNo;
            this.Form.ShowDialog(aTCustomDateLayout);
        }
    }
}