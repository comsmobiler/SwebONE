using SmoONE.DTOs;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebONE.CostCenter
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmCCAnalyseList : Swebui.Controls.SwebUserControl
    {
        public FrmCCAnalyseList() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        private void AddBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmCCAnalyseDetail());
            this.Parent.Controls.RemoveAt(0);
        }
        private void FrmCCAnalyseList_Load(object sender, EventArgs e)
        {
            Bind();

        }
        /// <summary>
        /// 初始化方法
        /// </summary>
        public void Bind()
        {
            //获取所有成本中心数据
            List<CCDto> listCC = AutofacConfig.costCenterService.GetAllCC();

            if (listCC.Count > 0)
            {
                foreach (CCDto cc in listCC)
                {
                    UserDetailDto user = AutofacConfig.userService.GetUserByUserID(cc.CC_LiableMan);
                    cc.CC_LiableMan = user.U_Name;

                }

                gridView1.DataSource = listCC;
                gridView1.DataBind();
            }

        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            gridView1.GetSelectedRows((obj, args) =>
            {
                if (args.SelectedRows.Count > 0)
                {
                    Dictionary<string, object> selectrow = args.SelectedRows[0];
                    string id = selectrow["CC_ID"].ToString();
                    FrmCCAnalyseDetail frmCCAnalyseDetail = new FrmCCAnalyseDetail();
                    frmCCAnalyseDetail.CCID = id;
                    frmCCAnalyseDetail.CC_Amount = decimal.Parse(selectrow["CC_Amount"].ToString());
                    frmCCAnalyseDetail.CC_LiableMan = selectrow["CC_LiableMan"].ToString();
                    frmCCAnalyseDetail.CC_Name = selectrow["CC_Name"].ToString();
                    frmCCAnalyseDetail.Flex = 1;
                    this.Parent.Controls.Add(frmCCAnalyseDetail);
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