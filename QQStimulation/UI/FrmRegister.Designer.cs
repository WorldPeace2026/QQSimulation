namespace QQStimulation
{
    partial class FrmRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.txtUser = new Sunny.UI.UITextBox();
            this.txtPwd = new Sunny.UI.UITextBox();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.txtPwd2 = new Sunny.UI.UITextBox();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("华文中宋", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(86, 140);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 47);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "账号";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("华文中宋", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(86, 236);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 53);
            this.uiLabel2.TabIndex = 1;
            this.uiLabel2.Text = "密码";
            // 
            // txtUser
            // 
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.Font = new System.Drawing.Font("华文中宋", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUser.Location = new System.Drawing.Point(229, 140);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUser.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtUser.Name = "txtUser";
            this.txtUser.Padding = new System.Windows.Forms.Padding(5);
            this.txtUser.ShowText = false;
            this.txtUser.Size = new System.Drawing.Size(211, 47);
            this.txtUser.TabIndex = 2;
            this.txtUser.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtUser.Watermark = "";
            // 
            // txtPwd
            // 
            this.txtPwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPwd.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPwd.Location = new System.Drawing.Point(229, 236);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPwd.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Padding = new System.Windows.Forms.Padding(5);
            this.txtPwd.ShowText = false;
            this.txtPwd.Size = new System.Drawing.Size(211, 53);
            this.txtPwd.TabIndex = 3;
            this.txtPwd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPwd.Watermark = "";
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.FillColor = System.Drawing.Color.Red;
            this.uiButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.uiButton1.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.uiButton1.Font = new System.Drawing.Font("华文中宋", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.ForeColor = System.Drawing.Color.Wheat;
            this.uiButton1.Location = new System.Drawing.Point(521, 168);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(206, 93);
            this.uiButton1.TabIndex = 4;
            this.uiButton1.Text = "注册";
            this.uiButton1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("华文中宋", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(86, 320);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(200, 53);
            this.uiLabel3.TabIndex = 5;
            this.uiLabel3.Text = "确认密码";
            // 
            // txtPwd2
            // 
            this.txtPwd2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPwd2.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPwd2.Location = new System.Drawing.Point(293, 320);
            this.txtPwd2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPwd2.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPwd2.Name = "txtPwd2";
            this.txtPwd2.Padding = new System.Windows.Forms.Padding(5);
            this.txtPwd2.ShowText = false;
            this.txtPwd2.Size = new System.Drawing.Size(147, 53);
            this.txtPwd2.TabIndex = 6;
            this.txtPwd2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPwd2.Watermark = "";
            this.txtPwd2.TextChanged += new System.EventHandler(this.uiTextBox3_TextChanged);
            // 
            // FrmRegister
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.Controls.Add(this.txtPwd2);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Name = "FrmRegister";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "注册界面";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 800, 450);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox txtUser;
        private Sunny.UI.UITextBox txtPwd;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox txtPwd2;
    }
}