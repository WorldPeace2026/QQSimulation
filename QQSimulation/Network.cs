using System;


namespace QQSimulation
{
    public class Network
    {
        //定义一个事件（喇叭）
        public event Action<string> OnDataReceived;
       //Mock是模拟的意思
        public void MockReceiveDataFromNetwork(string rawData)
        {
            //触发事件
            OnDataReceived?.Invoke(rawData);

        }

    }
}
