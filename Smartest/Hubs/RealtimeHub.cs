using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace Smartest.Hubs
{
    public class RealtimeHub : Hub
    {
        public void ChallengeAccepted(int challengeID, string opponent, string connectionIdOpponent)
        {
            Clients.Client(connectionIdOpponent).ChallengeAccepted(challengeID, opponent);
        }
    }
}