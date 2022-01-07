using SmoONE.CommLib;
using SmoONE.DTOs;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebONE.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class AttendanceMainLayoutDialog : Swebui.Controls.SwebUserControl
    {
        public AttendanceMainLayoutDialog() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        public ALInputDto newLog = new ALInputDto();     //新建日志传输对象
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类     
        public bool ShowResult = false;   //是否提交
        #endregion
        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtReason.Text) == true)         //原因不能为空
                {
                    throw new Exception(this.txtReason + "不能为空");
                }
                newLog.AL_Reason = this.txtReason.Text;           //迟到早退原因
                ReturnInfo r = AutofacConfig.attendanceService.AddAttendanceLog(newLog);
                if (r.IsSuccess == true)               //提交记录成功
                {
                    ShowResult = true;
                    this.Close();
                    if (lblTitle.Text == "迟到理由")
                    {
                        this.Form.Toast("签到成功");
                    }
                    else
                    {
                        this.Form.Toast("签退成功");
                    }
                 //   ((FrmWork)(Form)).Bind();                     //刷新页面
                }
                else
                {
                    throw new Exception(r.ErrorInfo);
                }
            }
            catch (Exception ex)
            {
                this.Form.Toast(ex.Message);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}