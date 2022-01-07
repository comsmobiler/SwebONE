using SmoONE.DTOs;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebONE.Attendance
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmAttendanceList : Swebui.Controls.SwebUserControl
    {
        public FrmAttendanceList() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        private void FrmAttendanceList_Load(object sender, EventArgs e)
        {
            Bind();
        }
        /// <summary>
        /// 获取初始化数据
        /// </summary>
        public void Bind()
        {
            List<ATDto> listATDto = AutofacConfig.attendanceService.GetAll();

            //如果考勤模板数据条数大于0
            if (listATDto.Count > 0)
            {
                List<AttendanceManager> listAT = new List<AttendanceManager>();
                foreach (ATDto at in listATDto)
                {
                    AttendanceManager atManager = new AttendanceManager();
                    atManager.AT_ID = at.AT_ID;
                    atManager.AT_Name = at.AT_Name;
                    atManager.AT_CommutingType = at.AT_CommutingType;
                    atManager.AT_WeeklyWorkingDay = atManager.getWeekDesc(at.AT_WeeklyWorkingDay);
                    switch ((WorkTimeType)Enum.Parse(typeof(WorkTimeType), at.AT_CommutingType))
                    {
                        case WorkTimeType.一天一上下班:
                            atManager.WorkDate = "上班：" + Convert.ToDateTime(at.AT_StartTime).ToString("HH:mm") + "    下班：" + Convert.ToDateTime(at.AT_EndTime).ToString("HH:mm");
                            break;
                        case WorkTimeType.一天二上下班:
                            atManager.WorkDate = "上午上班：" + Convert.ToDateTime(at.AT_AMStartTime).ToString("HH:mm") + "    上午下班：" + Convert.ToDateTime(at.AT_AMEndTime).ToString("HH:mm");
                            atManager.WorkDate1 = "下午上班：" + Convert.ToDateTime(at.AT_PMStartTime).ToString("HH:mm") + "    下午下班：" + Convert.ToDateTime(at.AT_PMEndTime).ToString("HH:mm");
                            break;
                    }
                    atManager.AT_EffectiveDesc = at.AT_EffectiveDate.ToString("yyyy年MM月dd日");
                    listAT.Add(atManager);
                }
                gridView1.DataSource = listAT;
                gridView1.DataBind();
            }
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmAttendanceCreate() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            gridView1.GetSelectedRows((obj, args) =>
            {
                if (args.SelectedRows.Count > 0)
                {
                    Dictionary<string, object> selectrow = args.SelectedRows[0];
                    string atid = selectrow["AT_ID"].ToString();
                    FrmAttendanceCreate frmAttendanceCreate = new FrmAttendanceCreate();
                    frmAttendanceCreate.ATNo = atid;
                    frmAttendanceCreate.Flex = 1;
                    this.Parent.Controls.Add(frmAttendanceCreate);
                    this.Parent.Controls.RemoveAt(0);
                }
                else { Toast("未选择行！"); }
            });
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {

        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            gridView1.GetSelectedRows((obj, args) =>
            {
                if (args.SelectedRows.Count > 0)
                {
                    Dictionary<string, object> selectrow = args.SelectedRows[0];
                    string id = selectrow["AT_ID"].ToString();
                    FrmAttendanceView frmAttendanceView = new FrmAttendanceView() { Flex = 1 };
                    frmAttendanceView.ATNo = id;
                    this.Parent.Controls.Add(frmAttendanceView);
                    this.Parent.Controls.RemoveAt(0);
                }
                else
                {
                    Toast("未选择行！");
                }

            });
        }
    }
}