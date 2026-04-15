using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Sunny.UI;
using QQSimulation.Utils;
using System.Linq.Expressions;
using QQSimulation.UI;

namespace QQSimulation
{
    public partial class FrmMain : UIForm
    {
        //申明一个全局变量，用来记住当前登录的账号
        public string currentUser;
        public SocketNetwork _socketNetwork;
        //在括号里面强制加一个user，强迫必须出示账号才开门
        public FrmMain(string user)
        {
            InitializeComponent();
            currentUser = user;//把外面传进来的账号，揣进全局变量
            this.Text = "QQ大本营——欢迎：" + currentUser;
            _socketNetwork = new SocketNetwork();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // 1. 先用黑板擦清空列表，防止重影
            listFriends.Items.Clear();
            // 2. 拿密码，接水管
            string myPath = Config.conStr;
            using (MySqlConnection con = new MySqlConnection(myPath))
            {
                try
                {
                    con.Open();
                    // 3. 写命令：查所有人，排除我自己 (currentUser)
                    string sql = $"SELECT id FROM user WHERE id !='{currentUser}'";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    // 4. 执行绝招：派质检员 (reader) 去读回传的表格
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {// 质检员一行一行往下走，走到没数据为止
                        while (reader.Read())
                        {// 把第0列（id列）的数据念出来
                            string friendId = reader.GetString(0);
                            // 塞进界面左边的UIListBox里
                            listFriends.Items.Add(friendId);
                        }

                    }

                }
                catch(Exception ex) {
                    MessageBox.Show("获取好友目录失败，失败原因是：" + ex.Message);
                }

            }
        }

        public void SendMessageToDevice(string msg)
        {
            //模拟通过网络把数据发出去
            MessageBox.Show("[FrmMain 底层网络中心]已将消息发送：" +msg);
        }
      

    
        private void listFriends_DoubleClick(object sender, EventArgs e)
        {
            //防呆
            if (this.listFriends.SelectedItem == null)
            {
                return;
            }
            //to get name


            string selectedName = this.listFriends.SelectedItem.ToString();

            FrmChat frmChat = new FrmChat(selectedName,this.SendMessageToDevice,this._socketNetwork);
            
            //取消独立属性
            frmChat.TopLevel = false;
            //取消最大化选项
            frmChat.FormBorderStyle = FormBorderStyle.None;
            //自动填满父容器
            frmChat.Dock = DockStyle.Fill;
            foreach(Control item in this.panelContainer.Controls)
            {
            
                item.Dispose();
               
            }
            this.panelContainer.Controls.Clear();
            this.panelContainer.Controls.Add(frmChat);
            frmChat.ShowTitle = false;//去掉假标题栏
            frmChat.Show();
        }

        private void panelContainer_Click(object sender, EventArgs e)
        {

        }
    }
}