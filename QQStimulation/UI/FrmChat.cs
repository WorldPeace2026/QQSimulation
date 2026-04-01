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

namespace QQStimulation.UI
{

    public partial class FrmChat : UIForm
    {
        //声明一个私有的全局变量放名字
        private string targetDeviceName;
        //端子声明
        private Action<string> _sendAction;
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

        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            string msg = this.txt_Input.Text;
            //防呆空发送
            if(msg == "")
            {
                MessageBox.Show("不能发送空消息！");
                return;

            }
            //调用委托
            this._sendAction(msg);
            //清空输入框
            this.txt_Input.Text = "";
        }
        private int _minHeight;//初始的单行高度
        private int _maxHeight = 120;//膨胀的极限高度
        private void txt_Input_TextChanged(object sender, EventArgs e)
        {
            //1.量尺寸
            Size textSize = TextRenderer.MeasureText(

                this.txt_Input.Text,
                this.txt_Input.Font,
                new Size(this.txt_Input.Width - 10, int.MaxValue),
                //减10是为了留点内边距
                TextFormatFlags.WordBreak
                );
            //2.算文本框上下的边框厚度
            int targetHeight = textSize.Height + 15;
            //修改Top的高度，根据新高度的变化量，就是说新高度-老高度
            if (targetHeight > _minHeight)
            {
                int diff = targetHeight - this.txt_Input.Height;
                this.txt_Input.Top = this.txt_Input.Top - diff;
            }
            // 3. 【机械限位逻辑】：判断要不要拉伸文本框
            if (targetHeight <= _minHeight)
            {
                //字少的时候保持初始高度，隐藏滚动条
                this.txt_Input.Height = _minHeight;
                this.txt_Input.ShowScrollBar = false;
            }
            else if(targetHeight > _minHeight && targetHeight < _maxHeight)
            {
                //字超过一行，但是没有到极限，拉伸文本框，隐藏滚动条
                this.txt_Input.Height = targetHeight;
                this.txt_Input.ShowScrollBar = false;
                //让光标始终保持在最后一行，跟随打字滚动
                this.txt_Input.SelectionStart = this.txt_Input.Text.Length;
                this.txt_Input.ScrollToCaret();
            }
            else
            {
                //超过极限，锁死高度，顺便打开进度条的显示
                this.txt_Input.Height = _maxHeight;
                this.txt_Input.ShowScrollBar = true;
                this.txt_Input.SelectionStart = this.txt_Input.Text.Length;
                this.txt_Input.ScrollToCaret();
            }
        }
    }
}
