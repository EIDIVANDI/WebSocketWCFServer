using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WebSocketWCFServer
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract(CallbackContract =typeof(IWebSocketCallBack))]
    public interface IWebSocketService
    {
        [OperationContract]
        Task SendDataAsync(string data);

    }

    public interface IWebSocketCallBack
    {
        [OperationContract(IsOneWay = true)]
        Task SendBackDataAsync(string data);
        
    }
}
