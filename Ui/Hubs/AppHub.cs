using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Ui.Hubs
{
    public class AppHub : Hub
    {
        public Task Send(string message)
        {
            return Clients.All.SendAsync(message);
        }
    }
}
