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
    partial class FrmRBCreate : Swebui.Controls.SwebUserControl
    {
        public FrmRBCreate() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "Properties"
        public string RBID;//报销编号
        private string RBCC;          //成本中心编号
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmRBList() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }
        /// <summary>
        /// 报错
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {//新建
                if (string.IsNullOrEmpty(RBID))
                {
                    if (string.IsNullOrEmpty(RBCC))     //判断成本中心是否已经选择
                    {
                        throw new Exception("请选择成本中心！");
                    }
                    else
                    {
                        RBInputDto RB = new RBInputDto();       //定义一个新的报销单
                        RB.CC_ID = RBCC;             //成本中心编号
                        RB.RB_Note = this.TxtNote.Text;            //报销单备注
                                                                   //将选中的消费记录行项添加到报销单中
                        foreach (RBItemLayout Row in ItemPanels.Controls)
                        {
                            if (string.IsNullOrEmpty(Row.TypeID))
                            {
                                throw new Exception("请选择消费类别！");
                            }
                            if (string.IsNullOrEmpty(Row.RBNote))
                            {
                                throw new Exception("请输入备注！");
                            }
                            if (string.IsNullOrEmpty(Row.Amount))
                            {
                                throw new Exception("请输入消费金额！");
                            }
                            else
                            {
                                if (System.Text.RegularExpressions.Regex.IsMatch(Row.Amount.Trim(), @"^(?!0+(?:\.0+)?$)(?:[1-9]\d*|0)(?:\.\d{1,2})?$") == false)
                                {
                                    throw new Exception("金额必须为大于0的数字！");
                                }
                            }
                            //把选中行的消费记录行项的数据添加到报销单中
                            RB_RowsInputDto NewRBRow = new RB_RowsInputDto();
                            NewRBRow.R_TypeID = Row.TypeID;          //消费类型编号
                            NewRBRow.R_Amount = decimal.Parse(Row.Amount);            //消费记录金额
                            NewRBRow.R_Note = Row.RBNote;                //消费记录日期
                            NewRBRow.R_ConsumeDate = Row.RBDate;           //消费日期
                            NewRBRow.R_CreateUser = Client.Session["U_ID"].ToString();//创建用户

                            RB.RB_Rows.Add(NewRBRow);

                        }
                        RB.RB_CreateUser = Client.Session["U_ID"].ToString();               //创建用户
                        ReturnInfo r = AutofacConfig.rBService.CreateRB(RB);
                        if (r.IsSuccess == true)
                        {
                            //如果数据库添加报销记录成功
                            this.ShowResult = ShowResult.Yes;
                            Toast("报销提交成功！");
                            BackBtn_Click(null, null);
                        }
                        else
                        {
                            throw new Exception(r.ErrorInfo);
                        }
                    }
                }
                //编辑
                else
                {

                    RBInputDto ReimBur = new RBInputDto();
                    ReimBur.RB_Rows = new List<RB_RowsInputDto>();
                    ReimBur.RB_ID = this.lblRBNO.Text;            //报销单编号
                    ReimBur.CC_ID = RBCC;                   //成本中心编号
                    ReimBur.RB_Note = this.TxtNote.Text;                  //备注
                                                                          //消费记录行项更改
                    foreach (RBItemLayout Row in ItemPanels.Controls)
                    {
                        if (string.IsNullOrEmpty(Row.TypeID))
                        {
                            throw new Exception("请选择消费类别！");
                        }
                        if (string.IsNullOrEmpty(Row.RBNote))
                        {
                            throw new Exception("请输入备注！");
                        }
                        if (string.IsNullOrEmpty(Row.Amount))
                        {
                            throw new Exception("请输入消费金额！");
                        }
                        else
                        {
                            if (System.Text.RegularExpressions.Regex.IsMatch(Row.Amount.Trim(), @"^(?!0+(?:\.0+)?$)(?:[1-9]\d*|0)(?:\.\d{1,2})?$") == false)
                            {
                                throw new Exception("金额必须为大于0的数字！");
                            }
                        }
                        //把选中行的消费记录行项的数据添加到报销单中
                        RB_RowsInputDto NewRBRow = new RB_RowsInputDto();
                        NewRBRow.R_TypeID = Row.TypeID;          //消费类型编号
                        NewRBRow.R_Amount = decimal.Parse(Row.Amount);            //消费记录金额
                        NewRBRow.R_Note = Row.RBNote;  //消费记录日期
                        NewRBRow.R_ConsumeDate = Row.RBDate;           //消费日期
                        if (Row.RBRowID != null)
                            NewRBRow.RB_ID = Row.RBRowID;
                        else
                            NewRBRow.RB_ID = this.lblRBNO.Text;
                        if (Row.RID != -1)
                            NewRBRow.R_ID = Row.RID;
                        else
                        {
                            NewRBRow.R_ID = -1;
                            NewRBRow.R_CreateUser = Client.Session["U_ID"].ToString();//创建用户
                        }
                        ReimBur.RB_Rows.Add(NewRBRow);
                    }
                    ReturnInfo r = AutofacConfig.rBService.UpdateRB(ReimBur);       //将报销记录更新到数据库中
                    if (r.IsSuccess == true)
                    {
                        this.ShowResult = ShowResult.Yes;
                        Toast("报销提交成功！");
                        BackBtn_Click(null, null);
                    }
                    else
                    {
                        throw new Exception(r.ErrorInfo);
                    }
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }


        private void AddRow_Click(object sender, EventArgs e)
        {
            ItemPanels.Controls.Add(new RBItemLayout());
        }

        private void FrmRBCreate_Load(object sender, EventArgs e)
        {
            try
            {
                //获取所有成本中心数据
                List<CCDto> listCC = AutofacConfig.costCenterService.GetAllCC();
                if (listCC.Count > 0)
                {
                    foreach (CCDto cc in listCC)
                    {
                        comboBox1.Nodes.Add(new TreeSelectNode(cc.CC_ID, cc.CC_Name));
                    }

                }
                //编辑初始化
                if (string.IsNullOrEmpty(RBID) == false)
                {
                    lblRBNO.Text = RBID;
                    RBDetailDto rBDetailDto = AutofacConfig.rBService.GetByID(RBID);
                    comboBox1.DefaultValue =new string[] { rBDetailDto.CC_ID };
                    TxtNote.Text = rBDetailDto.RB_Note;
                    RBCC = rBDetailDto.CC_ID;
                    titleLab.Text = "报销编辑";
                    List<RB_RowsDto> Rows = AutofacConfig.rBService.GetRowByRBID(RBID);
                    foreach (RB_RowsDto rB_Rows in Rows)
                    {
                        ItemPanels.Controls.Add(new RBItemLayout(rB_Rows.R_ID, rB_Rows.RB_ID, rB_Rows.R_TypeID, rB_Rows.R_Amount.ToString(), rB_Rows.R_ConsumeDate, rB_Rows.R_Note));
                    }
                }

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 成本中心选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void comboBox1_Press(object sender, TreeSelectPressEventArgs args)
        {
            RBCC = args.TreeID;
        }
    }
}