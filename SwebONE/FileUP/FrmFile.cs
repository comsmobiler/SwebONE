using SwebONE.Layout;
using Swebui;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SwebONE.FileUP
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class FrmFile : Swebui.Controls.SwebUserControl
    {
        public FrmFile() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }

        private void FrmFile_Load(object sender, EventArgs e)
        {
            GetFile();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Client.FileUpload((obj, args) =>
            {
                if (args.isError == true)
                    Toast(args.error);
                else
                {
                    if (File.Exists(SwebResourceManager.DefaultDocumentPath + "\\" + args.ResourceID))
                        MessageBox.Show("已存在同名文件,是否覆盖？", "提示", MessageBoxButtons.YesNo, (obj1, args1) =>
                        {
                            if (args1.Result == ShowResult.Yes)
                                args.SaveFile(args.ResourceID, SwebResourceManager.DefaultDocumentPath);
                            GetFile();
                        });
                    else
                        args.SaveFile(args.ResourceID, SwebResourceManager.DefaultDocumentPath);
                    GetFile();
                }
            });
        }
        /// <summary>
        /// 获取\Resources\Document下的文件
        /// </summary>
        private void GetFile()
        {
            itemPanel.Controls.Clear();
            DirectoryInfo folder = new DirectoryInfo(SwebResourceManager.DefaultDocumentPath);
            if (folder.GetFiles("*.*").Length > 0)
            {
 foreach (FileInfo file in folder.GetFiles("*.*"))
            {
                WorkButton workButton = new WorkButton();
                workButton.Text = file.Name;
                workButton.Margin = new Margin(10, 10, 10, 10);
                if (Regex.IsMatch(file.Name, "^*.zip$") || Regex.IsMatch(file.Name, "^*.rar$"))
                {
                    workButton.ResourceID = "zip.png";
                }
                else if(Regex.IsMatch(file.Name, "^*.ppt$")|| Regex.IsMatch(file.Name, "^*.pptx$"))
                {
                    workButton.ResourceID = "ppt.png";
                }
                else if (Regex.IsMatch(file.Name, "^*.doc") || Regex.IsMatch(file.Name, "^*.docx"))
                {
                    workButton.ResourceID = "word.png";
                }
                else if (Regex.IsMatch(file.Name, "^*.xls") || Regex.IsMatch(file.Name, "^*.xlsx"))
                {
                    workButton.ResourceID = "Excel.png";
                }
                else
                {
                    workButton.ResourceID = "Other.png";
                }
                workButton.Press += WorkBtn_Click;
                itemPanel.Controls.Add(workButton);
            }
                lblinfo.Text = "* 可点击图标下载文件";
            }
            else
            {
                lblinfo.Text = "暂无文件";
            }
           
        }
        private void WorkBtn_Click(object sender, EventArgs e)
        {
            WorkButton workButton = (WorkButton)sender;
            this.Client.FileDownload(workButton.Text, SwebResourceManager.DefaultDocumentPath);
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new FrmFile() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }
    }
}