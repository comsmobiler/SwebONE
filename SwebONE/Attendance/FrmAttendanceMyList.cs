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
    partial class FrmAttendanceMyList : Swebui.Controls.SwebUserControl
    {
        public FrmAttendanceMyList() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        internal string UserID;         //用户ID
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        string Year = DateTime.Now.Year.ToString();
        string Month = DateTime.Now.Month.ToString();
        public string CommutingType;    //上下班状态
        #endregion
        private void FrmAttendanceMyList_Load(object sender, EventArgs e)
        {
            try
            {
                this.btnYear.DefaultValue = new string[] { DateTime.Now.Year.ToString() };         //年份
                this.btnMonth.DefaultValue = new string[] { DateTime.Now.Month.ToString() };        //月份
                UserID = Client.Session["U_ID"].ToString();
                for (int i = DateTime.Now.Year; DateTime.Now.Year - i < 10; i--)        //添加年份选择范围
                {
                    btnYear.Nodes.Add(new TreeSelectNode(i.ToString(), i.ToString()));

                }
                for (int i = 1; i < 13; i++)
                {
                    btnMonth.Nodes.Add(new TreeSelectNode(i.ToString(), i.ToString()));

                }
                #region bind
                UserID = Client.Session["U_ID"].ToString();
                DataTable table = new DataTable();

                List<DateTime> listDate = AutofacConfig.attendanceService.GetDayOfMonthlyStatistics(UserID, Convert.ToDateTime(Year + "年" + Month + "月"));
                table.Columns.Add("Day");      //本月需要考勤的日期
                table.Columns.Add("Description");  //签到描述
                table.Columns.Add("OnTime", typeof(System.String));         //应签到时间 
                table.Columns.Add("Action");       //签到或签退
                table.Columns.Add("Time", typeof(System.String));         //签到时间
                table.Columns.Add("Info");       //显示当前是否能签到，是否已经签到
                foreach (DateTime Row in listDate)
                {
                    string Time = Row.ToString("yyyy年M月d日    dddd", new System.Globalization.CultureInfo("zh-CN"));



                    List<ALDto> listStats = AutofacConfig.attendanceService.GetALByUserAndDate(UserID, Convert.ToDateTime(Time));
                    if (listStats != null && listStats.Count > 0)
                    {
                        CommutingType = listStats[0].AL_CommutingType;      //上下班类型
                        if ((WorkTimeType)Enum.Parse(typeof(WorkTimeType), listStats[0].AL_CommutingType) == WorkTimeType.一天一上下班)            //一天一上下班
                        {
                            table.Rows.Add(Time, "上班", listStats[0].AL_OnTime.ToString("HH:mm"), listStats[0].AL_Status, listStats[0].AL_Date.ToString("HH:mm"), listStats[0].AL_Reason);
                            if (listStats.Count > 1)
                                table.Rows.Add(Time, "下班", listStats[1].AL_OnTime.ToString("HH:mm"), listStats[1].AL_Status, listStats[1].AL_Date.ToString("HH:mm"), listStats[1].AL_Reason);
                        }
                        else               //一天两上下班
                        {
                            table.Rows.Add(Time, "上午上班", listStats[0].AL_OnTime.ToString("HH:mm"), listStats[0].AL_Status, listStats[0].AL_Date.ToString("HH:mm"), listStats[0].AL_Reason);
                            if (listStats.Count > 1)
                                table.Rows.Add(Time, "下午下班", listStats[1].AL_OnTime.ToString("HH:mm"), listStats[1].AL_Status, listStats[1].AL_Date.ToString("HH:mm"), listStats[1].AL_Reason);
                            if (listStats.Count > 2)
                                table.Rows.Add(Time, "上午上班", listStats[2].AL_OnTime.ToString("HH:mm"), listStats[2].AL_Status, listStats[2].AL_Date.ToString("HH:mm"), listStats[2].AL_Reason);
                            if (listStats.Count > 3)
                                table.Rows.Add(Time, "下午下班", listStats[3].AL_OnTime.ToString("HH:mm"), listStats[3].AL_Status, listStats[3].AL_Date.ToString("HH:mm"), listStats[3].AL_Reason);
                        }
                    }
                }
                if (table.Rows.Count > 0)
                {
                    this.gridView1.DataSource = table;
                    this.gridView1.DataBind();
                }
                #endregion
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }

        private void Bind()
        {
            UserID = Client.Session["U_ID"].ToString();
            DataTable table = new DataTable();

            List<DateTime> listDate = AutofacConfig.attendanceService.GetDayOfMonthlyStatistics(UserID, Convert.ToDateTime(Year + "年" + Month + "月"));
            table.Columns.Add("Day");      //本月需要考勤的日期
            table.Columns.Add("Description");  //签到描述
            table.Columns.Add("OnTime", typeof(System.String));         //应签到时间 
            table.Columns.Add("Action");       //签到或签退
            table.Columns.Add("Time", typeof(System.String));         //签到时间
            table.Columns.Add("Info");       //显示当前是否能签到，是否已经签到
            foreach (DateTime Row in listDate)
            {
                string Time = Row.ToString("yyyy年M月d日    dddd", new System.Globalization.CultureInfo("zh-CN"));



                List<ALDto> listStats = AutofacConfig.attendanceService.GetALByUserAndDate(UserID, Convert.ToDateTime(Time));
                if (listStats != null && listStats.Count > 0)
                {
                    CommutingType = listStats[0].AL_CommutingType;      //上下班类型
                    if ((WorkTimeType)Enum.Parse(typeof(WorkTimeType), listStats[0].AL_CommutingType) == WorkTimeType.一天一上下班)            //一天一上下班
                    {
                        table.Rows.Add(Time, "上班", listStats[0].AL_OnTime.ToString("HH:mm"), listStats[0].AL_Status, listStats[0].AL_Date.ToString("HH:mm"), listStats[0].AL_Reason);
                        if (listStats.Count > 1)
                            table.Rows.Add(Time, "下班", listStats[1].AL_OnTime.ToString("HH:mm"), listStats[1].AL_Status, listStats[1].AL_Date.ToString("HH:mm"), listStats[1].AL_Reason);
                    }
                    else               //一天两上下班
                    {
                        table.Rows.Add(Time, "上午上班", listStats[0].AL_OnTime.ToString("HH:mm"), listStats[0].AL_Status, listStats[0].AL_Date.ToString("HH:mm"), listStats[0].AL_Reason);
                        if (listStats.Count > 1)
                            table.Rows.Add(Time, "下午下班", listStats[1].AL_OnTime.ToString("HH:mm"), listStats[1].AL_Status, listStats[1].AL_Date.ToString("HH:mm"), listStats[1].AL_Reason);
                        if (listStats.Count > 2)
                            table.Rows.Add(Time, "上午上班", listStats[2].AL_OnTime.ToString("HH:mm"), listStats[2].AL_Status, listStats[2].AL_Date.ToString("HH:mm"), listStats[2].AL_Reason);
                        if (listStats.Count > 3)
                            table.Rows.Add(Time, "下午下班", listStats[3].AL_OnTime.ToString("HH:mm"), listStats[3].AL_Status, listStats[3].AL_Date.ToString("HH:mm"), listStats[3].AL_Reason);
                    }
                }
            }
            this.gridView1.Reload(table);
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
                Bind();         //重新加载数据
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