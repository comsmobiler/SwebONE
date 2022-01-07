using SmoONE.DTOs;
using SwebONE.Layout;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebONE.CostCenter
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmCCAnalyseDetail : Swebui.Controls.SwebUserControl
    {
        public FrmCCAnalyseDetail() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        public string CCID;//成本中心
        public string CC_Name;//名称
        public decimal CC_Amount;//成本中心金额
        public string CC_LiableMan;//负责人
        private decimal CC_confirmAmount = 0;//已报销金额
        private decimal CC_createAmount = 0;//报销中金额
        private List<ReimbursementDto> listRBDto = new List<ReimbursementDto>();
        #endregion
        private void FrmCCAnalyseDetail_Load(object sender, EventArgs e)
        {
            idLab.Text = CCID;
            nameLab.Text = CC_Name;
            manLab.Text = CC_LiableMan;
            getRBDate();
            getCCFXDate();
            getBindtableDate("已报销");
        }
        /// <summary>
        /// 获取成本中心报销分析数据
        /// </summary>
        private void getRBDate()
        {

            try
            {
                //获取当前成本中心的报销数据
                listRBDto = AutofacConfig.rBService.GetByCCID(CCID);
                if (listRBDto.Count > 0)
                {
                    foreach (ReimbursementDto reimbursement in listRBDto)
                    {
                        switch (reimbursement.RB_Status)
                        {
                            case (int)RB_Status.新建:
                                break;
                            case (int)RB_Status.责任人审批:
                            case (int)RB_Status.行政审批:
                                CC_createAmount += reimbursement.RB_TotalAmount;
                                break;
                            case (int)RB_Status.财务审批:
                                CC_confirmAmount += reimbursement.RB_TotalAmount;

                                break;

                        }
                    }
                }
            }

            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
        }
        /// <summary>
        /// 绑定拼图分析数据
        /// </summary>
        private void getCCFXDate()
        {

            try
            {
                eCharts1.Option = @" {
  title: {
    text: '报销统计',
    left: 'center'
  },
  tooltip: {
    trigger: 'item'
  },
  legend: {
    orient: 'vertical',
    left: 'left'
  },
  series: [
    {
      name: '报销统计',
      type: 'pie',
      radius: '50%',
      data: [
        { value: " + CC_confirmAmount + @", name: '" + "已报销" + @"' },
        { value: " + CC_createAmount + @", name: '" + "报销中" + @"' },
        { value:" + (CC_Amount - CC_confirmAmount - CC_createAmount) + @", name: '" + "剩余金额" + @"' }
      ],
      emphasis: {
        itemStyle: {
          shadowBlur: 10,
          shadowOffsetX: 0,
          shadowColor: 'rgba(0, 0, 0, 0.5)'
        }
      }
    }
  ]
}";


            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }

        }

        /// <summary>
        /// 获取报销明细数据
        /// </summary>
        /// <param name="type"></param>
        private void getBindtableDate(string type)
        {

            try
            {
                if (type.Equals("已报销"))
                    itemTitle.Text = "已报销清单";
                else if(type.Equals("报销中"))
                    itemTitle.Text = "报销中清单";
                itemPanel.Controls.Clear();
                //如果报销数据条数大于0，分析数据
                if (listRBDto.Count > 0 & (type.Equals("已报销") || type.Equals("报销中")))
                {
                    List<string> listRBNO = new List<string>();
                    foreach (ReimbursementDto reimbursement in listRBDto)
                    {
                        if ((type.Equals("已报销") & reimbursement.RB_Status.Equals((int)RB_Status.财务审批)) || (type.Equals("报销中") & (reimbursement.RB_Status.Equals((int)RB_Status.责任人审批) || reimbursement.RB_Status.Equals((int)RB_Status.行政审批))))
                        {
                            listRBNO.Add(reimbursement.RB_ID);
                        }
                    }
                    if (listRBNO.Count > 0)
                    {
                        foreach (string rbNO in listRBNO)
                        {
                            List<RB_RowsDto> Rows = AutofacConfig.rBService.GetRowByRBID(rbNO);         //查找报销单的消费记录信息
                            if (Rows.Count > 0)
                            {
                                foreach (RB_RowsDto Row in Rows)
                                {
                                    UserDetailDto user = AutofacConfig.userService.GetUserByUserID(Row.R_CreateUser);
                                    string username = "";
                                    if (user != null & string.IsNullOrEmpty(user.U_Name) == false)
                                    {
                                        username = user.U_Name;
                                    }
                                    itemPanel.Controls.Add(new CCDetialLayout(Row.RB_ID, Row.R_ConsumeDate.ToString(), Row.R_TypeName, Row.R_Amount.ToString(), username));
                                }
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmCCAnalyseList() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }

        private void eCharts1_EChartsPress(object sender, EChartsPressEventArgs e)
        {
            if (e.Data != null)
            {
                Dictionary<string, object> keyValuePairs = (Dictionary<string, object>)e.Data;
                if(keyValuePairs.ContainsKey(("name")))
                {
                    if (keyValuePairs["name"].ToString() == "已报销")
                    {
                        getBindtableDate("已报销");
                    }
                    else if (keyValuePairs["name"].ToString() == "报销中")
                    {
                        getBindtableDate("报销中");
                    }
                }
            }
        }
    }
}