using System;

namespace QQServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. 实例化服务端专用的通讯类（造一个基站）
            SocketServer server = new SocketServer();

            // 2. 接线（订阅事件）
            server.OnClientConnected += (clientIP) =>
            {
                Console.WriteLine($"[系统提示] 客户已连接！客户端地址: {clientIP}");
            };

            server.OnDataReceived += (ip, msg) =>
            {
                string time = DateTime.Now.ToString("HH:mm:ss");
                Console.WriteLine($"[{time}] 客户 {ip} 发来消息: {msg}");
                server.SendToClient(ip, $"已阅，你的消息是：{msg}");
            };

            // 3. 启动服务器（开机通电）
            server.Start("127.0.0.1", 8888);

            Console.WriteLine("服务器机房已通电！正在 8888 房间后台死等客户敲门...");
            Console.ReadLine(); // 防止控制台闪退
        }
    }
}