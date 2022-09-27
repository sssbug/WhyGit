using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.SignalR;


namespace Why.Signalr.hubs
{
    public class ChatHub:Hub
    {
        public void Send(string name, string message)
        {
            Clients.All.SendAsync(name,message);
        }
    }
}
