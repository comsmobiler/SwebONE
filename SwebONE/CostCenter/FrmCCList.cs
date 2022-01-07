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
    partial class FrmCCList : Swebui.Controls.SwebUserControl
    {
        public FrmCCList() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        private void AddBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmCCCreate() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmCCList() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }

        private void FrmCCList_Load(object sender, EventArgs e)
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
                label2.Visible = false;
                gridView1.Visible = true;
                gridView1.DataSource = listCC;
                gridView1.DataBind();
            }
            else
            {
                label2.Visible = true;
                gridView1.Visible = false;
               
            }
        }
    }
}