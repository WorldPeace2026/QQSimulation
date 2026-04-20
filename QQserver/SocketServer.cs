using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace QQServer
{
    public class SocketServer
    {
        // 1. 贴上允许为空的标签 '?'
        private Socket? _serverSocket;

        // 2. 事件也可能没人订阅，所以加上 '?'
        public event Action<string>? OnClientConnected;
        public event Action<string, string>? OnDataReceived;
        // 建一个电话簿。左边存客户IP(string)，右边存对应的物理插头(Socket)
        private Dictionary<string, Socket> _clientDic = new Dictionary<string, Socket>();
        public void Start(string ipAddress, int port)
        {
            _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ip = IPAddress.Parse(ipAddress);
            IPEndPoint point = new IPEndPoint(ip, port);

            _serverSocket.Bind(point);
            _serverSocket.Listen(10);

            Task.Run(() => AcceptClients());
        }

        private void AcceptClients()
        {
            while (true)
            {
                // 如果 _serverSocket 是空的，下面这句会报错，但我们在 Start 里已经给它赋值了
    
                Socket clientSocket = _serverSocket!.Accept();

                //  【防呆设计】：?. 的意思是如果有地址就转字符串，如果没有，就执行 ?? 后面的默认值
                string clientIP = clientSocket.RemoteEndPoint?.ToString() ?? "未知地址";

                OnClientConnected?.Invoke(clientIP);
                //客户一连进来，立刻把他的 IP 和插头登记到电话簿里
                if (!_clientDic.ContainsKey(clientIP))
                {
                    _clientDic.Add(clientIP, clientSocket);
                }
                Task.Run(() => ReceiveFromClient(clientSocket, clientIP));
            }
        }
        public void SendToClient(string targetIP, string msg)
        {
            // 去电话簿里查，有没有这个 IP
            if (_clientDic.ContainsKey(targetIP))
            {
                // 查到了！把他的插头拿出来
                Socket targetSocket = _clientDic[targetIP];

                // 按照协议，把字符串打包成 byte[] 并发送（这里为了简便先直接发UTF8，你后期可以加上长度防粘包）
                byte[] textBytes = Encoding.UTF8.GetBytes(msg);
                byte[] buffer = new byte[textBytes.Length + 5];
                buffer[0] = 0; // 0代表文本类型
                BitConverter.GetBytes(textBytes.Length).CopyTo(buffer, 1);
                textBytes.CopyTo(buffer, 5);

                targetSocket.Send(buffer); // 物理发送！
                                           // 【探针1】：如果代码真的走到了这里，必须在黑框框里打印出来！
                Console.WriteLine($"[探针1] 成功向客户 {targetIP} 回发了消息！");
            }
            else
            {
                // 【探针2】：如果电话簿里没找到这个人，必须报警！
                Console.WriteLine($"[探针2警告] 电话簿里找不到IP：{targetIP}，无法回发！");
            }
        }
        private void ReceiveFromClient(Socket dedicatedSocket, string clientIP)
        {
            byte[] buffer = new byte[1024 * 1024];
            List<byte> cache = new List<byte>();

            while (true)
            {
                try
                {
                    int length = dedicatedSocket.Receive(buffer);
                    if (length == 0) break;

                    cache.AddRange(buffer.Take(length));

                    while (cache.Count >= 5)
                    {
                        int len = BitConverter.ToInt32(cache.ToArray(), 1);
                        int totalLen = len + 1 + 4;
                        if (totalLen > cache.Count) break;

                        string msg = Encoding.UTF8.GetString(cache.ToArray(), 5, len);

                        OnDataReceived?.Invoke(clientIP, msg);

                        cache.RemoveRange(0, totalLen);
                    }
                }
                catch
                {
                    break;
                }
            }
        }
    }
}