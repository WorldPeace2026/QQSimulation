using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace QQServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            IPEndPoint point = new IPEndPoint(ip, 8888);
            serverSocket.Bind(point);
            serverSocket.Listen(10);
            Console.WriteLine("服务器机房已通电！正在 8888 房间死等客户敲门...");

            // 【核心改变1】：前台必须永远在上班，所以要加死循环！
            while (true)
            {
                // 代码卡在这里等，来一个客户，往下走一步
                Socket clientSocket = serverSocket.Accept();

                // 打印出是哪个 IP 地址的客户连进来了
                Console.WriteLine($"[系统提示] 客户已连接！客户端地址: {clientSocket.RemoteEndPoint}");

                // 【核心改变2】：分配专属客服去后台接待，绝对不能卡住前台！
                // 把专属通讯插头传给这个方法，让它在 Task（临时工线程）里慢慢跑
                Task.Run(() => ReceiveFromClient(clientSocket));
            }
        }

        // 这是分配给每一个客户的专属接待房间
        static void ReceiveFromClient(Socket dedicatedSocket)//传进来的是clientSocket，转换成了dedicatedSocket是吗？
        {
            // 准备一个接水的盆
            byte[] buffer = new byte[1024 * 1024];
            List<byte>cache = new List<byte>();
            while (true)
            {
                try
                {
                    // 专属客服在这里死等客户发数据
                    int length = dedicatedSocket.Receive(buffer);
                    if (length == 0)
                    {
                        Console.WriteLine($"[系统提示] 客户 {dedicatedSocket.RemoteEndPoint} 正常断开了连接。");
                        break;
                    }
                    cache.AddRange(buffer.Take(length));
                    while (cache.Count >= 5) 
                    {
                        int len = BitConverter.ToInt32(cache.ToArray(),1);
                        int totalLen = len + 1 + 4;
                        if (totalLen > cache.Count) break;
                        string msg = Encoding.UTF8.GetString(cache.ToArray(), 5, len);

                       
                             cache.RemoveRange(0,totalLen);
                    }



                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[系统警告] 客户异常断开。原因: {ex.Message}");
                    break;
                }
            }
        }
    }
}