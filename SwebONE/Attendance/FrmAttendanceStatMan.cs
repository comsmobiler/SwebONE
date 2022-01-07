using SmoONE.DTOs;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SwebONE.Attendance
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmAttendanceStatMan : Swebui.Controls.SwebUserControl
    {
        public FrmAttendanceStatMan() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }

        #region "definition"
        public string DayTime;
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmAttendanceStatistics("天数统计") { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }

        private void FrmAttendanceStatMan_Load(object sender, EventArgs e)
        {
            try
            {
                this.lblDate.Text = DayTime;        //年月日
                Bind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 绑定数据
        /// </summary>
        private void Bind()
        {
            try
            {
                List<string> Users = AutofacConfig.attendanceService.GetUserNameByDate(Convert.ToDateTime(DayTime));
                DataTable table = new DataTable();
                table.Columns.Add("U_ID");          //用户编号
                table.Columns.Add("Pict");        //用户头像     
                table.Columns.Add("Name");        //用户昵称
                table.Columns.Add("Total");       //用户应签到次数
                table.Columns.Add("Al");          //用户正常签到次数
                table.Columns.Add("ProAl");          //用户正常签到次数
                table.Columns.Add("Late");        //用户迟到次数
                table.Columns.Add("ProLate");        //用户迟到次数
                table.Columns.Add("Early");       //用户早退次数
                table.Columns.Add("ProEarly");       //用户早退次数
                table.Columns.Add("No");          //用户未签次数
                table.Columns.Add("ProNo");          //用户未签次数
                table.Columns.Add("Absenteeism"); //旷工描述
                table.Columns.Add("ISAbsenteeism");//是否旷工               
                foreach (string User in Users)
                {
                    DailyStatisticsDto Stat = AutofacConfig.attendanceService.GetUserDailyStatistics(User, Convert.ToDateTime(DayTime));
                    UserDetailDto UserInfo = AutofacConfig.userService.GetUserByUserID(User);

                    string absenteeism = "";
                    bool isAbsenteeism = false;
                    if (Stat.DS_AllCount > 0 & Stat.DS_AllCount.Equals(Stat.DS_NoSignInCount + Stat.DS_NoSignOutCount))
                    {
                        absenteeism = "全天旷工：是";
                        isAbsenteeism = true;
                    }
                    float proAl = 0;
                    float proLate = 0;
                    float proEarly = 0;
                    float proNo = 0;
                    if (Stat.DS_AllCount > 0)
                    {
                        proAl = (float)Stat.DS_InTimeCount / Stat.DS_AllCount;
                        proLate = (float)Stat.DS_ComeLateCount / Stat.DS_AllCount;
                        proEarly = (float)Stat.DS_LeaveEarlyCount / Stat.DS_AllCount;
                        proNo = (float)(Stat.DS_NoSignInCount + Stat.DS_NoSignOutCount) / Stat.DS_AllCount;
                    }
                    table.Rows.Add(UserInfo.U_ID, UserInfo.U_Portrait, UserInfo.U_Name, UserInfo.U_Name + " 应签到 " + Stat.DS_AllCount + " 次", Stat.DS_InTimeCount + " 次", proAl, Stat.DS_ComeLateCount + " 次", proLate, Stat.DS_LeaveEarlyCount + " 次", proEarly, Stat.DS_NoSignInCount + Stat.DS_NoSignOutCount + " 次", proNo, absenteeism, isAbsenteeism);
                }
                if (table.Rows.Count > 0)
                {
                    this.gridView1.DataSource = table;
                    this.gridView1.DataBind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}