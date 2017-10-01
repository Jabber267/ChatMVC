using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ChatService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in both code and config file together.
    public class Service : IService
    {
        public string InsertChatMessage(string username, string message, DateTime dateTimeOfMessage)
        {
            string msg = string.Empty;
            OpenComsEntities context = new OpenComsEntities();
            MessageBoard mb = new MessageBoard();
            mb.Username = username;
            mb.Message = message;
            mb.DateTimeOfMessage = dateTimeOfMessage;
            context.MessageBoards.Add(mb);
            int res = context.SaveChanges();
            if (res > 0)
            {
                msg = "Success";
            }

            return msg;
        }

        public List<MessageBoard> GetMessageBoard()
        {
            List<MessageBoard> msgs = new List<MessageBoard>();
            OpenComsEntities context = new OpenComsEntities();
            var msb = context.MessageBoards;

            foreach (var msgObject in msb)
            {
                msgs.Add(new MessageBoard() { Username = msgObject.Username, Message = msgObject.Message, DateTimeOfMessage  = msgObject.DateTimeOfMessage });
            }

            return msgs;
        }
    }
}
