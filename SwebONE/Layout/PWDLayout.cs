using SmoONE.CommLib;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebONE.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class PWDLayout : Swebui.Controls.SwebUserControl
    {
        #region "definition"
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        string oldPwd = "";
        #endregion
        public PWDLayout() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string pwd1 = txtPwd1.Text.Trim();
                string pwd2 = txtPwd2.Text.Trim();
                if (string.IsNullOrEmpty(oldPwd) == true)
                {
                    throw new Exception("请输入原密码！");
                }
                if (pwd1.Length <= 0)
                {
                    throw new Exception("请输入新密码！");
                }

                if (pwd2.Length <= 0)
                {
                    throw new Exception("请输入确认密码！");
                }
                if (!pwd1.Equals(pwd2))
                {
                    throw new Exception("两次密码输入不一致，请检查！");
                }
                if (pwd1.Length < 6 || pwd1.Length > 12)
                {
                    throw new Exception("新密码必须为6-12位！");
                }
                if (pwd2.Length < 6 || pwd2.Length > 12)
                {
                    throw new Exception("确认密码必须为6-12位！");
                }

                if (oldPwd != null)
                {
                    //新密码处理,经过加密
                    string encryptPwd = AutofacConfig.userService.Encrypt(pwd2);
                    if (oldPwd.Equals(encryptPwd))
                    {
                        throw new Exception("您输入新密码和原密码密码一致，请重新输入！");
                    }
                    //更改密码
                    ReturnInfo result = AutofacConfig.userService.ChangePwd(Client.Session["U_ID"].ToString(), oldPwd, encryptPwd);
                    //如果返回true则修改成功，否则弹出错误
                    if (result.IsSuccess == true)
                    {
                        Close();
                        Toast("密码修改成功！", ToastLength.SHORT);
                    }
                    else
                    {
                        throw new Exception(result.ErrorInfo);
                    }
                }

            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }

        }
        /// <summary>
        /// 验证原密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {//判断用户密码是否正确
            string Pwd = txtEditInfo.Text.Trim();
            string encryptPwd = AutofacConfig.userService.Encrypt(Pwd);
            bool result = AutofacConfig.userService.IsPwd(Client.Session["U_ID"].ToString(), encryptPwd);
            if (result == false)
            {
                txtEditInfo.Text = "";
                errorlab.Text = "你输入的原密码不正确，请重新输入！";
            }
            else
            {
                oldPwd = encryptPwd;
                panel4.Visible = oldPsdPanel.Visible = false;
                panel5.Visible = panel6.Visible = true;
            }

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}