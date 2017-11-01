using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WebSocketWCFServer
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" à la fois dans le code et le fichier de configuration.
    public class WebSocketService : IWebSocketService
    {
        public async Task SendDataAsync(string data)
        {
                var callback = OperationContext.Current.GetCallbackChannel<IWebSocketCallBack>();
                if (((ICommunicationObject)callback).State == CommunicationState.Opened)
                {
                    await callback.SendBackDataAsync(
                        string.Format("data recieved: {0} at {1}",
                        data, DateTime.Now.ToLongTimeString()));
                }
        }
    }
}
