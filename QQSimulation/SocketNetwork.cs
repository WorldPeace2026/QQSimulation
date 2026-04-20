using System;
using System.Net.Sockets;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Org.BouncyCastle.Crypto.Paddings;

namespace QQSimulation
{
    public class SocketNetwork
    {
        // 【核心解耦：事件大喇叭】
        // 任何人（界面、数据库）只要订阅了这个喇叭，收到消息就会被通知。
        public event Action<string> OnMessageReceived;

        // 底层网络插头
        private Socket _socket;

        // 对外暴露的连接方法（供界面的“登录”按钮调用）
        public void ConnectToServer(string ip, int port)
        {
            try
            {
                // 1. 在内存造一个 TCP 插头
                _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                // 2. 物理连接服务器的三次握手（这里会卡顿一瞬间，实战中最好也放进后台线程）
                _socket.Connect(ip, port);

                // 3. 握手成功！立刻派一个“临时工线程”去死等数据
                Task.Run(() => StartReceiving());
            }
            catch (Exception ex)
            {
                // 连接失败（比如服务器没开，或者 IP 写错了）
                throw new Exception("连接服务器失败：" + ex.Message);
            }
        }

        // 这是一个跑在【后台临时工线程】里的死循环方法，绝对不会卡死主界面
        private void StartReceiving()
        {
            // 准备一个接水的盆（1MB 大小）
            byte[] _streamBf = new byte[1024 * 1024];
            List<byte> buffer = new List<byte>();
            while (true)
            {
                try
                {
                    // 【物理阻塞点】：线程跑到这里会进入休眠（0 CPU 占用）。
                    // 直到网卡收到了真实的电信号，操作系统才会把它叫醒。
                    int length = _socket.Receive(_streamBf);
                    if (length == 0) break;
                    // TCP 规则：收到 0 字节，说明对方正常断开了连接
                    buffer.AddRange(_streamBf.Take(length).ToArray());
                    while (buffer.Count >= 5)
                    {
                        int realLen = BitConverter.ToInt32(buffer.ToArray(), 1);//这里要不要写int realLen = BitConverter.ToInt32.ToArray(buffer, 1);
                        int totalLen = realLen + 5;
                        if (totalLen > buffer.Count) break;
                        byte msgType = buffer[0];
                        if (msgType == 0)
                        {

                            string msg = Encoding.UTF8.GetString(buffer.Skip(5).Take(realLen).ToArray());
                            System.Windows.Forms.MessageBox.Show("【探针3响了】底层网卡收到服务器回传：\n" + msg);
                            OnMessageReceived?.Invoke(msg);
                           }
                        else if(msgType == 1) 
                        {
                        //暂时把图片设为1吧，可能后续还要表情
                        }
                        else if (msgType == 2)
                        {
                            //表情

                        }
                        buffer.RemoveRange(0, totalLen);
                    }

                    // 触发大喇叭！把消息喊出去
                    // （?. 确保如果没人监听大喇叭，程序也不会崩溃）

                }
                catch
                {
                    // 发生了意外断开（如网线被拔出）
                    break;
                }
            }
        }
        public void SendMessage(string msg)
        {
           
                try
                {
                    byte[] textBytes = Encoding.UTF8.GetBytes(msg);
                    //制造标签
                    int length = textBytes.Length;
                    byte[] lenBytes = BitConverter.GetBytes(length);
                    byte[] buffer = new byte[length+5];
                    //^^^^^^^^^^^^^^^^^^^^^^^^^^^^拼接……………………………………………………………………^
                    buffer[0] = 0;
                    //0字头是消息文本的意思
                    lenBytes.CopyTo(buffer, 1);
                    textBytes.CopyTo(buffer, 5);
                    _socket.Send(buffer);
                }
                catch (Exception ex)
                {
                    throw new Exception("发送数据失败：" + ex.Message);
                }

            }
        }
    }
