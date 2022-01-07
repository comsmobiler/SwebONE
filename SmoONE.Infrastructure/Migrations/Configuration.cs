namespace SmoONE.Infrastructure.Migrations
{
    using SmoONE.Domain;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using CommLib;
    // ******************************************************************
    // �ļ��汾�� SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler
    // ����ʱ�䣺 2016/11
    // ��Ҫ���ݣ�  ���ݿ������ĵ�����
    // ******************************************************************

    /// <summary>
    /// ���ݿ������ĵ�����
    /// </summary>
    internal sealed class Configuration : DbMigrationsConfiguration<SmoONE.Infrastructure.SmoONEDbContext>
    {
        public Configuration()
        {
            //�ر��Զ�Ǩ��
            AutomaticMigrationsEnabled = false;
        }

        /// <summary>
        /// ��������(���ݿⴴ�����߸��º�,���ݿ���ض����ڵ����ݣ�
        /// </summary>
        protected override void Seed(SmoONE.Infrastructure.SmoONEDbContext context)
        {
            //  This method will be called after migrating to the latest version.            


            #region ���鲻Ҫע�͵���Ĭ�����ݣ������޸ģ�,��Ȼ����Ӱ��Ӧ�õ�ʹ��
            //��LeaveType�������Ĭ������
            context.LeaveTypes.AddOrUpdate(
                  new LeaveType { L_T_ID = "SJ", L_T_Name = "�¼�" },
                  new LeaveType { L_T_ID = "BJ", L_T_Name = "����" },
                  new LeaveType { L_T_ID = "NJ", L_T_Name = "���" },
                  new LeaveType { L_T_ID = "TX", L_T_Name = "����" },
                  new LeaveType { L_T_ID = "HJ", L_T_Name = "���" },
                  new LeaveType { L_T_ID = "CJ", L_T_Name = "����" },
                  new LeaveType { L_T_ID = "PCJ", L_T_Name = "�����" },
                  new LeaveType { L_T_ID = "LTJ", L_T_Name = "·;��" },
                  new LeaveType { L_T_ID = "QT", L_T_Name = "����" }
                );
            //��RB_Type�������Ĭ������
            context.RB_Types.AddOrUpdate(
                  new RB_RType { RB_RT_ID = "BJ", RB_RT_Name = "�����" },
                  new RB_RType { RB_RT_ID = "BJB", RB_RT_Name = "�ʼǱ�" },
                  new RB_RType { RB_RT_ID = "CB", RB_RT_Name = "�����" },
                  new RB_RType { RB_RT_ID = "CF", RB_RT_Name = "�ͷ�" },
                  new RB_RType { RB_RT_ID = "FZ", RB_RT_Name = "����" },
                  new RB_RType { RB_RT_ID = "GL", RB_RT_Name = "��·��" },
                  new RB_RType { RB_RT_ID = "HD", RB_RT_Name = "Ӳ��" },
                  new RB_RType { RB_RT_ID = "JT", RB_RT_Name = "��ͨ��" },
                  new RB_RType { RB_RT_ID = "JY", RB_RT_Name = "���ͷ�" },
                  new RB_RType { RB_RT_ID = "KD", RB_RT_Name = "��ݷ�" },
                  new RB_RType { RB_RT_ID = "TC", RB_RT_Name = "ͣ����" },
                  new RB_RType { RB_RT_ID = "TXF", RB_RT_Name = "ͨѶ��" },
                  new RB_RType { RB_RT_ID = "WX", RB_RT_Name = "����ά�޷�" },
                  new RB_RType { RB_RT_ID = "WY", RB_RT_Name = "��ҵ��" },
                  new RB_RType { RB_RT_ID = "XZ", RB_RT_Name = "��������" },
                  new RB_RType { RB_RT_ID = "YJ", RB_RT_Name = "Ѻ��" },
                  new RB_RType { RB_RT_ID = "YW", RB_RT_Name = "ҵ���" },
                  new RB_RType { RB_RT_ID = "ZS", RB_RT_Name = "ס�޷�" },
                  new RB_RType { RB_RT_ID = "QT", RB_RT_Name = "��������" }
                );
            //��CostCenter_Type�������Ĭ������
            context.CostCenter_Types.AddOrUpdate(
                new CostCenter_Type { CC_T_TypeID = "1", CC_T_Description = "ά��", CC_T_IsActive = 1 },
                new CostCenter_Type { CC_T_TypeID = "2", CC_T_Description = "�칫", CC_T_IsActive = 1 },
                new CostCenter_Type { CC_T_TypeID = "3", CC_T_Description = "��Ʒ��ϵ", CC_T_IsActive = 1 },
                new CostCenter_Type { CC_T_TypeID = "4", CC_T_Description = "��Ŀ", CC_T_IsActive = 1 },
                new CostCenter_Type { CC_T_TypeID = "5", CC_T_Description = "������ǰ", CC_T_IsActive = 1 },
                new CostCenter_Type { CC_T_TypeID = "6", CC_T_Description = "����", CC_T_IsActive = 1 },
                new CostCenter_Type { CC_T_TypeID = "7", CC_T_Description = "����", CC_T_IsActive = 1 },
                new CostCenter_Type { CC_T_TypeID = "8", CC_T_Description = "��Ӫ", CC_T_IsActive = 1 }
                );
            //��Role�������Ĭ������
            context.Roles.AddOrUpdate(
                new Role { R_RoleID = "Administrator", R_IsActive = 1, R_Name = "����Ա", R_UpdateDate = DateTime.Now },
                new Role { R_RoleID = "Employee", R_IsActive = 1, R_Name = "Ա��", R_UpdateDate = DateTime.Now }
                );
            //��Menu�������Ĭ������
            context.Menus.AddOrUpdate(
                new Menu { M_MenuID = "Home", M_Description = "��ҳ", M_Sort = 0, M_IsActive = 1, M_ParentID = "", M_UpdateDate = DateTime.Now, M_Portrait = "home" },
                new Menu { M_MenuID = "UserCenter", M_Description = "��������", M_Sort = 1, M_IsActive = 1, M_ParentID = "", M_UpdateDate = DateTime.Now, M_Portrait = "user-o" },         
                new Menu { M_MenuID = "Attendance", M_Description = "���ڹ���", M_Sort = 2, M_IsActive = 1, M_ParentID = "", M_UpdateDate = DateTime.Now, M_Portrait = "calendar-check-o" },
                new Menu { M_MenuID = "AttendanceManagement", M_Description = "���ڹ���", M_Sort = 1, M_IsActive = 1, M_ParentID = "Attendance", M_UpdateDate = DateTime.Now, M_Portrait = "circle" },
                new Menu { M_MenuID = "MyAttendanceHistory", M_Description = "�ҵĿ���", M_Sort = 2, M_IsActive = 1, M_ParentID = "Attendance", M_UpdateDate = DateTime.Now, M_Portrait = "circle" },
                new Menu { M_MenuID = "AttendanceStatistics", M_Description = "����ͳ��", M_Sort = 3, M_IsActive = 1, M_ParentID = "Attendance", M_UpdateDate = DateTime.Now, M_Portrait = "circle" },
                new Menu { M_MenuID = "RB", M_Description = "��������", M_Sort = 3, M_IsActive = 1, M_ParentID = "", M_UpdateDate = DateTime.Now, M_Portrait = "file-o" },
                new Menu { M_MenuID = "Leave", M_Description = "��ٹ���", M_Sort =4, M_IsActive = 1, M_ParentID = "", M_UpdateDate = DateTime.Now, M_Portrait = "file-text-o" },
                new Menu { M_MenuID = "EA", M_Description = "��������", M_Sort = 5, M_IsActive = 1, M_ParentID = "", M_UpdateDate = DateTime.Now, M_Portrait = "check-square-o" },
                new Menu { M_MenuID = "NeedEA", M_Description = "������", M_Sort = 1, M_IsActive = 1, M_ParentID = "EA", M_UpdateDate = DateTime.Now, M_Portrait = "circle" },
                new Menu { M_MenuID = "AlreadyEA", M_Description = "������", M_Sort =2, M_IsActive = 1, M_ParentID = "EA", M_UpdateDate = DateTime.Now, M_Portrait = "circle" },
                new Menu { M_MenuID = "Department", M_Description = "���Ź���", M_Sort = 6, M_IsActive = 1, M_ParentID = "", M_UpdateDate = DateTime.Now, M_Portrait = "sitemap" },
                new Menu { M_MenuID = "CC", M_Description = "�ɱ�����", M_Sort = 7, M_IsActive = 1, M_ParentID = "", M_UpdateDate = DateTime.Now, M_Portrait = "university" },
                new Menu { M_MenuID = "CCFX", M_Description = "�ɱ�����", M_Sort = 3, M_IsActive = 1, M_ParentID = "CC", M_UpdateDate = DateTime.Now, M_Portrait = "circle" },
                new Menu { M_MenuID = "CC_Type_Template", M_Description = "�ɱ�ģ��", M_Sort = 1, M_IsActive = 1, M_ParentID = "CC", M_UpdateDate = DateTime.Now, M_Portrait = "circle" },
                new Menu { M_MenuID = "CostCenter", M_Description = "�ɱ�����", M_Sort = 2, M_IsActive = 1, M_ParentID = "CC", M_UpdateDate = DateTime.Now, M_Portrait = "circle" },
                new Menu { M_MenuID = "FileUp", M_Description = "�ļ�����", M_Sort = 8, M_IsActive = 1, M_ParentID = "", M_UpdateDate = DateTime.Now, M_Portrait = "files-o" }
                  );
            //��RoleMenu�������Ĭ������
            context.RoleMenus.AddOrUpdate(
                new RoleMenu { RM_ID = 1, RM_RoleID = "Administrator", RM_MenuID = "Home" },
                new RoleMenu { RM_ID = 2, RM_RoleID = "Administrator", RM_MenuID = "UserCenter" },
                new RoleMenu { RM_ID = 3, RM_RoleID = "Administrator", RM_MenuID = "Attendance" },
                new RoleMenu { RM_ID = 4, RM_RoleID = "Administrator", RM_MenuID = "AttendanceManagement" },
                new RoleMenu { RM_ID = 5, RM_RoleID = "Administrator", RM_MenuID = "MyAttendanceHistory" },
                new RoleMenu { RM_ID = 6, RM_RoleID = "Administrator", RM_MenuID = "AttendanceStatistics" },
                new RoleMenu { RM_ID = 7, RM_RoleID = "Administrator", RM_MenuID = "RB" },
                new RoleMenu { RM_ID = 8, RM_RoleID = "Administrator", RM_MenuID = "Leave" },
                new RoleMenu { RM_ID = 9, RM_RoleID = "Administrator", RM_MenuID = "EA" },
                new RoleMenu { RM_ID = 10, RM_RoleID = "Administrator", RM_MenuID = "CC" },
                new RoleMenu { RM_ID = 11, RM_RoleID = "Administrator", RM_MenuID = "CCFX" },
                new RoleMenu { RM_ID = 12, RM_RoleID = "Administrator", RM_MenuID = "CC_Type_Template" },
                new RoleMenu { RM_ID = 13, RM_RoleID = "Administrator", RM_MenuID = "CostCenter" },
                new RoleMenu { RM_ID = 14, RM_RoleID = "Administrator", RM_MenuID = "FileUp" },
                new RoleMenu { RM_ID = 15, RM_RoleID = "Administrator", RM_MenuID = "Department" },
                new RoleMenu { RM_ID = 16, RM_RoleID = "Administrator", RM_MenuID = "NeedEA" },
                new RoleMenu { RM_ID = 17, RM_RoleID = "Administrator", RM_MenuID = "AlreadyEA" },
                new RoleMenu { RM_ID = 18, RM_RoleID = "Employee", RM_MenuID = "Home" },
                new RoleMenu { RM_ID = 19, RM_RoleID = "Employee", RM_MenuID = "UserCenter" },
                new RoleMenu { RM_ID = 20, RM_RoleID = "Employee", RM_MenuID = "Attendance" },
                new RoleMenu { RM_ID = 21, RM_RoleID = "Employee", RM_MenuID = "MyAttendanceHistory" },
                new RoleMenu { RM_ID = 22, RM_RoleID = "Employee", RM_MenuID = "AttendanceStatistics" },
                new RoleMenu { RM_ID = 23, RM_RoleID = "Employee", RM_MenuID = "RB" },
                new RoleMenu { RM_ID = 24, RM_RoleID = "Employee", RM_MenuID = "Leave" },
                new RoleMenu { RM_ID = 25, RM_RoleID = "Employee", RM_MenuID = "FileUp" },
                new RoleMenu { RM_ID = 26, RM_RoleID = "Employee", RM_MenuID = "EA" },
                new RoleMenu { RM_ID = 27, RM_RoleID = "Employee", RM_MenuID = "NeedEA" },
                new RoleMenu { RM_ID = 28, RM_RoleID = "Employee", RM_MenuID = "AlreadyEA" }

                );
            //��Department�������Ĭ������
            //context.Departments.AddOrUpdate(
            //    new Department { Dep_ID = "Dep2016102517120001", Dep_Name = "���²�", Dep_IsActive = 1, Dep_Leader = "13725731234", Dep_UpdateDate = DateTime.Now, Dep_UpdateUser = "13725731234", Dep_ProDay = 500, Dep_OtherDay = 400 }
            //    );
            #endregion


            #region ����ע�͵�Ĭ�����ݣ�����ͨ���������֣�
            //��User�������Ĭ������
            context.Users.AddOrUpdate(
                new User { U_ID = "13123456789", U_Name = "Smobiler", U_Pwd = DESEncrypt.Encrypt("123456"), U_Birthday = DateTime.Parse("1996-10-20 16:01:44"), U_CreateDate = DateTime.Now, U_Sex = 1, U_IsCheck = 1, U_IsCC = 1 }
                );
            //��UserRole�������Ĭ������
            context.UserRoles.AddOrUpdate(
                new UserRole { ID = 1, UserID = "13123456789", RoleID = "Administrator" }
                );
            ////��Leave�������Ĭ������
            //context.Leaves.AddOrUpdate(
            //    new Leave { L_ID = "Lv2016111012110001", L_CheckUsers = "13725731237,13725731238", L_CreateUser = "13725731235", L_CCTo = "13725731234", L_StartDate = DateTime.Now, L_CreateDate = DateTime.Now, L_EndDate = DateTime.Now.AddDays(3), L_LDay = 3, L_Reason = "����1", L_Status = 0, L_TypeID = "SJ", L_UpdateDate = DateTime.Now },
            //    new Leave { L_ID = "Lv2016111113140001", L_CheckUsers = "13725731237,13725731234", L_CreateUser = "13725731236", L_CCTo = "13725731235", L_StartDate = DateTime.Now.AddDays(-2), L_CreateDate = DateTime.Now, L_EndDate = DateTime.Now, L_LDay = 2, L_Reason = "����2", L_Status = 1, L_TypeID = "NJ", L_UpdateDate = DateTime.Now, L_UpdateUser = "13725731237", L_CurrantCheck = "13725731237" },
            //    new Leave { L_ID = "Lv2016111415420001", L_CheckUsers = "13725731234,13725731238", L_CreateUser = "13725731237", L_CCTo = "13725731236", L_StartDate = DateTime.Now.AddDays(-1), L_CreateDate = DateTime.Now, L_EndDate = DateTime.Now.AddDays(3), L_LDay = 4, L_Reason = "����3", L_Status = 0, L_TypeID = "CJ", L_UpdateDate = DateTime.Now },
            //    new Leave { L_ID = "Lv2016111707160001", L_CheckUsers = "13725731234", L_CreateUser = "13725731235", L_CCTo = "13725731236", L_StartDate = DateTime.Now.AddDays(1), L_CreateDate = DateTime.Now, L_EndDate = DateTime.Now.AddDays(5), L_LDay = 4, L_Reason = "����4", L_Status = -1, L_TypeID = "HJ", L_UpdateDate = DateTime.Now, L_UpdateUser = "13725731234", L_CurrantCheck = "13725731234" }
            //    );
            ////��Reimbursement�������Ĭ������
            //context.Reimbursements.AddOrUpdate(
            //    new Reimbursement { RB_ID = "RB2016110108160001", RB_TotalAmount = 120, RB_LiableMan = "13725731236", RB_AEACheckers = "13725731234", RB_FinancialCheckers = "13725731235,13725731236", RB_CreateUser = "13725731237", RB_CreateDate = DateTime.Now, RB_Note = "Note1", RB_Status = 0, RB_UpdateDate = DateTime.Now, CC_ID = "CC2016111320140001" },
            //    new Reimbursement { RB_ID = "RB2016110816100001", RB_TotalAmount = 100, RB_LiableMan = "13725731238", RB_AEACheckers = "13725731236,13725731237", RB_FinancialCheckers = "13725731235,13725731238", RB_CreateUser = "13725731235", RB_CreateDate = DateTime.Now, RB_Note = "Note2", RB_Status = 1, RB_UpdateDate = DateTime.Now, CC_ID = "CC2016110218450001", RB_CurrantCheck = "13725731238" },
            //    new Reimbursement { RB_ID = "RB2016111620130001", RB_TotalAmount = 140, RB_LiableMan = "13725731237", RB_AEACheckers = "13725731237", RB_FinancialCheckers = "13725731235,13725731234", RB_CreateUser = "13725731236", RB_CreateDate = DateTime.Now, RB_Note = "Note3", RB_Status = -1, RB_UpdateDate = DateTime.Now, CC_ID = "CC2016110619260001", RB_CurrantCheck = "13725731235" }
            //    );
            ////��RB_Rows�������Ĭ������
            //context.RB_Rows.AddOrUpdate(
            //    new RB_Rows { R_ID = 1, RB_ID = "RB2016110108160001", R_Amount = 20.3M, R_Note = "��ϸ1", R_TypeID = "JY", R_CreateDate = DateTime.Now, R_ConsumeDate = DateTime.Now.AddDays(-5) },
            //    new RB_Rows { R_ID = 2, RB_ID = "RB2016110108160001", R_Amount = 79.7M, R_Note = "��ϸ2", R_TypeID = "KD", R_CreateDate = DateTime.Now, R_ConsumeDate = DateTime.Now.AddDays(-4) },
            //    new RB_Rows { R_ID = 3, RB_ID = "RB2016110108160001", R_Amount = 20, R_Note = "��ϸ1", R_TypeID = "CB", R_CreateDate = DateTime.Now, R_ConsumeDate = DateTime.Now.AddDays(-3) },
            //    new RB_Rows { R_ID = 4, RB_ID = "RB2016110816100001", R_Amount = 70, R_Note = "��ϸ2", R_TypeID = "TXF", R_CreateDate = DateTime.Now, R_ConsumeDate = DateTime.Now.AddDays(-2) },
            //    new RB_Rows { R_ID = 5, RB_ID = "RB2016110816100001", R_Amount = 12.1M, R_Note = "��ϸ3", R_TypeID = "YW", R_CreateDate = DateTime.Now, R_ConsumeDate = DateTime.Now.AddDays(-1) },
            //    new RB_Rows { R_ID = 6, RB_ID = "RB2016110816100001", R_Amount = 17.9M, R_Note = "��ϸ4", R_TypeID = "FZ", R_CreateDate = DateTime.Now, R_ConsumeDate = DateTime.Now },
            //    new RB_Rows { R_ID = 7, RB_ID = "RB2016111620130001", R_Amount = 20, R_Note = "��ϸ1", R_TypeID = "GL", R_CreateDate = DateTime.Now, R_ConsumeDate = DateTime.Now },
            //    new RB_Rows { R_ID = 8, RB_ID = "RB2016111620130001", R_Amount = 20, R_Note = "��ϸ2", R_TypeID = "YJ", R_CreateDate = DateTime.Now, R_ConsumeDate = DateTime.Now }
            //    );
            ////��CC_Type_Template�������Ĭ������
            //context.CC_Type_Templates.AddOrUpdate(
            //    new CC_Type_Template { CC_TT_TemplateID = "CT2016110314280001", CC_TT_TypeID = "1", CC_TT_AEACheckers = "13725731234", CC_TT_FinancialCheckers = "13725731235,13725731236", CC_TT_UpdateDate = DateTime.Now },
            //    new CC_Type_Template { CC_TT_TemplateID = "CT2016110613470001", CC_TT_TypeID = "2", CC_TT_AEACheckers = "13725731236,13725731237", CC_TT_FinancialCheckers = "13725731235,13725731238", CC_TT_UpdateDate = DateTime.Now },
            //    new CC_Type_Template { CC_TT_TemplateID = "CT2016110809360001", CC_TT_TypeID = "3", CC_TT_AEACheckers = "13725731237", CC_TT_FinancialCheckers = "13725731235,13725731234", CC_TT_UpdateDate = DateTime.Now }
            //    );
            ////��CostCenter�������Ĭ������
            //context.CostCenters.AddOrUpdate(
            //    new CostCenter { CC_ID = "CC2016111320140001", CC_Name = "ά��1", CC_TypeID = "1", CC_LiableMan = "13725731236", CC_DepartmentID = "Dep2016102517120001", CC_StartDate = DateTime.Now.AddDays(-100), CC_EndDate = DateTime.Now.AddDays(60), CC_TemplateID = "CT2016110314280001", CC_Amount = 6000.6M, CC_IsActive = 1, CC_UsedAmount = 0, CC_CreateDate = DateTime.Now, CC_UpdateDate = DateTime.Now },
            //    new CostCenter { CC_ID = "CC2016110218450001", CC_Name = "�칫1", CC_TypeID = "2", CC_LiableMan = "13725731238", CC_DepartmentID = "Dep2016102517120001", CC_StartDate = DateTime.Now.AddDays(-100), CC_EndDate = DateTime.Now.AddDays(60), CC_TemplateID = "CT2016110613470001", CC_Amount = 7000.6M, CC_IsActive = 1, CC_UsedAmount = 0, CC_CreateDate = DateTime.Now, CC_UpdateDate = DateTime.Now },
            //    new CostCenter { CC_ID = "CC2016110619260001", CC_Name = "��Ʒ��ϵ1", CC_TypeID = "3", CC_LiableMan = "13725731237", CC_DepartmentID = "Dep2016102517120001", CC_StartDate = DateTime.Now.AddDays(-100), CC_EndDate = DateTime.Now.AddDays(60), CC_TemplateID = "CT2016110809360001", CC_Amount = 8000.6M, CC_IsActive = 1, CC_UsedAmount = 0, CC_CreateDate = DateTime.Now, CC_UpdateDate = DateTime.Now }
            //    );
            #endregion
        }
    }
}
