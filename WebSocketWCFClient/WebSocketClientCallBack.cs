using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSocketWCFClient
{
    internal class WebSocketClientCallBack : WebSocketWCFServiceReference.IWebSocketServiceCallback
    {
        public void SendBackData(string data)
        {
            Console.WriteLine(data);
        }

    }

}
