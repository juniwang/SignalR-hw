﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace JSignalR.Web
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            //Clients.All.hello();
            Clients.All.broadcastMessage(name, message);
        }
    }
}