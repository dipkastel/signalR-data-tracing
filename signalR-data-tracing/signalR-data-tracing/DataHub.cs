using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace signalR_data_tracing
{
    public class DataHub : Hub
    {
        public void SendToAll(string var1)
        {
            Clients.All.broadcastMessage(var1);
        }
        public void SendToAll(string var1, string var2)
        {
            Clients.All.broadcastMessage(var1, var2);
        }
        public void SendToAll(string var1, string var2,string var3)
        {
            Clients.All.broadcastMessage(var1, var2,var3);
        }
    }
}