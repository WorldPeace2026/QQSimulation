using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;
using MySql.Data.MySqlClient;
using QQStimulation.Utils;


namespace QQStimulation
{
    public partial class FrmLogin : UIForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void skinTextBox2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            string user = txt_User.Text.Trim();
            string pwd = txt_Pwd.Text.Trim();
            if(user==""||pwd == "")
            {
                MessageBox.Show("账号或者密码不能为空！");
                return;
            }

            //Sql查询语句获取基本的信息
            string sql = $"SELECT COUNT(*) FROM user WHERE id ='{user}' AND password='{pwd}'";
            string myPath = Config.conStr;
            MySqlConnection con = new MySqlConnection(myPath);
            try
            {
                con.Open();//打开管道
                MySqlCommand cmd = new MySqlCommand(sql, con);//装载命令行
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                if (result > 0)
                {
                    MessageBox.Show("登录成功！");
                    //创造实例化窗口
                    FrmMain frmMain = new FrmMain(txt_User.Text.Trim());
                    //把当前的登录界面隐藏起来
                    this.Hide();
                    //让主界面跳出来
                    frmMain.Show();
                }
                else
                {
                    MessageBox.Show("报告：密码错误或查无此人！");
                }

            }
            catch (Exception ex) { MessageBox.Show("数据库连接失败，原因：" + ex.Message); }
            finally {
                //类似于_stream.Close()?
                con.Close();
            }
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            FrmRegister frmReg = new FrmRegister();
            frmReg.ShowDialog();
        }
    }
}
