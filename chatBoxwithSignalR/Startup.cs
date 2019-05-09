using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace chatBoxwithSignalR
{
    public partial class Startup
    {
        public void configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
            app.MapSignalR();
        }

    }

    
    public class ChatHub : Microsoft.AspNet.SignalR.Hub
    {
        //method to update broadcast message to client
        public void Send (string name, string message)
        {
            Clients.All.broadcastMessage(name, message);
        }
    }

}