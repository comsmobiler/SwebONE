using SmoONE.CommLib;
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

    partial class FrmAttendanceMain : Swebui.Controls.SwebUserControl
    {
        public FrmAttendanceMain() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }

        #region "definition"
        public string ATNo;//考勤模板编号
        private WorkTimeType ATMode;//考勤类型
        private ATInputDto ATemplate = new ATInputDto();//考勤
        public string CommutingType;    //上下班状态
        string UserID;
        DateTime AL_Date;   //签到时间
        public int LocState;      //定位状态
        public string Location;        //定位签到所在位置
        public bool? hasgps = null;    //是否获取GPS   
        internal ALInputDto newLog = new ALInputDto();     //新建日志传输对象
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类 
        #endregion

        private void FrmAttendanceMain_Load(object sender, EventArgs e)
        {
            try
            {
                lblWeekDay.Text = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(DateTime.Today.DayOfWeek);  //显示当前星期几
                lblDate.Text = DateTime.Now.ToString("yyyy年MM月dd日");      //显示当前日期
                UserID = Client.Session["U_ID"].ToString();
                ATNo = AutofacConfig.attendanceService.GetATIDByATUser(UserID);
                if (string.IsNullOrEmpty(ATNo) == false)
                {
                    ATDetailDto At = AutofacConfig.attendanceService.GetATByID(ATNo);
                }
                WorkTimeDto WorkTime = AutofacConfig.attendanceService.GetCurrantASByUser(UserID);
                if (WorkTime != null)
                {
                    //获取定位信息：经纬度和所处位置
                    this.Client.GetGps(new GpsCallBackHandler((ss, ee) =>
                     {
                         if (ee.isError == true)
                         {
                             hasgps = false;
                         }
                         else
                         {
                             hasgps = true;
                         }
                         ee.Longitude = 120.75090000;
                         ee.Latitude = 30.76265000;
                         if ((ee.Latitude == Convert.ToDouble(WorkTime.AT_Latitude) && ee.Longitude == Convert.ToDouble(WorkTime.AT_Longitude)) || ATAddressDistance.GetDistance(Convert.ToDouble(ee.Latitude), Convert.ToDouble(ee.Longitude), Convert.ToDouble(WorkTime.AT_Latitude), Convert.ToDouble(WorkTime.AT_Longitude)) < Convert.ToDouble(WorkTime.AT_AllowableDeviation.ToString()))
                         {
                             LocState = 1;
                             Location = ee.Location;        //定位签到所在位置
                             Location = "嘉兴";
                         }
                         else
                         {
                             LocState = 2;
                         }
                     }));
                    Bind();

                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        public void Bind()
        {
            try
            {
                DataTable table = new DataTable();
                table.Columns.Add("ID");           //签到模板编号
                table.Columns.Add("Picture");      //签到图片
                table.Columns.Add("Description");  //签到描述
                table.Columns.Add("Time", typeof(System.String));         //签到时间
                table.Columns.Add("Img");          //图片ID
                table.Columns.Add("Action");       //签到或签退
                table.Columns.Add("Info");       //显示当前是否能签到，是否已经签到
                WorkTimeDto Mode = AutofacConfig.attendanceService.GetCurrantASByUser(UserID);
                CommutingType = Mode.AT_CommutingType;           //上下班类型
                if (Mode.AT_ASType == "上班")
                {
                    if ((WorkTimeType)Enum.Parse(typeof(WorkTimeType), Mode.AT_CommutingType) == WorkTimeType.一天一上下班)            //一天一上下班
                    {
                        table.Rows.Add("4", "shangban1", "上班", Convert.ToDateTime(Mode.AT_StartTime).ToString("HH:mm"), null, null, "未开始");
                        table.Rows.Add("5", "xiaban1", "下班", Convert.ToDateTime(Mode.AT_EndTime).ToString("HH:mm"), null, null, "未开始");
                    }
                    else                     //一天两上下班
                    {
                        table.Rows.Add("0", "shangban1", "上午上班", Convert.ToDateTime(Mode.AT_AMStartTime).ToString("HH:mm"), null, null, "未开始");
                        table.Rows.Add("1", "gongzuozhong1", "上午下班", Convert.ToDateTime(Mode.AT_AMEndTime).ToString("HH:mm"), null, null, "未开始");
                        table.Rows.Add("2", "gongzuozhong1", "下午上班", Convert.ToDateTime(Mode.AT_PMStartTime).ToString("HH:mm"), null, null, "未开始");
                        table.Rows.Add("3", "xiaban1", "下午下班", Convert.ToDateTime(Mode.AT_PMEndTime).ToString("HH:mm"), null, null, "未开始");
                    }
                }
                else
                {
                    this.lblInfo.Visible = true;
                    this.lblInfo.Text = "今天是休息日！";
                }
                List<ALDto> listLogs = AutofacConfig.attendanceService.GetALByUserAndDate(UserID, DateTime.Now);        //判断当天是否已经有签到
                if (listLogs.Count == table.Rows.Count)       //如果当天已完成所有签到
                {
                    //    DayTime = DateTime.Now.ToString();            //给DayTime值，使得页面显示统计模式
                }

                int x = 0;
                while (x < table.Rows.Count - 1)    //当上一条行项未签到，且时间已超过下一行项的签到时间时，显示未签到
                {
                    if (DateTime.Now >= Convert.ToDateTime(table.Rows[x + 1]["Time"]))
                    {
                        if (Convert.ToInt32(table.Rows[x]["ID"].ToString()) % 2 == 0)
                        {
                            table.Rows[x]["Info"] = "未签到";
                        }
                        else
                        {
                            table.Rows[x]["Info"] = "未签退";
                        }
                        x++;
                    }
                    else
                    {
                        x++;
                        break;
                    }
                }
                int count = 0;             //当前页面未签到和未签退的行项数
                foreach (DataRow Row in table.Rows)
                {
                    if (Row["Info"].ToString() == "未签到" || Row["Info"].ToString() == "未签退")
                    {
                        count++;
                    }
                }
                for (int i = listLogs.Count; i < count; i++)//当未签行项数大于数据库已记录未签条数时
                {
                    if (table.Rows[i]["Info"].ToString() == "未签到" || table.Rows[i]["Info"].ToString() == "未签退")
                    {
                        newLog.AL_Reason = null;
                        switch ((StatisticsTime)Enum.Parse(typeof(StatisticsTime), table.Rows[i]["Description"] + "时间"))
                        {
                            case StatisticsTime.上午上班时间:
                                newLog.AL_LogTimeType = StatisticsTime.上午上班时间;
                                break;
                            case StatisticsTime.上午下班时间:
                                newLog.AL_LogTimeType = StatisticsTime.上午下班时间;
                                break;
                            case StatisticsTime.下午上班时间:
                                newLog.AL_LogTimeType = StatisticsTime.下午上班时间;
                                break;
                            case StatisticsTime.下午下班时间:
                                newLog.AL_LogTimeType = StatisticsTime.下午下班时间;
                                break;
                            case StatisticsTime.上班时间:
                                newLog.AL_LogTimeType = StatisticsTime.上班时间;
                                break;
                            case StatisticsTime.下班时间:
                                newLog.AL_LogTimeType = StatisticsTime.下班时间;
                                break;
                        }
                        newLog.AL_Date = DateTime.Now;      //考勤日期
                        newLog.AL_UserID = UserID;          //用户ID
                        if ((WorkTimeType)Enum.Parse(typeof(WorkTimeType), CommutingType) == WorkTimeType.一天一上下班)
                        {
                            newLog.AL_CommutingType = WorkTimeType.一天一上下班;       //上下班类型
                        }
                        else
                        {
                            newLog.AL_CommutingType = WorkTimeType.一天二上下班;        //上下班类型
                        }
                        newLog.AL_Position = "无签到地点";                 //考勤地点
                        newLog.AL_OnTime = Convert.ToDateTime(table.Rows[i]["Time"]);    //签到准点时间
                        if (Convert.ToInt32(table.Rows[i]["ID"].ToString()) % 2 == 0)            //判断考勤状态
                        {
                            newLog.AL_Status = AttendanceType.未签到;
                        }
                        else
                        {
                            newLog.AL_Status = AttendanceType.未签退;
                        }
                        ReturnInfo r = AutofacConfig.attendanceService.AddAttendanceLog(newLog);
                    }
                }
                if (Convert.ToInt32(table.Rows[x - 1]["ID"]) % 2 == 0)
                {
                    table.Rows[x - 1]["Action"] = "签到";    //尚未签到的第一行，显示签到(签退)按钮 
                }
                else
                {
                    table.Rows[x - 1]["Action"] = "签退";    //尚未签到的第一行，显示签到(签退)按钮 
                }
                List<ALDto> listNewLogs = AutofacConfig.attendanceService.GetALByUserAndDate(UserID, DateTime.Now);        //判断当天是否已经有签到                
                for (int i = 0; i < listNewLogs.Count; i++)
                {
                    table.Rows[i]["Action"] = null;           //隐藏已签到这行的签到按钮
                    if (Convert.ToInt32(table.Rows[i + 1]["ID"]) % 2 == 0)
                    {
                        table.Rows[i + 1]["Action"] = "签到";    //尚未签到的第一行，显示签到(签退)按钮 
                    }
                    else
                    {
                        table.Rows[i + 1]["Action"] = "签退";    //尚未签到的第一行，显示签到(签退)按钮 
                    }
                    foreach (ALDto Row in listNewLogs)
                    {
                        AL_Date = Row.AL_Date;                 //考勤时间
                        if (Convert.ToInt32(table.Rows[i]["ID"].ToString()) % 2 == 0 && listNewLogs[i].AL_Status != "未签到")         //显示已签和签到时间
                        {
                            table.Rows[i]["Info"] = "已签到" + "  " + AL_Date.ToString("HH:mm");
                        }
                        else if (Convert.ToInt32(table.Rows[i]["ID"].ToString()) % 2 == 1 && listNewLogs[i].AL_Status != "未签退")
                        {

                            table.Rows[i]["Info"] = "已签退" + "  " + AL_Date.ToString("HH:mm");
                        }
                        if (Row.AL_OnTime == Convert.ToDateTime(table.Rows[i]["Time"]))
                        {
                            if (Row.AL_Status == "未签到" || Row.AL_Status == "未签退")         //显示未签
                            {
                                table.Rows[i]["Info"] = Row.AL_Status;
                            }
                            if (string.IsNullOrEmpty(Row.AL_Reason) == false)   //如果有迟到早退原因，显示信息提示框
                            {
                                table.Rows[i]["Img"] = "!\\ue85d000146223";
                            }
                        }
                    }
                    ATMainPicture.BlackWhite(table, i);        //已经签到的行项中，图片显示黑白
                }
                ATMainPicture.getPictures(table);        //对每个行项进行匹配，显示正确的图片信息
                listView1.Rows.Clear();
                if (table.Rows.Count > 0)           //如果数据不为空
                {
                    this.listView1.DataSource = table;
                    this.listView1.DataBind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}