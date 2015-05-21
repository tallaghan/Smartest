using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;


namespace Smartest.Hubs
{
    public class RealtimeHub : Hub
    {
        public void ChallengeAccepted(string opponent, string connectionId)
        {
            Clients.Client(connectionId).ChallengeAccepted(opponent);
        }
    }
}