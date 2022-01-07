using SmoONE.CommLib;
using SmoONE.DTOs;
using SwebONE.Attendance;
using SwebONE.Work;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebONE.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class ATMainLayout : Swebui.Controls.SwebUserControl
    {
        public ATMainLayout() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类  
        private void btnCheck_Click(object sender, EventArgs e)
        {

            try
            {

                ((FrmWork)(this.Owner.Parent.Parent.Parent)).newLog.AL_Reason = "";
                switch ((StatisticsTime)Enum.Parse(typeof(StatisticsTime), lblType.BindDataValue.ToString()))
                {
                    case StatisticsTime.上午上班时间:
                        ((FrmWork)(this.Owner.Parent.Parent.Parent)).newLog.AL_LogTimeType = StatisticsTime.上午上班时间;
                        break;
                    case StatisticsTime.上午下班时间:
                        ((FrmWork)(this.Owner.Parent.Parent.Parent)).newLog.AL_LogTimeType = StatisticsTime.上午下班时间;
                        break;
                    case StatisticsTime.下午上班时间:
                        ((FrmWork)(this.Owner.Parent.Parent.Parent)).newLog.AL_LogTimeType = StatisticsTime.下午上班时间;
                        break;
                    case StatisticsTime.下午下班时间:
                        ((FrmWork)(this.Owner.Parent.Parent.Parent)).newLog.AL_LogTimeType = StatisticsTime.下午下班时间;
                        break;
                    case StatisticsTime.上班时间:
                        ((FrmWork)(this.Owner.Parent.Parent.Parent)).newLog.AL_LogTimeType = StatisticsTime.上班时间;
                        break;
                    case StatisticsTime.下班时间:
                        ((FrmWork)(this.Owner.Parent.Parent.Parent)).newLog.AL_LogTimeType = StatisticsTime.下班时间;
                        break;
                }
                  ((FrmWork)(this.Owner.Parent.Parent.Parent)).newLog.AL_Date = DateTime.Now;          //签到时间
                ((FrmWork)(this.Owner.Parent.Parent.Parent)).newLog.AL_UserID = Client.Session["U_ID"].ToString();              //用户ID
                if ((WorkTimeType)Enum.Parse(typeof(WorkTimeType), ((FrmWork)(this.Owner.Parent.Parent.Parent)).CommutingType) == WorkTimeType.一天一上下班)
                {
                    ((FrmWork)(this.Owner.Parent.Parent.Parent)).newLog.AL_CommutingType = WorkTimeType.一天一上下班;
                }
                else
                {
                    ((FrmWork)(this.Owner.Parent.Parent.Parent)).newLog.AL_CommutingType = WorkTimeType.一天二上下班;
                }
               ((FrmWork)(this.Owner.Parent.Parent.Parent)).newLog.AL_Position = ((FrmWork)(this.Owner.Parent.Parent.Parent)).Location;                //签到位置
                ((FrmWork)(this.Owner.Parent.Parent.Parent)).newLog.AL_OnTime = Convert.ToDateTime(lblTime.BindDisplayValue.ToString());       //签到准点
                if (((FrmWork)(this.Owner.Parent.Parent.Parent)).LocState == 1)              //已成功定位
                {
                    if (btnCheck.Text == "签到")
                    {
                        if (DateTime.Now > Convert.ToDateTime(lblTime.BindDisplayValue.ToString()))
                        {
                            ((FrmWork)(this.Owner.Parent.Parent.Parent)).newLog.AL_Status = AttendanceType.迟到;         //签到状态  
                            AttendanceMainLayoutDialog frmReason = new AttendanceMainLayoutDialog();
                            frmReason.newLog = ((FrmWork)(this.Owner.Parent.Parent.Parent)).newLog;
                            frmReason.lblTitle.Text = "迟到理由";
                            this.Form.ShowDialog(frmReason, (obj, arg) =>
                            {
                                if (frmReason.ShowResult == true)
                                    ((FrmWork)(this.Owner.Parent.Parent.Parent)).GetAttendanceInfo();
                            });
                        }
                        else
                        {
                            ((FrmWork)(this.Owner.Parent.Parent.Parent)).newLog.AL_Status = AttendanceType.准点;             //签到状态
                            ReturnInfo r = AutofacConfig.attendanceService.AddAttendanceLog(((FrmWork)(this.Owner.Parent.Parent.Parent)).newLog);
                            if (r.IsSuccess == true)         //添加记录成功
                            {
                                this.Form.Toast("签到成功！");
                                ((FrmWork)(this.Owner.Parent.Parent.Parent)).GetAttendanceInfo();                     //刷新页面
                            }
                            else
                            {
                                throw new Exception(r.ErrorInfo);        //提示添加记录失败原因
                            }
                        }
                    }
                    else if (btnCheck.Text == "签退")
                    {
                        if (DateTime.Now < Convert.ToDateTime(lblTime.BindDisplayValue.ToString()))
                        {
                            MessageBox.Show("现在是早退时间，确认签退吗？", MessageBoxButtons.OKCancel, (object o, MessageBoxHandlerArgs args) =>
                            {
                                if (args.Result == ShowResult.OK)
                                {
                                    ((FrmWork)(this.Owner.Parent.Parent.Parent)).newLog.AL_Status = AttendanceType.早退;           //签到状态
                                    AttendanceMainLayoutDialog frmReason = new AttendanceMainLayoutDialog();
                                    frmReason.newLog = ((FrmWork)(this.Owner.Parent.Parent.Parent)).newLog;
                                    frmReason.lblTitle.Text = "早退理由";
                                    this.Form.ShowDialog(frmReason, (obj, arg) =>
                                    {
                                        if (frmReason.ShowResult == true)
                                            ((FrmWork)(this.Owner.Parent.Parent.Parent)).GetAttendanceInfo();
                                    });
                                }
                            });
                        }
                        else
                        {
                            ((FrmWork)(this.Owner.Parent.Parent.Parent)).newLog.AL_Status = AttendanceType.准点;
                            ReturnInfo r = AutofacConfig.attendanceService.AddAttendanceLog(((FrmWork)(this.Owner.Parent.Parent.Parent)).newLog);
                            if (r.IsSuccess == true)             //添加记录成功
                            {
                                this.Form.Toast("签退成功！");
                                ((FrmWork)(this.Owner.Parent.Parent.Parent)).GetAttendanceInfo();                  //刷新页面
                            }
                            else
                            {
                                throw new Exception(r.ErrorInfo);
                            }
                        }
                    }
                }
                else if (((FrmWork)(this.Owner.Parent.Parent.Parent)).LocState == 2)
                {
                    if (btnCheck.Text == "签到")
                    {
                        throw new Exception("签到失败，您当前不在公司附近");
                    }
                    else if (btnCheck.Text == "签退")
                    {
                        throw new Exception("签退失败，您当前不在公司附近");
                    }
                }
            }
            catch (Exception ex)
            {
                this.Form.Toast(ex.Message);
            }
        }
    }
}