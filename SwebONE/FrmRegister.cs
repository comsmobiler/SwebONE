using SmoONE.CommLib;
using SmoONE.Domain;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebONE
{
    partial class FrmRegister : Swebui.Controls.SwebForm
    {
        public FrmRegister() : base()
        {
            //This call is required by the SwebForm.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        string VCode = "1234";
        #endregion

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtTel.Text != null)
            {
               
                //模拟发送短信验证码
                ReturnInfo result = AutofacConfig.userService.SimulateSendVCode(txtTel.Text.Trim());
                if (result.IsSuccess == false)
                {
                    throw new Exception(result.ErrorInfo);
                }
            }

                panel5.Visible = false;
            panel6.Visible = true;

        }
        /// <summary>
        /// 验证手机号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTel.Text.Trim().Length <= 0)
                {
                    throw new Exception("请输入电话号码！");

                }
                else
                {
                    System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"^1(3[0-9]|4[57]|5[0-35-9]|7[0135678]|8[0-9])\d{8}$");
                    if (regex.IsMatch(txtTel.Text.Trim()) == false)
                    {
                        throw new Exception("手机号码格式不正确！");
                    }
                }
                //验证电话号码是否已经注册，当返回值为true时，表示已注册
                bool isRegister = AutofacConfig.userService.IsExists(txtTel.Text.Trim());
                if (isRegister == true)
                {
                    throw new Exception("电话号码" + txtTel.Text.Trim() + "已注册！");
                }
                //判断设备是否恶意注册，当返回值为true时，表示已恶意注册
                bool isMalicious = AutofacConfig.userService.IsMalicious(Client.DeviceID);
                if (isMalicious == true)
                {
                    throw new Exception("不能恶意注册！");
                }
                label3.Visible = true;
   
            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text.Trim().Length <= 0)
                {
                    throw new Exception("请输入昵称！");

                }
                if (VCode == null)
                {
                    throw new Exception("请输入手机验证码！");

                }
                string pwd1 = txtPwd1.Text.Trim();
                string pwd2 = txtPwd2.Text.Trim();
                if (pwd1.Length <= 0)
                {
                    throw new Exception("请输入新密码！");
                }
                if (pwd1.Length < 6 || pwd1.Length > 12)
                {
                    throw new Exception("新密码必须为6-12位！");
                }

                if (pwd2.Length <= 0)
                {
                    throw new Exception("请输入确认密码！");
                }
                if (pwd2.Length < 6 || pwd2.Length > 12)
                {
                    throw new Exception("新密码必须为6-12位！");
                }
                if (!pwd1.Equals(pwd2))
                {
                    throw new Exception("两次密码输入不一致，请检查！");
                }
                List<string> listrole = new List<string>();
                listrole.Add(comboBox1.SelectKey);

                //密码处理,经过加密
                string encryptPwd = AutofacConfig.userService.Encrypt(pwd2);
                ReturnInfo result = AutofacConfig.userService.RegisterByVCode(txtTel.Text.Trim(), encryptPwd, txtName.Text.Trim(), listrole, VCode);
                //如果返回true则注册成功，否则弹出错误
                if (result.IsSuccess == false)
                {
                    throw new Exception(result.ErrorInfo);
                }
                else
                {
                    List<Role> role = AutofacConfig.userService.GetRoleByUserID(txtTel.Text.Trim());
                    Client.Session["U_ID"] = txtTel.Text.Trim();
                    Client.Session["Roler"] = role;
                    MessageBox.Show("注册成功","提示", MessageBoxButtons.OK,(obj,args)=> {
                        this.Close();
                    });
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
        }

        private void comboBox1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {//获取角色信息
            List<Role> listRole = AutofacConfig.userService.GetAllRoles();
            if (listRole.Count > 0)
            {
                foreach (Role role in listRole)
                {
                    comboBox1.Items.Add(new ComboBoxItem(role.R_RoleID,role.R_Name));
                }
               
            }

        }
    }
}