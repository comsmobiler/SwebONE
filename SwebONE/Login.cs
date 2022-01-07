using SmoONE.CommLib;
using SmoONE.Domain;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebONE
{
    partial class Login : Swebui.Controls.SwebForm
    {
        public Login() : base()
        {
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {

                string userID = txtTel.Text.Trim();
                string pwd = txtPwd.Text.Trim();
                if (userID.Length <= 0)
                {
                    throw new Exception("请输入手机号码！");
                }
                if (pwd.Length <= 0)
                {
                    throw new Exception("请输入密码！");
                }
                if (pwd.Length < 6 || pwd.Length > 12)
                {
                    throw new Exception("密码必须为6-12位！");
                }
                //密码处理,经过加密
                string encryptPwd = AutofacConfig.userService.Encrypt(DateTime.Now.ToString("yyyyMMddHHmmss") + pwd);
                ReturnInfo result = AutofacConfig.userService.Login(userID, encryptPwd);

                if (result.IsSuccess == true)
                {
                    List<Role> role = AutofacConfig.userService.GetRoleByUserID(userID);
                    Client.Session["U_ID"] = userID;
                    Client.Session["Roler"] = role;
                    MainForm mainForm = new MainForm();
                    Show(mainForm);
                }
                else
                {
                    throw new Exception(result.ErrorInfo);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Show(new FrmRegister());
        }
        /// <summary>
        /// 返回密码登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            psdPanel.Visible = true;
            fastLoginPanel.Visible = false;
        }
        /// <summary>
        /// 获取验证码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length <= 0)
                {
                    throw new Exception("请输入手机号码！");
                }
                verifycode.Text = "使用验证码：1234";
                //模拟发送短信验证码
                ReturnInfo result = AutofacConfig.userService.SimulateSendVCode(textBox1.Text);
                if (result.IsSuccess == false)
                {
                    throw new Exception(result.ErrorInfo);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void verfiyLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string Tel = textBox1.Text.Trim();
                string code = txtVcode1.Text.Trim();
                if (Tel.Length < 0)
                {
                    throw new Exception("请输入手机号码！");

                }
                if (code.Length > 0)
                {
                    //判断验证码是否输入正确，当返回值为true时，表示验证成功，否则失败，弹出错误
                    ReturnInfo result = AutofacConfig.userService.LoginByVCode(Tel, code);
                    if (result.IsSuccess == true)
                    {
                        //获取当前用户角色
                        List<Role> role = AutofacConfig.userService.GetRoleByUserID(Tel);
                        Client.Session["U_ID"] = Tel;
                        Client.Session["Roler"] = role;
                        //   Close();
                        MainForm mainForm = new MainForm();
                        Show(mainForm);
                    }
                    else
                    {
                        Toast(result.ErrorInfo, ToastLength.SHORT);
                    }
                }
                else
                {
                    throw new Exception("请输入验证码");
                }

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            psdPanel.Visible = false;
            fastLoginPanel.Visible = true;
        }
    }
}