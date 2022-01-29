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
    partial class FrmAttendanceStatistics : Swebui.Controls.SwebUserControl
    {
        public FrmAttendanceStatistics() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        public FrmAttendanceStatistics(string tabname) : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
            ChangeTab(tabname);

        }

        #region "definition"
        public int btnMode = 1;             //选择显示模板
        internal string UserID;          //用户ID
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        string Year = DateTime.Now.Year.ToString();
        string Month = DateTime.Now.Month.ToString();
        #endregion
        private void TabBtn1_Click(object sender, EventArgs e)
        {
            try
            {
                Button button = (Button)sender;
                ChangeTab(button.Text);
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        private void ChangeTab(string tabname)
        {
            try
            {
                switch (tabname)
                {
                    case "人员统计":
                        panel3.Visible = true;
                        panel4.Visible = false;
                        btnMode = 1;
                        TabBtn1.BackColor = System.Drawing.Color.FromArgb(78, 137, 248);
                        TabBtn1.ForeColor = System.Drawing.Color.White;
                        TabBtn.BackColor = System.Drawing.Color.White;
                        TabBtn.ForeColor = System.Drawing.Color.DimGray;
                        break;
                    case "天数统计":
                        panel3.Visible = false;
                        panel4.Visible = true;
                        btnMode = 2;
                        TabBtn.BackColor = System.Drawing.Color.FromArgb(78, 137, 248);
                        TabBtn.ForeColor = System.Drawing.Color.White;
                        TabBtn1.BackColor = System.Drawing.Color.White;
                        TabBtn1.ForeColor = System.Drawing.Color.DimGray;
                        break;
                }
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
                //年份
                //月份             
                DataTable table = new DataTable();
                switch (btnMode)
                {
                    case 1:
                        //获取某月考勤用户数据
                        List<string> Users = AutofacConfig.attendanceService.GetUserNameByPeriod(Convert.ToDateTime(Year + "年" + Month + "月"), Convert.ToDateTime(Year + "年" + Month + "月").AddMonths(1).AddDays(-1));
                        if (Users.Count > 0)
                        {
                            table.Columns.Add("ID");                //用户ID
                            table.Columns.Add("Pict");              //用户头像
                            table.Columns.Add("Name");              //用户名称
                            table.Columns.Add("Total");             //应签到次数
                            table.Columns.Add("Al");                //准时签到次数
                            table.Columns.Add("Late");              //迟到次数
                            table.Columns.Add("Early");             //早退次数
                            table.Columns.Add("No");                //未签次数
                            foreach (string Row in Users)
                            {
                                MonthlyStatisticsDto Stat = AutofacConfig.attendanceService.GetUserMonthlyStatistics(Row, Convert.ToDateTime(Year + "年" + Month + "月"));
                                UserDetails UserDetail = new UserDetails();
                                UserDetailDto User = UserDetail.getUser(Row);
                                if (User != null)
                                {
                                    table.Rows.Add(User.U_ID, User.U_Portrait, User.U_Name, Stat.MS_AllCount, Stat.MS_InTimeCount, Stat.MS_ComeLateCount, Stat.MS_LeaveEarlyCount, Stat.MS_NoSignInCount + Stat.MS_NoSignOutCount);
                                }
                            }
                            this.gridATdata.Reload(table);
                        }

                        break;
                    case 2:
                        //获取某月考勤日期
                        List<DateTime> listDate = AutofacConfig.attendanceService.GetDayOfMonthlyStatistics(UserID, Convert.ToDateTime(Year + "年" + Month + "月"));
                        if (listDate.Count > 0)
                        {
                            table.Columns.Add("Day");         //需要签到的日期
                            foreach (DateTime Row in listDate)
                            {
                                string Time = Row.ToString("yyyy年M月d日    dddd", new System.Globalization.CultureInfo("zh-CN"));
                                table.Rows.Add(Time);
                            }
                            this.gridATdata1.Reload(table);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void FrmAttendanceStatistics_Load(object sender, EventArgs e)
        {
            try
            {
                UserID = Client.Session["U_ID"].ToString();
                this.btnYear.DefaultValue = new string[] { DateTime.Now.Year.ToString() };              //年份
                this.btnMonth.DefaultValue = new string[] { DateTime.Now.Month.ToString() };            //月份
                for (int i = DateTime.Now.Year; DateTime.Now.Year - i < 10; i--)        //添加年份选择范围
                {
                    btnYear.Nodes.Add(new TreeSelectNode(i.ToString(), i.ToString()));
                }
                for (int i = 1; i < 13; i++)
                {
                    btnMonth.Nodes.Add(new TreeSelectNode(i.ToString(), i.ToString()));
                }
                if (btnMode == 1)
                {
                    panel3.Visible = true;
                    panel4.Visible = false;
                }
                else
                {
                    panel3.Visible = false;
                    panel4.Visible = true;
                }

                TabBtn1.BackColor = System.Drawing.Color.FromArgb(78, 137, 248);
                TabBtn1.ForeColor = System.Drawing.Color.White;
                #region bind
                //年份
                //月份             
                DataTable table = new DataTable();
                //获取某月考勤用户数据
                List<string> Users = AutofacConfig.attendanceService.GetUserNameByPeriod(Convert.ToDateTime(Year + "年" + Month + "月"), Convert.ToDateTime(Year + "年" + Month + "月").AddMonths(1).AddDays(-1));
                if (Users.Count > 0)
                {
                    table.Columns.Add("ID");                //用户ID
                    table.Columns.Add("Pict");              //用户头像
                    table.Columns.Add("Name");              //用户名称
                    table.Columns.Add("Total");             //应签到次数
                    table.Columns.Add("Al");                //准时签到次数
                    table.Columns.Add("Late");              //迟到次数
                    table.Columns.Add("Early");             //早退次数
                    table.Columns.Add("No");                //未签次数
                    foreach (string Row in Users)
                    {
                        MonthlyStatisticsDto Stat = AutofacConfig.attendanceService.GetUserMonthlyStatistics(Row, Convert.ToDateTime(Year + "年" + Month + "月"));
                        UserDetails UserDetail = new UserDetails();
                        UserDetailDto User = UserDetail.getUser(Row);
                        if (User != null)
                        {
                            table.Rows.Add(User.U_ID, User.U_Portrait, User.U_Name, Stat.MS_AllCount, Stat.MS_InTimeCount, Stat.MS_ComeLateCount, Stat.MS_LeaveEarlyCount, Stat.MS_NoSignInCount + Stat.MS_NoSignOutCount);
                        }

                    }
                    this.gridATdata.DataSource = table;
                    this.gridATdata.DataBind();
                }
                #endregion
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        private void gridATdata1_RowClick(object sender, GridViewRowClickEventArgs e)
        {
            try
            {

                FrmAttendanceStatMan frmMan = new FrmAttendanceStatMan();
                frmMan.DayTime = e.CurrentRow["Day"].ToString();     //将选择日期，传递到下个页面
                frmMan.Flex = 1;
                this.Parent.Controls.Add(frmMan);
                this.Parent.Controls.RemoveAt(0);

            }
            catch (Exception ex)
            {
                this.Form.Toast(ex.Message);
            }
        }
        /// <summary>
        /// 年份选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYear_Press(object sender, TreeSelectPressEventArgs args)
        {

            try
            {
                Year = args.TreeID;
                Bind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 月份选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMonth_Press(object sender, TreeSelectPressEventArgs args)
        {
            try
            {
                Month = args.TreeID;
                Bind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}