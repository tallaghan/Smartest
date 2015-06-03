using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace Smartest.Hubs
{
    public class RealtimeHub : Hub
    {
        public void ChallengeAccepted(int challengeID, string opponent, string connectionIdChallenger)
        {
            string connectionIdOpponent = Context.ConnectionId;

            Clients.Client(connectionIdChallenger).ChallengeAccepted(challengeID, opponent, connectionIdOpponent);
        }

        public void CountdownToGame(int countdownFrom, string connectionIdOpponent)
        {
            Clients.Client(connectionIdOpponent).CountdownToGame(countdownFrom);
        }

    }
}