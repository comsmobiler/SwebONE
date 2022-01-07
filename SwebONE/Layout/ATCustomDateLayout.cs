using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmoONE.DTOs;
using System.Data;

namespace SwebONE.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class ATCustomDateLayout : Swebui.Controls.SwebUserControl
    {
        public ATCustomDateLayout() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        public string ATNo;//考勤模板编号
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类 
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ATCoustomDateLayout_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ATNo) == false)
            {
                List<ATCDDto> aTCDDtos = AutofacConfig.attendanceService.GetATCDByATID(ATNo);
                if (aTCDDtos.Count > 0)
                {
                    panel2.Visible = true;
                    lblinfo.Visible = false;
                    DataTable dt = new DataTable();
                    dt.Columns.Add("AT_CD_Date");
                    dt.Columns.Add("AT_CD_CDType");
                    foreach(ATCDDto  dto in aTCDDtos)
                    {
                        dt.Rows.Add(dto.AT_CD_Date.ToString("yyyy-MM-dd"), dto.AT_CD_CDType);
                    }
                    gridView1.DataSource = dt;
                    gridView1.DataBind();
                }
                else
                {
                    lblinfo.Text = "无自定义日期";
                    lblinfo.Visible = true;
                    panel2.Visible = false;
                }
            }
        }
    }
}