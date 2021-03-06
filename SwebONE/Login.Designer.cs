using Swebui;

namespace SwebONE
{
    partial class Login : Swebui.Controls.SwebForm
    {
        #region "SwebForm Designer generated code "

        //SwebForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SwebForm Designer
        //It can be modified using the SwebForm Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.panel1 = new Swebui.Controls.Panel();
            this.image1 = new Swebui.Controls.Image();
            this.panel2 = new Swebui.Controls.Panel();
            this.image2 = new Swebui.Controls.Image();
            this.psdPanel = new Swebui.Controls.Panel();
            this.panel3 = new Swebui.Controls.Panel();
            this.fontIcon1 = new Swebui.Controls.FontIcon();
            this.txtTel = new Swebui.Controls.TextBox();
            this.panel5 = new Swebui.Controls.Panel();
            this.fontIcon2 = new Swebui.Controls.FontIcon();
            this.txtPwd = new Swebui.Controls.TextBox();
            this.loginBtn = new Swebui.Controls.Button();
            this.panel6 = new Swebui.Controls.Panel();
            this.button2 = new Swebui.Controls.Button();
            this.button3 = new Swebui.Controls.Button();
            this.fastLoginPanel = new Swebui.Controls.Panel();
            this.panel7 = new Swebui.Controls.Panel();
            this.fontIcon3 = new Swebui.Controls.FontIcon();
            this.textBox1 = new Swebui.Controls.TextBox();
            this.button5 = new Swebui.Controls.Button();
            this.verifycode = new Swebui.Controls.Label();
            this.panel8 = new Swebui.Controls.Panel();
            this.fontIcon4 = new Swebui.Controls.FontIcon();
            this.txtVcode1 = new Swebui.Controls.TextBox();
            this.verfiyLogin = new Swebui.Controls.Button();
            this.button4 = new Swebui.Controls.Button();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.image1,
            this.panel2});
            this.panel1.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel1.Name = "panel1";
            this.panel1.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel1.Size = new System.Drawing.Size(600, 400);
            // 
            // image1
            // 
            this.image1.Name = "image1";
            this.image1.ResourceID = "logn_left.jpg";
            this.image1.Size = new System.Drawing.Size(300, 0);
            this.image1.SizeMode = Swebui.Controls.ImageSizeMode.Stretch;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(83)))), ((int)(((byte)(151)))));
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.image2,
            this.psdPanel,
            this.fastLoginPanel});
            this.panel2.Name = "panel2";
            this.panel2.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel2.Scrollable = true;
            this.panel2.Size = new System.Drawing.Size(300, 0);
            // 
            // image2
            // 
            this.image2.BorderRadius = 4;
            this.image2.BorderStyle = Swebui.Controls.BorderStyle.Dotted;
            this.image2.Margin = new Swebui.Controls.Margin(0F, 50F, 0F, 0F);
            this.image2.Name = "image2";
            this.image2.ResourceID = "logon1.gif";
            this.image2.Size = new System.Drawing.Size(0, 100);
            this.image2.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // psdPanel
            // 
            this.psdPanel.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel3,
            this.panel5,
            this.loginBtn,
            this.panel6});
            this.psdPanel.Flex = 1;
            this.psdPanel.Name = "psdPanel";
            this.psdPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // panel3
            // 
            this.panel3.Border = new Swebui.Controls.Border(1F);
            this.panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.panel3.BorderRadius = 4;
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.fontIcon1,
            this.txtTel});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel3.Margin = new Swebui.Controls.Margin(20F);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 32);
            // 
            // fontIcon1
            // 
            this.fontIcon1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.fontIcon1.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.fontIcon1.Name = "fontIcon1";
            this.fontIcon1.ResourceID = "user";
            this.fontIcon1.Size = new System.Drawing.Size(16, 16);
            // 
            // txtTel
            // 
            this.txtTel.BackColor = System.Drawing.Color.Transparent;
            this.txtTel.Border = new Swebui.Controls.Border(1F, 0F, 0F, 0F);
            this.txtTel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.txtTel.Flex = 1;
            this.txtTel.FontSize = 12F;
            this.txtTel.ForeColor = System.Drawing.Color.White;
            this.txtTel.Name = "txtTel";
            this.txtTel.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.txtTel.Size = new System.Drawing.Size(100, 32);
            this.txtTel.WaterMarkText = "账号";
            // 
            // panel5
            // 
            this.panel5.Border = new Swebui.Controls.Border(1F);
            this.panel5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.panel5.BorderRadius = 4;
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.fontIcon2,
            this.txtPwd});
            this.panel5.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel5.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel5.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.Center;
            this.panel5.Margin = new Swebui.Controls.Margin(20F, 0F, 20F, 0F);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(0, 32);
            // 
            // fontIcon2
            // 
            this.fontIcon2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.fontIcon2.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.fontIcon2.Name = "fontIcon2";
            this.fontIcon2.ResourceID = "unlock-alt";
            this.fontIcon2.Size = new System.Drawing.Size(16, 16);
            // 
            // txtPwd
            // 
            this.txtPwd.BackColor = System.Drawing.Color.Transparent;
            this.txtPwd.Border = new Swebui.Controls.Border(1F, 0F, 0F, 0F);
            this.txtPwd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.txtPwd.Flex = 1;
            this.txtPwd.FontSize = 12F;
            this.txtPwd.ForeColor = System.Drawing.Color.White;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.txtPwd.SecurityMode = true;
            this.txtPwd.Size = new System.Drawing.Size(100, 32);
            this.txtPwd.WaterMarkText = "密码";
            // 
            // loginBtn
            // 
            this.loginBtn.Margin = new Swebui.Controls.Margin(20F, 30F, 20F, 0F);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.NumberOfLines = 0;
            this.loginBtn.Size = new System.Drawing.Size(0, 35);
            this.loginBtn.Text = "登录";
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.button2,
            this.button3});
            this.panel6.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel6.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.SpaceBetween;
            this.panel6.Margin = new Swebui.Controls.Margin(20F, 20F, 20F, 0F);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(0, 38);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Name = "button2";
            this.button2.NumberOfLines = 0;
            this.button2.SelectBackgroundColor = System.Drawing.Color.Transparent;
            this.button2.SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.button2.Size = new System.Drawing.Size(99, 0);
            this.button2.Text = "演示账号";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Name = "button3";
            this.button3.NumberOfLines = 0;
            this.button3.SelectBackgroundColor = System.Drawing.Color.Transparent;
            this.button3.SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.button3.Size = new System.Drawing.Size(100, 0);
            this.button3.Text = "注册";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // fastLoginPanel
            // 
            this.fastLoginPanel.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel7,
            this.verifycode,
            this.panel8,
            this.verfiyLogin,
            this.button4});
            this.fastLoginPanel.Flex = 1;
            this.fastLoginPanel.Name = "fastLoginPanel";
            this.fastLoginPanel.Size = new System.Drawing.Size(0, 100);
            this.fastLoginPanel.Visible = false;
            // 
            // panel7
            // 
            this.panel7.Border = new Swebui.Controls.Border(1F);
            this.panel7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.panel7.BorderRadius = 4;
            this.panel7.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.fontIcon3,
            this.textBox1,
            this.button5});
            this.panel7.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel7.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel7.Margin = new Swebui.Controls.Margin(20F, 20F, 20F, 0F);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(0, 32);
            // 
            // fontIcon3
            // 
            this.fontIcon3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.fontIcon3.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.fontIcon3.Name = "fontIcon3";
            this.fontIcon3.ResourceID = "phone";
            this.fontIcon3.Size = new System.Drawing.Size(16, 16);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Transparent;
            this.textBox1.Border = new Swebui.Controls.Border(1F, 0F, 0F, 0F);
            this.textBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.textBox1.Flex = 1;
            this.textBox1.FontSize = 12F;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Name = "textBox1";
            this.textBox1.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.textBox1.Size = new System.Drawing.Size(100, 32);
            this.textBox1.WaterMarkText = "电话";
            // 
            // button5
            // 
            this.button5.Name = "button5";
            this.button5.NumberOfLines = 0;
            this.button5.Padding = new Swebui.Controls.Padding(5F, 0F, 5F, 0F);
            this.button5.Size = new System.Drawing.Size(0, 32);
            this.button5.Text = "获取验证码";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // verifycode
            // 
            this.verifycode.ForeColor = System.Drawing.Color.White;
            this.verifycode.Margin = new Swebui.Controls.Margin(20F, 0F, 20F, 0F);
            this.verifycode.Name = "verifycode";
            this.verifycode.Size = new System.Drawing.Size(0, 20);
            this.verifycode.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel8
            // 
            this.panel8.Border = new Swebui.Controls.Border(1F);
            this.panel8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.panel8.BorderRadius = 4;
            this.panel8.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.fontIcon4,
            this.txtVcode1});
            this.panel8.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel8.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel8.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.Center;
            this.panel8.Margin = new Swebui.Controls.Margin(20F, 0F, 20F, 0F);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(0, 32);
            // 
            // fontIcon4
            // 
            this.fontIcon4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.fontIcon4.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.fontIcon4.Name = "fontIcon4";
            this.fontIcon4.ResourceID = "unlock-alt";
            this.fontIcon4.Size = new System.Drawing.Size(16, 16);
            // 
            // txtVcode1
            // 
            this.txtVcode1.BackColor = System.Drawing.Color.Transparent;
            this.txtVcode1.Border = new Swebui.Controls.Border(1F, 0F, 0F, 0F);
            this.txtVcode1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.txtVcode1.Flex = 1;
            this.txtVcode1.FontSize = 12F;
            this.txtVcode1.ForeColor = System.Drawing.Color.White;
            this.txtVcode1.Name = "txtVcode1";
            this.txtVcode1.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.txtVcode1.Size = new System.Drawing.Size(100, 32);
            this.txtVcode1.WaterMarkText = "验证码";
            // 
            // verfiyLogin
            // 
            this.verfiyLogin.Margin = new Swebui.Controls.Margin(20F, 30F, 20F, 0F);
            this.verfiyLogin.Name = "verfiyLogin";
            this.verfiyLogin.NumberOfLines = 0;
            this.verfiyLogin.Size = new System.Drawing.Size(0, 35);
            this.verfiyLogin.Text = "登录";
            this.verfiyLogin.Click += new System.EventHandler(this.verfiyLogin_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Margin = new Swebui.Controls.Margin(20F, 30F, 20F, 0F);
            this.button4.Name = "button4";
            this.button4.NumberOfLines = 0;
            this.button4.Size = new System.Drawing.Size(0, 35);
            this.button4.Text = "<<返回";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Login
            // 
            this.BackgroundImage = "bg.png";
            this.BackgroundImageSizeMode = Swebui.Controls.ImageSizeMode.Cover;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1});
            this.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.Center;
            this.Overflow = Swebui.Controls.LayoutOverflow.Hidden;

        }
        #endregion

        private Swebui.Controls.Panel panel1;
        private Swebui.Controls.Image image1;
        private Swebui.Controls.Panel panel2;
        private Swebui.Controls.Image image2;
        private Swebui.Controls.Panel psdPanel;
        private Swebui.Controls.Panel panel3;
        private Swebui.Controls.FontIcon fontIcon1;
        private Swebui.Controls.TextBox txtTel;
        private Swebui.Controls.Panel panel5;
        private Swebui.Controls.FontIcon fontIcon2;
        private Swebui.Controls.TextBox txtPwd;
        private Swebui.Controls.Button loginBtn;
        private Swebui.Controls.Panel panel6;
        private Swebui.Controls.Button button2;
        private Swebui.Controls.Button button3;
        private Swebui.Controls.Panel fastLoginPanel;
        private Swebui.Controls.Panel panel7;
        private Swebui.Controls.FontIcon fontIcon3;
        private Swebui.Controls.TextBox textBox1;
        private Swebui.Controls.Panel panel8;
        private Swebui.Controls.FontIcon fontIcon4;
        private Swebui.Controls.TextBox txtVcode1;
        private Swebui.Controls.Button verfiyLogin;
        private Swebui.Controls.Button button4;
        private Swebui.Controls.Button button5;
        private Swebui.Controls.Label verifycode;
    }
}