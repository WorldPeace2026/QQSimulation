namespace QQStimulation
{
    partial class FrmLogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Login = new Sunny.UI.UIButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.txt_User = new Sunny.UI.UITextBox();
            this.txt_Pwd = new Sunny.UI.UITextBox();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Login.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Login.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Login.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Login.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Login.Font = new System.Drawing.Font("宋体", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Login.Location = new System.Drawing.Point(463, 152);
            this.btn_Login.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(108, 72);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "登录";
            this.btn_Login.TipsFont = new System.Drawing.Font("华文中宋", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Login.TipsForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Login.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(108, 131);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 34);
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "账号";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(108, 207);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 42);
            this.uiLabel2.TabIndex = 2;
            this.uiLabel2.Text = "密码";
            // 
            // txt_User
            // 
            this.txt_User.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_User.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_User.ButtonRectPressColor = System.Drawing.Color.Yellow;
            this.txt_User.ButtonStyleInherited = false;
            this.txt_User.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_User.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_User.Location = new System.Drawing.Point(267, 136);
            this.txt_User.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_User.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_User.Name = "txt_User";
            this.txt_User.Padding = new System.Windows.Forms.Padding(5);
            this.txt_User.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_User.ShowText = false;
            this.txt_User.Size = new System.Drawing.Size(150, 29);
            this.txt_User.TabIndex = 3;
            this.txt_User.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_User.Watermark = "";
            // 
            // txt_Pwd
            // 
            this.txt_Pwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Pwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Pwd.Location = new System.Drawing.Point(267, 207);
            this.txt_Pwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Pwd.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_Pwd.Name = "txt_Pwd";
            this.txt_Pwd.Padding = new System.Windows.Forms.Padding(5);
            this.txt_Pwd.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txt_Pwd.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txt_Pwd.ScrollBarStyleInherited = false;
            this.txt_Pwd.ShowText = false;
            this.txt_Pwd.Size = new System.Drawing.Size(150, 29);
            this.txt_Pwd.TabIndex = 4;
            this.txt_Pwd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_Pwd.Watermark = "";
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.uiButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.uiButton2.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.uiButton2.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiButton2.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.uiButton2.Font = new System.Drawing.Font("宋体", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.Location = new System.Drawing.Point(255, 287);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(176, 72);
            this.uiButton2.TabIndex = 5;
            this.uiButton2.Text = "点击注册";
            this.uiButton2.TipsFont = new System.Drawing.Font("华文中宋", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.TipsForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.uiButton2.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // FrmLogin
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(689, 388);
            this.ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.Controls.Add(this.uiButton2);
            this.Controls.Add(this.txt_Pwd);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.btn_Login);
            this.Name = "FrmLogin";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "登录界面";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 282, 253);
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);

        }

        #endregion

     
        private Sunny.UI.UIButton btn_Login;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox txt_User;
        private Sunny.UI.UITextBox txt_Pwd;
        private Sunny.UI.UIButton uiButton2;
    }
}

