using SmoONE.CommLib;
using SmoONE.DTOs;
using SwebONE.Layout;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebONE.RB
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmRBDetail : Swebui.Controls.SwebUserControl
    {
        public FrmRBDetail() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        public FrmRBDetail(string rbid) : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
            this.RBID = rbid;
        }
        public FrmRBDetail(string rbid, bool isEA) : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
            this.RBID = rbid;
            this.IsEA = isEA;
        }
        #region "definition"
        string RBID;//RB编号
        bool IsEA;//是否审批
        internal RB_Status Status;
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        private void BackBtn_Click(object sender, EventArgs e)
        {
            if (this.Tag == null)
            {
                this.Parent.Controls.Add(new FrmRBList() { Flex = 1 });

            }
            else
            {
                Type userType = this.Tag as Type;
                SwebControl swebControl = Activator.CreateInstance(userType) as SwebControl;
                swebControl.Flex = 1;
                this.Parent.Controls.Add(swebControl);
            }
            this.Parent.Controls.RemoveAt(0);
        }

        private void FrmRBDetail_Load(object sender, EventArgs e)
        { //初始化
            if (string.IsNullOrEmpty(RBID) == false)
            {
                lblRBNO.Text = RBID;
                RBDetailDto rBDetailDto = AutofacConfig.rBService.GetByID(RBID);
                CCDetailDto cCDetailDto = AutofacConfig.costCenterService.GetCCByID(rBDetailDto.CC_ID);
                TextCC.Text = cCDetailDto.CC_Name;
                TxtNote.Text = rBDetailDto.RB_Note;
                TxtAmount.Text = rBDetailDto.RB_TotalAmount.ToString();
                lblRBNO.Text = rBDetailDto.RB_ID;
                Status = (RB_Status)rBDetailDto.RB_Status;
                statusLab.Text = ((RB_Status)rBDetailDto.RB_Status).ToString();
                Txtdate.Text = rBDetailDto.RB_CreateDate.ToString();
                TxtReason.Text = rBDetailDto.RB_RejectionReason;
                if (rBDetailDto.RB_Status == 0)
                    statusLab.ForeColor = System.Drawing.Color.Orange;
                else if (rBDetailDto.RB_Status == -1)
                    statusLab.ForeColor = System.Drawing.Color.Red;
                else
                    statusLab.ForeColor = System.Drawing.Color.Green;
                List<RB_RowsDto> Rows = AutofacConfig.rBService.GetRowByRBID(RBID);
                foreach (RB_RowsDto rb in Rows)
                {
                    ItemPanels.Controls.Add(new RBItemLayoutRead(rb.R_TypeName, rb.R_Amount.ToString(), rb.R_ConsumeDate, rb.R_Note));
                }
            }
            if (IsEA == true)
            {
                yesBtn.Visible = noBtn.Visible = true;
            }


        }
        /// <summary>
        /// 审批同意
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void yesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                switch (Status)
                {
                    case RB_Status.新建:
                        Status = RB_Status.责任人审批;
                        break;
                    case RB_Status.责任人审批:
                        Status = RB_Status.行政审批;
                        break;
                    case RB_Status.行政审批:
                        Status = RB_Status.财务审批;
                        break;
                }
                ReturnInfo r = AutofacConfig.rBService.UpdateRBStatus(RBID, Status, Client.Session["U_ID"].ToString(), "");           //保存报销单
                if (r.IsSuccess == true)
                {
                    Toast("审批成功");
                    BackBtn_Click(null, null);
                }
                else
                {
                    throw new Exception(r.ErrorInfo);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 审批拒绝
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void noBtn_Click(object sender, EventArgs e)
        {
            FrmRefuseLayout refuseLayout = new FrmRefuseLayout(1, RBID);
            this.Form.ShowDialog(refuseLayout, (obj, args) =>
            {
                if (refuseLayout.ShowResult== ShowResult.Yes)
                {
                    if (refuseLayout.Result.IsSuccess == true)
                    {
                        Toast("已拒绝报销！", ToastLength.SHORT);
                        BackBtn_Click(null, null);
                    }
                    else
                    {
                        throw new Exception(refuseLayout.Result.ErrorInfo);
                    }
                }
            });
        }
    }

}