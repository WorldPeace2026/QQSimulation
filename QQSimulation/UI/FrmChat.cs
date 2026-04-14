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
using Sunny.UI.Win32;

namespace QQSimulation.UI
{

    public partial class FrmChat : UIForm
    {
        //声明一个私有的全局变量放名字
        private string targetDeviceName;
        //端子声明
        private Action<string> _sendAction;
        //全局网络对象
        private Network _net;
        public FrmChat(string deviceName,Action<string>sendMethod)
        {
            InitializeComponent();
            this.targetDeviceName = deviceName;
            this.Text = targetDeviceName;
            //接线，委托
            this._sendAction = sendMethod;
            //上电瞬间自动读取 UI 的物理高度作为下限挡块
            _minHeight = this.txt_Input.Height;
        }

        private void FrmChat_Load(object sender, EventArgs e)
        {
            _net = new Network();
            _net.OnDataReceived += this.ReceiveMessage;
            _net.MockReceiveDataFromNetwork("Hello!我是底层网络发来的测试数据！");
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            string msg = this.txt_Input.Text;
            //防呆空发送
            if(string.IsNullOrWhiteSpace(msg))
            {
                MessageBox.Show("不能发送空消息！");
                this.txt_Input.Text = "";
                this.txt_Input.Focus();
                return;

            }
            //调用委托
            this._sendAction(msg);
            //清空输入框
            this.txt_Input.Text = "";
        }
        private int _minHeight;//初始的单行高度
        private int _maxHeight = 100;//膨胀的极限高度
        private int _midHeight = 85;
        //绝对原点
        private int _originalTop = -1;//用-1来表示未校准
        //================================================隔离一下

        private void txt_Input_TextChanged(object sender, EventArgs e)
        {
            //上电复位防呆设计
            if (_originalTop == -1) _originalTop = this.txt_Input.Top;
            //1.量尺寸
            Size textSize = TextRenderer.MeasureText(

                this.txt_Input.Text,
                this.txt_Input.Font,
                new Size(this.txt_Input.Width - 10, int.MaxValue),
                //减10是为了留点内边距
                TextFormatFlags.WordBreak | TextFormatFlags.TextBoxControl
                );
            //2.算文本框上下的边框厚度
            int targetHeight = textSize.Height + 10;
            //加一个基准,算上下边框的厚度
            int actualNewHeight = targetHeight;
            if (actualNewHeight < _minHeight) actualNewHeight = _minHeight;
            if (actualNewHeight > _maxHeight) actualNewHeight = _maxHeight;
            
            
            // 3. 【机械限位逻辑】：判断要不要拉伸文本框
           if(actualNewHeight <= _midHeight)
            {
                //第一阶段，上边框不长下边框长
                this.txt_Input.Top = _originalTop;
                this.txt_Input.Height = actualNewHeight;
            }

            else
            {
                int absoluteBottomAnchor = _originalTop + _midHeight;
                this.txt_Input.Height = actualNewHeight;
                this.txt_Input.Top = absoluteBottomAnchor - actualNewHeight;
                
            }
           //要不要开滚动条，要不要光标锁定最后一行，要不要滚动条直接滚动到最后一行！
           //代码分离，逻辑分离，越简单越好
            if (targetHeight > _maxHeight)
            {
                // 真实高度溢出，亮红灯 (开滚动条)
                if (!this.txt_Input.ShowScrollBar) this.txt_Input.ShowScrollBar = true;
                this.txt_Input.SelectionStart = this.txt_Input.Text.Length;
                this.txt_Input.ScrollToCaret();
            }
            else
            {
                // 真实高度安全，关红灯 (关滚动条)
                if (this.txt_Input.ShowScrollBar) this.txt_Input.ShowScrollBar = false;
            }

        }
    }
}
