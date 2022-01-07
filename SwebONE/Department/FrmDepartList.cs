using SmoONE.DTOs;
using SwebONE.Layout;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebONE.Department
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmDepartList : Swebui.Controls.SwebUserControl
    {
        public FrmDepartList() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        //public DepartmentMode Mode; //客户展示模式
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        private void AddBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmDepartCreate() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmDepartList() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }

        private void treeView1_Press(object sender, TreeViewOnPressEventArgs e)
        {

        }

        private void FrmDepartList_Load(object sender, EventArgs e)
        {
            Bind();
        }
        public void Bind()
        {
            try
            {
                //获取所有部门数据
                List<DepartmentDto> listDep = AutofacConfig.departmentService.GetAllDepartment();


                if (listDep.Count > 0)
                {

                    foreach (DepartmentDto dep in listDep)
                    {
                        if (string.IsNullOrEmpty(dep.Dep_Icon) == true)
                        {
                            dep.Dep_Icon = "bumenicon";
                        }

                    }
                    foreach (DepartmentDto dep in listDep)
                    {
                        TreeViewNode node = new TreeViewNode(dep.Dep_ID, dep.Dep_Name);
                        List<UserDto> listDepUser = AutofacConfig.userService.GetUserByDepID(dep.Dep_ID);
                        if (listDepUser.Count > 0)
                        {
                            foreach (UserDto user in listDepUser)
                            {
                                string Name = "";
                                if (dep.Dep_Leader.Equals(user.U_ID))
                                {
                                    Name = user.U_Name + "  负责人";
                                }
                                else
                                {
                                    Name = user.U_Name;
                                }

                                TreeViewNode node1 = new TreeViewNode(user.U_ID, Name);
                                node.Nodes.Add(node1);
                            }

                        }
                        treeView1.Nodes.Add(node);

                    }

                }
                else
                {
                    // btnDMode.Visible = false;
                    //    lblInfor.Visible = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// 树节点选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_Press_1(object sender, TreeViewOnPressEventArgs e)
        {
            if (e.TreeID.Contains("Dep"))
            {
                depPanel.Visible = true;
                userPanel.Visible = false;
                DepDetailDto depDetailDto = AutofacConfig.departmentService.GetDepartmentByDepID(e.TreeID);
                if (depDetailDto.Dep_Icon != null)
                {
                    if (string.IsNullOrEmpty(depDetailDto.Dep_Icon))
                        depImg.ResourceID = "bumenicon.png";
                    else
                        depImg.ResourceID = depDetailDto.Dep_Icon;
                }
                else
                    depImg.ResourceID = "bumenicon.png";
                depName.BindDataValue = depDetailDto.Dep_ID;
                depName.Text = depDetailDto.Dep_Name;
                UserDetailDto userDetail = AutofacConfig.userService.GetUserByUserID(depDetailDto.Dep_Leader);
                depLeader.Text = userDetail.U_Name;

                AddMembers(e.TreeID);
            }
            else
            {
                userPanel.Visible = true;
                depPanel.Visible = false;
                UserDetailDto userDetail = AutofacConfig.userService.GetUserByUserID(e.TreeID);
                userName.Text = userDetail.U_Name;
                string userimg = "";
                if (userDetail.U_Portrait != null && string.IsNullOrEmpty(userDetail.U_Portrait)==false)
                    userimg = userDetail.U_Portrait;
                else
                {
                    if (((Sex)userDetail.U_Sex) == Sex.男)
                        userimg = "boy.png";
                    else
                        userimg = "girl.png";
                    userImg.ResourceID = userimg;
                    if (userDetail.U_Email == null)
                        userSex.Text = "";
                    else
                        userSex.Text = userDetail.U_Email;
                    userTel.Text = userDetail.U_Tel;
                    userSex.Text = ((Sex)userDetail.U_Sex).ToString();
                    userBrith.Text = userDetail.U_Birthday.ToString("yyyy-MM-dd");

                }

            }
        }


        private void AddMembers(string treeid)
        {
            foreach (TreeViewNode node in treeView1.Nodes)
            {
                if (node.TreeID == treeid)
                {
                    memberPanel.Controls.Clear();
                    for (int i = 0; i < node.Nodes.Count; i++)
                    {
                        UserDetailDto userDetail = AutofacConfig.userService.GetUserByUserID(node.Nodes[i].TreeID);

                        string userimg = "";
                        if (userDetail.U_Portrait != null && string.IsNullOrEmpty(userDetail.U_Portrait)==false)
                            userimg = userDetail.U_Portrait;
                        else
                        {
                            if (((Sex)userDetail.U_Sex) == Sex.男)
                                userimg = "boy.png";
                            else
                                userimg = "girl.png";
                        }

                        memberPanel.Controls.Add(new FrmDepUserLayout() { UserPortrait = userimg, UserName = userDetail.U_Name,Margin=new Margin(5) });
                    }
                    break;
                }
            }
        }
        /// <summary>
        /// 编辑按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(depName.BindDataValue.ToString()) == false)
            {
                FrmDepartCreate frmDepartCreate = new FrmDepartCreate();
                frmDepartCreate.Flex = 1;
                frmDepartCreate.D_ID = depName.BindDataValue.ToString();
                frmDepartCreate.D_menberNum = memberPanel.Controls.Count;
                this.Parent.Controls.Add(frmDepartCreate);
                this.Parent.Controls.RemoveAt(0);
            }
        }
    }
}