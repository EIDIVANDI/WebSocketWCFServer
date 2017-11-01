using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebSocketWCFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = Communicate();
            t.Wait();
        }

        private static async Task Communicate()
        {
            var context = new InstanceContext(new WebSocketClientCallBack());
            var client = new WebSocketWCFServiceReference.WebSocketServiceClient(context);
            while (true)
            {
                Console.Write("Input (\"Exit\" to exit):");
                string input = Console.ReadLine();
                if (input.ToUpperInvariant() == "EXIT")
                {
                    break;
                }
               await client.SendDataAsync(input);
                Thread.Sleep(500);
            }
            client.Close();
        }
    }
}
