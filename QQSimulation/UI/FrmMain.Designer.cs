namespace QQSimulation
{
    partial class FrmMain
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
            this.listFriends = new Sunny.UI.UIListBox();
            this.panelContainer = new Sunny.UI.UIPanel();
            this.SuspendLayout();
            // 
            // listFriends
            // 
            this.listFriends.Dock = System.Windows.Forms.DockStyle.Left;
            this.listFriends.FillColor = System.Drawing.Color.White;
            this.listFriends.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.listFriends.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listFriends.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(235)))), ((int)(((byte)(212)))));
            this.listFriends.ItemSelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.listFriends.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.listFriends.Location = new System.Drawing.Point(0, 35);
            this.listFriends.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listFriends.MinimumSize = new System.Drawing.Size(1, 1);
            this.listFriends.Name = "listFriends";
            this.listFriends.Padding = new System.Windows.Forms.Padding(2);
            this.listFriends.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.listFriends.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.listFriends.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.listFriends.ScrollBarStyleInherited = false;
            this.listFriends.ShowText = false;
            this.listFriends.Size = new System.Drawing.Size(270, 415);
            this.listFriends.Style = Sunny.UI.UIStyle.Custom;
            this.listFriends.TabIndex = 0;
            this.listFriends.Text = "uiListBox1";
            this.listFriends.DoubleClick += new System.EventHandler(this.listFriends_DoubleClick);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.panelContainer.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.panelContainer.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panelContainer.Location = new System.Drawing.Point(270, 35);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelContainer.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.panelContainer.Size = new System.Drawing.Size(530, 415);
            this.panelContainer.Style = Sunny.UI.UIStyle.Custom;
            this.panelContainer.TabIndex = 1;
            this.panelContainer.Text = null;
            this.panelContainer.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.panelContainer.Click += new System.EventHandler(this.panelContainer_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.listFriends);
            this.Name = "FrmMain";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "FrmMain";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 800, 450);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIListBox listFriends;
        private Sunny.UI.UIPanel panelContainer;
    }
}