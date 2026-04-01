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
using QQStimulation.Utils;

namespace QQStimulation
{

    public partial class FrmRegister : UIForm
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void uiTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            //抓取数据
            string user = txtUser.Text.Trim();
            string pwd = txtPwd.Text.Trim();
            string pwd2 = txtPwd2.Text.Trim();
            //2.防呆校验
            if(user == ""||pwd == "")
            {
                MessageBox.Show("账号或密码不能为空！");
                return;
            }
            if (pwd !=pwd2)
            {
                MessageBox.Show("两次输入的密码不一致，请重新输入！");
                txtPwd.Text = "";
                txtPwd2.Text = "";
                return;
            }
            //3.准备连通数据库
            string mypath = Config.conStr;//拿配置文件先进行一次身份检验
            using(MySqlConnection con =  new MySqlConnection(mypath))
            {
                try
                {
                    con.Open();//拨通电话
                    //【第一关】：先查账号是否重复注册
                    string sqlCheck = $"SELECT COUNT(*) FROM user WHERE id ='{user}'";
                    //将SQL语句和已打开的数据库连接打包成一个Command对象
                    MySqlCommand cmdCheck = new MySqlCommand(sqlCheck, con);
                    // 执行 SQL 并拿回第一行第一列的结果，将其转换为整型存入 existCount 变量
                    int existCount = Convert.ToInt32(cmdCheck.ExecuteScalar());

                    if (existCount > 0)
                    {
                        MessageBox.Show("该账号已经被注册！");
                        //[清空账密输入框，让用户重新输入]
                        txtUser.Text = "";
                        txtPwd.Text = "";
                        txtPwd2.Text = "";

                    }
                    else
                    {
                        //新的SQl，表示插入
                        string sqlInsert = $"Insert INTO user(id,password) VALUES ('{user}','{pwd}')";
                        //好像有点懂了
                        MySqlCommand cmdInsert = new MySqlCommand(sqlInsert,con);
                        int result = cmdInsert.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("注册成功！");
                            this.Close();//注册成功后关闭注册界面，回到登录界面，没想到对于窗口也是用Close。
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("数据库访问报错，原因：" + ex.Message);
                }
            }
        }
    }
}
