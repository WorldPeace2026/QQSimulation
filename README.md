# QQStimulation
## 项目逻辑时序图

```mermaid
sequenceDiagram
    participant UI as FrmChat (UI界面)
    participant Net as SocketNetwork (客户端通讯类)
    participant SrvNet as SocketServer (服务端通讯类)
    participant SrvLogic as Program.cs (服务端大脑)

    Note over UI,Net: 【第一阶段：客户端发车】
    UI->>UI: 1. 用户点击“发送”按钮
    UI->>UI: 2. 界面显示 [我]: 你好
    UI->>Net: 3. 通过 _sendAction 委托把 "你好" 传给网卡
    Net->>Net: 4. 打包成 Byte[] 字节流

    Note over Net,SrvNet: 【第二阶段：跨越网络】
    Net->>SrvNet: 5. _socket.Send() 物理发送电信号

    Note over SrvNet,SrvLogic: 【第三阶段：服务器接收】
    SrvNet->>SrvNet: 6. Receive() 收到字节，解包成字符串 "你好"
    SrvNet->>SrvLogic: 7. 触发 OnDataReceived 委托 (大喇叭)
    SrvLogic->>SrvLogic: 8. 控制台打印：客户发来消息...
