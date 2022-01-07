using SmoONE.DTOs;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebONE.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class ATUserChooseLayot : Swebui.Controls.SwebUserControl
    {
        public ATUserChooseLayot() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        public int selectUserQty = 0;//选中人员数
        public string ATNo;//考勤模板编号
        public string selectUser;//选中人员
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            this.ShowResult = ShowResult.No;
            this.Close();
        }

        private void ATUserChooseLayot_Load(object sender, EventArgs e)
        {
            GetATUser();
        }
        /// <summary>
        /// 获取用户
        /// </summary>
        private void GetATUser()
        {
            try
            {
                List<DataGridviewbyUser> listATUser = new List<DataGridviewbyUser>();//考勤用户集合
                //如果有考勤选中用户，则添加到考勤用户集合listATUser，并默认用户状态为选中
                if (string.IsNullOrEmpty(selectUser) == false)
                {
                    string[] selectUsers = selectUser.Split(',');
                    foreach (string user in selectUsers)
                    {
                        //UserDetailDto userdto = AutofacConfig.userService.GetUserByUserID(user);
                        UserDetails userDetails = new UserDetails();
                        UserDetailDto userdto = userDetails.getUser(user);
                        if (userdto != null)
                        {
                            DataGridviewbyUser atUser = new DataGridviewbyUser();
                            atUser.U_ID = userdto.U_ID;
                            atUser.U_Name = userdto.U_Name;
                            atUser.U_Portrait = userdto.U_Portrait;
                            string depID = "";
                            string depName = "";
                            if (string.IsNullOrEmpty(userdto.U_DepID))
                            {
                                DepDetailDto department = AutofacConfig.departmentService.GetDepartmentByDepID(userdto.U_DepID);
                                if (department != null)
                                {
                                    depID = department.Dep_ID;
                                    depID = department.Dep_Name;
                                }
                            }
                            atUser.U_DepID = depID;
                            atUser.U_DepName = depName;
                            atUser.SelectCheck = true;
                            listATUser.Add(atUser);
                        }
                    }
                }

                //编辑考勤模板且现考勤选中用户不包含当前考勤成员时，添加考勤用户到集合listATUser，并将用户状态默认为未选中
                if (string.IsNullOrEmpty(ATNo) == false)
                {
                    List<UserDto> listUser = AutofacConfig.attendanceService.GetATUser(ATNo);
                    if (listUser.Count > 0)
                    {
                        foreach (UserDto user in listUser)
                        {
                            if (!(string.IsNullOrEmpty(selectUser) == false & selectUser.Split(',').Contains(user.U_ID) == true))
                            {

                                DataGridviewbyUser atUser = new DataGridviewbyUser();
                                atUser.U_ID = user.U_ID;
                                atUser.U_Name = user.U_Name;
                                if (string.IsNullOrEmpty(user.U_Portrait) == true)
                                {
                                    switch (user.U_Sex)
                                    {
                                        case (int)Sex.男:
                                            atUser.U_Portrait = "boy";
                                            break;
                                        case (int)Sex.女:
                                            atUser.U_Portrait = "girl";
                                            break;
                                    }
                                }
                                else
                                {
                                    atUser.U_Portrait = user.U_Portrait;
                                }
                                string depID = "";
                                string depName = "";
                                if (string.IsNullOrEmpty(user.U_DepID))
                                {
                                    DepDetailDto department = AutofacConfig.departmentService.GetDepartmentByDepID(user.U_DepID);
                                    if (department != null)
                                    {
                                        depID = department.Dep_ID;
                                        depID = department.Dep_Name;
                                    }
                                }
                                atUser.U_DepID = depID;
                                atUser.U_DepName = depName;
                                atUser.SelectCheck = false;
                                listATUser.Add(atUser);
                            }
                        }
                    }
                }


                //如果未分配考勤模板的用户大于0时，添加到考勤用户集合listATUser     
                List<UserDto> listNoATUser = AutofacConfig.attendanceService.GetNoATUser();
                if (listNoATUser.Count > 0)
                {
                    foreach (UserDto user in listNoATUser)
                    {
                        if ((string.IsNullOrEmpty(selectUser) == true) || (string.IsNullOrEmpty(selectUser) == false & selectUser.Split(',').Contains(user.U_ID) == false))
                        {
                            DataGridviewbyUser atUser = new DataGridviewbyUser();
                            atUser.U_ID = user.U_ID;
                            atUser.U_Name = user.U_Name;
                            if (string.IsNullOrEmpty(user.U_Portrait) == true)
                            {
                                switch (user.U_Sex)
                                {
                                    case (int)Sex.男:
                                        atUser.U_Portrait = "boy";
                                        break;
                                    case (int)Sex.女:
                                        atUser.U_Portrait = "girl";
                                        break;
                                }
                            }
                            else
                            {
                                atUser.U_Portrait = user.U_Portrait;
                            }
                            string depID = "";
                            string depName = "";
                            if (string.IsNullOrEmpty(user.U_DepID))
                            {
                                DepDetailDto department = AutofacConfig.departmentService.GetDepartmentByDepID(user.U_DepID);
                                if (department != null)
                                {
                                    depID = department.Dep_ID;
                                    depID = department.Dep_Name;
                                }
                            }
                            atUser.U_DepID = depID;
                            atUser.U_DepName = depName;
                            atUser.SelectCheck = false;
                            listATUser.Add(atUser);
                        }
                    }
                }
                listView1.Rows.Clear();//清空人员列表数据
                if (listATUser.Count > 0)
                {

                    listView1.DataSource = listATUser; //绑定ListView数据
                    listView1.DataBind();
                    upCheckState();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 全选方法
        /// </summary>
        private void Checkall()
        {
            switch (checkAll1.Checked)
            {
                case true:
                    foreach (ListViewRow rows in listView1.Rows)
                    {
                        // rows.Cell.Items["Check"].DefaultValue = true;
                        ((ATUserLayout)(rows.Control)).Check.BindDisplayValue = true;

                    }
                    selectUserQty = listView1.Rows.Count;
                    break;
                case false:
                    foreach (ListViewRow rows in listView1.Rows)
                    {
                        //  rows.Cell.Items["Check"].DefaultValue = false;
                        ((ATUserLayout)(rows.Control)).Check.BindDisplayValue = false;

                    }
                    selectUserQty = 0;
                    break;
            }
            //更新选中人员数描述
            upSelectUserFoot();
        }
        /// <summary>
        /// 更新全选状态
        /// </summary>
        public void upCheckState()
        {
            selectUserQty = 0;
            foreach (ListViewRow rows in listView1.Rows)
            {


                if (Convert.ToBoolean(((ATUserLayout)(rows.Control)).Check.BindDisplayValue) == true)
                {
                    selectUserQty += 1;
                }
            }
            //当ListView行项选中条数等于ListView行数时，为全选状态，否则为不选状态。
            if (selectUserQty == listView1.Rows.Count)
            {
                checkAll1.Checked = true;
            }
            else
            {
                checkAll1.Checked = false;
            }
            //更新选中人员数描述
            upSelectUserFoot();
        }
        /// <summary>
        /// 更新选中人员数描述
        /// </summary>
        private void upSelectUserFoot()
        {
            try
            {
                if (selectUserQty > 0)
                {
                      btnSave.BackColor = System.Drawing.Color.FromArgb(43, 146, 223);
                    btnSave.Enabled = true;

                }
                else
                {
                    btnSave.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
                    btnSave.Enabled = false;
                }
             lblDesc.Text = "已选中 " + selectUserQty.ToString() + " 人";

            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
        }
        /// <summary>
        /// 全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkAll1_CheckedChanged(object sender, EventArgs e)
        {
            Checkall();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (selectUserQty <= 0)
                {
                    throw new Exception("请至少选择一位考勤成员！");
                }
                else
                {
                    selectUser = null;
                    foreach (ListViewRow rows in listView1.Rows)
                    {
                        if (Convert.ToBoolean(((ATUserLayout)(rows.Control)).Check.BindDisplayValue) == true)
                        {
                            if (string.IsNullOrEmpty(selectUser) == true)
                            {

                                selectUser = ((ATUserLayout)(rows.Control)).lblUser.BindDataValue.ToString();

                            }
                            else
                            {
                               selectUser += "," + ((ATUserLayout)(rows.Control)).lblUser.BindDataValue.ToString();
                            }
                        }
                    }
                    ShowResult = ShowResult.Yes;
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                this.Form.Toast(ex.Message, ToastLength.SHORT);
            }

        }
    }
}