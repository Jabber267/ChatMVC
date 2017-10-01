using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;

namespace Chat
{
    public class ChatHub : Hub
    {
        public override Task OnConnected()
        {
            Clients.All.user(Context.User.Identity.Name);
            return base.OnConnected();
        }

        public void send(string message)
        {
            if (Context.User.Identity.Name == "")
            {
                Clients.Caller.message("Anonymous: " + message);

                ChatServiceReference.ServiceClient client = new ChatServiceReference.ServiceClient();
                client.InsertChatMessage("Anonymous", message, DateTime.Now);

                Clients.Others.message("Anonymous: " + message);
            }
            else
            {
                Clients.Caller.message(Context.User.Identity.Name + ": " + message);

                ChatServiceReference.ServiceClient client = new ChatServiceReference.ServiceClient();
                client.InsertChatMessage(Context.User.Identity.Name, message, DateTime.Now);

                Clients.Others.message(Context.User.Identity.Name + ": " + message);
            }
            


        }
    }
}