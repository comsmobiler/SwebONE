using SmoONE.CommLib;
using SmoONE.DTOs;
using SwebONE.Layout;
using Swebui;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebONE.Department
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmDepartCreate : Swebui.Controls.SwebUserControl
    {
        public FrmDepartCreate() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        int selectUserQty = 0;//选中人员数
        public DepInputDto department = new DepInputDto();//部门信息
        public string D_ID;//部门编号
        string leader = "";//责任人
        string D_Portrait = "";//部门头像
        public int D_menberNum = 0;//部门成员数
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmDepartList() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }


        private void FrmDepartCreate_Load(object sender, EventArgs e)
        {
            listView1.Tag = this;
            DepDetailDto depDetailDto = new DepDetailDto();

            //编辑部门
            if (string.IsNullOrEmpty(D_ID) == false)
            {
                depDetailDto = AutofacConfig.departmentService.GetDepartmentByDepID(D_ID);
                GetAllUsers(depDetailDto.Dep_Leader);
                titleLab.Text = "部门编辑";
                txtDep_Name.Text = depDetailDto.Dep_Name;
                if (string.IsNullOrEmpty(depDetailDto.Dep_Icon) == false)
                {
                    D_Portrait = image1.ResourceID = depDetailDto.Dep_Icon;
                }
                leader = depDetailDto.Dep_Leader;
                Bind();
                DeleteBtn.Visible = true;
            }
            else
            {
                GetAllUsers(null);
            }



        }
        /// <summary>
        /// 获取部门负责人选项
        /// </summary>
        /// <param name="uid"></param>
        private void GetAllUsers(string uid)
        {

            List<UserDto> listDepUser = AutofacConfig.userService.GetAllUsers();//获取分配部门人员
            if (listDepUser.Count > 0)
            {
                if (string.IsNullOrEmpty(uid))
                    foreach (UserDto user in listDepUser)
                    {
                        comboBox1.Items.Add(new ComboBoxItem(user.U_ID, user.U_Name));
                    }
                else
                    foreach (UserDto user in listDepUser)
                    {
                        comboBox1.Items.Add(new ComboBoxItem(user.U_ID, user.U_Name));
                        if (user.U_ID == uid)
                        {
                            comboBox1.Text = user.U_Name;
                        }
                    }
            }

        }

        /// <summary>
        /// 选择负责人
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void comboBox1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectKey != null && string.IsNullOrEmpty(comboBox1.Text) == false)
                {
                    //查询该选中的用户是否已经是部门责任人
                    bool isLeader = AutofacConfig.departmentService.IsLeader(comboBox1.SelectKey);
                    //如果该选中责任人已是部门责任人，则报错
                    if (isLeader == true)
                    {
                        comboBox1.Text = "";
                        throw new Exception(comboBox1.Text + "已是部门责任人，请先解散部门！");
                    }
                    //
                    UserDepDto userdep = AutofacConfig.userService.GetUseDepByUserID(comboBox1.SelectKey);
                    //如果选中用户已是部门成员且不是部门责任人，则进行选择是否确认为部门责任人，若确认则为该部门负责人
                    if (userdep != null & isLeader == false)
                        if (userdep.Dep_ID != null)
                        {
                            if (string.IsNullOrEmpty(userdep.Dep_ID) == false)
                                MessageBox.Show(comboBox1.Text + "已是部门成员，是否确定为该部门责任人？", MessageBoxButtons.YesNo, (Object s1, MessageBoxHandlerArgs args) =>
                                {
                                    //此委托为异步委托事件
                                    if (args.Result == ShowResult.Yes)
                                    {
                                        leader = comboBox1.SelectKey;
                                        Bind();
                                    }
                                    else
                                    {
                                        comboBox1.Text = "";
                                    }
                                });
                            else
                            {
                                //如果选中用户不是部门责任人且不是部门成员，则为该部门负责人
                                if (isLeader == false & userdep != null & string.IsNullOrEmpty(userdep.Dep_ID) == true)
                                {
                                    leader = comboBox1.SelectKey;
                                }
                            }
                        }
                        else
                        {
                            //如果选中用户不是部门责任人且不是部门成员，则为该部门负责人
                            if (isLeader == false & userdep != null & string.IsNullOrEmpty(userdep.Dep_ID) == true)
                            {
                                leader = comboBox1.SelectKey;
                            }
                        }
                    Bind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }

        }
        /// <summary>
        /// 初始部门成员列表
        /// </summary>
        private void Bind()
        {
            try
            {
                if (string.IsNullOrEmpty(leader) == false)
                {
                    List<DataGridviewbyUser> listUser = new List<DataGridviewbyUser>();
                    List<UserDto> listDepUser = AutofacConfig.userService.GetAllUsers();//获取分配部门人员
                                                                                        //部门创建时ListView绑定数据
                    if (string.IsNullOrEmpty(D_ID) == true)
                    {
                        if (listDepUser.Count > 0)
                        {
                            //将未分配部门且不是当前部门责任人的用户，添加到listUser中
                            foreach (UserDto user in listDepUser)
                            {
                                if ((string.IsNullOrEmpty(user.U_DepID) == true) & (!leader.Equals(user.U_ID)))
                                {
                                    DataGridviewbyUser depUser = new DataGridviewbyUser();
                                    depUser.U_ID = user.U_ID;
                                    depUser.U_Name = user.U_Name;
                                    if (string.IsNullOrEmpty(user.U_Portrait) == true)
                                    {
                                        switch (user.U_Sex)
                                        {
                                            case (int)Sex.男:
                                                depUser.U_Portrait = "boy";
                                                break;
                                            case (int)Sex.女:
                                                depUser.U_Portrait = "girl";
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        depUser.U_Portrait = user.U_Portrait;
                                    }
                                    depUser.U_DepID = "";
                                    depUser.U_DepName = "";
                                    depUser.SelectCheck = false;
                                    listUser.Add(depUser);
                                }
                            }
                            //将已分配部门且不是当前部门责任人的用户，添加到listUser中
                            foreach (UserDto user in listDepUser)
                            {
                                if ((string.IsNullOrEmpty(user.U_DepID) == false) & (!leader.Equals(user.U_ID)))
                                {
                                    DataGridviewbyUser depUser = new DataGridviewbyUser();
                                    depUser.U_ID = user.U_ID;
                                    depUser.U_Name = user.U_Name;
                                    if (string.IsNullOrEmpty(user.U_Portrait) == true)
                                    {
                                        switch (user.U_Sex)
                                        {
                                            case (int)Sex.男:
                                                depUser.U_Portrait = "boy";
                                                break;
                                            case (int)Sex.女:
                                                depUser.U_Portrait = "girl";
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        depUser.U_Portrait = user.U_Portrait;
                                    }
                                    depUser.U_DepID = user.U_DepID;
                                    string DepName = "";
                                    if (AutofacConfig.departmentService.GetDepartmentByDepID(user.U_DepID) != null)
                                    {
                                        DepName = AutofacConfig.departmentService.GetDepartmentByDepID(user.U_DepID).Dep_Name;
                                    }
                                    depUser.U_DepName = DepName;
                                    depUser.SelectCheck = false;
                                    listUser.Add(depUser);
                                }
                            }
                        }
                    }
                    //部门编辑时ListView绑定数据
                    if (string.IsNullOrEmpty(D_ID) == false)
                    {
                        if (listDepUser.Count > 0)
                        {
                            //将当前部门且不是当前部门责任人的用户，添加到listUser中
                            foreach (UserDto user in listDepUser)
                            {
                                if ((string.IsNullOrEmpty(user.U_DepID) == false) & (D_ID.Equals(user.U_DepID)) & (!leader.Equals(user.U_ID)))
                                {
                                    DataGridviewbyUser depUser = new DataGridviewbyUser();
                                    depUser.U_ID = user.U_ID;
                                    depUser.U_Name = user.U_Name;
                                    if (string.IsNullOrEmpty(user.U_Portrait) == true)
                                    {
                                        switch (user.U_Sex)
                                        {
                                            case (int)Sex.男:
                                                depUser.U_Portrait = "boy";
                                                break;
                                            case (int)Sex.女:
                                                depUser.U_Portrait = "girl";
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        depUser.U_Portrait = user.U_Portrait;
                                    }
                                    depUser.U_DepID = D_ID;
                                    depUser.U_DepName = txtDep_Name.Text.Trim();
                                    depUser.SelectCheck = true;
                                    listUser.Add(depUser);
                                }
                            }
                            //将未分配部门且不是当前部门责任人的用户，添加到listUser中
                            foreach (UserDto user in listDepUser)
                            {
                                if ((string.IsNullOrEmpty(user.U_DepID) == true) & (!leader.Equals(user.U_ID)))
                                {
                                    DataGridviewbyUser depUser = new DataGridviewbyUser();
                                    depUser.U_ID = user.U_ID;
                                    depUser.U_Name = user.U_Name;
                                    if (string.IsNullOrEmpty(user.U_Portrait) == true)
                                    {
                                        switch (user.U_Sex)
                                        {
                                            case (int)Sex.男:
                                                depUser.U_Portrait = "boy";
                                                break;
                                            case (int)Sex.女:
                                                depUser.U_Portrait = "girl";
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        depUser.U_Portrait = user.U_Portrait;
                                    }
                                    depUser.U_DepID = "";
                                    depUser.U_DepName = "";
                                    depUser.SelectCheck = false;
                                    listUser.Add(depUser);
                                }
                            }
                            //将已分配部门且不是当前部门的用户，添加到listUser中
                            foreach (UserDto user in listDepUser)
                            {
                                if ((string.IsNullOrEmpty(user.U_DepID) == false) & (!D_ID.Equals(user.U_DepID)) & (!leader.Equals(user.U_ID)))
                                {
                                    DataGridviewbyUser depUser = new DataGridviewbyUser();
                                    depUser.U_ID = user.U_ID;
                                    depUser.U_Name = user.U_Name;
                                    if (string.IsNullOrEmpty(user.U_Portrait) == true)
                                    {
                                        switch (user.U_Sex)
                                        {
                                            case (int)Sex.男:
                                                depUser.U_Portrait = "boy";
                                                break;
                                            case (int)Sex.女:
                                                depUser.U_Portrait = "girl";
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        depUser.U_Portrait = user.U_Portrait;
                                    }
                                    depUser.U_DepID = user.U_DepID;
                                    string DepName = AutofacConfig.departmentService.GetDepartmentByDepID(user.U_DepID).Dep_Name;
                                    depUser.U_DepName = DepName;
                                    depUser.SelectCheck = false;
                                    listUser.Add(depUser);
                                }
                            }
                        }
                    }

                    listView1.Rows.Clear();//清空人员列表数据
                    if (listUser.Count > 0)
                    {
                        listView1.DataSource = listUser; //绑定ListView数据
                        listView1.DataBind();
                        ReSetState();

                    }

                }
                else
                {
                    throw new Exception("请输入部门信息！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// 部门头像
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Client.FileUpload((obj, args) =>
            {
                if (args.isError == false)
                {
                    if (string.IsNullOrEmpty(D_Portrait))
                    {
                        string[] suffixs = args.ResourceID.Split('.');
                        string imgName = "dep" + DateTime.Now.ToString("yyyyMMddhhmm") + "." + suffixs[1];
                        args.SaveFile(imgName, SwebResourceManager.DefaultImagePath);
                        D_Portrait = imgName;
                        image1.ResourceID = imgName;
                    }
                    else
                    {
                        string[] suffixs = args.ResourceID.Split('.');
                        string[] suffixs1 = D_Portrait.Split('.');
                        string imgName = "";
                        if (suffixs1.Length > 1)
                            imgName = suffixs1[0] + "." + suffixs[1];
                        args.SaveFile(imgName, SwebResourceManager.DefaultImagePath);
                        image1.ResourceID = imgName;
                    }
                }

            });

        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtDep_Name.Text.Trim().Length <= 0)
                {
                    throw new Exception("请输入部门名称！");
                }

                if (leader.Length <= 0)
                {
                    throw new Exception("请输入责任人！");
                }
                DepInputDto department = new DepInputDto();
                department.Dep_Name = txtDep_Name.Text;
                department.Dep_UpdateUser = Client.Session["U_ID"].ToString();
                department.Dep_Leader = leader;
                if (string.IsNullOrEmpty(D_Portrait) == false)
                {
                    department.Dep_Icon = D_Portrait;
                }
                else
                {
                    department.Dep_Icon = "";
                }
                if (string.IsNullOrEmpty(D_ID) == false)
                    department.Dep_ID = D_ID;
                #region"得到选中用户"
                List<string> listUser = new List<string>(); //用户集合
                string assignUser = "";//已分配部门用户
                string depLeader = "";//部门责任人用户
                department.Dep_Name = txtDep_Name.Text.Trim();
                listUser.Add(department.Dep_Leader);//添加当前部门负责人

                string depuser = null;//选中用户中且已分配部门的用户
                List<string> listselectuserdep = new List<string>();//获取选中用户的且是已分配部门中，用户的部门
                foreach (ListViewRow rows in listView1.Rows)
                {

                    if ((Convert.ToBoolean(((FrmDepAssignUserLayout)(rows.Control)).Check.BindDisplayValue) == true) & (!department.Dep_Leader.Equals(((FrmDepAssignUserLayout)(rows.Control)).lblUser.BindDataValue.ToString())))
                    {
                        string user = ((FrmDepAssignUserLayout)(rows.Control)).lblUser.BindDataValue.ToString();
                        listUser.Add(user);
                        //获取选中用户中的已分配部门的用户                      
                        if (string.IsNullOrEmpty(((FrmDepAssignUserLayout)(rows.Control)).lblDep.BindDisplayValue.ToString()) == false)
                        {
                            if (string.IsNullOrEmpty(depuser) == true)
                            {
                                depuser = ((FrmDepAssignUserLayout)(rows.Control)).lblUser.BindDataValue.ToString();
                            }
                            else
                            {
                                depuser += "," + ((FrmDepAssignUserLayout)(rows.Control)).lblUser.BindDataValue.ToString();
                            }
                            if (listselectuserdep.Count <= 0)
                            {
                                listselectuserdep.Add(((FrmDepAssignUserLayout)(rows.Control)).lblDep.BindDisplayValue.ToString());//添加选中用户的部门
                            }
                            else
                            {
                                if (listselectuserdep.Contains(((FrmDepAssignUserLayout)(rows.Control)).lblDep.BindDisplayValue.ToString()) == false)
                                {
                                    listselectuserdep.Add(((FrmDepAssignUserLayout)(rows.Control)).lblDep.BindDisplayValue.ToString());//添加选中用户的部门
                                }
                            }
                        }

                    }
                }
                #endregion


                //如果已分配部门的用户不为空时
                if (string.IsNullOrEmpty(depuser) == false)
                {
                    string[] depusers = depuser.Split(',');
                    //创建部门时，判断选中用户是否为部门责任人和是否为已分配部门成员
                    if (string.IsNullOrEmpty(department.Dep_ID) == true)
                    {
                        foreach (string user in depusers)
                        {
                            //如果是部门责任人，则添加到部门责任人用户depLeader中，否则添加到已分配部门用户assignUser中
                            if (AutofacConfig.departmentService.IsLeader(user) == true)
                            {
                                UserDetailDto userd = AutofacConfig.userService.GetUserByUserID(user);
                                if (string.IsNullOrEmpty(depLeader) == true)
                                {
                                    depLeader = userd.U_Name;
                                }
                                else
                                {
                                    depLeader += "," + userd.U_Name;
                                }

                            }
                            else
                            {
                                if (string.IsNullOrEmpty(assignUser) == true)
                                {
                                    assignUser = user;
                                }
                                else
                                {
                                    assignUser += "," + user;
                                }
                            }
                        }
                    }
                    //编辑部门时，判断选中用户是否为部门责任人和是否为已分配部门成员
                    if (string.IsNullOrEmpty(department.Dep_ID) == false)
                    {
                        foreach (string user in depusers)
                        {
                            UserDetailDto userd = AutofacConfig.userService.GetUserByUserID(user);
                            if (!department.Dep_ID.Equals(userd.U_DepID))
                            {
                                //如果是部门责任人，则添加到部门责任人用户depLeader中，否则添加到已分配部门用户assignUser中
                                if (AutofacConfig.departmentService.IsLeader(user) == true)
                                {

                                    if (string.IsNullOrEmpty(depLeader) == true)
                                    {
                                        depLeader = userd.U_Name;
                                    }
                                    else
                                    {
                                        depLeader += "," + userd.U_Name;
                                    }
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(assignUser) == true)
                                    {
                                        assignUser = user;
                                    }
                                    else
                                    {
                                        assignUser += "," + user;
                                    }
                                }
                            }
                        }
                    }
                    if (listselectuserdep.Count > 0 & string.IsNullOrEmpty(assignUser) == false)
                    {

                        string[] assignUsers = assignUser.Split(',');
                        string assignUser1 = "";
                        foreach (string depNO in listselectuserdep)
                        {
                            string assignU = "";
                            foreach (string user in assignUsers)
                            {
                                UserDetailDto userd = AutofacConfig.userService.GetUserByUserID(user);
                                if (user != null)
                                {
                                    if (userd.U_DepID.Equals(depNO))
                                    {
                                        if (string.IsNullOrEmpty(assignU) == true)
                                        {
                                            assignU = userd.U_Name;
                                        }
                                        else
                                        {
                                            assignU += "," + userd.U_Name;
                                        }
                                    }
                                }
                            }
                            if (string.IsNullOrEmpty(assignU) == false)
                            {
                                if (string.IsNullOrEmpty(assignU) == false)
                                {
                                    assignUser1 = assignU + "已是" + AutofacConfig.departmentService.GetDepartmentByDepID(depNO).Dep_Name + "部门成员";
                                }
                                else
                                {
                                    assignUser1 += "；" + assignU + "已是" + AutofacConfig.departmentService.GetDepartmentByDepID(depNO).Dep_Name + "部门成员";
                                }
                            }
                        }
                        assignUser = assignUser1;
                    }
                }
                if (string.IsNullOrEmpty(depLeader) == false)
                {
                    throw new Exception(depLeader + "已是部门责任人，请先解散部门！");
                }
                //bool isUPdateDep = false; //是否更新部门人员
                ReturnInfo result;
                if (string.IsNullOrEmpty(assignUser) == false)
                {
                    MessageBox.Show(assignUser + "是否分配？", "分配人员", MessageBoxButtons.YesNo, (Object s, MessageBoxHandlerArgs args) =>
                    {
                        if (args.Result == ShowResult.Yes)
                        {
                            //isUPdateDep = true;
                            department.UserIDs = listUser;
                            if (department.Dep_ID != null)
                            {

                                result = AutofacConfig.departmentService.UpdateDepartment(department);
                            }
                            else
                            {

                                result = AutofacConfig.departmentService.AddDepartment(department);
                            }
                            if (result.IsSuccess == false)
                            {
                                throw new Exception(result.ErrorInfo);
                            }
                            else
                            {
                                ShowResult = ShowResult.Yes;

                                Toast("部门人员分配成功！", ToastLength.LONG);
                                BackBtn_Click(null, null);
                            }
                        }
                    }
                      );
                }
                else
                {

                    department.UserIDs = listUser;
                    if (department.Dep_ID != null)
                    {

                        result = AutofacConfig.departmentService.UpdateDepartment(department);
                    }
                    else
                    {

                        result = AutofacConfig.departmentService.AddDepartment(department);
                    }
                    if (result.IsSuccess == false)
                    {
                        throw new Exception(result.ErrorInfo);
                    }
                    else
                    {
                        ShowResult = ShowResult.Yes;
                        Toast("部门人员分配成功！", ToastLength.LONG);
                        BackBtn_Click(null, null);
                    }
                }


            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }

        }


        private void checkAll_CheckedChanged(object sender, EventArgs e)
        {
            Checkall();
        }

        /// <summary>
        /// 全选
        /// </summary>
        private void Checkall()
        {
            switch (checkAll1.Checked)
            {
                case true:
                    foreach (ListViewRow rows in listView1.Rows)
                    {
                        //rows.Cell.Items["Check"].DefaultValue = true;
                        ((FrmDepAssignUserLayout)(rows.Control)).Check.BindDisplayValue = true;

                    }
                    selectUserQty = listView1.Rows.Count;
                    break;
                case false:
                    foreach (ListViewRow rows in listView1.Rows)
                    {
                        //rows.Cell.Items["Check"].DefaultValue = false;
                        ((FrmDepAssignUserLayout)(rows.Control)).Check.BindDisplayValue = false;

                    }
                    selectUserQty = 0;
                    break;
            }
        }
        /// <summary>
        /// 重置全选状态
        /// </summary>
        private void ReSetState()
        {
            selectUserQty = 0;
            foreach (ListViewRow rows in listView1.Rows)
            {
                if (Convert.ToBoolean(((FrmDepAssignUserLayout)(rows.Control)).Check.BindDisplayValue) == true)
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
        }
        /// <summary>
        /// 更新全选状态
        /// </summary>
        public void UpdateState()
        {
            //当ListView行项选中条数等于ListView行数时，为全选状态，否则为不选状态。
            if (selectUserQty == listView1.Rows.Count)
            {
                checkAll1.Checked = true;
            }
            else
            {
                checkAll1.Checked = false;
            }
        }

        public void AddSelectUserQty()
        {
            selectUserQty++;

        }
        public void SubtractSelectUserQty()
        {
            selectUserQty--;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            //bool isDelDep = false;//是否删除部门
            MessageBox.Show("是否确定删除部门？", "部门", MessageBoxButtons.YesNo, (Object s1, MessageBoxHandlerArgs args1) =>
            {
                if (args1.Result == ShowResult.Yes)
                {
                    //如果部门人员人数大于0，则弹出提示框在删除部门，否则直接删除
                    if (D_menberNum > 0)
                    {
                        MessageBox.Show(txtDep_Name.Text + "已分配部门人员是否删除？", "删除部门", MessageBoxButtons.YesNo, (Object s, MessageBoxHandlerArgs args) =>
                        {
                            if (args.Result == ShowResult.Yes)
                            {

                                //isDelDep = true;
                                try
                                {
                                    ReturnInfo result = AutofacConfig.departmentService.DeleteDepartment(D_ID);
                                    if (result.IsSuccess == true)
                                    {
                                        ShowResult = ShowResult.Yes;
                                       
                                        Toast("部门已删除！", ToastLength.LONG); 
                                        BackBtn_Click(null,null);
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
                        });
                    }
                    else
                    {
                        //isDelDep = true;
                        ReturnInfo result = AutofacConfig.departmentService.DeleteDepartment(D_ID);
                        if (result.IsSuccess == true)
                        {
                            ShowResult = ShowResult.Yes;
                            Toast("部门已删除！", ToastLength.LONG);
                            BackBtn_Click(null, null);
                        }
                        else
                        {
                            Toast(result.ErrorInfo, ToastLength.SHORT);
                        }
                    }

                }
            });
        }
    }
}