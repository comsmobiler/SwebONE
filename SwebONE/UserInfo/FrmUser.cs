using SmoONE.CommLib;
using SmoONE.DTOs;
using SwebONE.Layout;
using Swebui;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebONE.UserInfo
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmUser : Swebui.Controls.SwebUserControl
    {
        public FrmUser() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        internal string toolbarItemName = "";
        private int eInfo;
        private Sex sex;//性别
        private DateTime toasttime;//toast时间
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// 修改头像
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Form.Client.FileUpload((obj, args) =>
            {
                if (args.isError == false)
                {
                    UserInputDto upuser = new UserInputDto();
                    upuser.U_ID = Client.Session["U_ID"].ToString();
                    upuser.U_Portrait = userImg.ResourceID;
                    ReturnInfo result = AutofacConfig.userService.UpdateUser(upuser);
                    if (result.IsSuccess == false)
                    {
                        Toast(result.ErrorInfo, ToastLength.SHORT);
                    }
                    else
                    {
                        string[] suffixs = args.ResourceID.Split('.');
                        string imgName = "";
                        if (userImg.ResourceID == "boy" || userImg.ResourceID == "girl")
                        {
                            imgName = upuser.U_ID + "img" + "." + suffixs[1];

                            args.SaveFile(imgName, SwebResourceManager.DefaultImagePath);
                        }
                        else

                        {
                            string[] suffixs1 = userImg.ResourceID.Split('.');
                            if (suffixs.Length > 1)
                            {
                                imgName = suffixs1[0] + "." + suffixs[1];
                            }
                            else
                                imgName = userImg.ResourceID + "." + suffixs[1];
                            args.SaveFile(imgName, SwebResourceManager.DefaultImagePath);

                        }
                        userImg.ResourceID = userImg1.ResourceID = imgName;
                        userImg.Refresh();
                        userImg1.Refresh();
                    }
                }
            });
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            GetUser();
        }
        /// <summary>
        /// 获取用户信息
        /// </summary>
        public void GetUser()
        {
            try
            {
                btnEmail.ReadOnly = btnName.ReadOnly = true;
                saveBtn.Visible = cancelBtn.Visible = false;
                editBtn.Visible = true;
                UserDetails userDetails = new UserDetails();
                UserDetailDto user = userDetails.getUser(Client.Session["U_ID"].ToString());

                if (user != null)
                {
                    // imgPortrait.ResourceID = user.U_Portrait;
                    userImg.ResourceID = userImg1.ResourceID = user.U_Portrait;
                    btnName.Text = btnName1.Text = user.U_Name;
                    labTel.Text = user.U_Tel;
                    if (string.IsNullOrEmpty(user.U_DepID) == false)
                    {
                        DepDetailDto department = AutofacConfig.departmentService.GetDepartmentByDepID(user.U_DepID);
                        labDep.Text = department.Dep_Name;

                    }
                    else labDep.Text = "无";
                    sex = (Sex)user.U_Sex;
                    switch (sex)
                    {
                        case Sex.男:
                            btnSex.Text = "男";
                            break;
                        case Sex.女:
                            btnSex.Text = "女";
                            break;
                    }
                    dpkBirthday.Value = user.U_Birthday;
                    btnEmail.Text = user.U_Email;
                }
                else
                {
                    throw new Exception("用户" + Client.Session["U_ID"].ToString() + "不存在，请检查！");
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 编辑按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editBtn_Click(object sender, EventArgs e)
        {
            btnEmail.ReadOnly = btnName.ReadOnly = false;
            saveBtn.Visible = cancelBtn.Visible = true;
            editBtn.Visible = false;
        }
        /// <summary>
        /// 取消编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            GetUser();
        }
        /// <summary>
        /// 保存编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                UserInputDto upuser = new UserInputDto();
                upuser.U_ID = Client.Session["U_ID"].ToString();
                upuser.U_Birthday = dpkBirthday.Value;
                upuser.U_Name = btnName.Text.Trim();
                upuser.U_Email = btnEmail.Text.Trim();
                upuser.U_Sex = (Sex)Convert.ToInt32(btnSex.SelectKey);
                ReturnInfo result = AutofacConfig.userService.UpdateUser(upuser);
                //返回结果如果为false，则修改失败
                if (result.IsSuccess == false)
                {
                    GetUser();
                    throw new Exception(result.ErrorInfo);
                }
                else
                {
                    GetUser();
                    Toast("保存成功", ToastLength.SHORT);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void psdChange_Click(object sender, EventArgs e)
        {
            ShowDialog(new PWDLayout());
        }
    }
}