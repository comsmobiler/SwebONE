using SmoONE.Domain;
using SmoONE.DTOs;
using SwebONE.Attendance;
using SwebONE.CostCenter;
using SwebONE.Department;
using SwebONE.EA;
using SwebONE.FileUP;
using SwebONE.Leave;
using SwebONE.RB;
using SwebONE.UserInfo;
using SwebONE.Work;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebONE
{
    partial class MainForm : Swebui.Controls.SwebForm
    {
        public MainForm() : base()
        {
            //This call is required by the SwebForm.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            //获取登录账号信息
            UserDetails userDetails = new UserDetails();
            UserDetailDto user = userDetails.getUser(Client.Session["U_ID"].ToString());
            useBtn.Text = user.U_Name;
           //获取menu
            GetMenu();

            //默认显示主页
            MenuValueChanged(menuView1.Items[0]);
            menuView1.DefaultSelectedItem=menuView1.Items[0];
        }
        public void　SetUserName(string name) {
            useBtn.Text = name;
        
      }
        /// <summary>
        /// 获取Menu
        /// </summary>
        private void GetMenu()
        {
            try
            {
                List<Menu> listmenu = AutofacConfig.userService.GetMenuByUserID(Client.Session["U_ID"].ToString());
                List<Menu> sortedList = listmenu.OrderBy(a => a.M_Sort).ToList();
                //获取所有菜单组
                foreach (Menu menu in sortedList)
                {
                    MenuItem firstMenuItem = new MenuItem(menu.M_MenuID, menu.M_Description, menu.M_Portrait);
                    if (string.IsNullOrWhiteSpace(menu.M_ParentID) == true)
                    {
                        //添加二级菜单
                        List<Menu> listsecondMenu = AutofacConfig.userService.GetSubMenuByUserID(Client.Session["U_ID"].ToString(), menu.M_MenuID);
                        if (listsecondMenu.Count > 0)
                        {

                            foreach (Menu secondMenu in listsecondMenu)
                            {
                                MenuItem mvGroupItem = new MenuItem(secondMenu.M_MenuID, secondMenu.M_Description, secondMenu.M_Portrait);
                                firstMenuItem.Items.Add(mvGroupItem);
                            }
                        }
                        //添加一级菜单
                        //  grp.Items.Add(new IconMenuViewItem(menu.M_MenuID, menu.M_Portrait, menu.M_Description, menu.M_MenuID, ""));
                        menuView1.Items.Add(firstMenuItem);
                    }
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }

        /// <summary>
        /// MenuView 点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuView1_MenuItemClick(object sender, MenuViewItemClickEventArgs e)
        {
            MenuValueChanged(e.Item);
        }
        /// <summary>
        /// 设置MenuView默认选中项
        /// </summary>
        /// <param name="menuItem"></param>
        public void SetMenuViewSeleccted(MenuItem menuItem)
        {
            foreach (MenuItem item in menuView1.Items)
            {
                if (item.Id == menuItem.Id)
                { menuView1.DefaultSelectedItem = item;
                    break;
                }
                else if (item.Items.Count > 0)
                {
                    foreach(MenuItem item1 in item.Items)
                    {
                        if (item1.Id == menuItem.Id)
                        {
                            menuView1.DefaultSelectedItem = item1;
                            break;
                        }
                    }
                }
            }
          
        }
        /// <summary>
        /// 切换tab
        /// </summary>
        /// <param name="menuItem"></param>
        public void MenuValueChanged(MenuItem menuItem)
        {
            switch (menuItem.Id)
            {
                case "Home":
                    FrmWork frmWork = new FrmWork();
                    AddTabPage(menuItem, frmWork);
                    break;
                case "UserCenter":
                    FrmUser frmUser = new FrmUser();
                    AddTabPage(menuItem, frmUser);
                    break;
                case "AttendanceManagement":
                    FrmAttendanceList frmAttendanceList = new FrmAttendanceList();
                    AddTabPage(menuItem, frmAttendanceList);
                    break;
                case "MyAttendanceHistory":
                    FrmAttendanceMyList frmAttendanceMyList = new FrmAttendanceMyList();
                    AddTabPage(menuItem, frmAttendanceMyList);
                    break;
                case "AttendanceStatistics":
                    FrmAttendanceStatistics frmAttendanceStatistics = new FrmAttendanceStatistics();
                    AddTabPage(menuItem, frmAttendanceStatistics);
                    break;
                case "RB":
                    FrmRBList frmRBList = new FrmRBList();
                    AddTabPage(menuItem, frmRBList);
                    break;
                case "Leave":
                    FrmLeaveList frmLeaveList = new FrmLeaveList();
                    AddTabPage(menuItem,frmLeaveList);
                    break;
                case "NeedEA":
                    FrmNeedEA frmNeedEA = new FrmNeedEA();
                    AddTabPage(menuItem, frmNeedEA);
                    break;
                case "AlreadyEA":
                    FrmAlreadyEA frmAlreadyEA = new FrmAlreadyEA();
                    AddTabPage(menuItem, frmAlreadyEA);
                    break;
                case "Department":
                    FrmDepartList frmDepartList = new FrmDepartList();
                    AddTabPage(menuItem, frmDepartList);
                    break;
                case "CC_Type_Template":
                    FrmCCTemplateList frmCCTemplateList = new FrmCCTemplateList();
                    AddTabPage(menuItem, frmCCTemplateList);
                    break;
                case "CostCenter":
                    FrmCCList frmCCList = new FrmCCList();
                    AddTabPage(menuItem, frmCCList);
                    break;
                case "CCFX":
                    FrmCCAnalyseList frmCCAnalyseList = new FrmCCAnalyseList();
                    AddTabPage(menuItem,frmCCAnalyseList);
                    break;
                case "FileUp":
                    FrmFile frmFile = new FrmFile();
                    AddTabPage(menuItem, frmFile);
                    break;
            }
        }
        /// <summary>
        /// tabpageview 添加或跳转tab
        /// </summary>
        /// <param name="menuItem"></param>
        /// <param name="menuControl"></param>
        private void AddTabPage(MenuItem menuItem, SwebControl menuControl)
        {
            TabPageControl existTagControl = (TabPageControl)this.tabPageView1.Controls.Find(menuItem.Id);
            //判断是否存在tab,存在就跳转，不存在就添加
            if (existTagControl != null)
            {
                if (existTagControl.Controls[0].GetType() != menuControl.GetType())
                {
                    menuControl.Flex = 1;
                    ((TabPageControl)this.tabPageView1.Controls.Find(menuItem.Id)).Controls.Add(menuControl);
                    ((TabPageControl)this.tabPageView1.Controls.Find(menuItem.Id)).Controls.RemoveAt(0);
                }
                this.tabPageView1.PageIndex = this.tabPageView1.Controls.IndexOf(existTagControl);
            }
            else
            {
                TabPageControl tagControl = new TabPageControl();
                tagControl.Name = menuItem.Id;
                menuControl.Flex = 1;
                tagControl.Controls.Add(menuControl);
                this.tabPageView1.Controls.Add(tagControl);
                this.tabPageView1.PageIndex = this.tabPageView1.Controls.Count - 1;
            }

        }
        /// <summary>
        /// 退出按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("是否退出当前系统？", MessageBoxButtons.YesNo, (object o, MessageBoxHandlerArgs args) =>
            {
                try
                {
                    if (args.Result == ShowResult.Yes)
                    {
                        this.Client.ReStart();
                    }
                }
                catch (Exception ex)
                {
                    Toast(ex.Message, ToastLength.SHORT);
                }
            });
        }
    }
}
