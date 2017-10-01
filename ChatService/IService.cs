using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ChatService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
    [ServiceContract]
    [ServiceKnownType(typeof(List<MessageBoard>))]
    public interface IService
    {
        [OperationContract]
        string InsertChatMessage(string username, string message, DateTime dateTimeOfMessage);

        [OperationContract]
        List<MessageBoard> GetMessageBoard();
    }
}
