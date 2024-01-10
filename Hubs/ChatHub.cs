﻿using Microsoft.AspNetCore.SignalR;

namespace Ilie_Adrian_Laurentiu_Lab2.Hubs
{
    public class ChatHub : Hub 
    { 
        public async Task SendMessage(string user, string message) 
        { 
            await Clients.All.SendAsync("ReceiveMessage", user, message); 
        } 
    }
}